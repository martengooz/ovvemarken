using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ovvemarken_backend.Models
{
    /// <summary>
    /// Model for the summary of a patch
    /// </summary>
    public class PatchSummaryModel
    {
        /// <summary>
        /// ID of the patch
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Name of the patch
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Link to the images of the patch
        /// </summary>
        public string ImageLink { get; set; }
    }
}
