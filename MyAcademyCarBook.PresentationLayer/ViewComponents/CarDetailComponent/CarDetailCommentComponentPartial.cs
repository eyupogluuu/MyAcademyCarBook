using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.CarDetailComponent
{
	public class CarDetailCommentComponentPartial:ViewComponent
	{
		private readonly ICommentService _commentService;

        public CarDetailCommentComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
		{
			var values = _commentService.TGetCommentsByCar(id);
			return View(values);
		}
	}
}
