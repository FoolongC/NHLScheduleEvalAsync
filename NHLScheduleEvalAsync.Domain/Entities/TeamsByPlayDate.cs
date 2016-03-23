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
    public struct TeamsByPlayDate
    {
        public List<string> LstTeamNames;
        public DateTime PlayDate { get; set; }
    }
}
