using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.CarDetailComponent
{
    public class CarDetailCategoryPartial:ViewComponent
    {
        private readonly ICarCategoryService _carCategoryService;

        public CarDetailCategoryPartial(ICarCategoryService carCategoryService)
        {
            _carCategoryService = carCategoryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _carCategoryService.TGetListAll();
            return View(values);
        }
    }
}
