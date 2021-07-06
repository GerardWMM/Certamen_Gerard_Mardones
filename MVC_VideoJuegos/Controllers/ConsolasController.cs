using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_VideoJuegos.Models;

namespace MVC_VideoJuegos.Controllers
{
    public class ConsolasController : Controller
    {
        //Conexion a la base de datos
        ContextBD bd = new ContextBD();


        // GET: Consolas
        public ActionResult Index()
        {
            IEnumerable<Consola> consolas = bd.Consolas;
            return View(consolas);
        }

        // GET: Consolas/Details/5
        public ActionResult Details(int id)
        {
            Consola consola = bd.Consolas.Find(id);
            return View(consola);
        }

        // GET: Consolas/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Consolas/Create
        [HttpPost]
        public ActionResult Create(Consola consola)
        {
            try
            {
                bd.Consolas.Add(consola);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consolas/Edit/5
        public ActionResult Edit(int id)
        {
            Consola consola = bd.Consolas.Find(id);
            return View(consola);
        }

        // POST: Consolas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Consola consola)
        {
            try
            {
                //Buscar la consola a editar
                Consola find_consola = bd.Consolas.Find(id);
                //Aplicar los cambios en sus propiedades
                find_consola.marca = consola.marca;
                find_consola.modelo = consola.modelo;
                find_consola.anio_creacion = consola.anio_creacion;
                find_consola.nueva = consola.nueva;
                find_consola.precio = consola.precio;
                find_consola.stock = consola.stock;
                //Guardar los cambios en la db
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consolas/Delete/5
        public ActionResult Delete(int id)
        {
            Consola consola = bd.Consolas.Find(id);
            return View(consola);
        }

        // POST: Consolas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Consola consola = bd.Consolas.Find(id);
                bd.Consolas.Remove(consola);
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
