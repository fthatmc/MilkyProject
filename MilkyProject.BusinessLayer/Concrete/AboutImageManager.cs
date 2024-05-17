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
    public class AboutImageManager : IAboutImageService
    {
        private readonly IAboutImageDal _aboutImageDal;

        public AboutImageManager(IAboutImageDal aboutImageDal)
        {
            _aboutImageDal = aboutImageDal;
        }

        public void TDelete(int id)
        {
            _aboutImageDal.Delete(id);
        }

        public AboutImage TGetById(int id)
        {
           return _aboutImageDal.GetById(id);
        }

        public List<AboutImage> TGetListAll()
        {
            return _aboutImageDal.GetListAll();
        }

        public void TInsert(AboutImage entity)
        {
            _aboutImageDal.Insert(entity);
        }

        public void TUpdate(AboutImage entity)
        {
            _aboutImageDal.Update(entity);
        }
    }
}
