using FluentValidation;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.BusinessLayer.ValidationRules.ServiceValidation
{
	public class CreateServiceValidator:AbstractValidator<Service>
	{
		public CreateServiceValidator() 
		{
			RuleFor(x => x.tittle).NotEmpty().WithMessage("Başlık Boş Geçilemez");
			RuleFor(x => x.descreption).NotEmpty().WithMessage("Açıklama Boş Geçilemez");
			RuleFor(x => x.icon).NotEmpty().WithMessage("İcon Boş Geçilemez");
			RuleFor(x => x.tittle).MinimumLength(3).WithMessage("3 karakterden az veri girişi yapılamaz");
			RuleFor(x => x.tittle).MaximumLength(30).WithMessage("30 karakterden fazla veri girişi yapılamaz");
			RuleFor(x => x.descreption).MinimumLength(10).WithMessage("10 karakterden az veri girişi yapılamaz");
			RuleFor(x => x.descreption).MaximumLength(230).WithMessage("230 karakterden fazla veri girişi yapılamaz");
		}
	}
}
