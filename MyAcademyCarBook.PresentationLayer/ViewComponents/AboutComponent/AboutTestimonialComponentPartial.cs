using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.AboutComponent
{
    public class AboutTestimonialComponentPartial:ViewComponent
    {
        private readonly ITestimonialService testimonialService;

        public AboutTestimonialComponentPartial(ITestimonialService testimonialService)
        {
            this.testimonialService = testimonialService;
        }
        public IViewComponentResult Invoke()
        {
            var values = testimonialService.TGetListAll();
            return View(values);
        }
    }
}
