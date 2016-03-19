using NHLScheduleEval.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLScheduleEval.Domain.Entities
{
    /// <summary>
    /// Team model
    /// </summary>
    public class TeamB2BComparison
    {
        public Team Team { get; set; }
    }

    #region containers
    /// <summary>
    /// Team container for presentation layer
    /// </summary>
    public struct Team
    {
        public string TeamName { get; set; }
        public List<GameInfo> LstGameInfo { get; set; }
        public string Count { get; set; }
        public int TeamID { get; set; }
    }

    /// <summary>
    /// Game info container for each team
    /// </summary>
    public struct GameInfo
    {
        public string GameOneDate { get; set; }
        public string GameTwoDate { get; set; }
        public string GameOneHome { get; set; }
        public string GameTwoHome { get; set; }
        public string OpponentPlayedDayBefore { get; set; }
        public string FinalGameOne { get; set; }
        public string FinalGameTwo { get; set; }
    }
    #endregion
}
