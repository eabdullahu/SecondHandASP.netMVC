using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SecondHand.Data;
using SecondHand.Models;

namespace SecondHand.Controllers
{
    public class ContentsController : Controller
    {
        private readonly SecondHandContext _context;
        private readonly ILogger<UsersController> _logger;

        public ContentsController(SecondHandContext context, ILogger<UsersController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: Contents
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contents.ToListAsync());
        }

        // GET: Contents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contents = await _context.Contents
                .FirstOrDefaultAsync(m => m.contentId == id);
            if (contents == null)
            {
                return NotFound();
            }

            return View(contents);
        }

        // GET: Contents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("contentId,contentPage,contentGroup,contentOrder,contentCategory,contentTitle,contentDesc,contentImg,contentIcon,contentLink,contentDt")] Contents contents,  IFormFile file)
        {
            _logger.LogInformation(file.FileName);
            var basePath = Path.Combine(Directory.GetCurrentDirectory() + "\\wwwroot\\images\\banner\\");
            bool basePathExists = System.IO.Directory.Exists(basePath);
            if (!basePathExists) Directory.CreateDirectory(basePath);
            var fileName = Path.GetFileNameWithoutExtension(file.FileName);
            var filePath = Path.Combine(basePath, file.FileName);
            var extension = Path.GetExtension(file.FileName);
            if (!System.IO.File.Exists(filePath))
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

            }
            if (ModelState.IsValid)
            {
                contents.contentImg = fileName + extension; 
                _context.Add(contents);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contents);
        }

        // GET: Contents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contents = await _context.Contents.FindAsync(id);
            if (contents == null)
            {
                return NotFound();
            }
            return View(contents);
        }

        // POST: Contents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("contentId,contentPage,contentGroup,contentOrder,contentCategory,contentTitle,contentDesc,contentImg,contentIcon,contentLink,contentDt")] Contents contents, IFormFile file)
        {

            if (id != contents.contentId)
            {
                return NotFound();
            }


            if (ModelState.IsValid )
            {
                var basePath = Path.Combine(Directory.GetCurrentDirectory() + "\\wwwroot\\images\\banner\\");
                bool basePathExists = System.IO.Directory.Exists(basePath);
                if (!basePathExists) Directory.CreateDirectory(basePath);
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var filePath = Path.Combine(basePath, file.FileName);
                var extension = Path.GetExtension(file.FileName);
                if (!System.IO.File.Exists(filePath))
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                }
                try
                {
                    contents.contentImg = fileName + extension;
                    _context.Update(contents);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContentsExists(contents.contentId))
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
            return View(contents);
        }

        // GET: Contents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contents = await _context.Contents
                .FirstOrDefaultAsync(m => m.contentId == id);
            if (contents == null)
            {
                return NotFound();
            }

            return View(contents);
        }

        // POST: Contents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contents = await _context.Contents.FindAsync(id);
            _context.Contents.Remove(contents);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContentsExists(int id)
        {
            return _context.Contents.Any(e => e.contentId == id);
        }
    }
}
