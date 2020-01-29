using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using miercolesmvc.Models;

namespace miercolesmvc.Controllers
{
    public class EmpleadinController : Controller
    {
        private ContextoEmpleados db = new ContextoEmpleados();

        // GET: Empleadin
        public ActionResult Index()
        {
            return View(db.Empleados.ToList());
        }

        // GET: Empleadin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleadin empleadin = db.Empleados.Find(id);
            if (empleadin == null)
            {
                return HttpNotFound();
            }
            return View(empleadin);
        }

        // GET: Empleadin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleadin/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEmpleado,Nombre,Apellidos,Direccion,Email")] Empleadin empleadin)
        {
            if (ModelState.IsValid)
            {
                db.Empleados.Add(empleadin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empleadin);
        }

        // GET: Empleadin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleadin empleadin = db.Empleados.Find(id);
            if (empleadin == null)
            {
                return HttpNotFound();
            }
            return View(empleadin);
        }

        // POST: Empleadin/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEmpleado,Nombre,Apellidos,Direccion,Email")] Empleadin empleadin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empleadin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleadin);
        }

        // GET: Empleadin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleadin empleadin = db.Empleados.Find(id);
            if (empleadin == null)
            {
                return HttpNotFound();
            }
            return View(empleadin);
        }

        // POST: Empleadin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Empleadin empleadin = db.Empleados.Find(id);
            db.Empleados.Remove(empleadin);
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
