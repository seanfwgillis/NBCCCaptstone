using Model.Entities;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.AdminSupportSystem.Models
{
    public class ItemVM
    {
        public Item Item { get; set; }

        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "PO ID")]
        public int POId { get; set; }

        [Display(Name = "Item Status")]
        public ItemStatusType ItemStatus { get; set; }

        [Display(Name = "Item Name")]
        [Required(ErrorMessage = "Item Name is required.")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Display(Name = "Unit Price")]
        [Required(ErrorMessage = "Unit Price is required.")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Location")]
        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }

        [Display(Name = "Justification")]
        [Required(ErrorMessage = "Justification is required.")]
        public string Justification { get; set; }

        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Quantity is required.")]
        public int Quantity { get; set; }

        public decimal ItemTotal { get; set; }


    }
}