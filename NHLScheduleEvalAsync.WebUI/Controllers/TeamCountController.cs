using NHLScheduleEval.Domain.Abstract;
using NHLScheduleEval.Domain.Concrete;
using NHLScheduleEval.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NHLScheduleEvalAsync.Api.Controllers
{
    public class TeamCountController : ApiController
    {
        private ITeamB2BComparisonRepository repository;

        public TeamCountController(ITeamB2BComparisonRepository teamRepository)
        {
            repository = new GameB2BComparisonRepository();
        }

        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public IEnumerable<TeamB2BComparison> TeamGridCount()
        {
            return repository.GetB2BComparisonByTeamID(null).OrderByDescending(x => x.Count);
        }

        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public IEnumerable<TeamB2BComparison> TeamGridCount(string id)
        {
            return repository.GetB2BComparisonByTeamID(id).OrderByDescending(x => x.Count);
        }
    }
}