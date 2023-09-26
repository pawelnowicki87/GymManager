using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace GymManager.MVC.Controllers
{
    public class ClientController : BaseController
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Client()
        {
            return View();
        }
    }
}
