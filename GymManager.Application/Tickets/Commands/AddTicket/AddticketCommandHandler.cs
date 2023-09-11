using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Application.Tickets.Commands.AddTicket
{
    public class AddticketCommandHandler : IRequestHandler<AddticketCommand>
    {
        public async Task<Unit> Handle(AddticketCommand request, CancellationToken cancellationToken)
        {
            return Unit.Value;

        }
    }
}
