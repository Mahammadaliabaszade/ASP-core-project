using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectasp.DAL;
using FinalProjectasp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectasp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {

            if (!ModelState.IsValid) return View();
            bool Existing = await _context.Categories.AnyAsync(c => c.Name.ToLower() == category.Name.ToLower());
            if (Existing)
            {
                ModelState.AddModelError("Name", "This category already exist");
                return View();
            }
            category.IsDeleted = false;
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Category category = await _context.Categories.Where(c => c.IsDeleted == false).FirstOrDefaultAsync(c => c.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, Category category)
        {
            if (id == null) return NotFound();
            if (!ModelState.IsValid) return View(category);
            Category isExist2 = await _context.Categories.Where(c => c.IsDeleted == false).FirstOrDefaultAsync(c => c.Id == category.Id);
            if (isExist2 == null) return NotFound();

            Category isExist = await _context.Categories.Where(c => c.IsDeleted == false).FirstOrDefaultAsync(c => c.Name.ToLower() == category.Name.ToLower());
            if (isExist != null && isExist.Id != category.Id)
            {

                ModelState.AddModelError("Name", "Bu adli kategoriya movcuddur");
                return View(category);
            }
            isExist2.Name = category.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Category category = await _context.Categories.Where(c => c.IsDeleted == false).FirstOrDefaultAsync(c => c.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeletePost(int? id)
        {

            if (id == null) return NotFound();
            Category category = await _context.Categories.Where(c => c.IsDeleted == false).FirstOrDefaultAsync(c => c.Id == id);
            if (category == null) return NotFound();

            category.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }



    }
}
