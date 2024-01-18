using Microsoft.AspNetCore.Mvc;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.AboutComponent
{
    public class AboutHistoryComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
			return View();
		}
    }
}
