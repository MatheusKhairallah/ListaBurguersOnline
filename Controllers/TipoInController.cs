using Microsoft.AspNetCore.Mvc;
using ListaBurguersOnline.db;
using System.Linq;
using System.Collections.Generic;

namespace ListaBurguersOnline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoInController : ControllerBase
    {
        private hamburgueriaContext _db {get; set;}
        public TipoInController(hamburgueriaContext contexto)
        {
            _db = contexto;
        }
        
        [HttpGet]
        public List<TipoIngrediente> Get()
        {
            var listaTipoIn= _db.TipoIngrediente
                .ToList();
            
            return listaTipoIn;
        }
    }
}