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
    public class BannerManager : IBannerService
    {
        private readonly IBannerDal _bannerDal;

        public BannerManager(IBannerDal bannerDal)
        {
            _bannerDal = bannerDal;
        }

        public void TDelete(int id)
        {
            _bannerDal.Delete(id);
        }

        public Banner TGetById(int id)
        {
            return _bannerDal.GetById(id);
        }

        public List<Banner> TGetListAll()
        {
            return _bannerDal.GetListAll();
        }

        public void TInsert(Banner entity)
        {
            _bannerDal.Insert(entity);
        }

        public void TUpdate(Banner entity)
        {
            _bannerDal.Update(entity);
        }
    }
}
