using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class EditController : Controller
    {
        private AppDbContext _context { get; }

        public EditController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
            var existcontext = _context.Sliders.FirstOrDefault(x => x.Id == id);
            return View(existcontext);
        }

        [HttpPost]
        public IActionResult Update(Slider slider)
        {
            Slider existSlider = _context.Sliders.FirstOrDefault(x => x.Id == slider.Id);
            if (existSlider == null) return NotFound();

            existSlider.Title1 = slider.Title1;
            existSlider.Title2 = slider.Title2;
            existSlider.Description = slider.Description;
            _context.SaveChanges();


            return RedirectToAction("Index","AdminCategory");
        }
    }
}
