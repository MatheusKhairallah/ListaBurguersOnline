using Microsoft.AspNetCore.Mvc;
using ListaBurguersOnline.db;
using System.Linq;
using System.Collections.Generic;

namespace ListaBurguersOnline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnidadeController : ControllerBase
    {
        private hamburgueriaContext _db {get; set;}
        public UnidadeController(hamburgueriaContext contexto)
        {
            _db = contexto;
        }
        
        [HttpGet]
        public List<Unidade> Get()
        {
            var listaUnidade= _db.Unidade
                .ToList();
            
            return listaUnidade;
        }
    }
}