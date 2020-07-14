using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EmployeeLookup
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class DepartmentLookup
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class SupervisorLookup
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class JobLookup
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class DepartmentLookupBySupId
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
