using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DtoLayer.LocationDtos
{
    public class ResultLocationDto
    {
        public int LocationId { get; set; }
        public string Address { get; set; }
        public string Call { get; set; }
        public string Email { get; set; }
    }
}
