using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.DataAccessLayer.Context;
using MilkyProject.DataAccessLayer.Repositories;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DataAccessLayer.EntityFramework
{
    public class EfTeamSocialMediaDal : GenericRepository<TeamSocialMedia>, ITeamSocialMediaDal
    {
        public EfTeamSocialMediaDal(MilkyContext context) : base(context)
        {
        }
    }
}
