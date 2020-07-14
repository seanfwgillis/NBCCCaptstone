using Model;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.AdminSupportSystem.Models
{
    public class PersonalReviewVM
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(10000000, 99999999, ErrorMessage = "Employee ID must be exactly 8 digits")]
        public int EmployeeId { get; set; }
        [Required]
        [Range(10000000, 99999999, ErrorMessage = "Supervisor ID must be exactly 8 digits")]
        public int SupervisorId { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime Date { get; set; }
        [Required]
        public ReviewRatingType Rating { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }

        [Display(Name = "Reviewed By")]
        public string SupervisorName { get; set; }

    }
}