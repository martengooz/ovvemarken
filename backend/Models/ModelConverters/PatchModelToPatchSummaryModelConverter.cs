using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ovvemarken_backend.Models.ModelConverters
{
    /// <summary>
    /// Conversion between <see cref="PatchModel"/> and <see cref="PatchSummaryModel"/>
    /// </summary>
    public static class PatchModelToPatchSummaryModelConverter
    {
        /// <summary>
        /// Converts <see cref="PatchSummaryModel"/> to <see cref="PatchModel"/>
        /// </summary>
        /// <param name="from"><see cref="PatchSummaryModel"/></param>
        /// <returns><see cref="PatchModel"/></returns>
        public static PatchModel Convert(PatchSummaryModel from)
        {
            return new PatchModel()
            {
                ID = from.ID,
                Name = from.Name,
                ImageLink = from.ImageLink
            };
        }

        /// <summary>
        /// Converts <see cref="PatchModel"/> to <see cref="PatchSummaryModel"/>
        /// </summary>
        /// <param name="from"><see cref="PatchModel"/></param>
        /// <returns><see cref="PatchSummaryModel"/></returns>
        public static PatchSummaryModel Convert(PatchModel from)
        {
            return new PatchSummaryModel()
            {
                ID = from.ID,
                Name = from.Name,
                ImageLink = from.ImageLink
            };
        }
    }
}
