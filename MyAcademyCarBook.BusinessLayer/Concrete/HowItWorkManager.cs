using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.BusinessLayer.Concrete
{
	public class HowItWorkManager : IHowItWorkService
	{
		private readonly IHowItWorkDal _howItWorkDal;

		public HowItWorkManager(IHowItWorkDal howItWorkDal)
		{
			_howItWorkDal = howItWorkDal;
		}

		public void TDelete(HowItWork entity)
		{
			_howItWorkDal.Delete(entity);
		}

		public HowItWork TGetByID(int id)
		{
			return _howItWorkDal.GetByID(id);
		}

		public List<HowItWork> TGetListAll()
		{
			return _howItWorkDal.GetListAll();
		}

		public void TInsert(HowItWork entity)
		{
			_howItWorkDal.Insert(entity);
		}

		public void TUpdate(HowItWork entity)
		{
			_howItWorkDal.Update(entity);
		}
	}
}
