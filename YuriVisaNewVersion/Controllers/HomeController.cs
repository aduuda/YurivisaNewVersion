using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YuriVisaNewVersion.Areas.Admin.Models;

namespace YuriVisaNewVersion.Controllers
{
    public class HomeController : Controller
    {
        private newDSEntities db = new newDSEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult PaymentInformation()
        {
            return View();
        }
        public ActionResult News()
        {
            return View();
        }
        public ActionResult NewView(string Metatitle)
        {
            if (Metatitle == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            YuriContent yuriContent = db.YuriContents.Where(x=>x.MetaTitle==Metatitle).FirstOrDefault();            
            if (yuriContent == null)
            {
                return HttpNotFound();
            }
            ViewBag.Title = yuriContent.Name;
            ViewBag.content = yuriContent.Description;
            return View();
        }
    }
}