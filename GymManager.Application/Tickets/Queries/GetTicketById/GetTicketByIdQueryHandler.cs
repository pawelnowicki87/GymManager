﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Application.Tickets.Queries.GetTicketById;

class GetTicketByIdQueryHandler : IRequestHandler<GetTicketByIdQuery, TicketDto>
{
    public async Task<TicketDto> Handle(GetTicketByIdQuery request, CancellationToken cancellationToken)
    {
        var id = request.Id;

        //pobieranie danych z bazy danych
        return new TicketDto { Id = request.Id, Name = "`Temp Name Dto from handler" };

    }
}

