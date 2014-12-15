using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FeedbackGiver.Models;

namespace FeedbackGiver.DataAccessLayer
{
	public class ModelContext : DbContext
	{
		public ModelContext() : base("DefaultConnection") { }

		public DbSet<Feedback> Feedbacks { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}