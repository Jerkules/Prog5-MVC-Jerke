using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OefeningMVC.Models;

namespace OefeningMVC.Controllers
{
    public class componentsController : Controller
    {
        private componentContext db = new componentContext();

        // GET: components
        //public ActionResult Index()
        //{
        //    return View(db.Componenten.ToList());
        //}

        public ActionResult Index(string sortOrder)
        {

            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "naam" : "";
            var components = from c in db.Componenten
                             select c;
            switch (sortOrder)
            {
                case "naam":
                    components = db.Componenten.OrderBy(c => c.Naam);
                    break;
                case "aantal":
                    components = db.Componenten.OrderBy(c => c.aantal);
                    break;
                case "aankoopprijs":
                    components = db.Componenten.OrderBy(c => c.Aankoopprijs);
                    break;
                default:
                    ;
                    break;
            }
            return View(components.ToList());
        }

        // GET: components/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            component component = db.Componenten.Find(id);
            if (component == null)
            {
                return HttpNotFound();
            }
            return View(component);
        }

        // GET: components/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: components/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "Id,Naam,Categorie,Link,aantal,Aankoopprijs")] component component)
        {
            if (ModelState.IsValid)
            {
                db.Componenten.Add(component);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(component);
        }

        // GET: components/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            component component = db.Componenten.Find(id);
            if (component == null)
            {
                return HttpNotFound();
            }
            return View(component);
        }

        // POST: components/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "Id,Naam,Categorie,Link,aantal,Aankoopprijs")] component component)
        {
            if (ModelState.IsValid)
            {
                db.Entry(component).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(component);
        }

        // GET: components/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            component component = db.Componenten.Find(id);
            if (component == null)
            {
                return HttpNotFound();
            }
            return View(component);
        }

        // POST: components/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            component component = db.Componenten.Find(id);
            db.Componenten.Remove(component);
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
    }
}
