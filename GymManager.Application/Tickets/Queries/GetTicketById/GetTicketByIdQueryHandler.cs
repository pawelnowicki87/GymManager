using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GymManager.Application.Tickets.Queries.GetTicketById
{
    public class GetTicketByIdQueryHandler : IRequestHandler<GetTicketByIdQuery, TicketDto>
    {
        private readonly ILogger _logger;

        public GetTicketByIdQueryHandler(ILogger<GetTicketByIdQueryHandler> logger)
        {
            _logger = logger;
        }
        public async Task<TicketDto> Handle(GetTicketByIdQuery request, CancellationToken cancellationToken)
        {

            _logger.LogInformation("CommandTicket Handler");
            //pobieranie danych z bazy danych
            return new TicketDto { Id = request.Id, Name = "Próbny ticket" };
        }
    }
}
