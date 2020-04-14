using ovvemarken_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ovvemarken_backend.Interfaces.BL
{
    public interface IPatchService
    {
        public PatchModel GetPatchInfo(int id);

        /// <summary>
        /// Updates patch info
        /// </summary>
        /// <param name="patch">The patch to update</param>
        public void UpdatePatchInfo(PatchModel patch);
    }
}
