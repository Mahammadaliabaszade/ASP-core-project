using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class TeacherDetail
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Degree { get; set; }
        public string Experience { get; set; }
        public string Hobbies { get; set; }
        public string Faculty { get; set; }
        public int Language { get; set; }
        public int Development { get; set; }
        public int TeamLeader { get; set; }
        public int Inovasion { get; set; }
        public int Design { get; set; }
        public int Communication { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Skype { get; set; }
        public bool IsDeleted { get; set; }
        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }



    }
}
