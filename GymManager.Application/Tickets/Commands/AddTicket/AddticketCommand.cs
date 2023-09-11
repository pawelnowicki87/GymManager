using MediatR;


namespace GymManager.Application.Tickets.Commands.AddTicket
{
    public class AddticketCommand : IRequest
    {
        public string Name { get; set; }
    }
}
