using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enums;

namespace Model.Entities
{
    public class Item
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "PO Id")]
        public int POId { get; set; }
        [Display(Name = "Item Status")]
        public ItemStatusType ItemStatus { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }
        [Display(Name = "Location")]
        public string Location { get; set; }
        [Display(Name = "Justification")]
        public string Justification { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Item Total")]
        public decimal ItemTotal { get; set; }

        [Display(Name = "Middle Initial")]
        public string MiddleInitial { get; set; }
    }
}
