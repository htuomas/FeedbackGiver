using FeedbackGiver.Models;

namespace FeedbackGiver.DataAccessLayer
{
	public class ContextInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ModelContext>
	{
		protected override void Seed(ModelContext context)
		{
			var feedbacks = new[]
			{
				new Feedback {Id = 1, Topic = "Topic", Text = "Text is here."},
				new Feedback {Id = 2, Topic = "Foobar", Text = "Foo the to bar."},
				new Feedback {Id = 3, Topic = "Asdf", Text = "ASdf."}
			};

			foreach (var feedback in feedbacks)
			{
				context.Feedbacks.Add(feedback);
			}

			context.SaveChanges();
		}
	}
}