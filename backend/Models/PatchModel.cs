using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ovvemarken_backend.Models
{
    /// <summary>
    /// Model for a patch
    /// </summary>
    public class PatchModel
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

        /// <summary>
        /// Creator of the patch
        /// </summary>
        public string Creator { get; set; }

        /// <summary>
        /// Date when the patch was created
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Width of the patch
        /// </summary>
        [Range(0, 10000)] // 10 meter
        public int? Width { get; set; }

        /// <summary>
        /// Height of the patch
        /// </summary>
        [Range(0, 10000)] // 10 meter
        public int? Height { get; set; }
    }
}
