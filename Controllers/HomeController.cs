using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WordAPP.Models;

namespace WordAPP.Controllers
{
    public class HomeController : Controller
    {
        private IWordService service;
        public HomeController(IWordService _service)
        {
            service = _service;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpPost]
        public ActionResult Index(WordService model)
        {
            return View();
        }
        [Route("wordvalue/{value:double}/")]
        public string WordValue(double value)
        {
            return service.NumWordsWrapper(value);
        }       
    }
}
