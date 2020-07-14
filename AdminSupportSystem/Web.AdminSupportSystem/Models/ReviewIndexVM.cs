using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.AdminSupportSystem.Models
{
    public class ReviewIndexVM
    {
        public int EmployeeId { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Job Title")]
        public string JobName { get; set; }

        public bool HasReviewPending { get; set; }
    }
}