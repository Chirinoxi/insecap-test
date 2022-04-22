using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SGC.Models;

namespace SGC.Controllers
{
    public class InventarioCaracteristicasController : Controller
    {
        private InsecapContext db = new InsecapContext();

        // GET: InventarioCaracteristicas
        public ActionResult Index()
        {
            var inventarioCaracteristicas = db.InventarioCaracteristicas.Include(i => i.categoria);
            return View(inventarioCaracteristicas.ToList());
        }

        // GET: InventarioCaracteristicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventarioCaracteristicas inventarioCaracteristicas = db.InventarioCaracteristicas.Find(id);
            if (inventarioCaracteristicas == null)
            {
                return HttpNotFound();
            }
            return View(inventarioCaracteristicas);
        }

        // GET: InventarioCaracteristicas/Create
        public ActionResult Create()
        {
            ViewBag.idCategoria = new SelectList(db.Categoria, "idCategoria", "nombre");
            return View();
        }

        // POST: InventarioCaracteristicas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idInventarioCaracteristicas,idCategoria,Detalle,SoftDelete")] InventarioCaracteristicas inventarioCaracteristicas)
        {
            if (ModelState.IsValid)
            {
                db.InventarioCaracteristicas.Add(inventarioCaracteristicas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idCategoria = new SelectList(db.Categoria, "idCategoria", "nombre", inventarioCaracteristicas.idCategoria);
            return View(inventarioCaracteristicas);
        }

        // GET: InventarioCaracteristicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventarioCaracteristicas inventarioCaracteristicas = db.InventarioCaracteristicas.Find(id);
            if (inventarioCaracteristicas == null)
            {
                return HttpNotFound();
            }
            ViewBag.idCategoria = new SelectList(db.Categoria, "idCategoria", "nombre", inventarioCaracteristicas.idCategoria);
            return View(inventarioCaracteristicas);
        }

        // POST: InventarioCaracteristicas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idInventarioCaracteristicas,idCategoria,Detalle,SoftDelete")] InventarioCaracteristicas inventarioCaracteristicas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inventarioCaracteristicas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idCategoria = new SelectList(db.Categoria, "idCategoria", "nombre", inventarioCaracteristicas.idCategoria);
            return View(inventarioCaracteristicas);
        }

        // GET: InventarioCaracteristicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventarioCaracteristicas inventarioCaracteristicas = db.InventarioCaracteristicas.Find(id);
            if (inventarioCaracteristicas == null)
            {
                return HttpNotFound();
            }
            return View(inventarioCaracteristicas);
        }

        // POST: InventarioCaracteristicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InventarioCaracteristicas inventarioCaracteristicas = db.InventarioCaracteristicas.Find(id);
            db.InventarioCaracteristicas.Remove(inventarioCaracteristicas);
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
