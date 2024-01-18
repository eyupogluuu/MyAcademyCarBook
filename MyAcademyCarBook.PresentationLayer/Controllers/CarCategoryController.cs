using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class CarCategoryController : Controller
    {
        private readonly ICarCategoryService _carCategoryService;

        public CarCategoryController(ICarCategoryService carCategoryService)
        {
            _carCategoryService = carCategoryService;
        }

        public IActionResult Index()
        {
            var values = _carCategoryService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult addCarCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addCarCategory(CarCategory carCate)
        {
            _carCategoryService.TInsert(carCate);
            return RedirectToAction("Index");
        }
        public IActionResult deleteCarCategory(int id)
        {
            var value = _carCategoryService.TGetByID(id);
            _carCategoryService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult updateCarCategory(int id)
        {
            var value = _carCategoryService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult updateCarCategory(CarCategory carCate)
        {
            _carCategoryService.TUpdate(carCate);
            return RedirectToAction("Index");
        }
    }
}
