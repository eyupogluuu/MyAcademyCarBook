using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.CommunucationInfoComponent
{
    public class CommunucationPartailComponent:ViewComponent
    {
        private readonly ICommunucationInfoService communucationInfoService;

        public CommunucationPartailComponent(ICommunucationInfoService communucationInfoService)
        {
            this.communucationInfoService = communucationInfoService;
        }
        public IViewComponentResult Invoke()
        {
            var values = communucationInfoService.TGetListAll();
            return View(values);
        }
    }
}
