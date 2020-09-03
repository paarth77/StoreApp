using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StoreApp.Data;
using StoreApp.Models;

namespace StoreApp.Pages.OrdersViews
{
    public class IndexModel : PageModel
    {
        private readonly StoreApp.Data.StoreAppContext _context;

        public IndexModel(StoreApp.Data.StoreAppContext context)
        {
            _context = context;
        }

        public IList<Orders> Orders { get;set; }

        public async Task OnGetAsync()
        {
            Orders = await _context.Orders
                .Include(o => o.Customer).ToListAsync();
        }
    }
}
