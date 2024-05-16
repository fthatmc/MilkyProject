using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.EntityLayer.Concrete
{
    public class OpenHours
    {
        public int OpenHoursId { get; set; }
        public string MidWeek { get; set; }
        public string Weekend { get; set; }
        public string ClosedDay { get; set; }
    }
}
