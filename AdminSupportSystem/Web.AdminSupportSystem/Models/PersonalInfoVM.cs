using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.AdminSupportSystem.Models
{
    public class PersonalInfoVM
    {
        public Employee Employee { get; set; }

        public bool? IsSuccessful { get; set; }

        public string FullName
        {
            get
            {
                return Employee.FirstName + " " + Employee.LastName;
            }
        }
    }
}