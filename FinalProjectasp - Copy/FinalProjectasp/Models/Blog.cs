using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectasp.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string  Image { get; set; }

        public string Writer { get; set; }

        public DateTime Time { get; set; }

        public int ReadCount { get; set; }

        public string Blogname { get; set; }
        public string Title { get; set; }

        public int CategoryId { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Category Category { get; set; }
    }

}
