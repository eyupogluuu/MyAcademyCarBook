using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;
using System.Security.Cryptography.Pkcs;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class CommunucationInfoController : Controller
    {
        private readonly ICommunucationInfoService _communucationInfo;

        public CommunucationInfoController(ICommunucationInfoService communucationInfo)
        {
            _communucationInfo = communucationInfo;
        }

        public IActionResult Index()
        {
            var values = _communucationInfo.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateContactInfo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateContactInfo(CommunucationInfo contactInfo)
        {
            _communucationInfo.TInsert(contactInfo);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteContactInfo(int id)
        {
            var value = _communucationInfo.TGetByID(id);
            _communucationInfo.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateContactInfo(int id)
        {
            var value = _communucationInfo.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateContactInfo(CommunucationInfo model)
        {
            _communucationInfo.TUpdate(model);
            return RedirectToAction("Index");
        }
    }
}
