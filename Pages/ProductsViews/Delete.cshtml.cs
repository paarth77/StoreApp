﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StoreApp.Data;
using StoreApp.Models;

namespace StoreApp.Pages.ProductsViews
{
    public class DeleteModel : PageModel
    {
        private readonly StoreApp.Data.StoreAppContext _context;

        public DeleteModel(StoreApp.Data.StoreAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Products Products { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Products = await _context.Products.FirstOrDefaultAsync(m => m.ProductId == id);

            if (Products == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Products = await _context.Products.FindAsync(id);

            if (Products != null)
            {
                _context.Products.Remove(Products);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
