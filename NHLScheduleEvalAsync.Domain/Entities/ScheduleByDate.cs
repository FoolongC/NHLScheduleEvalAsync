using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLScheduleEval.Domain.Entities
{
    /// <summary>
    /// Container for repository
    /// </summary>
    public struct ScheduleByDate
    {
        public DateTime Date { get; set; }
        public string AwayTeam { get; set; }
        public string HomeTeam { get; set; }
        public string Final { get; set; }
    }
}
