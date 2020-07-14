using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class BaseEntity
    {
        public List<ValidationError> ValErrors { get; set; } = new List<ValidationError>();

        public string SingleError { get; set; }

        public void AddError(ValidationError error)
        {
            ValErrors.Add(error);
        }
    }
}
