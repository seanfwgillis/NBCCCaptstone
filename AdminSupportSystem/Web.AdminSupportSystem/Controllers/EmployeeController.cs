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
    public class EmployeeController : Controller
    {
        // GET: Employee
        private EmployeeService s = new EmployeeService();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchEmployee(string searchBy, string search)
        {
            try
            {
                if (Session["EmployeeId"] != null)
                {


                    List<Employee> employees = new List<Employee>();
                    if (searchBy == "Name" && search != "")
                    {
                        employees = s.FindEmployeesAllInfo(search);
                        if (employees.Count() == 0)
                        {
                            employees.Add(new Employee { SingleError = "None" });
                        }
                        return View(employees);
                    }
                    if (searchBy == "EmployeeID" && search != "")
                    {
                        int checker;
                        if (search.Trim().Length == 8 && Int32.TryParse(search, out checker))
                        {
                            employees = s.FindEmployeesAllInfo(Convert.ToInt32(search.Trim()));
                            if (employees.Count() == 0)
                            {
                                employees.Add(new Employee { SingleError = "None" });
                            }
                        }
                        else
                        {
                            employees.Add(new Employee { SingleError = "Format" });
                        }

                        return View(employees);
                    }
                    if (search == "")
                    {
                        Employee e = new Employee();
                        e.SingleError = "Blank";
                        employees.Add(e);
                        return View(employees);
                    }

                    return View(employees);

                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Employee", "GetEmployees"));
            }
        }

        public ActionResult Edit(int? id)
        {
            try
            {
                if (Session["EmployeeId"] != null)
                {
                    if (id == null)
                    {
                        return new HttpStatusCodeResult(400);
                    }

                    Employee e = s.GetEmployee((int)id);

                    if (e == null)
                    {
                        return new HttpStatusCodeResult(404);
                    }

                    PersonalInfoVM vm = new PersonalInfoVM()
                    {
                        Employee = e,

                    };

                    return View(vm);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Recipes", "Edit"));
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PersonalInfoVM vm)
        {
            try
            {
                if (s.ModifyPersonalInfo(vm.Employee))
                {
                    vm.IsSuccessful = true;
                    return View(vm);
                }
                return View(vm);
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Recipes", "Edit"));
            }
        }

    }
}