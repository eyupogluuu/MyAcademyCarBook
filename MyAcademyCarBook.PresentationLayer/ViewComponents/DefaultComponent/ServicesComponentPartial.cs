using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.DefaultComponent
{
    public class ServicesComponentPartial:ViewComponent
    {
        private readonly IServiceService _serviceService;

        public ServicesComponentPartial(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _serviceService.TGetListAll().Take(3).ToList();
            return View(values);
        }
    }
}
