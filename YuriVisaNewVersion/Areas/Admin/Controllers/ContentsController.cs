using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using YuriVisaNewVersion.Areas.Admin.Models;
 

namespace YuriVisaNewVersion.Areas.Admin.Controllers
{
    public class ContentsController : Controller
    {
        private newDSEntities db = new newDSEntities();

        // GET: Admin/Contents
        public ActionResult Index()
        {
            return View(db.YuriContents.ToList());
        }

        // GET: Admin/Contents/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            YuriContent yuriContent = db.YuriContents.Find(id);
            if (yuriContent == null)
            {
                return HttpNotFound();
            }
            return View(yuriContent);
        }

        // GET: Admin/Contents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Contents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "ID,Name,MetaTitle,Description,Image,CategoryID,Detail,CreatedDate,CreatedBy,Status,ViewCount")] YuriContent yuriContent)
        {
            if (ModelState.IsValid)
            {
                db.YuriContents.Add(yuriContent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(yuriContent);
        }

        // GET: Admin/Contents/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            YuriContent yuriContent = db.YuriContents.Find(id);
            if (yuriContent == null)
            {
                return HttpNotFound();
            }
            return View(yuriContent);
        }

        // POST: Admin/Contents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "ID,Name,MetaTitle,Description,Image,CategoryID,Detail,CreatedDate,CreatedBy,Status,ViewCount")] YuriContent yuriContent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(yuriContent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(yuriContent);
        }

        // GET: Admin/Contents/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            YuriContent yuriContent = db.YuriContents.Find(id);
            if (yuriContent == null)
            {
                return HttpNotFound();
            }
            return View(yuriContent);
        }

        // POST: Admin/Contents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)] 
        public ActionResult DeleteConfirmed(long id)
        {
            YuriContent yuriContent = db.YuriContents.Find(id);
            db.YuriContents.Remove(yuriContent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public string ChangeImage(int id, string image)
        {
            //if(id == null)
            //{
            //    return "Mã không tồn tại";
            //}
            YuriContent b = db.YuriContents.Find(id);
            b.Image = image;
            db.SaveChanges();
            return "";

        }
    }
}
