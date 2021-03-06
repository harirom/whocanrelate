﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WhoCanRelate;
using WhoCanRelate.Models;

namespace WhoCanRelate.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly BlogDbContext _context;

        public IActionResult WritePost()
        {
            return View();
        }

        /*
        public PostController(BlogDbContext context)
        {
            _context = context;
        }

       

        // GET: Post
        public async Task<IActionResult> Index()
        {
            return View(await _context.BlogContent.ToListAsync());
        }

        // GET: Post/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogContent = await _context.BlogContent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogContent == null)
            {
                return NotFound();
            }

            return View(blogContent);
        }

        // GET: Post/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Image,Body,Tag,Timestamp,Author")] BlogContent blogContent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blogContent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blogContent);
        }

        // GET: Post/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogContent = await _context.BlogContent.FindAsync(id);
            if (blogContent == null)
            {
                return NotFound();
            }
            return View(blogContent);
        }

        // POST: Post/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Image,Body,Tag,Timestamp,Author")] BlogContent blogContent)
        {
            if (id != blogContent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogContent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogContentExists(blogContent.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(blogContent);
        }

        // GET: Post/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogContent = await _context.BlogContent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogContent == null)
            {
                return NotFound();
            }

            return View(blogContent);
        }

        // POST: Post/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogContent = await _context.BlogContent.FindAsync(id);
            _context.BlogContent.Remove(blogContent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogContentExists(int id)
        {
            return _context.BlogContent.Any(e => e.Id == id);
        }
        */
    }
}
