﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DtoLayer.TeamSocialMediaDtos
{
    public class ResultTeamSocialMediaDtos
    {
        public int TeamSocialMediaId { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int TeamId { get; set; }
    }
}
