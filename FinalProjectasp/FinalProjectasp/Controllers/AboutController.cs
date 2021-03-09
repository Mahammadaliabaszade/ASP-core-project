using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.Models;
using FinalProjectasp.DAL;
using FinalProjectasp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProjectasp.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVm homeVm2 = new HomeVm
            {

                WelcomeEdu = _context.welcomeEdus.FirstOrDefault(),
                Teachers = _context.Teachers.Take(4).ToList(),
                Ceos = _context.Ceos.ToList(),
                Boards = _context.Boards.Take(6).ToList(),
                NoticeBoard = _context.NoticeBoard.FirstOrDefault(),
                Search = _context.Search.FirstOrDefault()


            };
            return View(homeVm2);
            
        }
    }
}
