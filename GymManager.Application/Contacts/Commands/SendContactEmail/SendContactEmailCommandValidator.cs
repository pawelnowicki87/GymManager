using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Application.Contacts.Commands.SendContactEmail
{
    public class SendContactEmailCommandValidator : AbstractValidator<SendContactEmailCommand>
    {
        //public SendContactEmailCommandValidator()
        //{
        //    RuleFor(x => x.Name)
        //        .NotEmpty().WithMessage("Pole Imie i Nazwisko jest wymagane");
        //}
    }
}
