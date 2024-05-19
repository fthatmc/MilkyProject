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
    public class TeamSocialMediaManager : ITeamSocialMediaService
    {
        private readonly ITeamSocialMediaDal _teamSocialMediaDal;

        public TeamSocialMediaManager(ITeamSocialMediaDal teamSocialMediaDal)
        {
            _teamSocialMediaDal = teamSocialMediaDal;
        }

        public void TDelete(int id)
        {
            _teamSocialMediaDal.Delete(id);
        }

        public TeamSocialMedia TGetById(int id)
        {
            return _teamSocialMediaDal.GetById(id);
        }

        public List<TeamSocialMedia> TGetListAll()
        {
            return _teamSocialMediaDal.GetListAll();
        }

        public List<TeamSocialMedia> TGetTeamSocialMediaByTeamId(int id)
        {
            return _teamSocialMediaDal.GetTeamSocialMediaByTeamId(id);
        }

        public void TInsert(TeamSocialMedia entity)
        {
            _teamSocialMediaDal.Insert(entity);
        }

        public void TUpdate(TeamSocialMedia entity)
        {
            _teamSocialMediaDal.Update(entity);
        }
    }
}
