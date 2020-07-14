using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EmployeeForAndroid
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string WorkNumber { get; set; }
        public string Department { get; set; }
        public bool IsSupervisor { get; set; }
        public string EmailAddress { get; set; }
    }
}
