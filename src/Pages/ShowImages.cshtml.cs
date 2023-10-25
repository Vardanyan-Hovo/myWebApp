using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myWebApp.Models;
using myWebApp.Pages;

namespace ManipulateImages.Pages
{
	public class ShowImagesModel : PageModel
    {
        public List<Image> ImagesAll { get; set; }
        private readonly ILogger<IndexModel> _logger;
        private readonly myWebApp.Data.ImageContext _context;

        public ShowImagesModel(ILogger<IndexModel> logger, myWebApp.Data.ImageContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Image? img { get; set; }

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
