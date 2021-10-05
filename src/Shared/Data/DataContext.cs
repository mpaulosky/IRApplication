using IR.Shared.Models;

using Microsoft.EntityFrameworkCore;

namespace IR.Shared.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}

		public DbSet<Issue> Issues { get; set; }
		public DbSet<Response> Responses { get; set; }
		public DbSet<Comment> Comments { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<Issue>().HasData(
			//	new Issue()
			//	{
			//		Id = 1,
			//		IssueDescription = "Electronic Items",
			//		InitiatorName = "Matthew",
			//		InitiatorId = Guid.NewGuid().ToString(),
			//	},
			//	new Issue()
			//	{
			//		Id = 2,
			//		IssueDescription = "Dresses",
			//		InitiatorName = "Matthew",
			//		InitiatorId = Guid.NewGuid().ToString(),
			//	},
			//	new Issue()
			//	{
			//		Id = 3,
			//		IssueDescription = "Grocery Items",
			//		InitiatorName = "Matthew",
			//		InitiatorId = Guid.NewGuid().ToString(),
			//	});
		}
	}
}