using Microsoft.AspNetCore.Mvc;

namespace EasyCash.PresentationLayer.ViewComponets.Customer
{
    public class _CustomerLayoutHeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
