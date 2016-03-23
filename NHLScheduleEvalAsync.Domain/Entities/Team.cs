using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLScheduleEval.Domain.Entities
{
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
}
