using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectasp.DAL;
using FinalProjectasp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectasp.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            ViewBag.Coursecount = _context.Courses.Where(c => c.IsDeleted == false).Count();
            return View(_context.Courses.Where(c=>c.IsDeleted==false).Include(c=>c.CourseDetail).Take(6).ToList());
        }
        public IActionResult LoadMore( int skip)
        {
            int coursecount= _context.Courses.Where(c => c.IsDeleted == false).Count();
            if (skip >= coursecount)
            {
                return Json("Dont use button");
            }
            List<Course> model = _context.Courses.Where(c => c.IsDeleted == false).Include(c => c.CourseDetail).Skip(skip).Take(6).ToList();
            return PartialView("_CoursePartial",model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Course element = _context.Courses.Where(x => x.Id == id).Include(x => x.CourseDetail).FirstOrDefault();
            if (element == null)
            {
                return NotFound();
            }
            return View(element);
        }

    }
}
