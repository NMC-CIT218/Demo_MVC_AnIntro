using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_MVC_AnIntro.Controllers
{
    public class AdderController : Controller
    {
        // GET: Adder
        public string Index(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }
    }
}