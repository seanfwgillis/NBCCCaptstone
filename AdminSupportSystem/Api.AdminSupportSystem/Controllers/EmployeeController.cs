using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.AdminSupportSystem.Controllers
{
    [RoutePrefix("api/employees")]
    public class EmployeeController : ApiController
    {
        private EmployeeService s = new EmployeeService();
        private DepartmentService d = new DepartmentService();

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAllEmployees()
        {
            try
            {
                List<EmployeeForAndroid> employees = s.GetEmployeesForAndroid();
                if (employees.Count == 0)
                {
                    return NotFound();
                }
                return Ok(employees.OrderBy(x => x.Name).ToList());
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.ExpectationFailed, ex.ToString());
            }
        }

        [HttpGet]
        [Route("departments")]
        public IHttpActionResult GetDepartments()
        {
            try
            {
                List<DepartmentLookup> departments = d.GetAllDepartments();
                if (departments.Count == 0)
                {
                    return NotFound();
                }
                return Ok(departments);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.ExpectationFailed, ex.ToString());
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetEmployeesByDepartmentId(int id)
        {
            try
            {
                List<EmployeeForAndroid> employees = s.GetEmployeesForAndroidByDepartment(id);
                if (employees == null)
                {
                    return NotFound();
                }
                return Ok(employees.OrderBy(x => x.Name).ToList());
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.ExpectationFailed, ex.ToString());
            }
        }
    }
}
