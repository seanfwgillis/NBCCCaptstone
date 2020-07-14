using Model;
using Model.Enums;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public class EmployeeService : BaseService
    {
        private Employee _e;
        private Login _l = new Login();

        public Employee GetEmployee(int id)
        {
            EmployeeRepo repo = new EmployeeRepo();
            _e = repo.RetrieveEmployeeById(id);
            return _e;
        }

        public bool AddEmployee(Employee e, string password)
        {
            _e = FinishEmployeeObject(e);
            EmployeeRepo repo = new EmployeeRepo();
            ValidateEmployeeForCreate();

            LoginRepo lRepo = new LoginRepo();
            PrepareLogin(password);
            if (Errors.Count == 0)
            {
                repo.AddEmployee(_e);
                return lRepo.Insert(_l);
            }
            return false;
        }

        public bool ModifyEmployee(Employee modified, Employee unmodified, int empId)
        {
            EmployeeRepo repo = new EmployeeRepo();
            _e = modified;
            ValidateEmployeeForModify(empId, unmodified);
            if (Errors.Count == 0)
            {
                return repo.ModifyEmployee(_e);
            }
            return false;
        }

        public bool ModifyPersonalInfo(Employee e)
        {
            _e = e;
            EmployeeRepo repo = new EmployeeRepo();
            ValidateForEmpInfo();
            {
                if (Errors.Count == 0)
                {
                    return repo.ModifyEmployee(_e);
                }
                return false;
            }
        }
        #region Uniques
        public string GetJobByEmployeeId(int id)
        {
            EmployeeRepo repo = new EmployeeRepo();
            return repo.GetJobByEmployeeId(id);
        }
        #endregion
        #region ForAndroid
        public List<EmployeeForAndroid> GetEmployeesForAndroid()
        {
            EmployeeRepo er = new EmployeeRepo();
            DepartmentService dr = new DepartmentService();

            List<Employee> holder = er.GetAllEmployees();
            List<EmployeeForAndroid> androidList = new List<EmployeeForAndroid>();

            foreach (Employee e in holder)
            {
                Department d = dr.GetDepartmentById(e.Department);
                EmployeeForAndroid emp = new EmployeeForAndroid()
                {
                    EmployeeId = e.Id,
                    Name = e.LastName + ", " + e.FirstName,
                    WorkNumber = e.WorkPhoneNumber,
                    Department = d.Name,
                    IsSupervisor = e.IsSupervisor,
                    EmailAddress = e.Email
                };

                androidList.Add(emp);

            }

            return androidList;

        }

        public List<EmployeeForAndroid> GetEmployeesForAndroidByDepartment(int departmentId)
        {
            EmployeeRepo er = new EmployeeRepo();
            DepartmentService dr = new DepartmentService();
            List<Employee> holder = er.RetrieveEmployeesByDepartment(departmentId);
            List<EmployeeForAndroid> androidList = new List<EmployeeForAndroid>();

            foreach (Employee e in holder)
            {
                Department d = dr.GetDepartmentById(e.Department);
                EmployeeForAndroid emp = new EmployeeForAndroid()
                {
                    EmployeeId = e.Id,
                    Name = e.LastName + ", " + e.FirstName,
                    WorkNumber = e.WorkPhoneNumber,
                    Department = d.Name,
                    IsSupervisor = e.IsSupervisor,
                    EmailAddress = e.Email
                };

                androidList.Add(emp);

            }

            return androidList;
        }


        #endregion
        #region Lists

        public List<Employee> GetEmployees()
        {
            EmployeeRepo repo = new EmployeeRepo();
            return repo.GetAllEmployees();
        }
        public List<EmployeeLookup> FindEmployees(string name)
        {
            EmployeeRepo repo = new EmployeeRepo();
            return repo.RetrieveEmployeesByLastName(name);
        }

        public List<Employee> FindEmployeesAllInfo(string name)
        {
            EmployeeRepo repo = new EmployeeRepo();
            return repo.RetrieveByNameAllInfo(name);
        }

        public List<Employee> FindEmployeesAllInfo(int id)
        {
            EmployeeRepo repo = new EmployeeRepo();
            return repo.RetrieveByNameAllInfo(id);
        }

        public List<SupervisorLookup> GetSupervisorsByDepartment(int departmentId)
        {
            EmployeeRepo repo = new EmployeeRepo();
            List<SupervisorLookup> supList = repo.RetrieveSupervisorsByDepartment(departmentId);


            return supList;
        }

        public List<Employee> GetEmployeesBySupervisor(int supervisorId)
        {
            EmployeeRepo repo = new EmployeeRepo();

            return repo.RetrieveEmployeesBySupervisor(supervisorId);
        }

        public List<Employee> GetAllSupervisors()
        {
            EmployeeRepo repo = new EmployeeRepo();

            return repo.RetrieveAllSupervisors();
        }


        #endregion
        #region Unique
        public List<EmployeeLookup> GetEmployeesBySupWithPendingReviews(int supervisorId)
        {
            ReviewService rs = new ReviewService();

            List<Employee> employees = GetEmployeesBySupervisor(supervisorId);
            List<EmployeeLookup> pendingReviews = new List<EmployeeLookup>();

            DateTime? range = DateTime.Now.AddMonths(-3);

            foreach (Employee emp in employees)
            {
                DateTime? date = rs.GetLastReview(emp.Id);

                if (date == null || range <= date)
                {
                    EmployeeLookup e = new EmployeeLookup()
                    {
                        Id = emp.Id,
                        Name = emp.LastName + ", " + emp.FirstName
                    };

                    pendingReviews.Add(e);
                }

            }

            return pendingReviews.OrderBy(x => x.Name).ToList();
        }
        public List<Employee> GetSupsPendingEmails()
        {
            List<Employee> allSups = GetAllSupervisors();
            List<Employee> supsSorted = new List<Employee>();

            foreach (Employee sup in allSups)
            {
                if (GetEmployeesBySupWithPendingReviews(sup.Id).Count() > 0)
                {
                    Employee e = new Employee()
                    {
                        Id = sup.Id,
                        Email = sup.Email,

                    };
                    supsSorted.Add(e);
                }
            }
            return supsSorted;
        }
        public List<EmployeeLookup> GetSupervisorsWithPendingReviews()
        {
            List<Employee> allSups = GetAllSupervisors();
            List<EmployeeLookup> pendingSups = new List<EmployeeLookup>();
            foreach (Employee sup in allSups)
            {
                if(GetEmployeesBySupWithPendingReviews(sup.Id).Count() > 0)
                {
                    EmployeeLookup e = new EmployeeLookup()
                    {
                        Id = sup.Id,
                        Name = sup.LastName + ", " + sup.FirstName
                    };
                    pendingSups.Add(e);
                }
            }

            return pendingSups.OrderBy(x => x.Name).ToList();
        }
        #endregion
        #region LoginCreation
        private void PrepareLogin(string password)
        {
            _l.Id = _e.Id;
            _l.Password = Hash(password);
            DetermineCredential();
            ValidateLogin();
        }
        #endregion

        #region Helpers
        private int GenerateRandomEmployeeId()
        {
            EmployeeRepo repo = new EmployeeRepo();
            Random random = new Random();

            List<int> allEmployeeIDs = repo.GetAllIdOfEmployees();

            int potentialId = random.Next(10000000, 99999999);

            foreach (int empId in allEmployeeIDs)
            {
                while (empId == potentialId)
                {
                    potentialId = random.Next(10000000, 99999999);
                }
            }

            return potentialId;
        }

        private Employee FinishEmployeeObject(Employee e)
        {
            e.Id = GenerateRandomEmployeeId();
            e.Status = Model.Enums.EmployeeStatusType.Active;

            return e;
        }

        private int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        private void DetermineCredential()
        {
            if (_e.IsSupervisor && _e.Department == 6)
            {
                _l.Credential = CredentialType.HRSup;

            }
            else if (_e.IsSupervisor && _e.Department != 6)
            {
                _l.Credential = CredentialType.RegSup;
            }
            else if (!_e.IsSupervisor && _e.Department == 6)
            {
                _l.Credential = CredentialType.HREmp;
            }
            else
            {
                _l.Credential = CredentialType.RegEmp;
            }
        }

        public string Hash(string input)
        {
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

        }

        public string[] GetAllProvincesAndTerritories()
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

        public string[] GetAllStates()
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
        public string[] GetCountries()
        {
            string[] countries =
            {
                "Canada",
                "United States"
            };
            return countries;
        }
        public string[] GetAllProvAndStates()
        {
            string[] provAndStates =
            {
                "---Provinces---",
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
                "NU","---States---","AL","AK","AS","AZ","AR","CA","CO","CT","DE","DC","FM","FL","GA",
                 "GU","HI","ID","IL","IN","IA","KS","KY","LA","ME","MH","MD","MA",
                 "MI","MN","MS","MO","MT","NE","NV","NH","NJ","NM","NY","NC","ND",
                 "MP","OH","OK","OR","PW","PA","PR","RI","SC","SD","TN","TX","UT",
                 "VT","VI","VA","WA","WV","WI","WY"
            };
            return provAndStates;
        }
        #endregion

        #region Validation
        public void ValidateEmployeeForCreate()
        {
            if (IsValidEmployeeEntity())
            {
                IsValidSupervisor();
                IsValidAge();
                IsValidStartDate();
            }

        }

        public void ValidateEmployeeForModify(int empId, Employee e)
        {
            if (IsValidEmployeeEntity())
            {
                IsValidSupervisor();
                IsValidStartDate();
                IsValidForRetirement();
                IsValidForSameUser(empId, e);
                IsActive(e);
                ValidateForRetired(e);
            }
        }

        public void ValidateLogin()
        {
            IsValidLoginEntity();
        }

        public void ValidateForEmpInfo()
        {
            IsValidEmployeeEntity();
        }

        private bool IsValidEmployeeEntity()
        {
            ValidationContext context = new ValidationContext(_e);
            List<ValidationResult> results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(_e, context, results, true);

            foreach (ValidationResult r in results)
            {
                Errors.Add(new Error(r.ErrorMessage));
            }

            return isValid;
        }

        private bool IsValidLoginEntity()
        {
            ValidationContext context = new ValidationContext(_l);
            List<ValidationResult> results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(_l, context, results, true);

            foreach (ValidationResult r in results)
            {
                Errors.Add(new Error(r.ErrorMessage));
            }

            return isValid;
        }

        private bool IsValidSupervisor()
        {
            EmployeeRepo r = new EmployeeRepo();
            if (r.GetSubordinates(_e.Supervisor) >= 10)
            {
                Errors.Add(new Error("Supervisor selected has too many subordinates"));
                return false;
            }
            return true;
        }

        private bool IsValidAge()
        {
            if (CalculateAge(_e.DOB) < 19)
            {
                Errors.Add(new Error("Individual is too young to hire. They must be at least 19 years of age."));
                return false;
            }
            return true;
        }

        private bool IsValidStartDate()
        {
            if (_e.SeniorityDate.Date.CompareTo(_e.StartDate.Date) > 0)
            {
                Errors.Add(new Error("Employee job start date cannot be prior to your hire date."));
                return false;
            }
            return true;
        }

        private bool IsValidForRetirement()
        {
            if (_e.Status == EmployeeStatusType.Retired && CalculateAge(_e.DOB) < 55)
            {
                Errors.Add(new Error("Employee cannot retire prior to the age of 55. You must selected Terminate."));
                return false;
            }
            return true;
        }

        private bool IsValidForSameUser(int emp, Employee e)
        {
            if (emp == _e.Id)
            {
                if (e.StartDate != _e.StartDate || e.Status != _e.Status || e.Department != _e.Department ||
                    e.Supervisor != _e.Supervisor || e.JobAssignment != _e.JobAssignment || e.IsSupervisor != _e.IsSupervisor)
                {
                    Errors.Add(new Error("You are not authorized to make this type of change for this employee."));
                    return false;
                }
                return true;
            }
            return true;
        }

        private bool IsActive(Employee e)
        {
            if (e.Status != EmployeeStatusType.Active)
            {
                if (_e.Status != EmployeeStatusType.Active)
                {
                    Errors.Add(new Error("You may not modify inactive employees. Please activate employee before making changes."));
                    return false;
                }

            }
            return true;
        }

        private bool ValidateForRetired(Employee e)
        {
            if (e.Status == EmployeeStatusType.Retired)
            {
                if (_e.Status != EmployeeStatusType.Retired)
                {
                    Errors.Add(new Error("Retired employees may not be reinstated."));
                    return false;
                }
                return true;
            }
            return true;
        }



        #endregion
    }
}
