using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DtoLayer.OpenHoursDtos
{
    public class UpdateOpenHoursDto
    {
        public int OpenHoursId { get; set; }
        public string MidWeek { get; set; }
        public string Weekend { get; set; }
        public string ClosedDay { get; set; }
    }
}
