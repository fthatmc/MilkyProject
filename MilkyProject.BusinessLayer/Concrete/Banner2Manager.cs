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
    public class Banner2Manager : IBanner2Service
    {
        private readonly IBanner2Dal _banner2Dal;

        public Banner2Manager(IBanner2Dal banner2Dal)
        {
            _banner2Dal = banner2Dal;
        }

        public void TDelete(int id)
        {
            _banner2Dal.Delete(id);
        }

        public Banner2 TGetById(int id)
        {
            return _banner2Dal.GetById(id);
        }

        public List<Banner2> TGetListAll()
        {
            return _banner2Dal.GetListAll();
        }

        public void TInsert(Banner2 entity)
        {
            _banner2Dal.Insert(entity);
        }

        public void TUpdate(Banner2 entity)
        {
            _banner2Dal.Update(entity);
        }
    }
}
