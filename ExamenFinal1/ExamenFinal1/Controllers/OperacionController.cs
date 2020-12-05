using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExamenFinal1.Controllers
{
    public class OperacionController : ApiController
    {
        [Route("api/Operacion")]
        [HttpGet]
        public string operacionmethod(int numero)
        {
            if (numero < 0)
            {
                return "ERROR";
            }
            else if (numero == 0)
            {
                return "Arturo Michel";
            }
            else
            {
                return $"{numero}";
            }
        }
    }
}
