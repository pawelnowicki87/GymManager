using Microsoft.AspNetCore.Mvc;

namespace GymManager.MVC.Components
{
    public class MainCarouselViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
