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
        private readonly MilkyContext _context;
        public EfTeamSocialMediaDal(MilkyContext context) : base(context)
        {
            _context = context;
        }

        public List<TeamSocialMedia> GetTeamSocialMediaByTeamId(int id)
        {
            var values = _context.TeamSocialMedias.Where(x => x.TeamId == id).ToList();
            return values;
        }
    }
}
