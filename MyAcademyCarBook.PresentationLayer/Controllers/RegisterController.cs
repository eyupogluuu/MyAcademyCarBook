using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MyAcademyCarBook.DataAccessLayer.EntityFramework;
using MyAcademyCarBook.EntityLayer.Concrete;
using MyAcademyCarBook.PresentationLayer.Models;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
	public class RegisterController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public RegisterController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public IActionResult registerIndex()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> registerIndex(RegisterViewModel model)//user tablosundan bilerek parametre almadık ki o sınıftan bütün propertyler gelmesin diye
		{
			var appUser = new AppUser()
			{
				name = model.name,
				surname = model.surname,
				Email = model.email,
				UserName = model.name,
			};
			var result=await _userManager.CreateAsync(appUser,model.password);
			if (result.Succeeded)
			{
				return RedirectToAction("Index", "Login");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError("", item.Description);
				}
			}
			return View();
		}

	}
}
