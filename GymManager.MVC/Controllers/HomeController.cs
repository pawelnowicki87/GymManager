using GymManager.Application.Tickets.Commands.AddTicket;
using GymManager.Application.Tickets.Queries.GetTicketById;
using GymManager.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GymManager.MVC.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}