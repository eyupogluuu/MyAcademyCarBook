using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.AboutComponent
{
    public class AboutComponentPartial:ViewComponent
    {
        private readonly IAboutService aboutService;

        public AboutComponentPartial(IAboutService aboutService)
        {
            this.aboutService = aboutService;
        }
        public IViewComponentResult Invoke()
        {
            var values = aboutService.TGetListAll();
            return View(values);
        }
    }
}
