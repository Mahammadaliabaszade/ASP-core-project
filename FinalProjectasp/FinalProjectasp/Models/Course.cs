using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectasp.Models
{
    public class Course
    {

        public int Id { get; set; }
        public string Image { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public int CategoryId { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Category Category { get; set; }

        public  CourseDetail CourseDetail { get; set; }






    }
}
