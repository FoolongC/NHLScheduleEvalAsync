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
    public struct PlayedB2B
    {
        public string TeamName { get; set; }
        public DateTime PlayDate1 { get; set; }
        public DateTime PlayDate2 { get; set; }
        public string FinalGame1 { get; set; }
        public string FinalGame2 { get; set; }
    }
}
