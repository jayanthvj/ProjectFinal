using System;
using Payroll_DAL;
using Payroll_EmployeeManagementSystem.Models;
using Payroll_Entity;
using System.Web.Mvc;
using System.Web.Security;
using System.Web;

namespace Payroll_EmployeeManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(AccountModel account)
        {
            try
            {
                Account accountEntity = new Account()
                {
                    EmailId = account.EmailId,
                    Password = account.Password,
                };
                EmployeeRepository repository = new EmployeeRepository();
                Account check = repository.CheckLogin(accountEntity);
                if (check != null)
                {
                    FormsAuthentication.SetAuthCookie(check.EmailId, false);

                    var authTicket = new FormsAuthenticationTicket(1, check.EmailId, DateTime.Now, DateTime.Now.AddMinutes(20), false, check.Role);
                    string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                    var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                    HttpContext.Response.Cookies.Add(authCookie);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.message = "UserId & Password is incorrect";
                }
                return View();
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
            //if (checkRole.Role == "admin")
            //{
            //    return RedirectToAction("AddEmployee", "Main");
            //}
            //else if (checkRole.Role == "user")
            //{
            //    return RedirectToAction("Display", "Main");
            //}
        }
        public ActionResult LogOff()
        {
            //AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}