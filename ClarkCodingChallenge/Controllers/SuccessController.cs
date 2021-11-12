using Microsoft.AspNetCore.Mvc;

namespace ClarkCodingChallenge.Controllers
{
    public class SuccessController : Controller
    {
        public IActionResult SubmitSuccessful()
        {
            return View("Success");
        }
    }
}
