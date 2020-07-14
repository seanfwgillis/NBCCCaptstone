using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class PasswordAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Convert.ToString(value) == "D41D8CD98F00B204E9800998ECF8427E")
            {
                return new ValidationResult("Password is required");
            }

            return ValidationResult.Success;

        }


    }

    internal class SINAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int sin;
            if (int.TryParse(value.ToString(), out sin) && value.ToString().Length == 9)
            {                
                return ValidationResult.Success;
            }

            return new ValidationResult("Invalid SIN format");

        }


    }

    internal class CountryAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            
            if (value.ToString().ToLower().Trim() == "canada" || value.ToString().ToLower().Trim() == "united states")
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("You must choose between Canada or United States");

        }


    }

    internal class ProvinceAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var states = GetAllStates();
            var provinces = GetAllProvincesAndTerritories();
            bool valid = false;

            foreach (string state in states)
            {
                if(value.ToString().ToUpper().Trim() == state )
                {
                    valid = true;
                }
            }
            foreach (string prov in provinces)
            {
                if (value.ToString().ToUpper().Trim() == prov)
                {
                    valid = true;
                }
            }

            if (valid)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Please type in a valid State or Province Abbreviation.");

        }

        private string[] GetAllStates()
        {
            string[] states =
            {
                "AL","AK","AS","AZ","AR","CA","CO","CT","DE","DC","FM","FL","GA",
                 "GU","HI","ID","IL","IN","IA","KS","KY","LA","ME","MH","MD","MA",
                 "MI","MN","MS","MO","MT","NE","NV","NH","NJ","NM","NY","NC","ND",
                 "MP","OH","OK","OR","PW","PA","PR","RI","SC","SD","TN","TX","UT",
                 "VT","VI","VA","WA","WV","WI","WY"

            };

            return states;

        }

        private string[] GetAllProvincesAndTerritories()
        {
            string[] provinces =
            {
                "ON",
                "QC",
                "NS",
                "NB",
                "MB",
                "BC",
                "PE",
                "SK",
                "AB",
                "NL",
                "NT",
                "YT",
                "NU"
            };

            return provinces;
        }


    }


}
