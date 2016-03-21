using NHLScheduleEval.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLScheduleEval.Domain.Abstract
{
    /// <summary>
    /// Repository interface for back to back game comparisons by team
    /// </summary>
    public interface ITeamB2BComparisonRepository
    {
        IEnumerable<TeamB2BComparison> GetB2BComparisonByTeamID(string teamName);
        IEnumerable<TeamB2BComparison> TeamB2BComparisons { get; }
    }
}
