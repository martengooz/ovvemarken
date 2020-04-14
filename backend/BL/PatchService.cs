using ovvemarken_backend.Interfaces.BL;
using ovvemarken_backend.Interfaces.DL;
using ovvemarken_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ovvemarken_backend.BL
{
    public class PatchService : IPatchService
    {
        private IPatchRepository _patchRepository;

        public PatchService(IPatchRepository patchRepository)
        {
            _patchRepository = patchRepository ?? throw new ArgumentNullException();
        }

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
