using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ovvemarken_backend.Models
{
    /// <summary>
    /// Model for searching for patches
    /// </summary>
    public class SearchModel
    {
        /// <summary>
        /// Page of the search
        /// </summary>
        [Range(1, double.PositiveInfinity)]
        public int Page { get; set; } = 1;

        /// <summary>
        /// Max number of patches to get
        /// </summary>
        [Range(1, 100)]
        public int MaxPatches { get; set; } = 20;
    }
}
