using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHLScheduleEval.Domain.Abstract;
using NHLScheduleEval.Domain.Entities;
using NHLScheduleEval.Domain.Concrete;

namespace NHLScheduleEval.WebUI.Controllers
{
    public class NHLScheduleEvalController : Controller
    {
        private ITeamB2BComparisonRepository repository;

        public NHLScheduleEvalController(ITeamB2BComparisonRepository teamRepository)
        {
            this.repository = teamRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult TeamGridAlpha(string teamName)
        {
            return PartialView("_TeamAlphaPartialView", repository.GetB2BComparisonByTeamID(teamName));  
        }
    }
}