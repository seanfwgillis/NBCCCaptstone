using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Review: BaseEntity
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
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        public ReviewRatingType Rating { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }

    }
}
