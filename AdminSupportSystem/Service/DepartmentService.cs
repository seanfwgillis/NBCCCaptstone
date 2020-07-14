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
    public class DepartmentService: BaseService
    {
        private Department _d = new Department();

        #region Post
        public bool AddDepartment(Department d)
        {
            _d = d;
            DepartmentRepo repo = new DepartmentRepo();
            ValidateForCreate();
            if (Errors.Count == 0)
            {
                return repo.Insert(_d);
            }

            return false;
        }

        public bool UpdateDepartment(Department d)
        {
            _d = d;
            DepartmentRepo repo = new DepartmentRepo();
            ValidateForMod();
            if (Errors.Count == 0)
            {
                return repo.Update(_d);
            }
            return false;
        }

        public bool DeleteDepartment(int id)
        {
            DepartmentRepo repo = new DepartmentRepo();
            return repo.Delete(id);
        }
        #endregion
        #region Get
        public Department GetDepartmentById(int id)
        {
            DepartmentRepo repo = new DepartmentRepo();
            _d = repo.GetDepartmentById(id);
            return _d;
        }

        public Department GetDepartmentBySupId(int id)
        {
            DepartmentRepo repo = new DepartmentRepo();
            _d = repo.GetDepartmentBySupId(id);
            return _d;
        }
        #endregion
        #region Lists

        public List<DepartmentLookup> GetAllDepartments()
        {
            DepartmentRepo repo = new DepartmentRepo();
            List<DepartmentLookup> departments = repo.GetDepartments();

            return departments;
        }

        public List<Department> GetAllDepartmentsAllInfo()
        {
            DepartmentRepo repo = new DepartmentRepo();
            List<Department> departments = repo.GetDepartmentsAllInfo();

            return departments;
        }

        public List<JobLookup> GetAllJobsByDepartmentId(int departmentId)
        {
            DepartmentRepo repo = new DepartmentRepo();
            List<JobLookup> jobs = repo.GetJobsByDepartmentId(departmentId);

            return jobs;
        }

        public List<DepartmentLookupBySupId> GetDepartmentsBySupId(int id)
        {
            DepartmentRepo repo = new DepartmentRepo();
            List<DepartmentLookupBySupId> dep = repo.GetDepartmentsBySupId(id);
            return dep;
        }


        #endregion
        #region Validation

        private void ValidateForCreate()
        {
            IsValidEntity();
            IsValidDate();
        }

        private void ValidateForMod()
        {
            IsValidEntity();
        }
        private bool IsValidEntity()
        {
            ValidationContext context = new ValidationContext(_d);
            List<ValidationResult> results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(_d, context, results, true);

            foreach (ValidationResult r in results)
            {
                Errors.Add(new Error(r.ErrorMessage));
            }

            return isValid;
        }

        private bool IsValidDate()
        {
            if(_d.InvocationDate.CompareTo(DateTime.Now) < 0)
            {
                Errors.Add(new Error("Invocation Date cannot be less then current date"));
                return false;
            }
            return true;
        }


        #endregion
    }
}
