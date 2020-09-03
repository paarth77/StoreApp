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
    public class DetailsModel : PageModel
    {
        private readonly StoreApp.Data.StoreAppContext _context;

        public DetailsModel(StoreApp.Data.StoreAppContext context)
        {
            _context = context;
        }

        public OrderItem OrderItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderItem = await _context.OrderItem
                .Include(o => o.Orders)
                .Include(o => o.Products).FirstOrDefaultAsync(m => m.OderItemId == id);

            if (OrderItem == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
