using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class CarStatusController : Controller
    {
        private readonly ICarStatusService _carStatusService;

        public CarStatusController(ICarStatusService carStatusService)
        {
            _carStatusService = carStatusService;
        }

        public IActionResult carStatusList()
        {
            var values = _carStatusService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public ActionResult carStatusAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult carStatusAdd(CarStatus carStatus)
        {
            _carStatusService.TInsert(carStatus);
            return RedirectToAction("carStatusList");
        }

        public ActionResult carStatusDelete(int id)
        {
            var values = _carStatusService.TGetByID(id);
            _carStatusService.TDelete(values);
            return RedirectToAction("carStatusList");
        }
        
        [HttpGet]
        public IActionResult carStatusUpdate(int id)
        {
            var values = _carStatusService.TGetByID(id);
            return View (values);
        }

        [HttpPost]
        public IActionResult carStatusUpdate(CarStatus carStatus)
        {
            _carStatusService.TUpdate(carStatus);
            return RedirectToAction("carStatusList");
        }
    }
}
