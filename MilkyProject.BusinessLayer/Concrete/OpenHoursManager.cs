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
    public class OpenHoursManager : IOpenHoursService
    {
        private readonly IOpenHoursDal _openHoursDal;

        public OpenHoursManager(IOpenHoursDal openHoursDal)
        {
            _openHoursDal = openHoursDal;
        }

        public void TDelete(int id)
        {
            _openHoursDal.Delete(id);
        }

        public OpenHours TGetById(int id)
        {
            return _openHoursDal.GetById(id);
        }

        public List<OpenHours> TGetListAll()
        {
            return _openHoursDal.GetListAll();
        }

        public void TInsert(OpenHours entity)
        {
            _openHoursDal.Insert(entity);
        }

        public void TUpdate(OpenHours entity)
        {
            _openHoursDal.Update(entity);
        }
    }
}
