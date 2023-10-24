using System.Linq;
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

    public void OnGet()
    {
        foreach(var x in _context.Images)
        {
            ImagesAll.Add(x);
        }
    }
}