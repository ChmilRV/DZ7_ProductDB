using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZ7_ProductDB.Models
{
	public partial class ProductContext: DbContext
	{
		//public ProductContext()
		//{
		//}
		public ProductContext(DbContextOptions<ProductContext> options)
			:base(options)
		{
		}

		public virtual DbSet<Product> Products { get; set; }


		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	if (!optionsBuilder.IsConfigured)
		//	{
		//	}
		//}

  //    protected override void OnModelCreating(ModelBuilder modelBuilder)
  //    {
  //       modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

  //       //modelBuilder.Entity<Product>(entity =>
  //       //{
  //       //   entity.HasKey(e => e.Id);

  //       //   entity.Property(e => e.Id).ValueGeneratedNever();

  //       //   entity.Property(e => e.Name).HasMaxLength(255);
  //       //});

  //       OnModelCreatingPartial(modelBuilder);
  //    }

  //    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

   }
}
