﻿using Backendproject.DAL;
using Backendproject.Models;
using Backendproject.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.Areas.adminPanel.Controllers
{
    [Area("adminPanel")]
    public class SliderController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(ApplicationDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View();

            if(slider.Photo is null)
            {
                ModelState.AddModelError("Photo", "Please enter image ");
                return View();
            }
            if (!slider.Photo.IsImageOkay(3))
            {
                ModelState.AddModelError("Photo", "Please choose valid image file");
                return View();
            }

            slider.Image = await slider.Photo.FileCreate(_env.WebRootPath, "assets/img");
            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            if (id is null || id == 0) return NotFound();

            Slider existed =  _context.Sliders.FirstOrDefault(s => s.Id == id);

            if (existed is null) return NotFound();
            return View(existed);
        }
        
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(int? id,Slider newSlider)
        {
            Slider existed = _context.Sliders.FirstOrDefault(s => s.Id == id);
            if (existed is null) return NotFound();

            if (!ModelState.IsValid) return View(existed);

            #region Shekil silinse extra check up
            // hech bir shekilin olmamagini yoxlayir(belke image i remove elave etdim)
            //if(newSlider.Photo is null)
            //{
            //    ModelState.AddModelError("Photo", "You need to upload one image to create slider");
            //    return View(existed);
            //}
            #endregion

            if (newSlider.Photo is null)
            {
                string filename = existed.Image;
                _context.Entry(existed).CurrentValues.SetValues(newSlider);
                existed.Image = filename;
            }
            else
            {
                if (!newSlider.Photo.IsImageOkay(3))
                {
                    ModelState.AddModelError("Photo", "Please choose valid image file");
                    return View(existed);
                }
                FileValidator.FileDelete(_env.WebRootPath, "assets/img", existed.Image);
                _context.Entry(existed).CurrentValues.SetValues(newSlider);
                existed.Image = await newSlider.Photo.FileCreate(_env.WebRootPath,
                    "assets/img");
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Remove(int? id)
        {
            if (id is null || id == 0) return NotFound();

            Slider existed = await _context.Sliders.FirstOrDefaultAsync(p => p.Id == id);
            if (existed is null) return NotFound();

            _context.Sliders.Remove(existed);
            FileValidator.FileDelete(_env.WebRootPath, "assets/img", existed.Image);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null || id == 0) return NotFound();

            Slider existed = await _context.Sliders.FirstOrDefaultAsync(p => p.Id == id);
            if (existed is null) return NotFound();

            return View(existed);
        }
    }
}
