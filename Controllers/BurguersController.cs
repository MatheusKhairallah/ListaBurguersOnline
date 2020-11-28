using Microsoft.AspNetCore.Mvc;
using ListaBurguersOnline.db;
using System.Linq;
using System.Collections.Generic;

namespace ListaBurguersOnline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BurguersController : ControllerBase
    {
        private hamburgueriaContext _db {get; set;}
        public BurguersController(hamburgueriaContext contexto)
        {
            _db = contexto;
        }
        
        [HttpGet]
        public List<Burguer> Get()
        {
            var listaBurguer= _db.Burguer
                .OrderBy(i=> i.Nome)
                .ToList();
            
            return listaBurguer;
        }
    }
}