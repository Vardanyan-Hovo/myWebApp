using System;
using System.ComponentModel.DataAnnotations;
using ManipulateImages.Data;

namespace myWebApp.Models
{
	public class Image
	{
		[Key]
		public int ID { get; set; }
		public string? imagUrl { get; set; }
		public int size { get; set; }
        public double radius { get; set; }
        public DateTime DateAdded { get; set; }
		public List<string>? effect;
	}
}

