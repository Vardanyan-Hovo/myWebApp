using System.Linq;
using ManipulateImages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myWebApp.Models;

namespace myWebApp.Pages;


public class IndexModel : PageModel
{
    public List<Image> ImagesAll { get; set; }
    private readonly ILogger<IndexModel> _logger;
    private readonly myWebApp.Data.ImageContext _context;

    public IndexModel(ILogger<IndexModel> logger, myWebApp.Data.ImageContext context)
    {
        _logger = logger;
        _context= context;
    }

    public IActionResult OnGet()
    {

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        return RedirectToPage("./InputImage");
    }
}