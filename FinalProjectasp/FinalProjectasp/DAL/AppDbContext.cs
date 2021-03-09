using EduHome.Models;
using FinalProjectasp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectasp.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<PrTeacher> PrTeachers { get; set; }

        public DbSet<WelcomeEdu> welcomeEdus { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseDetail> courseDetails { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventDetail> EventDetails { get; set; }
        public DbSet<Speaker> Speakers { get; set; }

        public DbSet<TeacherDetail> TeacherDetails { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<NoticeBoard> NoticeBoard { get; set; }

        public DbSet<Board> Boards { get; set; }

        public DbSet<Ceo> Ceos { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Header> Header { get; set; }

        public DbSet<Footer>  Footer { get; set; }

        public DbSet<Search> Search { get; set; }


    }
}
