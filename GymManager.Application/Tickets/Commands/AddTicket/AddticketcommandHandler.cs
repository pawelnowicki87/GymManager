using MediatR;
using Microsoft.Extensions.Logging;

namespace GymManager.Application.Tickets.Commands.AddTicket;

class AddticketcommandHandler : IRequestHandler<AddTicketCommand>
{
    private readonly ILogger _logger;

    public AddticketcommandHandler(ILogger<AddticketcommandHandler> logger)
    {
        _logger = logger;
    }

    public async Task<Unit> Handle(AddTicketCommand request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Add ticker command handler");
        _logger.LogError(new Exception("Error z handlera add ticket"), null);

        return Unit.Value; 
    }
}

