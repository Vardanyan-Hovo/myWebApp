using System;
namespace myWebApp.Models
{
	public class Image
	{
        internal object imagUrl;

        public int ID { get; internal set; }

		public class Student
		{
			public int ID { get; set; }
			public string imagUrl { get; set; }
			public int size { get; set; }
            public double radius { get; set; }
			public int effects { get; set; }
            public DateTime EnrollmentDate { get; set; }
		}
	}
}

