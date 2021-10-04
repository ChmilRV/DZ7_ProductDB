using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZ7_ProductDB.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public int Number { get; set; }
	}
}
