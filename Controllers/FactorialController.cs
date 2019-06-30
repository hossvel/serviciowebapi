using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using serviciowebapi.Dtos;
namespace serviciowebapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FactorialController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{numero}")]
        public Respuesta Get(int numero)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.numero = numero;
            respuesta.respuesta = factorial(numero);
            respuesta.version = "1.0";
            return respuesta;
        }
int factorial(int n) {
   if(n < 0) return 0;
   else if(n > 1) return n*factorial(n-1);
   return 1;
}


    }
}
