using Microsoft.AspNetCore.Mvc;
using ListaBurguersOnline.db;
using System.Linq;
using System.Collections.Generic;

namespace ListaBurguersOnline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BurguerInController : ControllerBase
    {
        private hamburgueriaContext _db {get; set;}
        public BurguerInController(hamburgueriaContext contexto)
        {
            _db = contexto;
        }
        
        [HttpGet]
        public List<BurguerIngrediente> Get()
        {
            var listaBurguerIn= _db.BurguerIngrediente
                .ToList();
            
            return listaBurguerIn;
        }
    }
}