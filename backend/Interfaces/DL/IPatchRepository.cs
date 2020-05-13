using ovvemarken_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ovvemarken_backend.Interfaces.DL
{
    /// <summary>
    /// Repository interface for patches
    /// </summary>
    public interface IPatchRepository
    {
        /// <summary>
        /// Creates a patch entry in the database
        /// </summary>
        /// <param name="patch">Patch to create</param>
        /// <returns>ID of the created patch</returns>
        public int CreatePatchInfo(PatchModel patch);

        /// <summary>
        /// Gets patch info from the database
        /// </summary>
        /// <param name="id">ID of the patch</param>
        /// <returns>The patch for the given id. Null if it doesn't exist.</returns>
        public PatchModel GetPatchInfo(int id);

        /// <summary>
        /// Searches for patches
        /// </summary>
        /// <param name="searchQuery">Query to search by</param>
        /// <returns>Found patches</returns>
        public ICollection<PatchModel> SearchPatches(SearchModel searchQuery);

        /// <summary>
        /// Updates patch in the database
        /// </summary>
        /// <param name="patch">The patch to update</param>
        public void UpdatePatchInfo(PatchModel patch);
    }
}
