using Microsoft.AspNetCore.Mvc;
using ListaBurguersOnline.db;
using System.Linq;
using System.Collections.Generic;

namespace ListaBurguersOnline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredienteController : ControllerBase
    {
        private hamburgueriaContext _db {get; set;}
        public IngredienteController(hamburgueriaContext contexto)
        {
            _db = contexto;
        }
        
        [HttpGet]
        public List<Ingrediente> Get()
        {
            var listaIngrediente= _db.Ingrediente
                .ToList();
            
            return listaIngrediente;
        }
    }
}