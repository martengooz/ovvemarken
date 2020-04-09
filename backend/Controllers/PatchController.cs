using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ovvemarken_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatchController : ControllerBase
    {
        // GET: api/Patch
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Patch/{id}
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
            return Ok(new {id = id});
        }

        // POST: api/Patch
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Patch/{id}
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
