using Model.Entities.Unique;
using Repository.Unique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Unique
{
    public class POEmployeeService
    {
        public List<POEmployee> GetPurchaseOrderDetailsByID(int Id)
        {
            POEmployeeRepo repo = new POEmployeeRepo();
            return repo.GetPODById(Id);
        }
        public List<POEmployee> GetPurchaseOrderDetailsByDate(DateTime start, DateTime end)
        {
            POEmployeeRepo repo = new POEmployeeRepo();
            return repo.GetPODByDate(start, end);
        }
    }
}
