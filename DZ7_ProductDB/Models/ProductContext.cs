using Microsoft.EntityFrameworkCore;

namespace DZ7_ProductDB.Models
{
	public partial class ProductContext : DbContext
	{
		public ProductContext()
		{
		}
		public ProductContext(DbContextOptions<ProductContext> options)
			: base(options)
		{
		}

		public virtual DbSet<Product> Product { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
