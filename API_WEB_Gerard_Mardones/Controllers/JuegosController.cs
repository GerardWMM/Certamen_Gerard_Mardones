using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_WEB_Gerard_Mardones.Models;

namespace API_WEB_Gerard_Mardones.Controllers
{
    public class JuegosController : ApiController
    {
        //Conexión a la base de datos
        ContextBD bd = new ContextBD();

        //Metodo GET para obtener los juegos
        public IEnumerable<Juego> Get()
        {
            var juegos = bd.Juegos.ToList();
            return juegos;
        }

        //Metodo GET para obtener los juegos por id
        public Juego Get(int id)
        {
            var juego = bd.Juegos.Find(id);
            return juego;
        }
    }
}
