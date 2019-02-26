using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using YuriVisaNewVersion.Areas.Admin.Code;
using YuriVisaNewVersion.Models;

namespace YuriVisaNewVersion.Areas.Admin.Controllers
{
    public class ManageController : Controller
    {

        // GET: Admin/Manage
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string user, string pass)
        {
            if (Membership.ValidateUser(user, Account.MD5Hash(pass)) && ModelState.IsValid)
            {
               
                FormsAuthentication.SetAuthCookie(user, true);
                Response.Cookies["position"].Value = "admin";
                Response.Cookies["position"].Expires = DateTime.Now.AddYears(1);
                return Redirect("~/Admin/Post");
            }
            else
            {
                ModelState.AddModelError("", "wrong username or password");
            }
            return View();

        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(string username, string password)
        {
            if (ModelState.IsValid)
            {
                var db = new DbYuriEntities();
                var account = new User();
                account.Username = username;
                account.Password = Account.MD5Hash(password);
                db.Users.Add(account);
                db.SaveChanges();

                return Redirect("/Admin/Post");
            }
            return View();
        }
    }
}