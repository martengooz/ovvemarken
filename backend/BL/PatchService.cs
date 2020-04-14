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
        private IPatchDbContext _patchDbContext;

        public PatchService(IPatchDbContext patchDbContext)
        {
            _patchDbContext = patchDbContext ?? throw new ArgumentNullException();
        }

        public PatchModel GetPatchInfo(int id)
        {
            return _patchDbContext.GetPatchInfo(id);
        }

        /// <summary>
        /// Updates patch info
        /// </summary>
        /// <param name="patch">The patch to update</param>
        public void UpdatePatchInfo(PatchModel patch)
        {
            _patchDbContext.UpdatePatchInfo(patch);
        }
    }
}
