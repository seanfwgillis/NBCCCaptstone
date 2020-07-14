using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Purchase : BaseEntity
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "PO Number")]
        public string PONumber { get; set; }

        [Display(Name = "Employee Id")]
        public int EmployeeId { get; set; }

        [Display(Name = "Supervisor")]
        public int Supervisor { get; set; }
     
        [Display(Name = "Approval Status")]
        public ApprovalStatus ApprovalStatus { get; set; }
   
        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }

      
        [Display(Name = "Subtotal")]
        public Decimal Subtotal { get; set; }
   
        [Display(Name = "Tax")]
        public Decimal Tax { get; set; }
   
        [Display(Name = "Grand Total")]
        public Decimal GrandTotal { get; set; }

        [Display(Name = "Modification Date")]
        public DateTime ModificationDate { get; set; }
  
        [Display(Name = "Modification Reason")]
        public String ModificationReason { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
