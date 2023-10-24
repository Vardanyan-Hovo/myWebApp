using Microsoft.EntityFrameworkCore;
namespace myWebApp.Data
{
   public class ImageContext : DbContext
   {
      public ImageContext(DbContextOptions<ImageContext> options) : base(options) 
	  { 
		  
	  }
      public DbSet<Models.Image>? Images { get; set; }
   }
}