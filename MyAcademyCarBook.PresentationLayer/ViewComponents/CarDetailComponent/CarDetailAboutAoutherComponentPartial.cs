using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.CarDetailComponent
{
	public class CarDetailAboutAoutherComponentPartial : ViewComponent
	{
		private readonly ICarDetailService carDetailService;
		public CarDetailAboutAoutherComponentPartial(ICarDetailService carDetailService)
		{
			this.carDetailService = carDetailService;
		}

		public IViewComponentResult Invoke(int id)
		{
			var values = carDetailService.TGetCarDetailWithAuthor(id);
			return View(values);
		}
	}
}
