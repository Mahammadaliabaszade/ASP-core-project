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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            ViewBag.bcount = _context.Blogs.Where(c => c.IsDeleted == false).Count();
            return View(_context.Blogs.Where(c => c.IsDeleted == false).Include(c => c.Category).Take(6).ToList());
        }
        public IActionResult LoadMore(int skip4)
        {
            int bcount = _context.Courses.Where(c => c.IsDeleted == false).Count();
            if (skip4 >= bcount)
            {
                return Json("Dont use button");
            }
            List<Blog> model = _context.Blogs.Where(c => c.IsDeleted == false).Include(c => c.Category).Skip(skip4).Take(6).ToList();
            return PartialView("_BlogPartial", model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Blog element = _context.Blogs.Where(x => x.Id == id).FirstOrDefault();
            if (element == null)
            {
                return NotFound();
            }
            return View(element);
        }
    }
}
