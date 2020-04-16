using ovvemarken_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ovvemarken_backend.Interfaces.BL
{
    /// <summary>
    /// Service interface for search
    /// </summary>
    public interface ISearchService
    {
        /// <summary>
        /// Searches for patchers and return summary of them
        /// </summary>
        /// <param name="searchQuery">Query specifing the serch</param>
        /// <returns>Summary of found patches</returns>
        public ICollection<PatchSummaryModel> SearchPatches(SearchModel searchQuery);
    }
}
