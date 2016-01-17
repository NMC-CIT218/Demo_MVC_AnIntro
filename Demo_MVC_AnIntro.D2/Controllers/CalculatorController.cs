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
        public string Index()
        {
            StringBuilder sb = new StringBuilder();
            string htmlCode;

            sb.Append("<h1 style=\"text-align:center\">Welcome to Our Calculator</h1>");
            sb.Append("</br>");
            sb.Append("<p style=\"text-align:center\">");
            sb.Append("To use the calculator, construct a URL like the example below with an operation ");
            sb.Append("followed by two integers separated with a forward slash.</p>");
            sb.Append("<p style=\"font-weight:bold; color:red; text-align:center\">/calculator/add/35/86</p>");

            htmlCode = sb.ToString();

            return htmlCode;
        }

        public string Add(int num1, int num2)
        {
            string HTMLcode;
            string answer;

            answer = (num1 + num2).ToString();

            HTMLcode = HttpUtility.HtmlEncode(String.Format("The sum of {0} and {1} is {2}.", num1, num2, answer));

            return HTMLcode;
        }

        public string Subract(int num1, int num2)
        {
            string HTMLcode;
            string answer;

            answer = (num1 - num2).ToString();

            HTMLcode = HttpUtility.HtmlEncode(String.Format("The difference of {0} and {1} is {2}.", num1, num2, answer));

            return HTMLcode;
        }

        public string Multiply(int num1, int num2)
        {
            string HTMLcode;
            string answer;

            answer = (num1 * num2).ToString();

            HTMLcode = HttpUtility.HtmlEncode(String.Format("The product of {0} and {1} is {2}.", num1, num2, answer));

            return HTMLcode;
        }

        public string Divide(int num1, int num2)
        {
            string HTMLcode;
            string answer;

            answer = ((double)num1 / num2).ToString("#.##");

            HTMLcode = HttpUtility.HtmlEncode(String.Format("The quotient of {0} divided by {1} is {2}.", num1, num2, answer));

            return HTMLcode;
        }
    }
}