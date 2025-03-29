using Microsoft.AspNetCore.Mvc;
using GymManager.Application.Tickets.Commands.AddTicket;

namespace GymManager.UI.Controllers;

public class HomeController : BaseController
{
    private readonly ILogger _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {

        await Mediator.Send(new AddTicketCommand { Name = "Pr�ba obs�ugi request�w z kontrolera nowy command"});

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }
}
