using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Image { get; set; }
        public bool IsDeleted { get; set; }
        public TeacherDetail TeacherDetail { get; set; }




    }
}
