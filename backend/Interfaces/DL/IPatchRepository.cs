using ovvemarken_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ovvemarken_backend.Interfaces.DL
{
    public interface IPatchRepository
    {
        public PatchModel GetPatchInfo(int id);

        /// <summary>
        /// Updates patch in the database
        /// </summary>
        /// <param name="patch">The patch to update</param>
        public void UpdatePatchInfo(PatchModel patch);
    }
}
