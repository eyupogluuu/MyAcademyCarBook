using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.EntityFramework;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutdal;

        public AboutManager(IAboutDal aboutdal)
        {
            _aboutdal = aboutdal;
        }

        public void TDelete(About entity)
        {
            _aboutdal.Delete(entity);
        }

        public About TGetByID(int id)
        {
            return _aboutdal.GetByID(id);
        }

        public List<About> TGetListAll()
        {
            return _aboutdal.GetListAll();
        }

        public void TInsert(About entity)
        {
            _aboutdal.Insert(entity);
        }

        public void TUpdate(About entity)
        {
            _aboutdal.Update(entity);
        }
    }
}
