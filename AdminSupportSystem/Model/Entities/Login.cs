using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Login : BaseEntity
    {
        [Required]
        [Display(Name = "Employee ID")]
        public int? Id { get; set; }
        [Required]
        [Password]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required]
        public CredentialType Credential { get; set; }
    }
}
