using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DtoLayer.AboutServiceDtos
{
    public class ResultAboutService
    {
        public int AboutServiceId { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
