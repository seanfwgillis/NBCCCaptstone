using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Web.AdminSupportSystem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private LoginService s = new LoginService();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            Login l = new Login();
            return View(l);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login l)
        {
            try
            {
                if (l.Id == null || l.Password == null)
                {
                    return View(l);
                }

                if(s.IsValidLogin((int)l.Id, l.Password))
                {
                    EmployeeService es = new EmployeeService();
                    Employee e = es.GetEmployee((int)l.Id);
                    Session["EmployeeId"] = l.Id;                   
                    Session["Credential"] = s.GetLoginCredential((int)l.Id);
                    Session["Name"] = e.FirstName + " " + e.LastName;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    l.AddError(new ValidationError("Login Failed"));
                }

                return View(l);
            }
            catch(Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Login", "Login"));
            }
        }

        public ActionResult Logout()
        {
            Session.Remove("EmployeeId");
            Session.Remove("Credential");
            Session.Remove("Name");
            return RedirectToAction("Index", "Home");
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

    }
}