using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StoreApp.Data;
using StoreApp.Models;

namespace StoreApp.Pages.OrderItemsViews
{
    public class IndexModel : PageModel
    {
        private readonly StoreApp.Data.StoreAppContext _context;

        public IndexModel(StoreApp.Data.StoreAppContext context)
        {
            _context = context;
        }

        public IList<OrderItem> OrderItem { get;set; }

        public async Task OnGetAsync()
        {
            OrderItem = await _context.OrderItem
                .Include(o => o.Orders)
                .Include(o => o.Products).ToListAsync();
        }
    }
}
