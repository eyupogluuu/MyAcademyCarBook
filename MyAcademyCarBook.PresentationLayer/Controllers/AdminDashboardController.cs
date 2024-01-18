using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class AdminDashboardController : Controller
    {
        private readonly ICarService _carService;
        private readonly CarBookContext _context;

        public AdminDashboardController(ICarService carService, CarBookContext context)
        {
            _carService = carService;
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _carService.TGetAllCarsWithBrands();
            ViewBag.count = _context.cars.Count();
            var value = _context.prices.Max(x => x.priceValue);
            ViewBag.maxprice = _context.prices.Max(x => x.priceValue);
            ViewBag.testimonials = _context.testimonials.Count();
            ViewBag.avg = _context.prices.Average(x => x.priceValue);
            ViewBag.brand = _context.brands.Count();
            return View(values);
        }
    }
}
