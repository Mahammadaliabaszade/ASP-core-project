using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectasp.DAL;
using Microsoft.AspNetCore.Mvc;

namespace FinalProjectasp.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class EventController : Controller
    {

       

        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Events.Where(e => e.IsDeleted == false).ToList());
        }


        public async Task<IActionResult> Create() {


            return View();
        }

        //public async Task<IActionResult> Create(Event event)
        //{
        //    if (!ModelState.IsValid)
        //    {

        //    }

        //    return View();
        //}


    }
}
