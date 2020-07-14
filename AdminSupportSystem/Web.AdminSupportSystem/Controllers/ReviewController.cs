using Model;
using Model.Enums;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.AdminSupportSystem.Models;

namespace Web.AdminSupportSystem.Controllers
{
    public class ReviewController : Controller
    {
        // GET: Review
        private EmployeeService es = new EmployeeService();
        private ReviewService rs = new ReviewService();

        public ActionResult Index()
        {
            if (Session["EmployeeId"] != null)
            {
                try
                {
                    string credential = Session["Credential"].ToString();
                    if (credential == "HRSup" || credential == "RegSup")
                    {
                        List<Employee> e = new List<Employee>();
                        List<ReviewIndexVM> vm = new List<ReviewIndexVM>();

                        e = es.GetEmployeesBySupervisor(Convert.ToInt32(Session["EmployeeId"]))
                            .OrderBy(emp => emp.LastName).ToList();
                        foreach (Employee emp in e)
                        {
                            DateTime? date = rs.GetLastReview(emp.Id);
                            DateTime? range = DateTime.Now.AddMonths(-3);
                            string jobName = es.GetJobByEmployeeId(emp.Id);
                            if (date != null)
                            {
                                if (range <= date)
                                {
                                    ReviewIndexVM rv = new ReviewIndexVM();
                                    rv.EmployeeId = emp.Id;
                                    rv.JobName = jobName;
                                    rv.FullName = emp.LastName + ", " + emp.FirstName;
                                    rv.HasReviewPending = false;
                                    vm.Add(rv);
                                }
                                else
                                {
                                    ReviewIndexVM rv = new ReviewIndexVM();
                                    rv.EmployeeId = emp.Id;
                                    rv.JobName = jobName;
                                    rv.FullName = emp.LastName + ", " + emp.FirstName;
                                    rv.HasReviewPending = true;
                                    vm.Add(rv);
                                }
                            }
                            else
                            {
                                ReviewIndexVM rv = new ReviewIndexVM();
                                rv.EmployeeId = emp.Id;
                                rv.JobName = jobName;
                                rv.FullName = emp.LastName + ", " + emp.FirstName;
                                rv.HasReviewPending = true;
                                vm.Add(rv);
                            }

                        }
                        return View(vm);
                    }

                }
                catch (Exception ex)
                {
                    return View("Error", new HandleErrorInfo(ex, "Review", "Index"));
                }

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public ActionResult Create(int? id)
        {
            try
            {

                Employee e = es.GetEmployee((int)id);
                Employee s = es.GetEmployee(Convert.ToInt32(Session["EmployeeId"]));

                Review r = new Review();
                r.EmployeeId = (int)id;
                r.SupervisorId = Convert.ToInt32(Session["EmployeeId"]);

                ReviewCreateVM vm = new ReviewCreateVM();
                vm.Review = r;
                vm.EmployeeName = e.FirstName + " " + e.LastName;
                vm.SupervisorName = s.FirstName + " " + s.LastName;

                return View(vm);
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Review", "Create"));
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReviewCreateVM vm)
        {
            try
            {

                if (rs.CreateReview(vm.Review))
                {
                    vm.IsSuccessful = true;
                    return View(vm);
                }
                vm.IsSuccessful = false;
                return View(vm);
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Review", "Create"));
            }
        }

        public ActionResult PersonalReviews()
        {
            if (Session["EmployeeId"] != null)
            {
                try
                {
                    List<Review> r = rs.GetReviewsForEmployee(Convert.ToInt32(Session["EmployeeId"]));
                    List<PersonalReviewVM> vm = new List<PersonalReviewVM>();
                    foreach(Review rev in r)
                    {
                        Employee s = es.GetEmployee(rev.SupervisorId);
                        PersonalReviewVM persRev = new PersonalReviewVM()
                        {
                            Id = rev.Id,
                            EmployeeId = rev.EmployeeId,
                            SupervisorId = rev.SupervisorId,
                            Date = rev.Date,
                            Rating = rev.Rating,
                            Comments = rev.Comments,
                            SupervisorName = s.LastName + ", " + s.FirstName,
                        };
                        vm.Add(persRev);
                    }
                    return View(vm);
                }
                catch (Exception ex)
                {
                    return View("Error", new HandleErrorInfo(ex, "Review", "PersonalReviews"));
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult PersonalReviewDetails(int id)
        {
            try
            {
                Review r = rs.GetReview(id);
                return View(r);
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Review", "PersonalReviewDetails"));
            }
        }

    }
}