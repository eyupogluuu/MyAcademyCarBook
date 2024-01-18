using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class AdminCarDetailController : Controller
    {
        private readonly ICarDetailService _carDetailService;

        public AdminCarDetailController(ICarDetailService carDetailService)
        {
            _carDetailService = carDetailService;
        }

        public IActionResult Index()
        {
            var values = _carDetailService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult addCarDetail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addCarDetail(CarDetail carDetail)
        {
            _carDetailService.TInsert(carDetail);
            return RedirectToAction("Index");
        }

        public IActionResult deleteCarDetail(int id)
        {
            _carDetailService.TDelete(_carDetailService.TGetCarDetailByCarID(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult updateCarDetail(int id)
        {
            var value = _carDetailService.TGetCarDetailByCarID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult updateCarDetail(CarDetail carDetail)
        {
            _carDetailService.TUpdate(carDetail);
            return RedirectToAction("Index");
        }
    }
}
