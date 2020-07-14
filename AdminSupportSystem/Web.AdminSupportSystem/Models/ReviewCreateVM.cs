using Model;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.AdminSupportSystem.Models
{
    public class ReviewCreateVM
    {
        public string EmployeeName { get; set; }
        public string SupervisorName { get; set; }

        public Review Review { get; set; }
        public IEnumerable<SelectListItem> Ratings { get; set; }

        public bool? IsSuccessful { get; set; }

        public ReviewCreateVM()
        {
            Ratings = Enum.GetNames(typeof(ReviewRatingType)).Select(name => new SelectListItem()
            {
                Text = name,
                Value = name
            });
        }


    }
}