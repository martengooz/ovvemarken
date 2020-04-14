using ovvemarken_backend.Interfaces.DL;
using ovvemarken_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ovvemarken_backend.DL
{
    /// <summary>
    /// Repoitory for handling patches in the database
    /// </summary>
    public class PatchRepository : IPatchRepository
    {
        /// <summary>
        /// Gets patch info from the database
        /// </summary>
        /// <param name="id">ID of the patch</param>
        /// <returns>The patch for the given id. Null if it doesn't exist.</returns>
        public PatchModel GetPatchInfo(int id)
        {
            using var db = new SQLiteDBContext();
            var patch = db.Patches.FirstOrDefault(p => p.ID == id);
            return patch;
        }

        /// <summary>
        /// Updates patch info in the database
        /// </summary>
        /// <param name="patch">The patch to update</param>
        /// <exception cref="KeyNotFoundException">Thrown if the id of the patch isn't found</exception>
        public void UpdatePatchInfo(PatchModel patch)
        {
            if (patch != null)
            {
                using var db = new SQLiteDBContext();
                var entity = db.Patches.FirstOrDefault(item => item.ID == patch.ID);
                if (entity != null)
                {
                    entity.Name = patch.Name ?? entity.Name;
                    entity.ImageLink = patch.ImageLink ?? entity.ImageLink;
                    entity.Creator = patch.Creator ?? entity.Creator;
                    entity.Date = patch.Date ?? entity.Date;
                    entity.Width = patch.Width ?? entity.Width;
                    entity.Height = patch.Height ?? entity.Height;
                    db.Patches.Update(entity);
                    db.SaveChanges();
                }
                else
                {
                    throw new KeyNotFoundException("Patch doesn't exist.");
                }
            }
        }
    }
}
