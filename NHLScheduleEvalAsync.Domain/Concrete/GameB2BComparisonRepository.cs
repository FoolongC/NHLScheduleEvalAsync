using NHLScheduleEval.Domain.Abstract;
using NHLScheduleEval.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NHLScheduleEval.Domain.Concrete
{
	/// <summary>
	/// Model for NHL 2013 season schedule evaluation
	/// </summary>
	public class GameB2BComparisonRepository : ITeamB2BComparisonRepository
	{
		private List<TeamB2BComparison> lstTeamB2BComparison = new List<TeamB2BComparison>();

		public IEnumerable<TeamB2BComparison> GetB2BComparisonByTeamID(string teamName)
		{
			#region randomNess
			List<string> thing = new List<string>()
			{
				"Anaheim",
				"Carolina",
				"Chicago",
				"Detroit",
				"Edmonton",
				"Florida",
				"Nashville",
				"New Jersey",
				"Ottawa",
				"Philadelphia",
				"San Jose",
				"St. Louis",
				"Tampa Bay",
				"Winnipeg"
			};

			if (thing.Contains(teamName))
			{
				Random r = new Random();
				int rInt = r.Next(2000, 4000);
				Thread.Sleep(rInt);
			}
            #endregion

            SampleData sd = new SampleData();
            List<ScheduleByDate> lstScheduleByDate = sd.Get2013Schedule();

            //create groups by date
            var scheduleGroupedByDate =
				(
					from scheds in lstScheduleByDate
					group scheds by scheds.Date into newScheduleGroup
					orderby newScheduleGroup.Key
					select newScheduleGroup
				).ToList();

			List<TeamsByPlayDate> lstTeamsByPlayDate = new List<TeamsByPlayDate>();

			//then iterate through each group and create a list of teams that played in that date group
			foreach (var teamsByPlayDate in scheduleGroupedByDate)
			{
				TeamsByPlayDate tbpd = new TeamsByPlayDate();
				tbpd.PlayDate = teamsByPlayDate.Key;
				tbpd.LstTeamNames = new List<string>();

				foreach (var homeAndAway in teamsByPlayDate)
				{
					tbpd.LstTeamNames.Add(homeAndAway.HomeTeam);
					tbpd.LstTeamNames.Add(homeAndAway.AwayTeam);
				}

				lstTeamsByPlayDate.Add(tbpd);
			}

			int nextInList = 1;
			List<PlayedB2B> lstPlayBackToBack = new List<PlayedB2B>();

			//extract teams that played back to back games
			foreach (var team in lstTeamsByPlayDate)
			{
				List<string> lstTeamsThatPlayedB2B = null;
				if (nextInList < lstTeamsByPlayDate.Count)
					lstTeamsThatPlayedB2B = (team.LstTeamNames.Intersect<string>(lstTeamsByPlayDate[nextInList].LstTeamNames)).ToList();

				if (lstTeamsThatPlayedB2B != null)
				{
					foreach (var t in lstTeamsThatPlayedB2B)
					{
						PlayedB2B p2b = new PlayedB2B
						{
							PlayDate1 = team.PlayDate,
							PlayDate2 = lstTeamsByPlayDate[nextInList].PlayDate,
							TeamName = t
						};
						lstPlayBackToBack.Add(p2b);
					}
				}
				nextInList++;
			}

			//now group the list of teams that played back to back by team
			var scheduleGroupedByTeam =
				from teamGrp in lstPlayBackToBack
				where teamName != null ? teamGrp.TeamName == teamName : teamGrp.TeamName != null
				group teamGrp by teamGrp.TeamName into NewByTeamGroup
				orderby NewByTeamGroup.Key
				select NewByTeamGroup;

			//get each team in the group
			foreach (var team in scheduleGroupedByTeam)
			{
				var name = (from t in team select t.TeamName).FirstOrDefault().ToString();
				var count = (from c in team select c).Count();

				// create team object
				Team teamModel = new Team()
				{
					TeamName = name,
					Count = count.ToString(),
					LstGameInfo = new List<GameInfo>()
				};

				// create a new model
				TeamB2BComparison tB2BComparison = new TeamB2BComparison();

				// iterate through play dates to construct info for each game played
				foreach (var playDates in team)
				{
					#region putItAllTogether
					var teamsIn1stGame =
						(from oppGame1 in
							 (
								from teams1stGame in lstScheduleByDate
								where teams1stGame.Date == playDates.PlayDate1
								select teams1stGame
							 ).ToList()
						 where oppGame1.HomeTeam == teamModel.TeamName || oppGame1.AwayTeam == teamModel.TeamName
						 select oppGame1
						).FirstOrDefault();

					var teamsIn2ndGame =
						(from opp2ndGame in
							 (
								 from teams2ndGames in lstScheduleByDate
								 where teams2ndGames.Date == playDates.PlayDate2
								 select teams2ndGames
							 ).ToList()
						 where opp2ndGame.HomeTeam == teamModel.TeamName || opp2ndGame.AwayTeam == teamModel.TeamName
						 select opp2ndGame
						).FirstOrDefault();

					string opponentGame2 = teamsIn2ndGame.AwayTeam != teamModel.TeamName ? teamsIn2ndGame.AwayTeam : teamsIn2ndGame.HomeTeam;

					var oppPlayedNightBefore =
						(from opp1 in
							 (
								 from teams1 in lstScheduleByDate
								 where teams1.Date == playDates.PlayDate1
								 select teams1
							 )
						 where opp1.HomeTeam == opponentGame2 || opp1.AwayTeam == opponentGame2
						 select opp1
						).FirstOrDefault();
					#endregion

					string yesAnswer = "Yes";

					if (teamsIn1stGame.HomeTeam == teamModel.TeamName && teamsIn2ndGame.HomeTeam == teamModel.TeamName)
						yesAnswer = "<b>Yes</b>";//if both games in b2b are home games then make 'yes' bold to point out no travel for that particular b2b

					// create the game info object
					GameInfo gi = new GameInfo()
					{
						GameOneDate = playDates.PlayDate1.ToShortDateString(),
						GameOneHome = teamsIn1stGame.HomeTeam == teamModel.TeamName ? yesAnswer : "No",
						GameTwoHome = teamsIn2ndGame.HomeTeam == teamModel.TeamName ? yesAnswer : "No",
						FinalGameOne = teamsIn1stGame.Final,
						GameTwoDate = playDates.PlayDate2.ToShortDateString(),
						OpponentPlayedDayBefore = oppPlayedNightBefore.HomeTeam != null ? "<b><span class='oppPlayedNightBefYes'>Yes</span></b>" : "<span class='oppPlayedNightBefNo'>No</span>",
						FinalGameTwo = teamsIn2ndGame.Final
					};

					// add game info to team 
					teamModel.LstGameInfo.Add(gi);
				}

				// add the team to the model
				tB2BComparison.Team = teamModel;
				tB2BComparison.Count = Convert.ToInt32(teamModel.Count);
				// add the model to the repository list
				lstTeamB2BComparison.Add(tB2BComparison);
			}

			return lstTeamB2BComparison;
		}

		/// <summary>
		/// Repository of back to back game comparisons by team
		/// </summary>
		public IEnumerable<TeamB2BComparison> TeamB2BComparisons
		{
			get
			{
				return lstTeamB2BComparison;
			}
		}
	}
}
