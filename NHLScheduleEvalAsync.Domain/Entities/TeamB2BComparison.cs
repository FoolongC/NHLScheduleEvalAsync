﻿using NHLScheduleEval.Domain.Concrete;
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
        public int Count { get; set; }
    }
}
