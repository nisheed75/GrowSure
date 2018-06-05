using SQLite;

namespace GrowSure.Client.Android.Persistence
{
	[Table ("category")]
	public class CategoryTable
	{
		[PrimaryKey]
		public string Id { get; set; }

		[NotNull]
		public string Name { get; set; }

		[NotNull]
		public string Theme { get; set; }
	}
}

