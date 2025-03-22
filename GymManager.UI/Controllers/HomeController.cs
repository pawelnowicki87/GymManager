using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GymManager.UI.Models;
using MediatR;
using GymManager.Application.Tickets.Queries.GetTicketById;
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

        await Mediator.Send(new AddTicketCommand { Name = "Próba obs³ugi requestów z kontrolera nowy command"});

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
