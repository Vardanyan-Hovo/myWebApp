using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using myWebApp.Models;
using myWebApp.Pages;
using myWebApp.Data;

namespace ManipulateImages.Pages
{
	public class InputImageModel : PageModel
    {
        private ImageContext _context;

        public InputImageModel(ImageContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public Image img;

        public void OnPostOne()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            //if (img != null) _context.Images.Add(img);
            //await _context.SaveChangesAsync();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (img != null) _context.Images.Add(img);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
