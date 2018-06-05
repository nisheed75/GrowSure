using GrowSure.Client.Android.Models;
using SQLite;

namespace GrowSure.Client.Android.Persistence
{
	[Table ("tasks")]
	public class QuizTable
	{
		[PrimaryKey, AutoIncrement]
		public int _id { get; set; }

        [NotNull]
        public Player Assignee { get; set; }

        [NotNull]
		public string Type { get; set; }

		[NotNull]
		public string Name { get; set; }

		[NotNull]
		public string Answer { get; set; }

		public string Options { get; set; }

		public string Min { get; set; }

		public string Max { get; set; }

		public string Step { get; set; }

		public string Start { get; set; }

		public string End { get; set; }

		public string Solved { get; set; }
	}
}

