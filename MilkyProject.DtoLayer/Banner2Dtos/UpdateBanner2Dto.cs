﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DtoLayer.Banner2Dtos
{
    public class UpdateBanner2Dto
    {
        public int Banner2Id { get; set; }
        public string BigImageUrl { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
