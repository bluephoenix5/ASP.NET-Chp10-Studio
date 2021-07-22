using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    //[Route("/home")]
    public class SkillsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("skills/")]
        public IActionResult Skills()
        {
            string html = "<h1>Skills Tracker</h1>" + "<h2>Programming Languages and Progess</h2>" + "<ol><li>C#</li><li>Java</li><li>Python</li></ol>";

            return Content(html, "text/html");
        }

        [HttpGet("skills/form")]
        public IActionResult DateAndProgress()
        {
            string html = "<form method='post' action='/skills/form'>" +
                "<label for='start'>Date:</label> " +
                "<input type='date' id='start' name='startdate' value='2021-07-22' min='' max=''/> " +
                "<label for='language'>C#:</label>" +
                "<select name='progress1' id='progress1'> <option value='Learning basics'>Learning basics</option> <option value='Making apps'>Making apps</option> <option value='Master coder'>Master coder</option> </select>" +
                "<label for='language'>Java:</label>" +
                "<select name='progress2' id='progress2'> <option value='Learning basics'>Learning basics</option> <option value='Making apps'>Making apps</option> <option value='Master coder'>Master coder</option> </select>" +
                "<label for='language'>Python:</label>" +
                "<select name='progress3' id='progress3'> <option value='Learning basics'>Learning basics</option> <option value='Making apps'>Making apps</option> <option value='Master coder'>Master coder</option> </select>" +
                "<input type='submit' value='Submit'/>" +
                "</form>";

            return Content(html, "text/html");
        }

        [HttpPost("/skills/form")]
        public IActionResult Results(string startdate, string progress1, string progress2, string progress3)
        {
            string html = $"<h1>{startdate}</h1>" + $"<ol><li>C#: {progress1}</li>" + $"<li>Java: {progress2}</li>" + $"<li>Python: {progress3}</li></ol>";

            //return Content(startdate + progress1 + progress2 + progress3);
            return Content(html, "text/html");
        }
    }
}
