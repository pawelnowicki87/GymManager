using MediatR;
using System.ComponentModel.DataAnnotations;

namespace GymManager.Application.Contacts.Commands.SendContactEmail
{
    public class SendContactEmailCommand : IRequest
    {
        [Required(ErrorMessage ="Pole imię i nazwisko jest wymagane")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pole Email jest wymagane")]
        [EmailAddress(ErrorMessage = "Pole 'E-Email' nie jest prawidłowym adresem e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Pole Tytuł jest wymagane")]
        public string  Title { get; set; }

        [Required(ErrorMessage = "Pole wiadomość jest wymagane")]
        public string Message { get; set; }
        public string AntySpamResult { get; set; }
    }
}
