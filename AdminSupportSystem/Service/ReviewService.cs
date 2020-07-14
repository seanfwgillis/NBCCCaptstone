using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ReviewService: BaseService
    {
        private ReviewRepo repo = new ReviewRepo();
        private EmployeeRepo repoEmp = new EmployeeRepo();

        #region Post
        public bool CreateReview(Review r)
        {
            return ValiteModel(r) ? repo.CreateReview(r) : false;
            
        }
        #endregion
        #region Get/Lists

        public Review GetReview(int id)
        {
            return repo.GetReview(id);
        }
        public List<Review> GetReviewsBySupervisor(int supervisorId)
        {
            return repo.GetReviewsBySupervisor(supervisorId);
        }
        public List<Review> GetReviewsForEmployee(int employeeId)
        {
            return repo.GetReviewsByEmployeeId(employeeId);
        }
        #endregion
        #region Unique
        public DateTime? GetLastReview(int employeeId)
        {
            return repo.GetLastReviewDate(employeeId);
        }

        #endregion

        #region Validation

        private bool ValiteModel(Review r)
        {
            return IsValidEntity(r) && IsValidDate(r);
        }
        private bool IsValidEntity(Review rev)
        {
            ValidationContext context = new ValidationContext(rev);
            List<ValidationResult> results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(rev, context, results, true);

            foreach (ValidationResult r in results)
            {
                rev.AddError(new ValidationError(r.ErrorMessage));
            }

            return isValid;
        }

        private bool IsValidDate(Review r)
        {
            if (r.Date.Date.CompareTo(DateTime.Today) > 0)
            {
                r.AddError(new ValidationError("Reviews cannot be made for the future."));
                return false;
            }
            return true;
        }
        #endregion


    }
}
