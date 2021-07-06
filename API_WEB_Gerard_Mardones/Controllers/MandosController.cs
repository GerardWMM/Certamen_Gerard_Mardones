using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_WEB_Gerard_Mardones.Models;

namespace API_WEB_Gerard_Mardones.Controllers
{
    public class MandosController : ApiController
    {
        //Conexión a la base de datos
        ContextBD bd = new ContextBD();

        //Metodo GET para obtener los mandos
        public IEnumerable<Mando> Get()
        {
            var mandos = bd.Mandos.ToList();
            return mandos;
        }

        //Metodo GET para obtener los mandos por id
        public Mando Get(int id)
        {
            var mando = bd.Mandos.Find(id);
            return mando;
        }
    }
}
