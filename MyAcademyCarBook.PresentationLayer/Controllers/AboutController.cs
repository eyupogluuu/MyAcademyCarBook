using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var values = _aboutService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult deleteAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            _aboutService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult addAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addAbout(About about)
        {
            _aboutService.TInsert(about);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult updateAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult updateAbout(About about)
        {
            _aboutService.TUpdate(about);
            return RedirectToAction("Index");
        }

        public IActionResult UIAbout()
        {
            ViewBag.title1 = "Hakkımızda ";
            ViewBag.title2 = "Hakkımızda Merak Ettikleriniz";
            return View();
        }
		
	}
}
