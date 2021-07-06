using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_WEB_Gerard_Mardones.Models;

namespace API_WEB_Gerard_Mardones.Controllers
{
    public class ConsolasController : ApiController
    {
        //Conexión a la base de datos
        ContextBD bd = new ContextBD();

        //Metodo GET para obtener las consolas
        public IEnumerable<Consola> Get()
        {
            var consolas = bd.Consolas.ToList();
            return consolas;
        }

        //Metodo GET para obtener las consolas por id
        public Consola Get(int id)
        {
            var consola = bd.Consolas.Find(id);
            return consola;
        }
    }
}
