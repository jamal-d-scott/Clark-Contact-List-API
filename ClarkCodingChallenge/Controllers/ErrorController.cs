using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClarkCodingChallenge.Controllers
{
    public class ErrorController : Controller
    {
        /// <summary>
        /// Redirects the user to an error page.
        /// </summary>
        /// <returns>The Error View</returns>
        public IActionResult ShowErrorPage()
        {
            return View("Error");
        }
    }
}
