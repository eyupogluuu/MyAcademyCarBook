using Microsoft.EntityFrameworkCore;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;
using MyAcademyCarBook.DataAccessLayer.Repositories;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.DataAccessLayer.EntityFramework
{
	public class EFCarDetailDal:GenericRepository<CarDetail>,ICarDetailDal
	{
        public CarDetail GetCarDetailByCarID(int id)
        {
            var context = new CarBookContext();
            var values = context.carDetails.Where(x => x.carID == id).FirstOrDefault();
            return values;
        }

        public CarDetail GetCarDetailWithAuthor(int id)
        {
            var context = new CarBookContext();
            var values = context.carDetails.Include(x => x.appuser).Where(y => y.carID == id).FirstOrDefault();
            return values;
        }
    }
}
