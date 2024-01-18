using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.BusinessLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.ServiceComponent
{
	public class howıtworkPartial:ViewComponent
	{
		private readonly IHowItWorkService _howItWorkService;

		public howıtworkPartial(IHowItWorkService howItWorkService)
		{
			_howItWorkService = howItWorkService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _howItWorkService.TGetListAll();
			return View(values);
		}
	}
}
