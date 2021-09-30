using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_ADM.Models;

namespace MVC_ADM.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataBaseStore2 _context;

        public ProductController(DataBaseStore2 context)
        {
            _context = context;
        }

        // GET: Product
        public async Task<IActionResult> Index()
        {
            var dataBaseStore2 = _context.Product.Include(p => p.Category);
            return View(await dataBaseStore2.ToListAsync());
        }

        // GET: Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "CategoryName");
            ViewBag.tempdataurl = TempData["BlobUrl"];
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,Price,Amount,Description,CategoryId,ImgFotoProduct")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        // GET: Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "CategoryName", product.CategoryId);
            ViewBag.tempdataurl = TempData["BlobUrl"];
            return View(product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,Price,Amount,Description,CategoryId,ImgFotoProduct")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
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
            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductId == id);
        }

        // Upload Fotos
        [HttpPost]
        public IActionResult UpLoadImg(List<IFormFile> file)
        {
            // Ligar ao serviço Storage
            string containername = "alexandrecoutoimages";
            BlobServiceClient bsc = new BlobServiceClient("DefaultEndpointsProtocol=https;AccountName=asprojeto;AccountKey=a0B+PPewtIG4+ngBo/4uXdEnNq/RGCvVESJat3kcNOdmYTydATc8ik9Y7oumfAJOEJXvfyF5lP3zjOGROOPguA==;EndpointSuffix=core.windows.net");
            BlobContainerClient bcc = bsc.GetBlobContainerClient(containername);
            //Se não existir ele cria:
            bool bbcExists = bcc.Exists();
            if (bbcExists != true)
            {
                bcc = bsc.CreateBlobContainer(containername);
            }


            foreach (var I in file)
            {
                var localFileName = Path.GetFileName(I.FileName);
                BlobClient bc = bcc.GetBlobClient(localFileName);
                MemoryStream ms = new MemoryStream();
                I.CopyTo(ms);
                ms.Position = 0;
                bc.Upload(ms, true);
                var blobUrl = bc.Uri.AbsoluteUri;
                TempData["BlobUrl"] = blobUrl;
            }
            return RedirectToAction(nameof(Create));

        }
    }
}