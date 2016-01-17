using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Demo_MVC_AnIntro.D2.Controllers
{
    public class CalculatorController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "The Calculator";
            ViewData["Title"] = "The Calculator";

            return View();
        }

        public ActionResult Calculate(string operation, double num1, double num2)
        {
            double result;
            string resultMessage;
            string operationUpper;

            operationUpper = operation.ToUpper();

            //
            // perform calculation and build out result message
            //
            switch (operationUpper)
            {
                case ("ADD"):
                    result = num1 + num2;
                    resultMessage = String.Format("The sum of {0} and {1} is {2}.", num1, num2, result);
                    break;
                case ("SUBTRACT"):
                    result = num1 - num2;
                    resultMessage = String.Format("The difference of {0} and {1} is {2}.", num1, num2, result);
                    break;
                case ("MULTIPLY"):
                    result = num1 * num2;
                    resultMessage = String.Format("The product of {0} and {1} is {2}.", num1, num2, result);
                    break;
                case ("DIVIDE"):
                    result = num1 / num2;
                    resultMessage = String.Format("The quotient of {0} and {1} is {2}.", num1, num2, result.ToString("#.##"));
                    break;
                default:
                    result = 0;
                    resultMessage = String.Format("There was an error in the operation choice. \"{0}\" is not a valid operation.", operation);
                    break;
            }

            //
            // set ViewBag properties
            //
            ViewBag.ResultMessage = resultMessage;

            return View();
        }
    }
}