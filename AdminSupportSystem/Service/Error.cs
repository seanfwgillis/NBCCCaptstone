using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Error
    {
        public string Description { get; set; }
        public Error(string description)
        {
            Description = description;
        }
    }
}
