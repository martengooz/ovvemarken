using ovvemarken_backend.Interfaces.DL;
using ovvemarken_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ovvemarken_backend.DL
{
    public class PatchDbContext : IPatchDbContext
    {
        public PatchModel GetPatchInfo(int id)
        {
            using var db = new SQLiteDBContext();
            var patch = db.Patches.FirstOrDefault(p => p.ID == id);
            return patch;
        }

            {
                var patch = db.Patches
                    .Where(p => p.ID == id)
                    .FirstOrDefault();
                return patch;
            }
        }
    }
}
