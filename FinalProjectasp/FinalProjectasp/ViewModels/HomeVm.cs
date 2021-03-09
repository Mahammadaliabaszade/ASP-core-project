using EduHome.Models;
using FinalProjectasp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectasp.ViewModels
{
    public class HomeVm
    {
        public List<Slider> Sliders { get; set; }

        public List<Teacher> Teachers { get; set; }

        public List<PrTeacher> PrTeachers { get; set; }

        public WelcomeEdu WelcomeEdu { get; set; }

        public List<Course> Courses { get; set; }

        public NoticeBoard NoticeBoard { get; set; }

        public List<Board> Boards { get; set; }

        public List<Event> Events { get; set; }

        public List<Ceo> Ceos { get; set; }

        public List<Blog> Blogs { get; set; }

        public Search  Search { get; set; }



    }
}
