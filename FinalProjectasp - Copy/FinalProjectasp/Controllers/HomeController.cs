using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalProjectasp.Models;
using FinalProjectasp.DAL;
using FinalProjectasp.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectasp.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVm homeVm = new HomeVm
            {
                Sliders = _context.Sliders.Take(3).ToList(),
                PrTeachers = _context.PrTeachers.Take(3).ToList(),
                Teachers = _context.Teachers.Where(b => b.IsDeleted == false).Include(b=>b.TeacherDetail).ToList(),
                WelcomeEdu =_context.welcomeEdus.FirstOrDefault(),
                Courses=_context.Courses.Where(b => b.IsDeleted == false).Include(b=>b.CourseDetail).Take(3).ToList(),
                Boards=_context.Boards.Take(6).ToList(),
                NoticeBoard=_context.NoticeBoard.FirstOrDefault(),
                Events=_context.Events.Where(c=>c.IsDeleted==false).Include(c=>c.Category).Take(4).ToList(),
                Ceos=_context.Ceos.ToList(),
                Blogs=_context.Blogs.Where(b=>b.IsDeleted==false).Include(b=>b.Category).Take(3).ToList(),
                Search=_context.Search.FirstOrDefault()
            };
            return View(homeVm);
        }

    }
}
