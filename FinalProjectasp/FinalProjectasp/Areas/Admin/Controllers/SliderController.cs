using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectasp.DAL;
using FinalProjectasp.Models;
using Fiorella.Extentions;
using Fiorella.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectasp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.SliderCount = _context.Sliders.Count();

            return View(await _context.Sliders.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (ModelState["Photos"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }
            foreach (IFormFile photo in slider.Photos)
            {
                if (!photo.IsSelectedType("image/"))
                {
                    ModelState.AddModelError("Photos", $"{photo.Name}-Not image type!");
                    return View();
                }
                if (photo.CheckMaxLenght(300))
                {
                    ModelState.AddModelError("Photos", $"Max size must be less than 300 kb.{photo.FileName} size is {photo.Length / 1024}kb");
                    return View();
                }
                Slider newSlider = new Slider();
                newSlider.Image = await photo.SaveImageAsync(_env.WebRootPath, "img");
                await _context.Sliders.AddAsync(newSlider);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();

            if (!Helper.DeleteImage(_env.WebRootPath, "img", slider.Image))
            {
                ModelState.AddModelError("", "Some problem exist");
                return View(slider);
            }
            if (_context.Sliders.Count() != 1)
            {
                _context.Sliders.Remove(slider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));

        }
    }
}
