using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.MVC.Controllers
{
    public class BaseController : Controller
    {

        private ISender _mediator;
        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
    }

}
