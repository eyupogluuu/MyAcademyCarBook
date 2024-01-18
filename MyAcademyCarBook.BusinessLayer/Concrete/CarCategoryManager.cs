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
    public class CarCategoryManager : ICarCategoryService
    {
        private readonly ICarCategoryDal _carCatedoryDal;

        public CarCategoryManager(ICarCategoryDal carCatedoryDal)
        {
            _carCatedoryDal = carCatedoryDal;
        }

        public void TDelete(CarCategory entity)
        {
            _carCatedoryDal.Delete(entity);
        }

        public CarCategory TGetByID(int id)
        {
            return _carCatedoryDal.GetByID(id);
        }

        public List<CarCategory> TGetListAll()
        {
            return _carCatedoryDal.GetListAll();
        }

        public void TInsert(CarCategory entity)
        {
           _carCatedoryDal.Insert(entity);
        }

        public void TUpdate(CarCategory entity)
        {
            _carCatedoryDal.Update(entity);
        }
    }
}
