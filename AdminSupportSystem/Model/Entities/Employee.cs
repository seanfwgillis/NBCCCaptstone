using Model;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee: BaseEntity
    {
        [Required]
        [Range(10000000,99999999, ErrorMessage = "Employee ID must be exactly 8 digits")]

        public int Id { get; set; }
        [Required]
        [Range(10000000, 99999999, ErrorMessage = "Supervisor must be selected")]
        public int Supervisor { get; set; }
        [Required]
        public int Department { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Initial")]
        public string MiddleInitial { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }
        [Required]
        [Country]
        [Display(Name = "Country")]
        public string Country { get; set; }
        [Required]
        [Province]
        [Display(Name = "Province")]
        public string ProvState { get; set; }
        [Required]
        [RegularExpression(@"[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]",
            ErrorMessage = "Invalid Postal Code format.")]
        [Display(Name = "Postal Code")]
        public string PostalZip { get; set; }
        [Required]
        [Range(100000000, 999999999, ErrorMessage = "Incorrect SIN Format")]
        public int SIN { get; set; }
        [Required]
        public DateTime SeniorityDate { get; set; }
        [Required]
        [Range(1, 299, ErrorMessage = "Job Title must be selected")]
        public int JobAssignment { get; set; }
        [Required]
        public bool IsSupervisor { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Work Phone Number Format.")]
        [Display(Name = "Work #")]
        public string WorkPhoneNumber { get; set; }
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Cell Phone Number Format.")]
        [Display(Name = "Cell #")]
        public string CellPhoneNumber { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email Format.")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        public EmployeeStatusType Status { get; set; }

        public DateTime? EndDate { get; set; }
        public byte[] TimeStamp { get; set; }



    }
}
