﻿using ovvemarken_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ovvemarken_backend.Interfaces.DL
{
    public interface IPatchDbContext
    {
        public PatchModel GetPatchInfo(int id);
    }
}