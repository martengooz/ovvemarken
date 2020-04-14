using ovvemarken_backend.Interfaces.BL;
using ovvemarken_backend.Interfaces.DL;
using ovvemarken_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ovvemarken_backend.BL
{
    /// <summary>
    /// Service for handling patches
    /// </summary>
    public class PatchService : IPatchService
    {
        private readonly IPatchRepository _patchRepository;

        /// <summary>
        /// Contructor of patch service
        /// </summary>
        /// <param name="patchRepository">Repository for patch info</param>
        /// <exception cref="ArgumentNullException">Thrown for null argument</exception>
        public PatchService(IPatchRepository patchRepository)
        {
            _patchRepository = patchRepository ?? throw new ArgumentNullException();
        }

        /// <summary>
        /// Gets the info of a patch
        /// </summary>
        /// <param name="id">ID of the patch</param>
        /// <returns>The info of the patch with given id</returns>
        public PatchModel GetPatchInfo(int id)
        {
            return _patchRepository.GetPatchInfo(id);
        }

        /// <summary>
        /// Updates patch info
        /// </summary>
        /// <param name="patch">The patch to update</param>
        public void UpdatePatchInfo(PatchModel patch)
        {
            _patchRepository.UpdatePatchInfo(patch);
        }
    }
}
