using ovvemarken_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ovvemarken_backend.Interfaces.BL
{
    /// <summary>
    /// Service interface for patches
    /// </summary>
    public interface IPatchService
    {
        /// <summary>
        /// Gets the info of a patch
        /// </summary>
        /// <param name="id">ID of the patch</param>
        /// <returns>The info of the patch with given id</returns>
        public PatchModel GetPatchInfo(int id);

        /// <summary>
        /// Updates patch info
        /// </summary>
        /// <param name="patch">The patch to update</param>
        public void UpdatePatchInfo(PatchModel patch);
    }
}
