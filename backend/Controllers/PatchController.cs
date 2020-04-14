using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ovvemarken_backend.Interfaces.BL;
using ovvemarken_backend.Models;

namespace ovvemarken_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatchController : ControllerBase
    {
        private readonly IPatchService _patchService;

        public PatchController(IPatchService patchService)
        {
            _patchService = patchService;
        }

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
            var patch = _patchService.GetPatchInfo(id);
            if (patch != null)
            {
                return Ok(patch);
            }
            return NotFound();
        }

        // POST: api/Patch
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Updates patch info of an existing patch
        /// PUT: api/Patch
        /// </summary>
        /// <param name="patch">Patch to update</param>
        /// <returns>Ok if patch got updated</returns>
        /// <returns>Not found if the patch doesn't exist</returns>
        [HttpPut]
        public ActionResult Put([FromBody] PatchModel patch)
        {
            try
            {
                _patchService.UpdatePatchInfo(patch);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            return Ok();
        }

        // DELETE: api/ApiWithActions/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
