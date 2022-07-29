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
    public class SpecialOfferController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SpecialOfferController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index(int page = 1)
        {
            byte ItemsPerPage = 4;
            ViewBag.CurrPage = page;
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.SpecialOffers.Count() / ItemsPerPage);

            List<SpecialOffer> specialOffers = _context.SpecialOffers
                .OrderByDescending(c => c.Id).Skip((page-1)*ItemsPerPage)
                .Take(ItemsPerPage).ToList();
            return View(specialOffers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(SpecialOffer specialOffer)
        {
            if (!ModelState.IsValid) return View();

            if (specialOffer.Photo is null)
            {
                ModelState.AddModelError("Photo", "Please enter image ");
                return View();
            }
            if (!specialOffer.Photo.IsImageOkay(2))
            {
                ModelState.AddModelError("Photo", "Please choose valid image file");
                return View();
            }

            specialOffer.Image = await specialOffer.Photo.FileCreate(_env.WebRootPath, "assets/img");
            await _context.SpecialOffers.AddAsync(specialOffer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            if (id is null || id == 0) return NotFound();

            SpecialOffer existed = _context.SpecialOffers.FirstOrDefault(s => s.Id == id);

            if (existed is null) return NotFound();
            return View(existed);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(int? id, SpecialOffer newSpecialOffer)
        {
            SpecialOffer existed = _context.SpecialOffers.FirstOrDefault(s => s.Id == id);
            if (existed is null) return NotFound();

            if (!ModelState.IsValid) return View(existed);

            if (newSpecialOffer.Photo is null)
            {
                string filename = existed.Image;
                _context.Entry(existed).CurrentValues.SetValues(newSpecialOffer);
                existed.Image = filename;
            }
            else
            {
                if (!newSpecialOffer.Photo.IsImageOkay(3))
                {
                    ModelState.AddModelError("Photo", "Please choose valid image file");
                    return View(existed);
                }
                FileValidator.FileDelete(_env.WebRootPath, "assets/img", existed.Image);
                _context.Entry(existed).CurrentValues.SetValues(newSpecialOffer);
                existed.Image = await newSpecialOffer.Photo.FileCreate(_env.WebRootPath,
                    "assets/img");
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Remove(int? id)
        {
            if (id is null || id == 0) return NotFound();

            SpecialOffer existed = await _context.SpecialOffers.FirstOrDefaultAsync(s => s.Id == id);
            if (existed is null) return NotFound();

            _context.SpecialOffers.Remove(existed);
            FileValidator.FileDelete(_env.WebRootPath, "assets/img", existed.Image);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null || id == 0) return NotFound();

            SpecialOffer existed = await _context.SpecialOffers.FirstOrDefaultAsync(s => s.Id == id);
            if (existed is null) return NotFound();

            return View(existed);
        }
    }
}
