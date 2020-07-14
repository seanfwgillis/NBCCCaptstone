using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ValidationError
    {
        public ValidationError(string errDesc)
        {
            ErrorDescription = errDesc;
        }

        public string ErrorDescription { get; set; }

    }
}
