using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MVC_ADM.Models;

namespace Razor_WebStore.Pages.Store
{
    public class IndexModel : PageModel
    {
        private readonly DataBaseStore2 _context;

        public IndexModel(DataBaseStore2 context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product
                .Include(o => o.Category).ToListAsync();
        }
    }
}
