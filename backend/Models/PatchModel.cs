using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ovvemarken_backend.Models
{
    public class PatchModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string ImageLink { get; set; }

        public string Creator { get; set; }

        public DateTime Date { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }
    }
}
