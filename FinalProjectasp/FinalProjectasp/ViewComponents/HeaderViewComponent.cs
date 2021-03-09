using FinalProjectasp.DAL;
using FinalProjectasp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectasp.ViewComponents
{
    [ViewComponent(Name = "Header")]
    public class HeaderViewComponent: Microsoft.AspNetCore.Mvc.ViewComponent
    {

        private readonly AppDbContext _context;
        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Microsoft.AspNetCore.Mvc.IViewComponentResult> Invoke()
        {
            Header model = _context.Header.FirstOrDefault();
            return View(await Task.FromResult(model));
        }
    }
}
