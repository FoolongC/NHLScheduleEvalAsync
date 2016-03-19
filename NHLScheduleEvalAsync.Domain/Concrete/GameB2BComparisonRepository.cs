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
            // Manual here since this info is static
            // 'ScheduleByDate' properties came directly from NHL.com in the summer of 2013
            List<ScheduleByDate> lstScheduleByDate = new List<ScheduleByDate>()
            {
				#region popSchedule
				new ScheduleByDate { Date = Convert.ToDateTime("01-19-13"), AwayTeam = "Pittsburgh", HomeTeam = "Philadelphia", Final = "Final: PIT (3) - PHI (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-19-13"), AwayTeam = "Ottawa", HomeTeam = "Winnipeg", Final = "Final: OTT (4) - WPG (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-19-13"), AwayTeam = "Chicago", HomeTeam = "Los Angeles", Final = "Final: CHI (5) - LAK (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-19-13"), AwayTeam = "NY Rangers", HomeTeam = "Boston", Final = "Final: NYR (1) - BOS (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-19-13"), AwayTeam = "Toronto", HomeTeam = "Montreal", Final = "Final: TOR (2) - MTL (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-19-13"), AwayTeam = "New Jersey", HomeTeam = "NY Islanders", Final = "Final: NJD (2) - NYI (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-19-13"), AwayTeam = "Washington", HomeTeam = "Tampa Bay", Final = "Final: WSH (3) - TBL (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-19-13"), AwayTeam = "Carolina", HomeTeam = "Florida", Final = "Final: CAR (1) - FLA (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-19-13"), AwayTeam = "Detroit", HomeTeam = "St. Louis", Final = "Final: DET (0) - STL (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-19-13"), AwayTeam = "Columbus", HomeTeam = "Nashville", Final = "Final: CBJ (3) - NSH (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-19-13"), AwayTeam = "Phoenix", HomeTeam = "Dallas", Final = "Final: PHX (3) - DAL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-19-13"), AwayTeam = "Colorado", HomeTeam = "Minnesota", Final = "Final: COL (2) - MIN (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-19-13"), AwayTeam = "Anaheim", HomeTeam = "Vancouver", Final = "Final: ANA (7) - VAN (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-20-13"), AwayTeam = "Philadelphia", HomeTeam = "Buffalo", Final = "Final: PHI (2) - BUF (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-20-13"), AwayTeam = "San Jose", HomeTeam = "Calgary", Final = "Final: SJS (4) - CGY (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-20-13"), AwayTeam = "Pittsburgh", HomeTeam = "NY Rangers", Final = "Final: PIT (6) - NYR (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-20-13"), AwayTeam = "Dallas", HomeTeam = "Minnesota", Final = "Final: DAL (0) - MIN (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-20-13"), AwayTeam = "Edmonton", HomeTeam = "Vancouver", Final = "Final: EDM (3) - VAN (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-20-13"), AwayTeam = "Chicago", HomeTeam = "Phoenix", Final = "Final: CHI (6) - PHX (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-21-13"), AwayTeam = "Winnipeg", HomeTeam = "Boston", Final = "Final: WPG (1) - BOS (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-21-13"), AwayTeam = "Tampa Bay", HomeTeam = "NY Islanders", Final = "Final: TBL (3) - NYI (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-21-13"), AwayTeam = "St. Louis", HomeTeam = "Nashville", Final = "Final: STL (4) - NSH (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-21-13"), AwayTeam = "Buffalo", HomeTeam = "Toronto", Final = "Final: BUF (2) - TOR (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-21-13"), AwayTeam = "Florida", HomeTeam = "Ottawa", Final = "Final: FLA (0) - OTT (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-21-13"), AwayTeam = "Detroit", HomeTeam = "Columbus", Final = "Final: DET (4) - CBJ (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-21-13"), AwayTeam = "Anaheim", HomeTeam = "Calgary", Final = "Final: ANA (5) - CGY (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-22-13"), AwayTeam = "Winnipeg", HomeTeam = "Washington", Final = "Final: WPG (4) - WSH (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-22-13"), AwayTeam = "Tampa Bay", HomeTeam = "Carolina", Final = "Final: TBL (4) - CAR (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-22-13"), AwayTeam = "Florida", HomeTeam = "Montreal", Final = "Final: FLA (1) - MTL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-22-13"), AwayTeam = "Philadelphia", HomeTeam = "New Jersey", Final = "Final: PHI (0) - NJD (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-22-13"), AwayTeam = "Dallas", HomeTeam = "Detroit", Final = "Final: DAL (2) - DET (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-22-13"), AwayTeam = "Nashville", HomeTeam = "Minnesota", Final = "Final: NSH (3) - MIN (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-22-13"), AwayTeam = "St. Louis", HomeTeam = "Chicago", Final = "Final: STL (2) - CHI (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-22-13"), AwayTeam = "Los Angeles", HomeTeam = "Colorado", Final = "Final: LAK (1) - COL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-22-13"), AwayTeam = "San Jose", HomeTeam = "Edmonton", Final = "Final: SJS (6) - EDM (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-23-13"), AwayTeam = "Toronto", HomeTeam = "Pittsburgh", Final = "Final: TOR (5) - PIT (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-23-13"), AwayTeam = "Boston", HomeTeam = "NY Rangers", Final = "Final: BOS (3) - NYR (4) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-23-13"), AwayTeam = "Calgary", HomeTeam = "Vancouver", Final = "Final: CGY (2) - VAN (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-23-13"), AwayTeam = "Columbus", HomeTeam = "Phoenix", Final = "Final: CBJ (1) - PHX (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-24-13"), AwayTeam = "NY Islanders", HomeTeam = "Toronto", Final = "Final: NYI (7) - TOR (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-24-13"), AwayTeam = "NY Rangers", HomeTeam = "Philadelphia", Final = "Final: NYR (1) - PHI (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-24-13"), AwayTeam = "Montreal", HomeTeam = "Washington", Final = "Final: MTL (4) - WSH (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-24-13"), AwayTeam = "Buffalo", HomeTeam = "Carolina", Final = "Final: BUF (3) - CAR (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-24-13"), AwayTeam = "Ottawa", HomeTeam = "Florida", Final = "Final: OTT (3) - FLA (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-24-13"), AwayTeam = "Nashville", HomeTeam = "St. Louis", Final = "Final: NSH (0) - STL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-24-13"), AwayTeam = "Chicago", HomeTeam = "Dallas", Final = "Final: CHI (3) - DAL (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-24-13"), AwayTeam = "Columbus", HomeTeam = "Colorado", Final = "Final: CBJ (0) - COL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-24-13"), AwayTeam = "Los Angeles", HomeTeam = "Edmonton", Final = "Final: LAK (1) - EDM (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-24-13"), AwayTeam = "Phoenix", HomeTeam = "San Jose", Final = "Final: PHX (3) - SJS (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-25-13"), AwayTeam = "NY Islanders", HomeTeam = "Boston", Final = "Final: NYI (2) - BOS (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-25-13"), AwayTeam = "Carolina", HomeTeam = "Buffalo", Final = "Final: CAR (3) - BUF (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-25-13"), AwayTeam = "Washington", HomeTeam = "New Jersey", Final = "Final: WSH (2) - NJD (3) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-25-13"), AwayTeam = "Ottawa", HomeTeam = "Tampa Bay", Final = "Final: OTT (4) - TBL (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-25-13"), AwayTeam = "Minnesota", HomeTeam = "Detroit", Final = "Final: MIN (3) - DET (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-25-13"), AwayTeam = "Pittsburgh", HomeTeam = "Winnipeg", Final = "Final: PIT (2) - WPG (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-25-13"), AwayTeam = "Vancouver", HomeTeam = "Anaheim", Final = "Final: VAN (5) - ANA (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-26-13"), AwayTeam = "Colorado", HomeTeam = "San Jose", Final = "Final: COL (0) - SJS (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-26-13"), AwayTeam = "Toronto", HomeTeam = "NY Rangers", Final = "Final: TOR (2) - NYR (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-26-13"), AwayTeam = "Chicago", HomeTeam = "Columbus", Final = "Final: CHI (3) - CBJ (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-26-13"), AwayTeam = "Philadelphia", HomeTeam = "Florida", Final = "Final: PHI (7) - FLA (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-26-13"), AwayTeam = "St. Louis", HomeTeam = "Dallas", Final = "Final: STL (4) - DAL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-26-13"), AwayTeam = "Los Angeles", HomeTeam = "Phoenix", Final = "Final: LAK (4) - PHX (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-26-13"), AwayTeam = "Edmonton", HomeTeam = "Calgary", Final = "Final: EDM (3) - CGY (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-26-13"), AwayTeam = "Nashville", HomeTeam = "Anaheim", Final = "Final: NSH (2) - ANA (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-27-13"), AwayTeam = "Buffalo", HomeTeam = "Washington", Final = "Final: BUF (2) - WSH (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-27-13"), AwayTeam = "Pittsburgh", HomeTeam = "Ottawa", Final = "Final: PIT (2) - OTT (1) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-27-13"), AwayTeam = "New Jersey", HomeTeam = "Montreal", Final = "Final: NJD (3) - MTL (4) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-27-13"), AwayTeam = "Philadelphia", HomeTeam = "Tampa Bay", Final = "Final: PHI (1) - TBL (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-27-13"), AwayTeam = "Detroit", HomeTeam = "Chicago", Final = "Final: DET (1) - CHI (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-27-13"), AwayTeam = "NY Islanders", HomeTeam = "Winnipeg", Final = "Final: NYI (4) - WPG (5) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-27-13"), AwayTeam = "Minnesota", HomeTeam = "St. Louis", Final = "Final: MIN (4) - STL (5) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-27-13"), AwayTeam = "Vancouver", HomeTeam = "San Jose", Final = "Final: VAN (1) - SJS (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-28-13"), AwayTeam = "Boston", HomeTeam = "Carolina", Final = "Final: BOS (5) - CAR (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-28-13"), AwayTeam = "Dallas", HomeTeam = "Columbus", Final = "Final: DAL (1) - CBJ (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-28-13"), AwayTeam = "Nashville", HomeTeam = "Phoenix", Final = "Final: NSH (0) - PHX (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-28-13"), AwayTeam = "Colorado", HomeTeam = "Edmonton", Final = "Final: COL (1) - EDM (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-28-13"), AwayTeam = "Vancouver", HomeTeam = "Los Angeles", Final = "Final: VAN (2) - LAK (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-29-13"), AwayTeam = "New Jersey", HomeTeam = "Boston", Final = "Final: NJD (1) - BOS (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-29-13"), AwayTeam = "Toronto", HomeTeam = "Buffalo", Final = "Final: TOR (4) - BUF (3) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-29-13"), AwayTeam = "Philadelphia", HomeTeam = "NY Rangers", Final = "Final: PHI (1) - NYR (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-29-13"), AwayTeam = "Winnipeg", HomeTeam = "Montreal", Final = "Final: WPG (3) - MTL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-29-13"), AwayTeam = "Washington", HomeTeam = "Ottawa", Final = "Final: WSH (2) - OTT (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-29-13"), AwayTeam = "NY Islanders", HomeTeam = "Pittsburgh", Final = "Final: NYI (4) - PIT (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-29-13"), AwayTeam = "Florida", HomeTeam = "Tampa Bay", Final = "Final: FLA (2) - TBL (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-29-13"), AwayTeam = "Dallas", HomeTeam = "Detroit", Final = "Final: DAL (1) - DET (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-29-13"), AwayTeam = "Columbus", HomeTeam = "Minnesota", Final = "Final: CBJ (2) - MIN (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-29-13"), AwayTeam = "Anaheim", HomeTeam = "San Jose", Final = "Final: ANA (2) - SJS (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-30-13"), AwayTeam = "Montreal", HomeTeam = "Ottawa", Final = "Final: MTL (1) - OTT (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-30-13"), AwayTeam = "Chicago", HomeTeam = "Minnesota", Final = "Final: CHI (2) - MIN (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-30-13"), AwayTeam = "Edmonton", HomeTeam = "Phoenix", Final = "Final: EDM (2) - PHX (1) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-30-13"), AwayTeam = "Colorado", HomeTeam = "Vancouver", Final = "Final: COL (0) - VAN (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-31-13"), AwayTeam = "Buffalo", HomeTeam = "Boston", Final = "Final: BUF (7) - BOS (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-31-13"), AwayTeam = "Washington", HomeTeam = "Toronto", Final = "Final: WSH (2) - TOR (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-31-13"), AwayTeam = "NY Islanders", HomeTeam = "New Jersey", Final = "Final: NYI (5) - NJD (4) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-31-13"), AwayTeam = "Pittsburgh", HomeTeam = "NY Rangers", Final = "Final: PIT (3) - NYR (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-31-13"), AwayTeam = "St. Louis", HomeTeam = "Columbus", Final = "Final: STL (4) - CBJ (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-31-13"), AwayTeam = "Winnipeg", HomeTeam = "Florida", Final = "Final: WPG (3) - FLA (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-31-13"), AwayTeam = "Colorado", HomeTeam = "Calgary", Final = "Final: COL (6) - CGY (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-31-13"), AwayTeam = "Nashville", HomeTeam = "Los Angeles", Final = "Final: NSH (2) - LAK (1) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("01-31-13"), AwayTeam = "Edmonton", HomeTeam = "San Jose", Final = "Final: EDM (2) - SJS (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-01-13"), AwayTeam = "Philadelphia", HomeTeam = "Washington", Final = "Final: PHI (2) - WSH (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-01-13"), AwayTeam = "Ottawa", HomeTeam = "Carolina", Final = "Final: OTT (0) - CAR (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-01-13"), AwayTeam = "Winnipeg", HomeTeam = "Tampa Bay", Final = "Final: WPG (3) - TBL (8)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-01-13"), AwayTeam = "St. Louis", HomeTeam = "Detroit", Final = "Final: STL (3) - DET (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-01-13"), AwayTeam = "Phoenix", HomeTeam = "Dallas", Final = "Final: PHX (3) - DAL (4) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-01-13"), AwayTeam = "Chicago", HomeTeam = "Vancouver", Final = "Final: CHI (1) - VAN (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-01-13"), AwayTeam = "Minnesota", HomeTeam = "Anaheim", Final = "Final: MIN (1) - ANA (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-02-13"), AwayTeam = "New Jersey", HomeTeam = "Pittsburgh", Final = "Final: NJD (1) - PIT (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-02-13"), AwayTeam = "Buffalo", HomeTeam = "Montreal", Final = "Final: BUF (1) - MTL (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-02-13"), AwayTeam = "Edmonton", HomeTeam = "Colorado", Final = "Final: EDM (1) - COL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-02-13"), AwayTeam = "Boston", HomeTeam = "Toronto", Final = "Final: BOS (1) - TOR (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-02-13"), AwayTeam = "Carolina", HomeTeam = "Philadelphia", Final = "Final: CAR (3) - PHI (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-02-13"), AwayTeam = "NY Rangers", HomeTeam = "Tampa Bay", Final = "Final: NYR (3) - TBL (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-02-13"), AwayTeam = "Detroit", HomeTeam = "Columbus", Final = "Final: DET (2) - CBJ (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-02-13"), AwayTeam = "Dallas", HomeTeam = "Phoenix", Final = "Final: DAL (0) - PHX (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-02-13"), AwayTeam = "Chicago", HomeTeam = "Calgary", Final = "Final: CHI (3) - CGY (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-02-13"), AwayTeam = "Los Angeles", HomeTeam = "Anaheim", Final = "Final: LAK (4) - ANA (7)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-02-13"), AwayTeam = "Nashville", HomeTeam = "San Jose", Final = "Final: NSH (2) - SJS (1) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-03-13"), AwayTeam = "Pittsburgh", HomeTeam = "Washington", Final = "Final: PIT (6) - WSH (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-03-13"), AwayTeam = "Ottawa", HomeTeam = "Montreal", Final = "Final: OTT (1) - MTL (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-03-13"), AwayTeam = "Florida", HomeTeam = "Buffalo", Final = "Final: FLA (4) - BUF (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-03-13"), AwayTeam = "New Jersey", HomeTeam = "NY Islanders", Final = "Final: NJD (3) - NYI (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-04-13"), AwayTeam = "Carolina", HomeTeam = "Toronto", Final = "Final: CAR (4) - TOR (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-04-13"), AwayTeam = "Dallas", HomeTeam = "Colorado", Final = "Final: DAL (3) - COL (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-04-13"), AwayTeam = "Minnesota", HomeTeam = "Phoenix", Final = "Final: MIN (1) - PHX (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-04-13"), AwayTeam = "Vancouver", HomeTeam = "Edmonton", Final = "Final: VAN (3) - EDM (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-04-13"), AwayTeam = "San Jose", HomeTeam = "Anaheim", Final = "Final: SJS (1) - ANA (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-05-13"), AwayTeam = "NY Rangers", HomeTeam = "New Jersey", Final = "Final: NYR (1) - NJD (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-05-13"), AwayTeam = "Pittsburgh", HomeTeam = "NY Islanders", Final = "Final: PIT (4) - NYI (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-05-13"), AwayTeam = "Toronto", HomeTeam = "Washington", Final = "Final: TOR (3) - WSH (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-05-13"), AwayTeam = "Los Angeles", HomeTeam = "Columbus", Final = "Final: LAK (4) - CBJ (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-05-13"), AwayTeam = "Buffalo", HomeTeam = "Ottawa", Final = "Final: BUF (3) - OTT (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-05-13"), AwayTeam = "Tampa Bay", HomeTeam = "Philadelphia", Final = "Final: TBL (1) - PHI (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-05-13"), AwayTeam = "Calgary", HomeTeam = "Detroit", Final = "Final: CGY (4) - DET (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-05-13"), AwayTeam = "Florida", HomeTeam = "Winnipeg", Final = "Final: FLA (2) - WPG (3) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-05-13"), AwayTeam = "Nashville", HomeTeam = "St. Louis", Final = "Final: NSH (6) - STL (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-05-13"), AwayTeam = "Chicago", HomeTeam = "San Jose", Final = "Final: CHI (5) - SJS (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-06-13"), AwayTeam = "Boston", HomeTeam = "Montreal", Final = "Final: BOS (2) - MTL (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-06-13"), AwayTeam = "Anaheim", HomeTeam = "Colorado", Final = "Final: ANA (3) - COL (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-06-13"), AwayTeam = "Dallas", HomeTeam = "Edmonton", Final = "Final: DAL (3) - EDM (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-07-13"), AwayTeam = "Montreal", HomeTeam = "Buffalo", Final = "Final: MTL (4) - BUF (5) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-07-13"), AwayTeam = "Tampa Bay", HomeTeam = "New Jersey", Final = "Final: TBL (2) - NJD (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-07-13"), AwayTeam = "NY Islanders", HomeTeam = "NY Rangers", Final = "Final: NYI (1) - NYR (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-07-13"), AwayTeam = "Florida", HomeTeam = "Philadelphia", Final = "Final: FLA (3) - PHI (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-07-13"), AwayTeam = "Washington", HomeTeam = "Pittsburgh", Final = "Final: WSH (2) - PIT (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-07-13"), AwayTeam = "Calgary", HomeTeam = "Columbus", Final = "Final: CGY (4) - CBJ (3) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-07-13"), AwayTeam = "Carolina", HomeTeam = "Ottawa", Final = "Final: CAR (3) - OTT (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-07-13"), AwayTeam = "Toronto", HomeTeam = "Winnipeg", Final = "Final: TOR (3) - WPG (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-07-13"), AwayTeam = "Detroit", HomeTeam = "St. Louis", Final = "Final: DET (5) - STL (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-07-13"), AwayTeam = "Los Angeles", HomeTeam = "Nashville", Final = "Final: LAK (0) - NSH (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-07-13"), AwayTeam = "Vancouver", HomeTeam = "Minnesota", Final = "Final: VAN (4) - MIN (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-07-13"), AwayTeam = "Chicago", HomeTeam = "Phoenix", Final = "Final: CHI (6) - PHX (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-08-13"), AwayTeam = "Anaheim", HomeTeam = "Dallas", Final = "Final: ANA (1) - DAL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-09-13"), AwayTeam = "Pittsburgh", HomeTeam = "New Jersey", Final = "Final: PIT (1) - NJD (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-09-13"), AwayTeam = "Carolina", HomeTeam = "Philadelphia", Final = "Final: CAR (3) - PHI (4) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-09-13"), AwayTeam = "Winnipeg", HomeTeam = "Ottawa", Final = "Final: WPG (1) - OTT (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-09-13"), AwayTeam = "Edmonton", HomeTeam = "Detroit", Final = "Final: EDM (1) - DET (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-09-13"), AwayTeam = "Phoenix", HomeTeam = "San Jose", Final = "Final: PHX (1) - SJS (0) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-09-13"), AwayTeam = "Toronto", HomeTeam = "Montreal", Final = "Final: TOR (6) - MTL (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-09-13"), AwayTeam = "Buffalo", HomeTeam = "NY Islanders", Final = "Final: BUF (3) - NYI (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-09-13"), AwayTeam = "Florida", HomeTeam = "Washington", Final = "Final: FLA (0) - WSH (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-09-13"), AwayTeam = "Anaheim", HomeTeam = "St. Louis", Final = "Final: ANA (6) - STL (5) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-09-13"), AwayTeam = "Nashville", HomeTeam = "Minnesota", Final = "Final: NSH (1) - MIN (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-09-13"), AwayTeam = "Calgary", HomeTeam = "Vancouver", Final = "Final: CGY (1) - VAN (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-10-13"), AwayTeam = "Los Angeles", HomeTeam = "Detroit", Final = "Final: LAK (2) - DET (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-10-13"), AwayTeam = "Edmonton", HomeTeam = "Columbus", Final = "Final: EDM (3) - CBJ (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-10-13"), AwayTeam = "Boston", HomeTeam = "Buffalo", Final = "Final: BOS (3) - BUF (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-10-13"), AwayTeam = "Tampa Bay", HomeTeam = "NY Rangers", Final = "Final: TBL (1) - NYR (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-10-13"), AwayTeam = "New Jersey", HomeTeam = "Pittsburgh", Final = "Final: NJD (3) - PIT (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-10-13"), AwayTeam = "Chicago", HomeTeam = "Nashville", Final = "Final: CHI (3) - NSH (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-11-13"), AwayTeam = "Philadelphia", HomeTeam = "Toronto", Final = "Final: PHI (2) - TOR (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-11-13"), AwayTeam = "Carolina", HomeTeam = "NY Islanders", Final = "Final: CAR (6) - NYI (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-11-13"), AwayTeam = "San Jose", HomeTeam = "Columbus", Final = "Final: SJS (2) - CBJ (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-11-13"), AwayTeam = "Los Angeles", HomeTeam = "St. Louis", Final = "Final: LAK (4) - STL (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-11-13"), AwayTeam = "Phoenix", HomeTeam = "Colorado", Final = "Final: PHX (3) - COL (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-11-13"), AwayTeam = "Minnesota", HomeTeam = "Calgary", Final = "Final: MIN (2) - CGY (1) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-12-13"), AwayTeam = "Carolina", HomeTeam = "New Jersey", Final = "Final: CAR (4) - NJD (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-12-13"), AwayTeam = "NY Rangers", HomeTeam = "Boston", Final = "Final: NYR (4) - BOS (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-12-13"), AwayTeam = "Buffalo", HomeTeam = "Ottawa", Final = "Final: BUF (0) - OTT (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-12-13"), AwayTeam = "Montreal", HomeTeam = "Tampa Bay", Final = "Final: MTL (4) - TBL (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-12-13"), AwayTeam = "Washington", HomeTeam = "Florida", Final = "Final: WSH (6) - FLA (5) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-12-13"), AwayTeam = "Philadelphia", HomeTeam = "Winnipeg", Final = "Final: PHI (3) - WPG (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-12-13"), AwayTeam = "San Jose", HomeTeam = "Nashville", Final = "Final: SJS (0) - NSH (1) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-12-13"), AwayTeam = "Anaheim", HomeTeam = "Chicago", Final = "Final: ANA (3) - CHI (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-12-13"), AwayTeam = "Dallas", HomeTeam = "Edmonton", Final = "Final: DAL (4) - EDM (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-12-13"), AwayTeam = "Minnesota", HomeTeam = "Vancouver", Final = "Final: MIN (1) - VAN (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-13-13"), AwayTeam = "Ottawa", HomeTeam = "Pittsburgh", Final = "Final: OTT (2) - PIT (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-13-13"), AwayTeam = "St. Louis", HomeTeam = "Detroit", Final = "Final: STL (4) - DET (3) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-13-13"), AwayTeam = "Dallas", HomeTeam = "Calgary", Final = "Final: DAL (4) - CGY (7)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-14-13"), AwayTeam = "NY Islanders", HomeTeam = "NY Rangers", Final = "Final: NYI (4) - NYR (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-14-13"), AwayTeam = "Toronto", HomeTeam = "Carolina", Final = "Final: TOR (1) - CAR (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-14-13"), AwayTeam = "Washington", HomeTeam = "Tampa Bay", Final = "Final: WSH (4) - TBL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-14-13"), AwayTeam = "Montreal", HomeTeam = "Florida", Final = "Final: MTL (1) - FLA (0) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-14-13"), AwayTeam = "Phoenix", HomeTeam = "Nashville", Final = "Final: PHX (0) - NSH (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-14-13"), AwayTeam = "Colorado", HomeTeam = "Minnesota", Final = "Final: COL (4) - MIN (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-15-13"), AwayTeam = "Boston", HomeTeam = "Buffalo", Final = "Final: BOS (2) - BUF (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-15-13"), AwayTeam = "Philadelphia", HomeTeam = "New Jersey", Final = "Final: PHI (3) - NJD (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-15-13"), AwayTeam = "Pittsburgh", HomeTeam = "Winnipeg", Final = "Final: PIT (3) - WPG (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-15-13"), AwayTeam = "Anaheim", HomeTeam = "Detroit", Final = "Final: ANA (5) - DET (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-15-13"), AwayTeam = "San Jose", HomeTeam = "Chicago", Final = "Final: SJS (1) - CHI (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-15-13"), AwayTeam = "St. Louis", HomeTeam = "Calgary", Final = "Final: STL (5) - CGY (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-15-13"), AwayTeam = "Dallas", HomeTeam = "Vancouver", Final = "Final: DAL (4) - VAN (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-15-13"), AwayTeam = "Columbus", HomeTeam = "Los Angeles", Final = "Final: CBJ (1) - LAK (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-16-13"), AwayTeam = "Tampa Bay", HomeTeam = "Florida", Final = "Final: TBL (6) - FLA (5) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-16-13"), AwayTeam = "Ottawa", HomeTeam = "Toronto", Final = "Final: OTT (0) - TOR (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-16-13"), AwayTeam = "Philadelphia", HomeTeam = "Montreal", Final = "Final: PHI (1) - MTL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-16-13"), AwayTeam = "New Jersey", HomeTeam = "NY Islanders", Final = "Final: NJD (1) - NYI (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-16-13"), AwayTeam = "Anaheim", HomeTeam = "Nashville", Final = "Final: ANA (3) - NSH (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-16-13"), AwayTeam = "Columbus", HomeTeam = "Phoenix", Final = "Final: CBJ (3) - PHX (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-16-13"), AwayTeam = "Colorado", HomeTeam = "Edmonton", Final = "Final: COL (4) - EDM (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-17-13"), AwayTeam = "Pittsburgh", HomeTeam = "Buffalo", Final = "Final: PIT (4) - BUF (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-17-13"), AwayTeam = "Los Angeles", HomeTeam = "Chicago", Final = "Final: LAK (2) - CHI (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-17-13"), AwayTeam = "Boston", HomeTeam = "Winnipeg", Final = "Final: BOS (3) - WPG (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-17-13"), AwayTeam = "Calgary", HomeTeam = "Dallas", Final = "Final: CGY (4) - DAL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-17-13"), AwayTeam = "Detroit", HomeTeam = "Minnesota", Final = "Final: DET (2) - MIN (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-17-13"), AwayTeam = "Washington", HomeTeam = "NY Rangers", Final = "Final: WSH (1) - NYR (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-17-13"), AwayTeam = "St. Louis", HomeTeam = "Vancouver", Final = "Final: STL (4) - VAN (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-18-13"), AwayTeam = "Ottawa", HomeTeam = "New Jersey", Final = "Final: OTT (2) - NJD (1) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-18-13"), AwayTeam = "Philadelphia", HomeTeam = "NY Islanders", Final = "Final: PHI (7) - NYI (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-18-13"), AwayTeam = "Nashville", HomeTeam = "Colorado", Final = "Final: NSH (5) - COL (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-18-13"), AwayTeam = "Carolina", HomeTeam = "Montreal", Final = "Final: CAR (0) - MTL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-18-13"), AwayTeam = "Toronto", HomeTeam = "Florida", Final = "Final: TOR (3) - FLA (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-18-13"), AwayTeam = "Calgary", HomeTeam = "Phoenix", Final = "Final: CGY (0) - PHX (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-18-13"), AwayTeam = "Columbus", HomeTeam = "Anaheim", Final = "Final: CBJ (2) - ANA (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-19-13"), AwayTeam = "Winnipeg", HomeTeam = "Buffalo", Final = "Final: WPG (2) - BUF (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-19-13"), AwayTeam = "Montreal", HomeTeam = "NY Rangers", Final = "Final: MTL (3) - NYR (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-19-13"), AwayTeam = "NY Islanders", HomeTeam = "Ottawa", Final = "Final: NYI (1) - OTT (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-19-13"), AwayTeam = "Toronto", HomeTeam = "Tampa Bay", Final = "Final: TOR (2) - TBL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-19-13"), AwayTeam = "San Jose", HomeTeam = "St. Louis", Final = "Final: SJS (2) - STL (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-19-13"), AwayTeam = "Detroit", HomeTeam = "Nashville", Final = "Final: DET (3) - NSH (4) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-19-13"), AwayTeam = "Vancouver", HomeTeam = "Chicago", Final = "Final: VAN (3) - CHI (4) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-19-13"), AwayTeam = "Los Angeles", HomeTeam = "Edmonton", Final = "Final: LAK (3) - EDM (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-20-13"), AwayTeam = "Philadelphia", HomeTeam = "Pittsburgh", Final = "Final: PHI (6) - PIT (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-20-13"), AwayTeam = "St. Louis", HomeTeam = "Colorado", Final = "Final: STL (0) - COL (1) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-20-13"), AwayTeam = "Los Angeles", HomeTeam = "Calgary", Final = "Final: LAK (3) - CGY (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-21-13"), AwayTeam = "Buffalo", HomeTeam = "Toronto", Final = "Final: BUF (1) - TOR (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-21-13"), AwayTeam = "Florida", HomeTeam = "Philadelphia", Final = "Final: FLA (5) - PHI (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-21-13"), AwayTeam = "New Jersey", HomeTeam = "Washington", Final = "Final: NJD (3) - WSH (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-21-13"), AwayTeam = "Winnipeg", HomeTeam = "Carolina", Final = "Final: WPG (4) - CAR (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-21-13"), AwayTeam = "NY Islanders", HomeTeam = "Montreal", Final = "Final: NYI (4) - MTL (3) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-21-13"), AwayTeam = "NY Rangers", HomeTeam = "Ottawa", Final = "Final: NYR (2) - OTT (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-21-13"), AwayTeam = "Boston", HomeTeam = "Tampa Bay", Final = "Final: BOS (4) - TBL (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-21-13"), AwayTeam = "Columbus", HomeTeam = "Detroit", Final = "Final: CBJ (3) - DET (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-21-13"), AwayTeam = "Vancouver", HomeTeam = "Dallas", Final = "Final: VAN (4) - DAL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-21-13"), AwayTeam = "Minnesota", HomeTeam = "Edmonton", Final = "Final: MIN (3) - EDM (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-22-13"), AwayTeam = "Florida", HomeTeam = "Pittsburgh", Final = "Final: FLA (1) - PIT (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-22-13"), AwayTeam = "Vancouver", HomeTeam = "Nashville", Final = "Final: VAN (1) - NSH (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-22-13"), AwayTeam = "San Jose", HomeTeam = "Chicago", Final = "Final: SJS (1) - CHI (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-23-13"), AwayTeam = "New Jersey", HomeTeam = "Washington", Final = "Final: NJD (1) - WSH (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-23-13"), AwayTeam = "Winnipeg", HomeTeam = "Philadelphia", Final = "Final: WPG (3) - PHI (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-23-13"), AwayTeam = "Phoenix", HomeTeam = "Edmonton", Final = "Final: PHX (2) - EDM (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-23-13"), AwayTeam = "Colorado", HomeTeam = "Los Angeles", Final = "Final: COL (1) - LAK (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-23-13"), AwayTeam = "NY Islanders", HomeTeam = "Buffalo", Final = "Final: NYI (4) - BUF (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-23-13"), AwayTeam = "NY Rangers", HomeTeam = "Montreal", Final = "Final: NYR (0) - MTL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-23-13"), AwayTeam = "Toronto", HomeTeam = "Ottawa", Final = "Final: TOR (2) - OTT (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-23-13"), AwayTeam = "Tampa Bay", HomeTeam = "Carolina", Final = "Final: TBL (5) - CAR (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-23-13"), AwayTeam = "Nashville", HomeTeam = "Detroit", Final = "Final: NSH (0) - DET (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-23-13"), AwayTeam = "Columbus", HomeTeam = "St. Louis", Final = "Final: CBJ (1) - STL (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-23-13"), AwayTeam = "San Jose", HomeTeam = "Dallas", Final = "Final: SJS (1) - DAL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-23-13"), AwayTeam = "Minnesota", HomeTeam = "Calgary", Final = "Final: MIN (1) - CGY (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-24-13"), AwayTeam = "Boston", HomeTeam = "Florida", Final = "Final: BOS (4) - FLA (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-24-13"), AwayTeam = "Winnipeg", HomeTeam = "New Jersey", Final = "Final: WPG (4) - NJD (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-24-13"), AwayTeam = "Vancouver", HomeTeam = "Detroit", Final = "Final: VAN (3) - DET (8)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-24-13"), AwayTeam = "Carolina", HomeTeam = "NY Islanders", Final = "Final: CAR (4) - NYI (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-24-13"), AwayTeam = "Columbus", HomeTeam = "Chicago", Final = "Final: CBJ (0) - CHI (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-24-13"), AwayTeam = "Tampa Bay", HomeTeam = "Pittsburgh", Final = "Final: TBL (3) - PIT (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-24-13"), AwayTeam = "Phoenix", HomeTeam = "Calgary", Final = "Final: PHX (4) - CGY (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-24-13"), AwayTeam = "Colorado", HomeTeam = "Anaheim", Final = "Final: COL (3) - ANA (4) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-25-13"), AwayTeam = "Toronto", HomeTeam = "Philadelphia", Final = "Final: TOR (4) - PHI (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-25-13"), AwayTeam = "Montreal", HomeTeam = "Ottawa", Final = "Final: MTL (1) - OTT (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-25-13"), AwayTeam = "Dallas", HomeTeam = "Nashville", Final = "Final: DAL (4) - NSH (5) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-25-13"), AwayTeam = "Edmonton", HomeTeam = "Chicago", Final = "Final: EDM (2) - CHI (3) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-25-13"), AwayTeam = "Anaheim", HomeTeam = "Los Angeles", Final = "Final: ANA (2) - LAK (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-26-13"), AwayTeam = "Winnipeg", HomeTeam = "NY Rangers", Final = "Final: WPG (4) - NYR (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-26-13"), AwayTeam = "Carolina", HomeTeam = "Washington", Final = "Final: CAR (0) - WSH (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-26-13"), AwayTeam = "Dallas", HomeTeam = "Columbus", Final = "Final: DAL (5) - CBJ (4) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-26-13"), AwayTeam = "Boston", HomeTeam = "NY Islanders", Final = "Final: BOS (4) - NYI (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-26-13"), AwayTeam = "Buffalo", HomeTeam = "Tampa Bay", Final = "Final: BUF (2) - TBL (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-26-13"), AwayTeam = "Pittsburgh", HomeTeam = "Florida", Final = "Final: PIT (4) - FLA (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-26-13"), AwayTeam = "Calgary", HomeTeam = "Minnesota", Final = "Final: CGY (1) - MIN (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-26-13"), AwayTeam = "Phoenix", HomeTeam = "Vancouver", Final = "Final: PHX (4) - VAN (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-26-13"), AwayTeam = "Colorado", HomeTeam = "San Jose", Final = "Final: COL (2) - SJS (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-27-13"), AwayTeam = "Montreal", HomeTeam = "Toronto", Final = "Final: MTL (5) - TOR (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-27-13"), AwayTeam = "Washington", HomeTeam = "Philadelphia", Final = "Final: WSH (1) - PHI (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-27-13"), AwayTeam = "Nashville", HomeTeam = "Anaheim", Final = "Final: NSH (1) - ANA (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-27-13"), AwayTeam = "Detroit", HomeTeam = "Los Angeles", Final = "Final: DET (1) - LAK (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-28-13"), AwayTeam = "Ottawa", HomeTeam = "Boston", Final = "Final: OTT (1) - BOS (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-28-13"), AwayTeam = "Toronto", HomeTeam = "NY Islanders", Final = "Final: TOR (5) - NYI (4) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-28-13"), AwayTeam = "Tampa Bay", HomeTeam = "NY Rangers", Final = "Final: TBL (1) - NYR (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-28-13"), AwayTeam = "Pittsburgh", HomeTeam = "Carolina", Final = "Final: PIT (1) - CAR (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-28-13"), AwayTeam = "Buffalo", HomeTeam = "Florida", Final = "Final: BUF (4) - FLA (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-28-13"), AwayTeam = "New Jersey", HomeTeam = "Winnipeg", Final = "Final: NJD (1) - WPG (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-28-13"), AwayTeam = "Chicago", HomeTeam = "St. Louis", Final = "Final: CHI (3) - STL (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-28-13"), AwayTeam = "Edmonton", HomeTeam = "Dallas", Final = "Final: EDM (5) - DAL (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-28-13"), AwayTeam = "Calgary", HomeTeam = "Colorado", Final = "Final: CGY (4) - COL (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-28-13"), AwayTeam = "Minnesota", HomeTeam = "Phoenix", Final = "Final: MIN (4) - PHX (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("02-28-13"), AwayTeam = "Detroit", HomeTeam = "San Jose", Final = "Final: DET (2) - SJS (1) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-01-13"), AwayTeam = "Edmonton", HomeTeam = "St. Louis", Final = "Final: EDM (2) - STL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-01-13"), AwayTeam = "Columbus", HomeTeam = "Chicago", Final = "Final: CBJ (3) - CHI (4) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-01-13"), AwayTeam = "Minnesota", HomeTeam = "Anaheim", Final = "Final: MIN (2) - ANA (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-02-13"), AwayTeam = "Ottawa", HomeTeam = "Philadelphia", Final = "Final: OTT (1) - PHI (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-02-13"), AwayTeam = "Tampa Bay", HomeTeam = "Boston", Final = "Final: TBL (2) - BOS (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-02-13"), AwayTeam = "New Jersey", HomeTeam = "Buffalo", Final = "Final: NJD (3) - BUF (4) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-02-13"), AwayTeam = "Washington", HomeTeam = "Winnipeg", Final = "Final: WSH (3) - WPG (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-02-13"), AwayTeam = "Pittsburgh", HomeTeam = "Montreal", Final = "Final: PIT (7) - MTL (6) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-02-13"), AwayTeam = "Florida", HomeTeam = "Carolina", Final = "Final: FLA (2) - CAR (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-02-13"), AwayTeam = "Anaheim", HomeTeam = "Phoenix", Final = "Final: ANA (4) - PHX (5) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-02-13"), AwayTeam = "Los Angeles", HomeTeam = "Vancouver", Final = "Final: LAK (2) - VAN (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-02-13"), AwayTeam = "Nashville", HomeTeam = "San Jose", Final = "Final: NSH (1) - SJS (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-03-13"), AwayTeam = "Chicago", HomeTeam = "Detroit", Final = "Final: CHI (2) - DET (1) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-03-13"), AwayTeam = "Ottawa", HomeTeam = "NY Islanders", Final = "Final: OTT (2) - NYI (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-03-13"), AwayTeam = "Colorado", HomeTeam = "Columbus", Final = "Final: COL (1) - CBJ (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-03-13"), AwayTeam = "St. Louis", HomeTeam = "Dallas", Final = "Final: STL (1) - DAL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-03-13"), AwayTeam = "Carolina", HomeTeam = "Florida", Final = "Final: CAR (3) - FLA (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-03-13"), AwayTeam = "Montreal", HomeTeam = "Boston", Final = "Final: MTL (4) - BOS (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-03-13"), AwayTeam = "Buffalo", HomeTeam = "NY Rangers", Final = "Final: BUF (2) - NYR (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-03-13"), AwayTeam = "Edmonton", HomeTeam = "Minnesota", Final = "Final: EDM (2) - MIN (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-03-13"), AwayTeam = "Vancouver", HomeTeam = "Calgary", Final = "Final: VAN (2) - CGY (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-04-13"), AwayTeam = "New Jersey", HomeTeam = "Toronto", Final = "Final: NJD (2) - TOR (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-04-13"), AwayTeam = "Tampa Bay", HomeTeam = "Pittsburgh", Final = "Final: TBL (3) - PIT (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-04-13"), AwayTeam = "Anaheim", HomeTeam = "Phoenix", Final = "Final: ANA (4) - PHX (5) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-04-13"), AwayTeam = "Nashville", HomeTeam = "Los Angeles", Final = "Final: NSH (1) - LAK (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-05-13"), AwayTeam = "Tampa Bay", HomeTeam = "New Jersey", Final = "Final: TBL (5) - NJD (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-05-13"), AwayTeam = "Montreal", HomeTeam = "NY Islanders", Final = "Final: MTL (3) - NYI (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-05-13"), AwayTeam = "Boston", HomeTeam = "Washington", Final = "Final: BOS (3) - WSH (4) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-05-13"), AwayTeam = "Buffalo", HomeTeam = "Carolina", Final = "Final: BUF (3) - CAR (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-05-13"), AwayTeam = "Edmonton", HomeTeam = "Columbus", Final = "Final: EDM (3) - CBJ (4) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-05-13"), AwayTeam = "Philadelphia", HomeTeam = "NY Rangers", Final = "Final: PHI (2) - NYR (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-05-13"), AwayTeam = "Winnipeg", HomeTeam = "Florida", Final = "Final: WPG (1) - FLA (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-05-13"), AwayTeam = "Colorado", HomeTeam = "Detroit", Final = "Final: COL (1) - DET (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-05-13"), AwayTeam = "Minnesota", HomeTeam = "Chicago", Final = "Final: MIN (3) - CHI (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-05-13"), AwayTeam = "San Jose", HomeTeam = "Vancouver", Final = "Final: SJS (3) - VAN (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-05-13"), AwayTeam = "St. Louis", HomeTeam = "Los Angeles", Final = "Final: STL (4) - LAK (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-06-13"), AwayTeam = "Ottawa", HomeTeam = "Toronto", Final = "Final: OTT (4) - TOR (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-06-13"), AwayTeam = "Colorado", HomeTeam = "Chicago", Final = "Final: COL (2) - CHI (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-06-13"), AwayTeam = "San Jose", HomeTeam = "Calgary", Final = "Final: SJS (1) - CGY (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-06-13"), AwayTeam = "Phoenix", HomeTeam = "Anaheim", Final = "Final: PHX (0) - ANA (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-07-13"), AwayTeam = "Toronto", HomeTeam = "Boston", Final = "Final: TOR (2) - BOS (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-07-13"), AwayTeam = "Buffalo", HomeTeam = "New Jersey", Final = "Final: BUF (2) - NJD (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-07-13"), AwayTeam = "NY Rangers", HomeTeam = "NY Islanders", Final = "Final: NYR (2) - NYI (1) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-07-13"), AwayTeam = "Pittsburgh", HomeTeam = "Philadelphia", Final = "Final: PIT (5) - PHI (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-07-13"), AwayTeam = "Florida", HomeTeam = "Washington", Final = "Final: FLA (1) - WSH (7)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-07-13"), AwayTeam = "Montreal", HomeTeam = "Carolina", Final = "Final: MTL (4) - CAR (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-07-13"), AwayTeam = "Vancouver", HomeTeam = "Columbus", Final = "Final: VAN (1) - CBJ (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-07-13"), AwayTeam = "Winnipeg", HomeTeam = "Tampa Bay", Final = "Final: WPG (2) - TBL (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-07-13"), AwayTeam = "Edmonton", HomeTeam = "Detroit", Final = "Final: EDM (0) - DET (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-07-13"), AwayTeam = "St. Louis", HomeTeam = "Phoenix", Final = "Final: STL (6) - PHX (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-07-13"), AwayTeam = "Dallas", HomeTeam = "Los Angeles", Final = "Final: DAL (5) - LAK (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-08-13"), AwayTeam = "Ottawa", HomeTeam = "NY Rangers", Final = "Final: OTT (3) - NYR (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-08-13"), AwayTeam = "Winnipeg", HomeTeam = "Florida", Final = "Final: WPG (3) - FLA (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-08-13"), AwayTeam = "Edmonton", HomeTeam = "Nashville", Final = "Final: EDM (0) - NSH (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-08-13"), AwayTeam = "Chicago", HomeTeam = "Colorado", Final = "Final: CHI (2) - COL (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-08-13"), AwayTeam = "Calgary", HomeTeam = "Anaheim", Final = "Final: CGY (0) - ANA (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-09-13"), AwayTeam = "Philadelphia", HomeTeam = "Boston", Final = "Final: PHI (0) - BOS (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-09-13"), AwayTeam = "Washington", HomeTeam = "NY Islanders", Final = "Final: WSH (2) - NYI (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-09-13"), AwayTeam = "Detroit", HomeTeam = "Columbus", Final = "Final: DET (0) - CBJ (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-09-13"), AwayTeam = "St. Louis", HomeTeam = "San Jose", Final = "Final: STL (4) - SJS (3) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-09-13"), AwayTeam = "Pittsburgh", HomeTeam = "Toronto", Final = "Final: PIT (5) - TOR (4) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-09-13"), AwayTeam = "New Jersey", HomeTeam = "Carolina", Final = "Final: NJD (3) - CAR (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-09-13"), AwayTeam = "Montreal", HomeTeam = "Tampa Bay", Final = "Final: MTL (4) - TBL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-09-13"), AwayTeam = "Minnesota", HomeTeam = "Nashville", Final = "Final: MIN (2) - NSH (1) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-09-13"), AwayTeam = "Dallas", HomeTeam = "Phoenix", Final = "Final: DAL (1) - PHX (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-09-13"), AwayTeam = "Calgary", HomeTeam = "Los Angeles", Final = "Final: CGY (2) - LAK (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-10-13"), AwayTeam = "NY Rangers", HomeTeam = "Washington", Final = "Final: NYR (4) - WSH (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-10-13"), AwayTeam = "Columbus", HomeTeam = "Detroit", Final = "Final: CBJ (3) - DET (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-10-13"), AwayTeam = "Montreal", HomeTeam = "Florida", Final = "Final: MTL (5) - FLA (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-10-13"), AwayTeam = "Winnipeg", HomeTeam = "New Jersey", Final = "Final: WPG (2) - NJD (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-10-13"), AwayTeam = "NY Islanders", HomeTeam = "Pittsburgh", Final = "Final: NYI (1) - PIT (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-10-13"), AwayTeam = "Edmonton", HomeTeam = "Chicago", Final = "Final: EDM (6) - CHI (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-10-13"), AwayTeam = "Buffalo", HomeTeam = "Philadelphia", Final = "Final: BUF (2) - PHI (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-10-13"), AwayTeam = "Vancouver", HomeTeam = "Minnesota", Final = "Final: VAN (2) - MIN (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-10-13"), AwayTeam = "San Jose", HomeTeam = "Colorado", Final = "Final: SJS (2) - COL (3) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-10-13"), AwayTeam = "St. Louis", HomeTeam = "Anaheim", Final = "Final: STL (2) - ANA (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-11-13"), AwayTeam = "Boston", HomeTeam = "Ottawa", Final = "Final: BOS (3) - OTT (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-11-13"), AwayTeam = "Calgary", HomeTeam = "Los Angeles", Final = "Final: CGY (1) - LAK (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-12-13"), AwayTeam = "NY Rangers", HomeTeam = "Buffalo", Final = "Final: NYR (1) - BUF (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-12-13"), AwayTeam = "Carolina", HomeTeam = "Washington", Final = "Final: CAR (4) - WSH (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-12-13"), AwayTeam = "Vancouver", HomeTeam = "Columbus", Final = "Final: VAN (2) - CBJ (1) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-12-13"), AwayTeam = "Boston", HomeTeam = "Pittsburgh", Final = "Final: BOS (2) - PIT (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-12-13"), AwayTeam = "Tampa Bay", HomeTeam = "Florida", Final = "Final: TBL (3) - FLA (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-12-13"), AwayTeam = "Toronto", HomeTeam = "Winnipeg", Final = "Final: TOR (2) - WPG (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-12-13"), AwayTeam = "San Jose", HomeTeam = "St. Louis", Final = "Final: SJS (2) - STL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-12-13"), AwayTeam = "Anaheim", HomeTeam = "Minnesota", Final = "Final: ANA (2) - MIN (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-12-13"), AwayTeam = "Nashville", HomeTeam = "Dallas", Final = "Final: NSH (4) - DAL (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-12-13"), AwayTeam = "Edmonton", HomeTeam = "Colorado", Final = "Final: EDM (4) - COL (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-12-13"), AwayTeam = "Los Angeles", HomeTeam = "Phoenix", Final = "Final: LAK (2) - PHX (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-13-13"), AwayTeam = "Ottawa", HomeTeam = "Montreal", Final = "Final: OTT (3) - MTL (4) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-13-13"), AwayTeam = "Philadelphia", HomeTeam = "New Jersey", Final = "Final: PHI (2) - NJD (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-13-13"), AwayTeam = "Detroit", HomeTeam = "Calgary", Final = "Final: DET (2) - CGY (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-14-13"), AwayTeam = "Florida", HomeTeam = "Boston", Final = "Final: FLA (1) - BOS (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-14-13"), AwayTeam = "Pittsburgh", HomeTeam = "Toronto", Final = "Final: PIT (3) - TOR (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-14-13"), AwayTeam = "Washington", HomeTeam = "Carolina", Final = "Final: WSH (3) - CAR (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-14-13"), AwayTeam = "Chicago", HomeTeam = "Columbus", Final = "Final: CHI (2) - CBJ (1) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-14-13"), AwayTeam = "NY Islanders", HomeTeam = "Tampa Bay", Final = "Final: NYI (2) - TBL (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-14-13"), AwayTeam = "NY Rangers", HomeTeam = "Winnipeg", Final = "Final: NYR (1) - WPG (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-14-13"), AwayTeam = "Phoenix", HomeTeam = "St. Louis", Final = "Final: PHX (0) - STL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-14-13"), AwayTeam = "Colorado", HomeTeam = "Minnesota", Final = "Final: COL (3) - MIN (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-14-13"), AwayTeam = "Anaheim", HomeTeam = "Dallas", Final = "Final: ANA (2) - DAL (1) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-14-13"), AwayTeam = "Nashville", HomeTeam = "Vancouver", Final = "Final: NSH (4) - VAN (7)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-14-13"), AwayTeam = "Los Angeles", HomeTeam = "San Jose", Final = "Final: LAK (3) - SJS (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-15-13"), AwayTeam = "New Jersey", HomeTeam = "Philadelphia", Final = "Final: NJD (1) - PHI (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-15-13"), AwayTeam = "Nashville", HomeTeam = "Calgary", Final = "Final: NSH (3) - CGY (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-15-13"), AwayTeam = "Detroit", HomeTeam = "Edmonton", Final = "Final: DET (3) - EDM (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-16-13"), AwayTeam = "Washington", HomeTeam = "Boston", Final = "Final: WSH (1) - BOS (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-16-13"), AwayTeam = "NY Rangers", HomeTeam = "Pittsburgh", Final = "Final: NYR (0) - PIT (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-16-13"), AwayTeam = "Ottawa", HomeTeam = "Buffalo", Final = "Final: OTT (4) - BUF (3) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-16-13"), AwayTeam = "Minnesota", HomeTeam = "Colorado", Final = "Final: MIN (6) - COL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-16-13"), AwayTeam = "Winnipeg", HomeTeam = "Toronto", Final = "Final: WPG (5) - TOR (4) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-16-13"), AwayTeam = "Montreal", HomeTeam = "New Jersey", Final = "Final: MTL (2) - NJD (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-16-13"), AwayTeam = "Carolina", HomeTeam = "Tampa Bay", Final = "Final: CAR (1) - TBL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-16-13"), AwayTeam = "Phoenix", HomeTeam = "Columbus", Final = "Final: PHX (0) - CBJ (1) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-16-13"), AwayTeam = "NY Islanders", HomeTeam = "Florida", Final = "Final: NYI (4) - FLA (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-16-13"), AwayTeam = "Anaheim", HomeTeam = "St. Louis", Final = "Final: ANA (1) - STL (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-16-13"), AwayTeam = "Chicago", HomeTeam = "Dallas", Final = "Final: CHI (8) - DAL (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-16-13"), AwayTeam = "Detroit", HomeTeam = "Vancouver", Final = "Final: DET (5) - VAN (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-16-13"), AwayTeam = "San Jose", HomeTeam = "Los Angeles", Final = "Final: SJS (2) - LAK (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-17-13"), AwayTeam = "Boston", HomeTeam = "Pittsburgh", Final = "Final: BOS (1) - PIT (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-17-13"), AwayTeam = "Winnipeg", HomeTeam = "Ottawa", Final = "Final: WPG (1) - OTT (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-17-13"), AwayTeam = "Buffalo", HomeTeam = "Washington", Final = "Final: BUF (3) - WSH (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-17-13"), AwayTeam = "Nashville", HomeTeam = "Edmonton", Final = "Final: NSH (2) - EDM (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-18-13"), AwayTeam = "Carolina", HomeTeam = "NY Rangers", Final = "Final: CAR (1) - NYR (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-18-13"), AwayTeam = "Philadelphia", HomeTeam = "Tampa Bay", Final = "Final: PHI (2) - TBL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-18-13"), AwayTeam = "Calgary", HomeTeam = "Dallas", Final = "Final: CGY (3) - DAL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-18-13"), AwayTeam = "Chicago", HomeTeam = "Colorado", Final = "Final: CHI (5) - COL (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-18-13"), AwayTeam = "Minnesota", HomeTeam = "Vancouver", Final = "Final: MIN (3) - VAN (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-18-13"), AwayTeam = "San Jose", HomeTeam = "Anaheim", Final = "Final: SJS (3) - ANA (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-18-13"), AwayTeam = "Phoenix", HomeTeam = "Los Angeles", Final = "Final: PHX (0) - LAK (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-19-13"), AwayTeam = "NY Rangers", HomeTeam = "New Jersey", Final = "Final: NYR (3) - NJD (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-19-13"), AwayTeam = "Ottawa", HomeTeam = "NY Islanders", Final = "Final: OTT (5) - NYI (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-19-13"), AwayTeam = "Florida", HomeTeam = "Carolina", Final = "Final: FLA (4) - CAR (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-19-13"), AwayTeam = "Nashville", HomeTeam = "Columbus", Final = "Final: NSH (3) - CBJ (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-19-13"), AwayTeam = "Buffalo", HomeTeam = "Montreal", Final = "Final: BUF (3) - MTL (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-19-13"), AwayTeam = "Washington", HomeTeam = "Pittsburgh", Final = "Final: WSH (1) - PIT (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-19-13"), AwayTeam = "Boston", HomeTeam = "Winnipeg", Final = "Final: BOS (1) - WPG (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-19-13"), AwayTeam = "St. Louis", HomeTeam = "Vancouver", Final = "Final: STL (2) - VAN (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-19-13"), AwayTeam = "Phoenix", HomeTeam = "Los Angeles", Final = "Final: PHX (2) - LAK (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-20-13"), AwayTeam = "Tampa Bay", HomeTeam = "Toronto", Final = "Final: TBL (2) - TOR (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-20-13"), AwayTeam = "Minnesota", HomeTeam = "Detroit", Final = "Final: MIN (4) - DET (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-20-13"), AwayTeam = "Dallas", HomeTeam = "Colorado", Final = "Final: DAL (3) - COL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-20-13"), AwayTeam = "San Jose", HomeTeam = "Edmonton", Final = "Final: SJS (4) - EDM (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-20-13"), AwayTeam = "Chicago", HomeTeam = "Anaheim", Final = "Final: CHI (2) - ANA (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-21-13"), AwayTeam = "Toronto", HomeTeam = "Buffalo", Final = "Final: TOR (4) - BUF (5) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-21-13"), AwayTeam = "Montreal", HomeTeam = "NY Islanders", Final = "Final: MTL (5) - NYI (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-21-13"), AwayTeam = "Florida", HomeTeam = "NY Rangers", Final = "Final: FLA (3) - NYR (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-21-13"), AwayTeam = "New Jersey", HomeTeam = "Carolina", Final = "Final: NJD (4) - CAR (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-21-13"), AwayTeam = "Boston", HomeTeam = "Ottawa", Final = "Final: BOS (2) - OTT (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-21-13"), AwayTeam = "Washington", HomeTeam = "Winnipeg", Final = "Final: WSH (4) - WPG (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-21-13"), AwayTeam = "Calgary", HomeTeam = "Nashville", Final = "Final: CGY (3) - NSH (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-21-13"), AwayTeam = "Vancouver", HomeTeam = "Phoenix", Final = "Final: VAN (2) - PHX (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-21-13"), AwayTeam = "Dallas", HomeTeam = "Los Angeles", Final = "Final: DAL (2) - LAK (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-22-13"), AwayTeam = "Pittsburgh", HomeTeam = "NY Islanders", Final = "Final: PIT (4) - NYI (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-22-13"), AwayTeam = "Calgary", HomeTeam = "Columbus", Final = "Final: CGY (1) - CBJ (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-22-13"), AwayTeam = "Washington", HomeTeam = "Winnipeg", Final = "Final: WSH (6) - WPG (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-22-13"), AwayTeam = "Detroit", HomeTeam = "Anaheim", Final = "Final: DET (5) - ANA (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-23-13"), AwayTeam = "Tampa Bay", HomeTeam = "Ottawa", Final = "Final: TBL (3) - OTT (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-23-13"), AwayTeam = "San Jose", HomeTeam = "Minnesota", Final = "Final: SJS (0) - MIN (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-23-13"), AwayTeam = "Vancouver", HomeTeam = "Los Angeles", Final = "Final: VAN (1) - LAK (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-23-13"), AwayTeam = "Boston", HomeTeam = "Toronto", Final = "Final: BOS (2) - TOR (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-23-13"), AwayTeam = "Buffalo", HomeTeam = "Montreal", Final = "Final: BUF (2) - MTL (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-23-13"), AwayTeam = "Florida", HomeTeam = "New Jersey", Final = "Final: FLA (1) - NJD (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-23-13"), AwayTeam = "Columbus", HomeTeam = "Nashville", Final = "Final: CBJ (2) - NSH (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-23-13"), AwayTeam = "Colorado", HomeTeam = "Dallas", Final = "Final: COL (2) - DAL (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-23-13"), AwayTeam = "St. Louis", HomeTeam = "Edmonton", Final = "Final: STL (3) - EDM (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-24-13"), AwayTeam = "Florida", HomeTeam = "NY Islanders", Final = "Final: FLA (0) - NYI (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-24-13"), AwayTeam = "Washington", HomeTeam = "NY Rangers", Final = "Final: WSH (3) - NYR (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-24-13"), AwayTeam = "Philadelphia", HomeTeam = "Pittsburgh", Final = "Final: PHI (1) - PIT (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-24-13"), AwayTeam = "Tampa Bay", HomeTeam = "Winnipeg", Final = "Final: TBL (2) - WPG (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-24-13"), AwayTeam = "Vancouver", HomeTeam = "Colorado", Final = "Final: VAN (3) - COL (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-24-13"), AwayTeam = "St. Louis", HomeTeam = "Calgary", Final = "Final: STL (2) - CGY (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-24-13"), AwayTeam = "Detroit", HomeTeam = "Anaheim", Final = "Final: DET (2) - ANA (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-25-13"), AwayTeam = "Toronto", HomeTeam = "Boston", Final = "Final: TOR (2) - BOS (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-25-13"), AwayTeam = "New Jersey", HomeTeam = "Ottawa", Final = "Final: NJD (2) - OTT (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-25-13"), AwayTeam = "Los Angeles", HomeTeam = "Chicago", Final = "Final: LAK (5) - CHI (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-25-13"), AwayTeam = "Edmonton", HomeTeam = "Nashville", Final = "Final: EDM (2) - NSH (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-25-13"), AwayTeam = "Minnesota", HomeTeam = "Dallas", Final = "Final: MIN (7) - DAL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-25-13"), AwayTeam = "Detroit", HomeTeam = "Phoenix", Final = "Final: DET (3) - PHX (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-25-13"), AwayTeam = "San Jose", HomeTeam = "Anaheim", Final = "Final: SJS (5) - ANA (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-26-13"), AwayTeam = "Florida", HomeTeam = "Toronto", Final = "Final: FLA (2) - TOR (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-26-13"), AwayTeam = "Montreal", HomeTeam = "Pittsburgh", Final = "Final: MTL (0) - PIT (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-26-13"), AwayTeam = "NY Islanders", HomeTeam = "Washington", Final = "Final: NYI (3) - WSH (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-26-13"), AwayTeam = "Winnipeg", HomeTeam = "Carolina", Final = "Final: WPG (4) - CAR (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-26-13"), AwayTeam = "NY Rangers", HomeTeam = "Philadelphia", Final = "Final: NYR (5) - PHI (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-26-13"), AwayTeam = "Buffalo", HomeTeam = "Tampa Bay", Final = "Final: BUF (1) - TBL (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-26-13"), AwayTeam = "Edmonton", HomeTeam = "St. Louis", Final = "Final: EDM (3) - STL (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-26-13"), AwayTeam = "Calgary", HomeTeam = "Chicago", Final = "Final: CGY (0) - CHI (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-26-13"), AwayTeam = "Columbus", HomeTeam = "Vancouver", Final = "Final: CBJ (0) - VAN (1) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-27-13"), AwayTeam = "Montreal", HomeTeam = "Boston", Final = "Final: MTL (6) - BOS (5) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-27-13"), AwayTeam = "Phoenix", HomeTeam = "Minnesota", Final = "Final: PHX (3) - MIN (4) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-27-13"), AwayTeam = "Colorado", HomeTeam = "Calgary", Final = "Final: COL (3) - CGY (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-27-13"), AwayTeam = "Anaheim", HomeTeam = "San Jose", Final = "Final: ANA (0) - SJS (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-28-13"), AwayTeam = "Carolina", HomeTeam = "Toronto", Final = "Final: CAR (3) - TOR (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-28-13"), AwayTeam = "NY Islanders", HomeTeam = "Philadelphia", Final = "Final: NYI (4) - PHI (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-28-13"), AwayTeam = "Winnipeg", HomeTeam = "Pittsburgh", Final = "Final: WPG (0) - PIT (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-28-13"), AwayTeam = "NY Rangers", HomeTeam = "Ottawa", Final = "Final: NYR (0) - OTT (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-28-13"), AwayTeam = "Buffalo", HomeTeam = "Florida", Final = "Final: BUF (4) - FLA (5) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-28-13"), AwayTeam = "Los Angeles", HomeTeam = "St. Louis", Final = "Final: LAK (4) - STL (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-28-13"), AwayTeam = "Phoenix", HomeTeam = "Nashville", Final = "Final: PHX (7) - NSH (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-28-13"), AwayTeam = "Columbus", HomeTeam = "Edmonton", Final = "Final: CBJ (4) - EDM (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-28-13"), AwayTeam = "Colorado", HomeTeam = "Vancouver", Final = "Final: COL (1) - VAN (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-28-13"), AwayTeam = "Detroit", HomeTeam = "San Jose", Final = "Final: DET (0) - SJS (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-29-13"), AwayTeam = "New Jersey", HomeTeam = "Tampa Bay", Final = "Final: NJD (4) - TBL (5) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-29-13"), AwayTeam = "Anaheim", HomeTeam = "Chicago", Final = "Final: ANA (2) - CHI (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-29-13"), AwayTeam = "Minnesota", HomeTeam = "Dallas", Final = "Final: MIN (3) - DAL (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-29-13"), AwayTeam = "Columbus", HomeTeam = "Calgary", Final = "Final: CBJ (6) - CGY (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-30-13"), AwayTeam = "Boston", HomeTeam = "Philadelphia", Final = "Final: BOS (1) - PHI (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-30-13"), AwayTeam = "NY Islanders", HomeTeam = "Pittsburgh", Final = "Final: NYI (0) - PIT (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-30-13"), AwayTeam = "Carolina", HomeTeam = "Winnipeg", Final = "Final: CAR (3) - WPG (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-30-13"), AwayTeam = "Nashville", HomeTeam = "Colorado", Final = "Final: NSH (0) - COL (1) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-30-13"), AwayTeam = "Washington", HomeTeam = "Buffalo", Final = "Final: WSH (4) - BUF (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-30-13"), AwayTeam = "NY Rangers", HomeTeam = "Montreal", Final = "Final: NYR (0) - MTL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-30-13"), AwayTeam = "Toronto", HomeTeam = "Ottawa", Final = "Final: TOR (4) - OTT (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-30-13"), AwayTeam = "New Jersey", HomeTeam = "Florida", Final = "Final: NJD (2) - FLA (3) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-30-13"), AwayTeam = "Los Angeles", HomeTeam = "Minnesota", Final = "Final: LAK (3) - MIN (4) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-30-13"), AwayTeam = "Vancouver", HomeTeam = "Edmonton", Final = "Final: VAN (0) - EDM (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-30-13"), AwayTeam = "Phoenix", HomeTeam = "San Jose", Final = "Final: PHX (2) - SJS (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-31-13"), AwayTeam = "Chicago", HomeTeam = "Detroit", Final = "Final: CHI (7) - DET (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-31-13"), AwayTeam = "Anaheim", HomeTeam = "Columbus", Final = "Final: ANA (1) - CBJ (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-31-13"), AwayTeam = "Los Angeles", HomeTeam = "Dallas", Final = "Final: LAK (3) - DAL (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-31-13"), AwayTeam = "Washington", HomeTeam = "Philadelphia", Final = "Final: WSH (4) - PHI (5) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("03-31-13"), AwayTeam = "Boston", HomeTeam = "Buffalo", Final = "Final: BOS (2) - BUF (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-01-13"), AwayTeam = "NY Islanders", HomeTeam = "New Jersey", Final = "Final: NYI (3) - NJD (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-01-13"), AwayTeam = "Winnipeg", HomeTeam = "NY Rangers", Final = "Final: WPG (2) - NYR (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-01-13"), AwayTeam = "Carolina", HomeTeam = "Montreal", Final = "Final: CAR (1) - MTL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-01-13"), AwayTeam = "Colorado", HomeTeam = "Detroit", Final = "Final: COL (2) - DET (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-01-13"), AwayTeam = "St. Louis", HomeTeam = "Minnesota", Final = "Final: STL (4) - MIN (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-01-13"), AwayTeam = "Nashville", HomeTeam = "Chicago", Final = "Final: NSH (2) - CHI (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-01-13"), AwayTeam = "Anaheim", HomeTeam = "Dallas", Final = "Final: ANA (4) - DAL (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-01-13"), AwayTeam = "Calgary", HomeTeam = "Edmonton", Final = "Final: CGY (1) - EDM (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-01-13"), AwayTeam = "Vancouver", HomeTeam = "San Jose", Final = "Final: VAN (2) - SJS (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-02-13"), AwayTeam = "Ottawa", HomeTeam = "Boston", Final = "Final: OTT (2) - BOS (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-02-13"), AwayTeam = "Winnipeg", HomeTeam = "NY Islanders", Final = "Final: WPG (2) - NYI (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-02-13"), AwayTeam = "Washington", HomeTeam = "Carolina", Final = "Final: WSH (5) - CAR (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-02-13"), AwayTeam = "Buffalo", HomeTeam = "Pittsburgh", Final = "Final: BUF (4) - PIT (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-02-13"), AwayTeam = "Florida", HomeTeam = "Tampa Bay", Final = "Final: FLA (3) - TBL (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-02-13"), AwayTeam = "Colorado", HomeTeam = "Nashville", Final = "Final: COL (1) - NSH (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-02-13"), AwayTeam = "Los Angeles", HomeTeam = "Phoenix", Final = "Final: LAK (1) - PHX (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-03-13"), AwayTeam = "Pittsburgh", HomeTeam = "NY Rangers", Final = "Final: PIT (1) - NYR (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-03-13"), AwayTeam = "Montreal", HomeTeam = "Philadelphia", Final = "Final: MTL (3) - PHI (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-03-13"), AwayTeam = "Edmonton", HomeTeam = "Calgary", Final = "Final: EDM (8) - CGY (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-03-13"), AwayTeam = "Dallas", HomeTeam = "Anaheim", Final = "Final: DAL (2) - ANA (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-03-13"), AwayTeam = "Minnesota", HomeTeam = "San Jose", Final = "Final: MIN (2) - SJS (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-04-13"), AwayTeam = "New Jersey", HomeTeam = "Boston", Final = "Final: NJD (0) - BOS (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-04-13"), AwayTeam = "Philadelphia", HomeTeam = "Toronto", Final = "Final: PHI (5) - TOR (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-04-13"), AwayTeam = "NY Islanders", HomeTeam = "Washington", Final = "Final: NYI (1) - WSH (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-04-13"), AwayTeam = "Tampa Bay", HomeTeam = "Carolina", Final = "Final: TBL (5) - CAR (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-04-13"), AwayTeam = "Winnipeg", HomeTeam = "Montreal", Final = "Final: WPG (1) - MTL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-04-13"), AwayTeam = "Columbus", HomeTeam = "Nashville", Final = "Final: CBJ (3) - NSH (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-04-13"), AwayTeam = "St. Louis", HomeTeam = "Chicago", Final = "Final: STL (4) - CHI (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-04-13"), AwayTeam = "Detroit", HomeTeam = "Phoenix", Final = "Final: DET (2) - PHX (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-04-13"), AwayTeam = "Edmonton", HomeTeam = "Vancouver", Final = "Final: EDM (0) - VAN (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-04-13"), AwayTeam = "Minnesota", HomeTeam = "Los Angeles", Final = "Final: MIN (0) - LAK (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-05-13"), AwayTeam = "Ottawa", HomeTeam = "Buffalo", Final = "Final: OTT (2) - BUF (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-05-13"), AwayTeam = "NY Rangers", HomeTeam = "Pittsburgh", Final = "Final: NYR (1) - PIT (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-05-13"), AwayTeam = "Columbus", HomeTeam = "St. Louis", Final = "Final: CBJ (1) - STL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-05-13"), AwayTeam = "Detroit", HomeTeam = "Colorado", Final = "Final: DET (3) - COL (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-05-13"), AwayTeam = "Dallas", HomeTeam = "Anaheim", Final = "Final: DAL (3) - ANA (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-05-13"), AwayTeam = "Calgary", HomeTeam = "San Jose", Final = "Final: CGY (1) - SJS (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-06-13"), AwayTeam = "Philadelphia", HomeTeam = "Winnipeg", Final = "Final: PHI (1) - WPG (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-06-13"), AwayTeam = "Chicago", HomeTeam = "Nashville", Final = "Final: CHI (1) - NSH (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-06-13"), AwayTeam = "Edmonton", HomeTeam = "Los Angeles", Final = "Final: EDM (1) - LAK (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-06-13"), AwayTeam = "Boston", HomeTeam = "Montreal", Final = "Final: BOS (1) - MTL (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-06-13"), AwayTeam = "Toronto", HomeTeam = "New Jersey", Final = "Final: TOR (2) - NJD (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-06-13"), AwayTeam = "Tampa Bay", HomeTeam = "NY Islanders", Final = "Final: TBL (2) - NYI (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-06-13"), AwayTeam = "NY Rangers", HomeTeam = "Carolina", Final = "Final: NYR (4) - CAR (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-06-13"), AwayTeam = "Washington", HomeTeam = "Florida", Final = "Final: WSH (4) - FLA (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-06-13"), AwayTeam = "Colorado", HomeTeam = "Phoenix", Final = "Final: COL (0) - PHX (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-06-13"), AwayTeam = "Calgary", HomeTeam = "Vancouver", Final = "Final: CGY (2) - VAN (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-07-13"), AwayTeam = "St. Louis", HomeTeam = "Detroit", Final = "Final: STL (1) - DET (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-07-13"), AwayTeam = "Dallas", HomeTeam = "San Jose", Final = "Final: DAL (5) - SJS (4) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-07-13"), AwayTeam = "Ottawa", HomeTeam = "Florida", Final = "Final: OTT (1) - FLA (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-07-13"), AwayTeam = "Minnesota", HomeTeam = "Columbus", Final = "Final: MIN (3) - CBJ (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-07-13"), AwayTeam = "Tampa Bay", HomeTeam = "Washington", Final = "Final: TBL (2) - WSH (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-07-13"), AwayTeam = "Nashville", HomeTeam = "Chicago", Final = "Final: NSH (3) - CHI (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-07-13"), AwayTeam = "New Jersey", HomeTeam = "Buffalo", Final = "Final: NJD (2) - BUF (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-07-13"), AwayTeam = "Los Angeles", HomeTeam = "Anaheim", Final = "Final: LAK (3) - ANA (4) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-08-13"), AwayTeam = "Carolina", HomeTeam = "Boston", Final = "Final: CAR (2) - BOS (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-08-13"), AwayTeam = "NY Rangers", HomeTeam = "Toronto", Final = "Final: NYR (3) - TOR (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-08-13"), AwayTeam = "Calgary", HomeTeam = "Colorado", Final = "Final: CGY (3) - COL (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-08-13"), AwayTeam = "Phoenix", HomeTeam = "Vancouver", Final = "Final: PHX (0) - VAN (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-08-13"), AwayTeam = "Edmonton", HomeTeam = "Anaheim", Final = "Final: EDM (1) - ANA (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-09-13"), AwayTeam = "Philadelphia", HomeTeam = "NY Islanders", Final = "Final: PHI (1) - NYI (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-09-13"), AwayTeam = "Pittsburgh", HomeTeam = "Carolina", Final = "Final: PIT (5) - CAR (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-09-13"), AwayTeam = "San Jose", HomeTeam = "Columbus", Final = "Final: SJS (0) - CBJ (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-09-13"), AwayTeam = "Washington", HomeTeam = "Montreal", Final = "Final: WSH (3) - MTL (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-09-13"), AwayTeam = "Ottawa", HomeTeam = "Tampa Bay", Final = "Final: OTT (2) - TBL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-09-13"), AwayTeam = "Buffalo", HomeTeam = "Winnipeg", Final = "Final: BUF (1) - WPG (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-09-13"), AwayTeam = "St. Louis", HomeTeam = "Nashville", Final = "Final: STL (1) - NSH (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-09-13"), AwayTeam = "Chicago", HomeTeam = "Minnesota", Final = "Final: CHI (1) - MIN (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-09-13"), AwayTeam = "Los Angeles", HomeTeam = "Dallas", Final = "Final: LAK (1) - DAL (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-10-13"), AwayTeam = "Toronto", HomeTeam = "NY Rangers", Final = "Final: TOR (2) - NYR (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-10-13"), AwayTeam = "Boston", HomeTeam = "New Jersey", Final = "Final: BOS (5) - NJD (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-10-13"), AwayTeam = "Vancouver", HomeTeam = "Calgary", Final = "Final: VAN (4) - CGY (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-10-13"), AwayTeam = "Phoenix", HomeTeam = "Edmonton", Final = "Final: PHX (3) - EDM (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-10-13"), AwayTeam = "Colorado", HomeTeam = "Anaheim", Final = "Final: COL (4) - ANA (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-11-13"), AwayTeam = "NY Islanders", HomeTeam = "Boston", Final = "Final: NYI (2) - BOS (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-11-13"), AwayTeam = "Ottawa", HomeTeam = "Philadelphia", Final = "Final: OTT (3) - PHI (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-11-13"), AwayTeam = "Carolina", HomeTeam = "Washington", Final = "Final: CAR (1) - WSH (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-11-13"), AwayTeam = "Montreal", HomeTeam = "Buffalo", Final = "Final: MTL (5) - BUF (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-11-13"), AwayTeam = "Pittsburgh", HomeTeam = "Tampa Bay", Final = "Final: PIT (6) - TBL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-11-13"), AwayTeam = "San Jose", HomeTeam = "Detroit", Final = "Final: SJS (3) - DET (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-11-13"), AwayTeam = "Florida", HomeTeam = "Winnipeg", Final = "Final: FLA (2) - WPG (7)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-11-13"), AwayTeam = "St. Louis", HomeTeam = "Minnesota", Final = "Final: STL (2) - MIN (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-11-13"), AwayTeam = "Colorado", HomeTeam = "Los Angeles", Final = "Final: COL (2) - LAK (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-12-13"), AwayTeam = "Ottawa", HomeTeam = "New Jersey", Final = "Final: OTT (2) - NJD (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-12-13"), AwayTeam = "St. Louis", HomeTeam = "Columbus", Final = "Final: STL (1) - CBJ (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-12-13"), AwayTeam = "Dallas", HomeTeam = "Nashville", Final = "Final: DAL (5) - NSH (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-12-13"), AwayTeam = "Detroit", HomeTeam = "Chicago", Final = "Final: DET (2) - CHI (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-12-13"), AwayTeam = "Phoenix", HomeTeam = "Calgary", Final = "Final: PHX (2) - CGY (3) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-13-13"), AwayTeam = "Philadelphia", HomeTeam = "Buffalo", Final = "Final: PHI (0) - BUF (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-13-13"), AwayTeam = "Vancouver", HomeTeam = "Colorado", Final = "Final: VAN (3) - COL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-13-13"), AwayTeam = "Montreal", HomeTeam = "Toronto", Final = "Final: MTL (1) - TOR (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-13-13"), AwayTeam = "NY Rangers", HomeTeam = "NY Islanders", Final = "Final: NYR (1) - NYI (0) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-13-13"), AwayTeam = "Tampa Bay", HomeTeam = "Washington", Final = "Final: TBL (5) - WSH (6) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-13-13"), AwayTeam = "Boston", HomeTeam = "Carolina", Final = "Final: BOS (2) - CAR (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-13-13"), AwayTeam = "Pittsburgh", HomeTeam = "Florida", Final = "Final: PIT (3) - FLA (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-13-13"), AwayTeam = "Columbus", HomeTeam = "Minnesota", Final = "Final: CBJ (3) - MIN (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-13-13"), AwayTeam = "San Jose", HomeTeam = "Dallas", Final = "Final: SJS (1) - DAL (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-13-13"), AwayTeam = "Calgary", HomeTeam = "Edmonton", Final = "Final: CGY (4) - EDM (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-13-13"), AwayTeam = "Anaheim", HomeTeam = "Los Angeles", Final = "Final: ANA (1) - LAK (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-14-13"), AwayTeam = "Chicago", HomeTeam = "St. Louis", Final = "Final: CHI (2) - STL (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-14-13"), AwayTeam = "Tampa Bay", HomeTeam = "Buffalo", Final = "Final: TBL (1) - BUF (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-14-13"), AwayTeam = "Detroit", HomeTeam = "Nashville", Final = "Final: DET (3) - NSH (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-15-13"), AwayTeam = "New Jersey", HomeTeam = "Toronto", Final = "Final: NJD (0) - TOR (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-15-13"), AwayTeam = "Philadelphia", HomeTeam = "Montreal", Final = "Final: PHI (7) - MTL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-15-13"), AwayTeam = "Dallas", HomeTeam = "Chicago", Final = "Final: DAL (2) - CHI (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-15-13"), AwayTeam = "Vancouver", HomeTeam = "Nashville", Final = "Final: VAN (5) - NSH (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-15-13"), AwayTeam = "Columbus", HomeTeam = "Colorado", Final = "Final: CBJ (4) - COL (3) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-15-13"), AwayTeam = "Minnesota", HomeTeam = "Calgary", Final = "Final: MIN (4) - CGY (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-15-13"), AwayTeam = "San Jose", HomeTeam = "Phoenix", Final = "Final: SJS (4) - PHX (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-16-13"), AwayTeam = "Florida", HomeTeam = "NY Islanders", Final = "Final: FLA (2) - NYI (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-16-13"), AwayTeam = "Toronto", HomeTeam = "Washington", Final = "Final: TOR (1) - WSH (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-16-13"), AwayTeam = "Carolina", HomeTeam = "Ottawa", Final = "Final: CAR (2) - OTT (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-16-13"), AwayTeam = "NY Rangers", HomeTeam = "Philadelphia", Final = "Final: NYR (2) - PHI (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-16-13"), AwayTeam = "Tampa Bay", HomeTeam = "Winnipeg", Final = "Final: TBL (3) - WPG (4) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-16-13"), AwayTeam = "Vancouver", HomeTeam = "St. Louis", Final = "Final: VAN (1) - STL (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-16-13"), AwayTeam = "Minnesota", HomeTeam = "Edmonton", Final = "Final: MIN (5) - EDM (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-16-13"), AwayTeam = "Los Angeles", HomeTeam = "San Jose", Final = "Final: LAK (2) - SJS (3) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-17-13"), AwayTeam = "Montreal", HomeTeam = "Pittsburgh", Final = "Final: MTL (4) - PIT (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-17-13"), AwayTeam = "Buffalo", HomeTeam = "Boston", Final = "Final: BUF (3) - BOS (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-17-13"), AwayTeam = "Detroit", HomeTeam = "Calgary", Final = "Final: DET (2) - CGY (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-17-13"), AwayTeam = "Columbus", HomeTeam = "Anaheim", Final = "Final: CBJ (3) - ANA (2) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-18-13"), AwayTeam = "NY Islanders", HomeTeam = "Toronto", Final = "Final: NYI (5) - TOR (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-18-13"), AwayTeam = "Florida", HomeTeam = "NY Rangers", Final = "Final: FLA (1) - NYR (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-18-13"), AwayTeam = "Tampa Bay", HomeTeam = "Montreal", Final = "Final: TBL (2) - MTL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-18-13"), AwayTeam = "Washington", HomeTeam = "Ottawa", Final = "Final: WSH (1) - OTT (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-18-13"), AwayTeam = "New Jersey", HomeTeam = "Philadelphia", Final = "Final: NJD (3) - PHI (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-18-13"), AwayTeam = "Carolina", HomeTeam = "Winnipeg", Final = "Final: CAR (3) - WPG (4) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-18-13"), AwayTeam = "Phoenix", HomeTeam = "St. Louis", Final = "Final: PHX (1) - STL (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-18-13"), AwayTeam = "Vancouver", HomeTeam = "Dallas", Final = "Final: VAN (1) - DAL (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-18-13"), AwayTeam = "Columbus", HomeTeam = "Los Angeles", Final = "Final: CBJ (1) - LAK (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-18-13"), AwayTeam = "Minnesota", HomeTeam = "San Jose", Final = "Final: MIN (1) - SJS (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-19-13"), AwayTeam = "NY Rangers", HomeTeam = "Buffalo", Final = "Final: NYR (8) - BUF (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-19-13"), AwayTeam = "Dallas", HomeTeam = "St. Louis", Final = "Final: DAL (1) - STL (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-19-13"), AwayTeam = "Nashville", HomeTeam = "Chicago", Final = "Final: NSH (4) - CHI (5) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-19-13"), AwayTeam = "Edmonton", HomeTeam = "Colorado", Final = "Final: EDM (4) - COL (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-19-13"), AwayTeam = "Anaheim", HomeTeam = "Calgary", Final = "Final: ANA (1) - CGY (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-20-13"), AwayTeam = "Pittsburgh", HomeTeam = "Boston", Final = "Final: PIT (3) - BOS (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-20-13"), AwayTeam = "Florida", HomeTeam = "New Jersey", Final = "Final: FLA (2) - NJD (6)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-20-13"), AwayTeam = "NY Islanders", HomeTeam = "Winnipeg", Final = "Final: NYI (5) - WPG (4) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-20-13"), AwayTeam = "Washington", HomeTeam = "Montreal", Final = "Final: WSH (5) - MTL (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-20-13"), AwayTeam = "Toronto", HomeTeam = "Ottawa", Final = "Final: TOR (4) - OTT (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-20-13"), AwayTeam = "Philadelphia", HomeTeam = "Carolina", Final = "Final: PHI (5) - CAR (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-20-13"), AwayTeam = "Phoenix", HomeTeam = "Chicago", Final = "Final: PHX (3) - CHI (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-20-13"), AwayTeam = "Detroit", HomeTeam = "Vancouver", Final = "Final: DET (1) - VAN (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-21-13"), AwayTeam = "Florida", HomeTeam = "Boston", Final = "Final: FLA (0) - BOS (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-21-13"), AwayTeam = "New Jersey", HomeTeam = "NY Rangers", Final = "Final: NJD (1) - NYR (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-21-13"), AwayTeam = "Carolina", HomeTeam = "Tampa Bay", Final = "Final: CAR (3) - TBL (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-21-13"), AwayTeam = "Calgary", HomeTeam = "Minnesota", Final = "Final: CGY (4) - MIN (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-21-13"), AwayTeam = "St. Louis", HomeTeam = "Colorado", Final = "Final: STL (3) - COL (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-21-13"), AwayTeam = "Columbus", HomeTeam = "San Jose", Final = "Final: CBJ (4) - SJS (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-21-13"), AwayTeam = "Anaheim", HomeTeam = "Edmonton", Final = "Final: ANA (3) - EDM (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-21-13"), AwayTeam = "Dallas", HomeTeam = "Los Angeles", Final = "Final: DAL (3) - LAK (4) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-22-13"), AwayTeam = "Winnipeg", HomeTeam = "Buffalo", Final = "Final: WPG (2) - BUF (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-22-13"), AwayTeam = "Pittsburgh", HomeTeam = "Ottawa", Final = "Final: PIT (3) - OTT (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-22-13"), AwayTeam = "Phoenix", HomeTeam = "Detroit", Final = "Final: PHX (0) - DET (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-22-13"), AwayTeam = "Anaheim", HomeTeam = "Edmonton", Final = "Final: ANA (3) - EDM (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-22-13"), AwayTeam = "Chicago", HomeTeam = "Vancouver", Final = "Final: CHI (1) - VAN (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-23-13"), AwayTeam = "Montreal", HomeTeam = "New Jersey", Final = "Final: MTL (2) - NJD (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-23-13"), AwayTeam = "Winnipeg", HomeTeam = "Washington", Final = "Final: WPG (3) - WSH (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-23-13"), AwayTeam = "NY Islanders", HomeTeam = "Carolina", Final = "Final: NYI (3) - CAR (4) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-23-13"), AwayTeam = "Buffalo", HomeTeam = "Pittsburgh", Final = "Final: BUF (4) - PIT (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-23-13"), AwayTeam = "Boston", HomeTeam = "Philadelphia", Final = "Final: BOS (2) - PHI (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-23-13"), AwayTeam = "NY Rangers", HomeTeam = "Florida", Final = "Final: NYR (2) - FLA (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-23-13"), AwayTeam = "Colorado", HomeTeam = "St. Louis", Final = "Final: COL (1) - STL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-23-13"), AwayTeam = "Calgary", HomeTeam = "Nashville", Final = "Final: CGY (3) - NSH (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-23-13"), AwayTeam = "Los Angeles", HomeTeam = "Minnesota", Final = "Final: LAK (1) - MIN (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-23-13"), AwayTeam = "Dallas", HomeTeam = "San Jose", Final = "Final: DAL (2) - SJS (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-24-13"), AwayTeam = "Toronto", HomeTeam = "Tampa Bay", Final = "Final: TOR (2) - TBL (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-24-13"), AwayTeam = "Los Angeles", HomeTeam = "Detroit", Final = "Final: LAK (1) - DET (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-24-13"), AwayTeam = "Chicago", HomeTeam = "Edmonton", Final = "Final: CHI (4) - EDM (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-24-13"), AwayTeam = "San Jose", HomeTeam = "Phoenix", Final = "Final: SJS (1) - PHX (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-25-13"), AwayTeam = "NY Islanders", HomeTeam = "Philadelphia", Final = "Final: NYI (1) - PHI (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-25-13"), AwayTeam = "Ottawa", HomeTeam = "Washington", Final = "Final: OTT (2) - WSH (1) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-25-13"), AwayTeam = "NY Rangers", HomeTeam = "Carolina", Final = "Final: NYR (4) - CAR (3) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-25-13"), AwayTeam = "Tampa Bay", HomeTeam = "Boston", Final = "Final: TBL (0) - BOS (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-25-13"), AwayTeam = "Pittsburgh", HomeTeam = "New Jersey", Final = "Final: PIT (2) - NJD (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-25-13"), AwayTeam = "Toronto", HomeTeam = "Florida", Final = "Final: TOR (4) - FLA (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-25-13"), AwayTeam = "Nashville", HomeTeam = "Detroit", Final = "Final: NSH (2) - DET (5)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-25-13"), AwayTeam = "Montreal", HomeTeam = "Winnipeg", Final = "Final: MTL (4) - WPG (2)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-25-13"), AwayTeam = "Calgary", HomeTeam = "St. Louis", Final = "Final: CGY (1) - STL (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-25-13"), AwayTeam = "Columbus", HomeTeam = "Dallas", Final = "Final: CBJ (3) - DAL (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-25-13"), AwayTeam = "Anaheim", HomeTeam = "Vancouver", Final = "Final: ANA (3) - VAN (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-26-13"), AwayTeam = "NY Islanders", HomeTeam = "Buffalo", Final = "Final: NYI (1) - BUF (2) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-26-13"), AwayTeam = "Edmonton", HomeTeam = "Minnesota", Final = "Final: EDM (6) - MIN (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-26-13"), AwayTeam = "Calgary", HomeTeam = "Chicago", Final = "Final: CGY (1) - CHI (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-26-13"), AwayTeam = "Colorado", HomeTeam = "Phoenix", Final = "Final: COL (5) - PHX (4) S/O" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-27-13"), AwayTeam = "New Jersey", HomeTeam = "NY Rangers", Final = "Final: NJD (0) - NYR (4)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-27-13"), AwayTeam = "Montreal", HomeTeam = "Toronto", Final = "Final: MTL (4) - TOR (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-27-13"), AwayTeam = "Philadelphia", HomeTeam = "Ottawa", Final = "Final: PHI (2) - OTT (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-27-13"), AwayTeam = "Boston", HomeTeam = "Washington", Final = "Final: BOS (2) - WSH (3) OT" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-27-13"), AwayTeam = "Florida", HomeTeam = "Tampa Bay", Final = "Final: FLA (5) - TBL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-27-13"), AwayTeam = "Nashville", HomeTeam = "Columbus", Final = "Final: NSH (1) - CBJ (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-27-13"), AwayTeam = "Detroit", HomeTeam = "Dallas", Final = "Final: DET (3) - DAL (0)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-27-13"), AwayTeam = "Carolina", HomeTeam = "Pittsburgh", Final = "Final: CAR (3) - PIT (8)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-27-13"), AwayTeam = "Minnesota", HomeTeam = "Colorado", Final = "Final: MIN (3) - COL (1)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-27-13"), AwayTeam = "Chicago", HomeTeam = "St. Louis", Final = "Final: CHI (1) - STL (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-27-13"), AwayTeam = "Vancouver", HomeTeam = "Edmonton", Final = "Final: VAN (2) - EDM (7)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-27-13"), AwayTeam = "Phoenix", HomeTeam = "Anaheim", Final = "Final: PHX (5) - ANA (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-27-13"), AwayTeam = "San Jose", HomeTeam = "Los Angeles", Final = "Final: SJS (2) - LAK (3)" },
                new ScheduleByDate { Date = Convert.ToDateTime("04-28-13"), AwayTeam = "Ottawa", HomeTeam = "Boston", Final = "Final: OTT (4) - BOS (2)" }
				#endregion
			};

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
                where teamGrp.TeamName.ToLower() == teamName.ToLower()
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
                         where oppGame1.HomeTeam == teamName || oppGame1.AwayTeam == teamName
                         select oppGame1
                        ).FirstOrDefault();

                    var teamsIn2ndGame =
                        (from opp2ndGame in
                             (
                                 from teams2ndGames in lstScheduleByDate
                                 where teams2ndGames.Date == playDates.PlayDate2
                                 select teams2ndGames
                             ).ToList()
                         where opp2ndGame.HomeTeam == teamName || opp2ndGame.AwayTeam == teamName
                         select opp2ndGame
                        ).FirstOrDefault();

                    string opponentGame2 = teamsIn2ndGame.AwayTeam != teamName ? teamsIn2ndGame.AwayTeam : teamsIn2ndGame.HomeTeam;

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

                    if (teamsIn1stGame.HomeTeam == teamName && teamsIn2ndGame.HomeTeam == teamName)
                        yesAnswer = "<b>Yes</b>";//if both games in b2b are home games then make 'yes' bold to point out no travel for that particular b2b

                    // create the game info object
                    GameInfo gi = new GameInfo()
                    {
                        GameOneDate = playDates.PlayDate1.ToShortDateString(),
                        GameOneHome = teamsIn1stGame.HomeTeam == teamName ? yesAnswer : "No",
                        GameTwoHome = teamsIn2ndGame.HomeTeam == teamName ? yesAnswer : "No",
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

    #region Containers
    public struct TeamsByPlayDate
    {
        public List<string> LstTeamNames;
        public DateTime PlayDate { get; set; }
    }

    public struct ScheduleByDate
    {
        public DateTime Date { get; set; }
        public string AwayTeam { get; set; }
        public string HomeTeam { get; set; }
        public string Final { get; set; }
    }

    public struct PlayedB2B
    {
        public string TeamName { get; set; }
        public DateTime PlayDate1 { get; set; }
        public DateTime PlayDate2 { get; set; }
        public string FinalGame1 { get; set; }
        public string FinalGame2 { get; set; }
    }
    #endregion
}
