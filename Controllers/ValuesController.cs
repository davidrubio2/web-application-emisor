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
    public class ValuesController : ControllerBase
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

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return objEmisor.DeleteEmisor(id);
        }
    }
}
