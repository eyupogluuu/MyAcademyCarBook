using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.DefaultComponent
{
    public class FilteretedCarListComponentPartial:ViewComponent
    {
        private readonly ICarService _carService;
        private readonly ICarCategoryService _carCategoryService;
        private readonly IBrandService _brandService;

        public FilteretedCarListComponentPartial(ICarService carService, ICarCategoryService carCategoryService, IBrandService brandService)
        {
            _carService = carService;
            _carCategoryService = carCategoryService;
            _brandService = brandService;
        }

        public IViewComponentResult Invoke()
        {
            List<SelectListItem> value1 = _brandService.TGetListAll()
      .Where(x => x.brandName != null)
      .Select(x => new SelectListItem
      {
          Text = x.brandName,
          Value = x.brandID.ToString()
      })
      .ToList();
            List<SelectListItem> value2 = _carCategoryService.TGetListAll()
        .Where(x => x.carcategoryName != null)
        .Select(x => new SelectListItem
        {
            Text = x.carcategoryName,
            Value = x.carcategoryID.ToString()
        })
        .ToList();
            List<SelectListItem> value3 = _carService.TGetListAll()
       .Select(x => new SelectListItem
       {
           Text = x.gearType,
           Value = x.carID.ToString()
       })
       .ToList();

            ViewBag.brand = value1;
            ViewBag.category = value2;
            ViewBag.geartype = value3;

            return View();
        }


    }
}
