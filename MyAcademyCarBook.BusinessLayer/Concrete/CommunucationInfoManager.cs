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
    public class CommunucationInfoManager : ICommunucationInfoService
    {
        private readonly ICommunucationInfoDal _communucationInfoDal;

        public CommunucationInfoManager(ICommunucationInfoDal communucationInfoDal)
        {
            _communucationInfoDal = communucationInfoDal;
        }

        public void TDelete(CommunucationInfo entity)
        {
           _communucationInfoDal.Delete(entity);
        }

        public CommunucationInfo TGetByID(int id)
        {
            return _communucationInfoDal.GetByID(id);
        }

        public List<CommunucationInfo> TGetListAll()
        {
            return _communucationInfoDal.GetListAll();
        }

        public void TInsert(CommunucationInfo entity)
        {
            _communucationInfoDal.Insert(entity);
        }

        public void TUpdate(CommunucationInfo entity)
        {
            _communucationInfoDal.Update(entity);
        }
    }
}
