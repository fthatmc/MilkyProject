﻿using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinessLayer.Abstract
{
    public interface ITeamSocialMediaService : IGenericService<TeamSocialMedia>
    {
        List<TeamSocialMedia> TGetTeamSocialMediaByTeamId(int id);
    }
}
