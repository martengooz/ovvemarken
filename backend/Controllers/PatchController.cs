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
    /// <summary>
    /// Patch controller
    /// Handles all api calls for a patch
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PatchController : ControllerBase
    {
        private readonly IPatchService _patchService;

        /// <summary>
        /// Constructor for the patch controller
        /// </summary>
        /// <param name="patchService">Service for handling patches</param>
        /// <exception cref="ArgumentNullException">Thrown for null argument</exception>
        public PatchController(IPatchService patchService)
        {
            _patchService = patchService ?? throw new ArgumentNullException();
        }

        /// <summary>
        /// Gets a patch
        /// GET: api/Patch/{id}
        /// </summary>
        /// <param name="id">ID of the patch</param>
        /// <returns>The patch with the ID</returns>
        /// <returns>Not found if the patch doesn't exist</returns>
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
