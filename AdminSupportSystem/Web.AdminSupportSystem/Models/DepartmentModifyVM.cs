using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.AdminSupportSystem.Models
{
    public class DepartmentModifyVM
    {
        public int DepartmentId { get; set; }
        public bool? IsSuccessful { get; set; }
        public Department Department { get; set; }
        [Display(Name = "Departments")]
        public List<SelectListItem> Departments { get; set; }

    }
}