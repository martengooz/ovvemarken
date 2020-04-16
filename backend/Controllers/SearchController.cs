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
    /// Search controller
    /// Handles all api calls for searching for multiple patches
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService _searchService;

        /// <summary>
        /// Constructor for the search controller
        /// </summary>
        /// <param name="patchService">Service for handling patches</param>
        /// <exception cref="ArgumentNullException">Thrown for null argument</exception>
        public SearchController(ISearchService searchService)
        {
            _searchService = searchService ?? throw new ArgumentNullException();
        }

        /// <summary>
        /// Gets summary of patches
        /// GET: api/Search
        /// </summary>
        /// <returns>Summary of patches for the first page</returns>
        [HttpPost]
        public ActionResult GetSearchResult([FromBody] SearchModel searchQuery)
        {
            var patches = _searchService.SearchPatches(searchQuery);
            if (patches != null)
            {
                return Ok(patches);
            }
            return NotFound();
        }
    }
}
