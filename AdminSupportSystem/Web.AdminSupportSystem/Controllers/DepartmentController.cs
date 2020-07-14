using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.AdminSupportSystem.Models;

namespace Web.AdminSupportSystem.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        private DepartmentService s = new DepartmentService();
        private DepartmentModifyVM vm = new DepartmentModifyVM();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Modify(bool? isSuccessful)
        {
            try
            {
                if (Session["EmployeeId"] != null)
                {

                    string credential = Session["Credential"].ToString();
                    if (credential == "HRSup" || credential == "HREmp")
                    {
                        vm.Departments = GetDepartments();
                        if (isSuccessful != null)
                        {
                            vm.IsSuccessful = isSuccessful;
                        }

                        return View(vm);
                    }
                    if (credential == "RegSup")
                    {
                        vm.Departments = GetDepartmentBySup(Convert.ToInt32(Session["EmployeeId"].ToString()));
                        vm.Department = s.GetDepartmentBySupId(Convert.ToInt32(Session["EmployeeId"].ToString()));
                        if (isSuccessful != null)
                        {
                            vm.IsSuccessful = isSuccessful;
                        }

                        return View(vm);
                    }
                    if (credential == "RegEmp")
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    return View();

                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Department", "Index"));
            }
        }

        [HttpPost]
        public ActionResult Modify(int? departmentId)
        {
            if (departmentId != null)
            {
                string credential = Session["Credential"].ToString();
                if (credential == "HRSup")
                {
                    vm.Departments = GetDepartments();
                }
                if (credential == "RegSup")
                {
                    vm.Departments = GetDepartmentBySup(Convert.ToInt32(Session["EmployeeId"].ToString()));

                }
                vm.Department = s.GetDepartmentById((int)departmentId);
                return View(vm);
            }
            else
            {
                return RedirectToAction("Modify");
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DepartmentModifyVM vm)
        {
            try
            {
                if (s.UpdateDepartment(vm.Department))
                {

                    return RedirectToAction("Modify", new { isSuccessful = true});
                }

                return View();
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Department", "Index"));
            }
        }

        private List<SelectListItem> GetDepartments()
        {
            return s.GetAllDepartments().Select(d => new SelectListItem
            {
                Value = d.Id.ToString(),
                Text = d.Name
            }).ToList();
        }

        private List<SelectListItem> GetDepartmentBySup(int id)
        {
            return s.GetDepartmentsBySupId(id).Select(d => new SelectListItem
            {
                Value = d.Id.ToString(),
                Text = d.Name
            }).ToList();
        }

    }
}