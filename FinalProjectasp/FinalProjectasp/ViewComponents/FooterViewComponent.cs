using FinalProjectasp.DAL;
using FinalProjectasp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectasp.ViewComponents
{

   
    public class FooterViewComponent : ViewComponent
    {

        private readonly AppDbContext _context;
        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Footer model = _context.Footer.FirstOrDefault();
            return View(await Task.FromResult(model));
        }
    }
}
