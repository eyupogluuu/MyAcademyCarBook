using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;
using X.PagedList;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
	public class CarController : Controller
	{
        private readonly ICarService _carService;
        private readonly ICarDetailService _carDetailService;
        private readonly IBrandService _brandService;
        private readonly ICarCategoryService _carCategoryService;
        private readonly ICarStatusService _carStatusService;

        public CarController(ICarService carService, ICarDetailService carDetailService, IBrandService brandService, ICarCategoryService carCategoryService, ICarStatusService carStatusService)
        {
            _carService = carService;
            _carDetailService = carDetailService;
            _brandService = brandService;
            _carCategoryService = carCategoryService;
            _carStatusService = carStatusService;
        }
        public IActionResult Index()
        {
            var values = _carService.TGetAllCarsWithBrands();
            return View(values);
        }

        public IActionResult Index2()
        {
            var values = _carService.TGetAllCarsWithBrands();
            return View(values);
        }
        public IActionResult carList(int page = 1)
        {
            ViewBag.title1 = "Araba Listesi";
            ViewBag.title2 = "Sizin İçin Araç Listemiz";
            //var values = _carService.TGetAllCarsWithBrands();
            //return View(values).ToPagedList(a,3);
            var result = _carService.TGetAllCarsWithBrands();

            var values = result.ToPagedList(page, 6);
            return View(values);

            //ViewBag.title1 = "Araç Listesi";
            //ViewBag.title2 = "Sizin için araç listesi";

            //var allCars = _carService.TGetAllCarsWithBrands().ToPagedList(page, 4);


            //return View(allCars);
        }

        [HttpGet]
        public IActionResult addCar()
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
            List<SelectListItem> value3 = _carStatusService.TGetListAll()
       .Where(x => x.carStatus != null)
       .Select(x => new SelectListItem
       {
           Text = x.carStatus,
           Value = x.carStatusID.ToString()
       })
       .ToList();

            ViewBag.brand = value1;
            ViewBag.category = value2;
            ViewBag.status = value3;

            return View();
        }
        [HttpPost]
        public IActionResult addCar(Car car)
        {
            _carService.TInsert(car);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult RentCar(int seatCount, string gearType, int brandId, int categoryId)
        {
            var values = _carService.TGetAllCarsWithBrands().Where(x => x.personCount == seatCount && x.gearType == gearType && x.brandID == brandId && x.carcategoryID == categoryId).ToList();

            return View(values);
        }

        public IActionResult carDetail(int id)
        {
            ViewBag.title1 = "Araç Detayı";
            ViewBag.title2 = "Son Araç detayı";
            ViewBag.i = id;
            var value = _carDetailService.TGetCarDetailByCarID(id);
            ViewBag.v = value.descreption;
            return View();
        }

        [HttpGet]
        public IActionResult deleteCar(int id)
        {
            var value = _carService.TGetByID(id);
            _carService.TDelete(value);
            return View();
        }

        [HttpGet]
        public IActionResult updateCar(int id)
        {
            var value = _carService.TGetByID(id);
            List<SelectListItem> categories = _carCategoryService.TGetListAll()
                .Where(x => x.carcategoryName != null)
                .Select(x => new SelectListItem
                {
                    Text = x.carcategoryName,
                    Value = x.carcategoryID.ToString()
                })
                .ToList();

            List<SelectListItem> brands = _brandService.TGetListAll()
                .Where(x => x.brandName != null)
                .Select(x => new SelectListItem
                {
                    Text = x.brandName,
                    Value = x.brandID.ToString()
                })
                .ToList();

            List<SelectListItem> statuses = _carStatusService.TGetListAll()
                .Where(x => x.carStatus != null)
                .Select(x => new SelectListItem
                {
                    Text = x.carStatus,
                    Value = x.carStatusID.ToString()
                })
                .ToList();

            // ViewBag'e bu listeleri ekleyin
            ViewBag.CarCategoryList = categories;
            ViewBag.BrandList = brands;
            ViewBag.CarStatusList = statuses;

            return View(value);
        }
        [HttpPost]
        public IActionResult updateCar(Car car)
        {
            _carService.TUpdate(car);
            return RedirectToAction("Index");
        }

       
      

    }
}
