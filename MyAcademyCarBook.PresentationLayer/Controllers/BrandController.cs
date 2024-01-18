using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult brandList()
        {
            var values =_brandService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public ActionResult brandAdd()
        {

            return View();
        }
        [HttpPost]
        public ActionResult brandAdd(Brand brand)
        {
            _brandService.TInsert(brand);
            return RedirectToAction("brandList");
        }
        public ActionResult brandDelete(int id) 
        {
            var value=_brandService.TGetByID(id);
            _brandService.TDelete(value);
            return RedirectToAction("brandList");
        }
        [HttpGet]
        public ActionResult brandUpdate(int id) 
        {
            var value = _brandService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
		public IActionResult brandUpdate(Brand brand)
		{
			_brandService.TUpdate(brand);
			return RedirectToAction("brandList");
		}

        public IActionResult GetBrandSerachByName(string name)
        {
            ViewData["CurrentFilter"] = name;
            var values = from x in _brandService.TGetListAll() select x;
            if (!string.IsNullOrEmpty(name))
            {
                values = values.Where(y => y.brandName.Contains(name));// name parametresinden gelen ifadeyi içeren değerleri listele
            }
            return View();
        }
	}
}
