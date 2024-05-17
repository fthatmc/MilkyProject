using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinessLayer.Concrete
{
    public class AboutServiceManager : IAboutServiceService
    {
        private readonly IAboutServiceDal _aboutServiceDal;

        public AboutServiceManager(IAboutServiceDal aboutServiceDal)
        {
            _aboutServiceDal = aboutServiceDal;
        }

        public void TDelete(int id)
        {
            _aboutServiceDal.Delete(id);
        }

        public AboutService TGetById(int id)
        {
            return _aboutServiceDal.GetById(id);
        }

        public List<AboutService> TGetListAll()
        {
             return _aboutServiceDal.GetListAll();
        }

        public void TInsert(AboutService entity)
        {
            _aboutServiceDal.Insert(entity);
        }

        public void TUpdate(AboutService entity)
        {
            _aboutServiceDal.Update(entity);
        }
    }
}
