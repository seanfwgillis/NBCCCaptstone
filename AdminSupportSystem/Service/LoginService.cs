using Model;
using Model.Enums;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class LoginService : BaseService
    {

        public CredentialType GetLoginCredential(int employeeId)
        {
            LoginRepo repo = new LoginRepo();

            return repo.GetLoginCredential(employeeId);
        }

        public bool IsValidLogin(int employeeId, string password)
        {
            LoginRepo repo = new LoginRepo();
            EmployeeService s = new EmployeeService();

            Employee emp = s.GetEmployee(employeeId);

            if (repo.ValidateLogin(employeeId, Hash(password)) > 0)
            {
                if (emp.Status == EmployeeStatusType.Active)
                {
                    return true;
                }

                return false;
            }
            return false;

        }


        #region Helpers
        public string Hash(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        #endregion

        #region Validation
        private bool ValidateModel(Login login)
        {
            // validate our model
            ValidationContext context = new ValidationContext(login);
            List<ValidationResult> results = new List<ValidationResult>();

            Validator.TryValidateObject(login, context, results, true);

            foreach (ValidationResult r in results)
            {
                login.AddError(new ValidationError(r.ErrorMessage));
            }

            return login.ValErrors.Count == 0;

        }
        #endregion
    }
}
