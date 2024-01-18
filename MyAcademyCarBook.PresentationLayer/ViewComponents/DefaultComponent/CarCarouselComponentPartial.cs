using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.DefaultComponent
{
    public class CarCarouselComponentPartial:ViewComponent
    {
        private readonly ICarService _carService;

        public CarCarouselComponentPartial(ICarService carService)
        {
            _carService = carService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _carService.TGetAllCarsWithBrands().Take(5).ToList();
            return View(values);
        }

    }
}
