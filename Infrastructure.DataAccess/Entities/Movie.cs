using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.Entities
{
    public class Movie
    {
		public int id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public bool isAvaliable { get; set; }
		public int duration { get; set; }
		
		public DateTime availableDate { get; set; }
		public int classificationId { get; set; }

	}
}
