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
    public class EventController : Controller
    {
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            ViewBag.Eventcount = _context.Events.Where(c => c.IsDeleted == false).Count();
            return View(_context.Events.Where(c => c.IsDeleted == false).Include(c => c.EventDetail).Take(6).ToList());
        }
        public IActionResult LoadMore(int skip2)
        {
            int eventcount = _context.Courses.Where(c => c.IsDeleted == false).Count();
            if (skip2 >= eventcount)
            {
                return Json("Dont use button");
            }
            List<Event> model = _context.Events.Where(c => c.IsDeleted == false).Include(c => c.EventDetail).Skip(skip2).Take(6).ToList();
            return PartialView("_EventPartial", model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
           Event element= _context.Events.Where(x=>x.Id ==id).Include(x=>x.EventDetail).Include(x => x.EventDetail.Speaker).FirstOrDefault();
            if (element == null)
            {
                return NotFound();
            }
            return View(element);
        }

    }
}
