using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClarkCodingChallenge.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult ShowErrorPage()
        {
            return View("Error");
        }
    }
}
