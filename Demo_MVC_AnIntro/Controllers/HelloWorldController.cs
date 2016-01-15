using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_MVC_AnIntro.Controllers
{

    public class HelloWorldController : Controller
    {
        private string[] names = new string[] { "John", "Jeff" };

        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        public string Welcome(string name = "bozo", int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + names[ID] + ", ID is: " + ID);
        }
    }
}