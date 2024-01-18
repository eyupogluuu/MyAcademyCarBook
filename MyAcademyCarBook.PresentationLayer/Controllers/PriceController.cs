using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
	public class PriceController : Controller
	{
		private readonly IPriceService _priceService;
		private readonly ICarService _carService;

        public PriceController(IPriceService priceService, ICarService carService)
        {
            _priceService = priceService;
            _carService = carService;
        }

        public IActionResult priceList()
		{
			var values=_priceService.TGetPricesWithCars();
			return View(values);
		}

		[HttpGet]
		public IActionResult priceAdd()
		{
			List<SelectListItem> values = (from x in _carService.TGetAllCarsWithBrands()
										   select new SelectListItem
										   {
											   Text = x.brand.brandName + " " + x.model,
											   Value = x.carID.ToString()
										   }).ToList();
			ViewBag.v = values;
			return View();
		}

		[HttpPost]
		public IActionResult priceAdd(Price price)
		{
			_priceService.TInsert(price);
			return RedirectToAction("priceList");
		}
		public IActionResult priceDelete(int id)
		{
			var values=_priceService.TGetByID(id);
			_priceService.TDelete(values);
			return RedirectToAction("priceList");
		}
		public IActionResult priceUpdate(int id)
		{
            List<SelectListItem> values = (from x in _carService.TGetAllCarsWithBrands()
                                           select new SelectListItem
                                           {
                                               Text = x.brand.brandName + " " + x.model,
                                               Value = x.carID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = _priceService.TGetByID(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult priceUpdate(Price price)
		{
			_priceService.TUpdate(price);
			return RedirectToAction("priceList");
		}
	}
}
