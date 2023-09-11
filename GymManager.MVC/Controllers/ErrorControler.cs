using Microsoft.AspNetCore.Mvc;

namespace GymManager.MVC.Controllers
{
    public class ErrorControler : Controller
    {
        [HttpGet("/Error")]
        public IActionResult Index()
        {
            return View("Error");
        }
    }
}
