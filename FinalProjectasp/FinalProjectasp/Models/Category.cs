using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectasp.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Count { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Course> Courses { get; set; }

        public ICollection<Event> Events { get; set; }

        public ICollection<Blog> Blogs { get; set; }



    }
}
