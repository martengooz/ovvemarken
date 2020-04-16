using ovvemarken_backend.Interfaces.BL;
using ovvemarken_backend.Interfaces.DL;
using ovvemarken_backend.Models;
using ovvemarken_backend.Models.ModelConverters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ovvemarken_backend.BL
{
    /// <summary>
    /// Service for handling search
    /// </summary>
    public class SearchService : ISearchService
    {
        private readonly IPatchRepository _patchRepository;

        /// <summary>
        /// Constructor for the search service
        /// </summary>
        /// <param name="patchRepository">Repository for handling patches</param>
        /// <exception cref="ArgumentNullException">Thrown for null argument</exception>
        public SearchService(IPatchRepository patchRepository)
        {
            _patchRepository = patchRepository ?? throw new ArgumentNullException();

        }

        /// <summary>
        /// Searches for patchers and return summary of them
        /// </summary>
        /// <param name="searchQuery">Query specifing the serch</param>
        /// <returns>Summary of found patches</returns>
        public ICollection<PatchSummaryModel> SearchPatches(SearchModel searchQuery)
        {
            var patches = _patchRepository.SearchPatches(searchQuery);
            var patchSummaries = patches.Select(p => PatchModelToPatchSummaryModelConverter.Convert(p)).ToList();
            return patchSummaries;
        }
    }
}
