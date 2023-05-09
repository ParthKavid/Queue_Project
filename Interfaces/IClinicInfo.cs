using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Project.Interfaces
{
    public interface IClinicInfo
    {
        string ClinicName { get; set; }
        string StartTime { get; set; }
        string EndTime { get; set; }
        string ClinicAddress { get; set; }
    }
}
