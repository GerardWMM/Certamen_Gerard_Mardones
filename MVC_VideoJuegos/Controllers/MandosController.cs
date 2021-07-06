using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_VideoJuegos.Models;

namespace MVC_VideoJuegos.Controllers
{
    public class MandosController : Controller
    {
        //Conexión a la bd
        ContextBD bd = new ContextBD();

        // GET: Mandos
        public ActionResult Index()
        {
            IEnumerable<Mando> mandos = bd.Mandos;
            return View(mandos);
        }

        // GET: Mandos/Details/5
        public ActionResult Details(int id)
        {
            Mando mando = bd.Mandos.Find(id);
            return View(mando);
        }

        // GET: Mandos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mandos/Create
        [HttpPost]
        public ActionResult Create(Mando mando)
        {
            try
            {
                bd.Mandos.Add(mando);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mandos/Edit/5
        public ActionResult Edit(int id)
        {
            Mando mando = bd.Mandos.Find(id);
            return View(mando);
        }

        // POST: Mandos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Mando mando)
        {
            try
            {
                Mando find_mando = bd.Mandos.Find(id);

                find_mando.marca = mando.marca;
                find_mando.modelo = mando.modelo;
                find_mando.compatibilidad = mando.compatibilidad;
                find_mando.precio = mando.precio;
                find_mando.stock = mando.stock;

                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mandos/Delete/5
        public ActionResult Delete(int id)
        {
            Mando mando = bd.Mandos.Find(id);
            return View(mando);
        }

        // POST: Mandos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Mando mando = bd.Mandos.Find(id);
                bd.Mandos.Remove(mando);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
