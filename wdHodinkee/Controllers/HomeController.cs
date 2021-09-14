using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wdHodinkee.Models;

namespace wdHodinkee.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Local()
        {
            return View();
        }

        public IActionResult Remote()
        {
            return View();
        }

        public IActionResult RemotePlus()
        {
            return View();
        }

        public PartialViewResult _New()
        {
            return PartialView("_New");
        }

        public PartialViewResult _Edit()
        {
            return PartialView("_Edit");
        }

        public IActionResult SetViewData(string value)
        {
            VariableGlobal.Data = value;
            return new EmptyResult();
        }

        public IActionResult ContentArticle()
        {
            return View();
        }

        public IActionResult Article()
        {
            article data = new article();
            if (VariableGlobal.Data != null)
            {
                data = Newtonsoft.Json.JsonConvert.DeserializeObject<article>(VariableGlobal.Data);
            }
            return View(data);
        }


    }
}
