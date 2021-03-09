using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectasp.Models
{
    public class CourseDetail
    {

        public int Id { get; set; }

        public string Description { get; set; }
        public string ApplyTitle { get; set; }

        public string CertificationTitle { get; set; }
        public string CourseTitle { get; set; }

        public DateTime Start { get; set; }

        public string Duration { get; set; }
        public string ClassDuration { get; set; }

        public string Skilllevel { get; set; }
        public string Language { get; set; }

        public int Students { get; set; }

        public string Assesments { get; set; }
        public int Fee { get; set; }

        public bool IsDeleted { get; set; }

        public int CourseId { get; set; }

        public  Course Course { get; set; }






    }
}
