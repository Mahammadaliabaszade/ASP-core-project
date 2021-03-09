using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.Models;
using FinalProjectasp.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectasp.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;

        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            ViewBag.tcount = _context.Teachers.Where(c => c.IsDeleted == false).Count();
            return View(_context.Teachers.Where(c => c.IsDeleted == false).Include(c => c.TeacherDetail).Take(8).ToList());
        }
        public IActionResult LoadMore(int skip3)
        {
            int tcount = _context.Courses.Where(c => c.IsDeleted == false).Count();
            if (skip3>= tcount)
            {
                return Json("Dont use button");
            }
            List<Teacher> model = _context.Teachers.Where(c => c.IsDeleted == false).Include(c => c.TeacherDetail).Skip(skip3).Take(8).ToList();
            return PartialView("_TeacherPartial", model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Teacher element = _context.Teachers.Where(x => x.Id == id).Include(x => x.TeacherDetail).FirstOrDefault();
            if (element == null)
            {
                return NotFound();
            }
            return View(element);
        }
    }
}
