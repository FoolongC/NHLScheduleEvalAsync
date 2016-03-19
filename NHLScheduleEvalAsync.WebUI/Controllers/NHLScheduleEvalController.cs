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
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult TeamGrid(string teamName)
        {
            ITeamB2BComparisonRepository repository = new GameB2BComparisonRepository();
            return PartialView("_TeamPartialView", repository.GetB2BComparisonByTeamID(teamName));  
        }
    }
}