using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.BusinessLayer.ValidationRules.ServiceValidation;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
	public class ServiceController : Controller
	{
		private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult serviceList()
		{
            ViewBag.title1 = "Servis Listesi";
            ViewBag.title2 = "Sizler için Servislerimiz";
            return View();
        }

		public IActionResult serviceList2()
		{
			var values = _serviceService.TGetListAll();
			return View(values);
		}

		[HttpGet]
		public IActionResult addService()
		{
			return View();
		}

        [HttpPost]
        public IActionResult addService(Service s)
        {
			CreateServiceValidator validationRules= new CreateServiceValidator();
			ValidationResult result= validationRules.Validate(s);
			if (result.IsValid)
			{
                _serviceService.TInsert(s);

				return RedirectToAction("serviceList");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View(); 
			}
			
        }
        public IActionResult DeleteService(int id)
        {
            var value = _serviceService.TGetByID(id);
            _serviceService.TDelete(value);
            return RedirectToAction("ServiceList");
        }
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var value = _serviceService.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return RedirectToAction("ServiceList");
        }
    }
}
