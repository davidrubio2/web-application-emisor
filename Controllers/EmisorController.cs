using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webappemisor.Models;

namespace webappemisor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmisorController : ControllerBase
    {
        DataAccessEmisor objEmisor = new DataAccessEmisor();


        [HttpGet]
        public ActionResult<List<Emisor>> GetAll()
        {
            return objEmisor.GetAllEmisor().ToList();

        }

        [HttpPost]
        public string Add(Emisor emisor)
        {
            return objEmisor.AddEmisor(emisor);
        }

        [HttpPut("{id}")]
        public string Put(int id, Emisor emisor)
        {
            return objEmisor.AlterEmisor(id,emisor);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return objEmisor.DeleteEmisor(id);
        }
    }
}
