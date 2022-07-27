﻿using Backendproject.DAL;
using Backendproject.Models;
using Backendproject.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.Areas.adminPanel.Controllers
{
    [Area("adminPanel")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CategoryController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.Include(c => c.Clothes).ToList();
            return View(categories);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Category category)
        {
            if (!ModelState.IsValid) return View();

            if (category.Photo is null)
            {
                ModelState.AddModelError("Photo", "Please input image file");
                return View();
            }
            if (!category.Photo.IsImageOkay(2))
            {
                ModelState.AddModelError("Photo", "Please input valid image file");
                return View();
            }

            category.Image = await category.Photo.FileCreate(_env.WebRootPath, "assets/img");
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public ActionResult Edit(int? id)
        {
            if (id is null || id == 0) return NotFound();

            Category existed = _context.Categories.FirstOrDefault(c => c.Id == id);

            if (existed is null) return NotFound();
            return View(existed);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int? id, Category newCategory)
        {
            Category existed = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (existed is null) return NotFound();
            if (!ModelState.IsValid) return View(existed);

            if (newCategory.Photo is null)
            {
                string filename = existed.Image;
                _context.Entry(existed).CurrentValues.SetValues(newCategory);
                existed.Image = filename;
            }
            else
            {
                if (!newCategory.Photo.IsImageOkay(2))
                {
                    ModelState.AddModelError("Photo", "Please choose valid image file");
                    return View(existed);
                }
                //db den shekilsiz elave etmek olur
                if (existed.Image != null)
                {
                    FileValidator.FileDelete(_env.WebRootPath, "assets/img", existed.Image);
                }
                _context.Entry(existed).CurrentValues.SetValues(newCategory);
                existed.Image = await newCategory.Photo.FileCreate(_env.WebRootPath,
                    "assets/img");
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> Remove(int? id)
        {
            if (id is null || id == 0) return NotFound();
            Category existed = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (existed is null) return NotFound();
            //if(existed.Image != null)
            //{
            FileValidator.FileDelete(_env.WebRootPath, "assets/img", existed.Image);

            //}
            _context.Categories.Remove(existed);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> Detail(int? id)
        {
            if (id is null || id == 0) return NotFound();
            Category existed = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (existed is null) return NotFound();

            return View(existed);
        }
    }
}
