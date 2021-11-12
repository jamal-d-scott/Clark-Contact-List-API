using Microsoft.AspNetCore.Mvc;

namespace ClarkCodingChallenge.Controllers
{
    public class SuccessController : Controller
    {
        /// <summary>
        /// Redirects the user to a success page.
        /// </summary>
        /// <returns>The Success View</returns>
        public IActionResult SubmitSuccessful()
        {
            return View("Success");
        }
    }
}
