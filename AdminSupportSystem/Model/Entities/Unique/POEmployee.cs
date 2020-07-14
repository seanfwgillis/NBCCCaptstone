using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Unique
{
    public class POEmployee
    {
        public DateTime CreationDate { get; set; }
        public string PONumber { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }
        public Decimal Subtotal { get; set; }
        public Decimal Tax { get; set; }
        public Decimal GrandTotal { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Department { get; set; }
        public int Supervisor { get; set; }
    }
}
