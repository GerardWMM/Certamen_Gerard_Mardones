using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_VideoJuegos.Models;

namespace MVC_VideoJuegos.Controllers
{
    public class JuegosController : Controller
    {
        //Conexion a la base de datos
        ContextBD bd = new ContextBD();

        // GET: Juegos
        public ActionResult Index()
        {
            IEnumerable<Juego> juegos = bd.Juegos;
            return View(juegos);
        }

        // GET: Juegos/Details/5
        public ActionResult Details(int id)
        {
            Juego juegos = bd.Juegos.Find(id);
            return View(juegos);
        }

        // GET: Juegos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Juegos/Create
        [HttpPost]
        public ActionResult Create(Juego juego)
        {
            try
            {
                bd.Juegos.Add(juego);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juegos/Edit/5
        public ActionResult Edit(int id)
        {
            Juego juego = bd.Juegos.Find(id);
            return View(juego);
        }

        // POST: Juegos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Juego juego)
        {
            try
            {
                Juego find_juego = bd.Juegos.Find(id);

                find_juego.nombre = juego.nombre;
                find_juego.plataforma = juego.plataforma;
                find_juego.anio = juego.anio;
                find_juego.precio = juego.precio;
                find_juego.stock = juego.stock;
                find_juego.restriccion = juego.restriccion;

                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juegos/Delete/5
        public ActionResult Delete(int id)
        {
            Juego juego = bd.Juegos.Find(id);
            return View(juego);
        }

        // POST: Juegos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Juego juego = bd.Juegos.Find(id);
                bd.Juegos.Remove(juego);
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
