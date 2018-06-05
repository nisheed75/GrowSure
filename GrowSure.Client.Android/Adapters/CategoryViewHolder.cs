using Android.Widget;
using GrowSure.Cleint.Android;

namespace GrowSure.Client.Android.Adapters
{
	public class CategoryViewHolder : Java.Lang.Object
	{
		public TextView Title { get; set; }

		public ImageView Icon { get; set; }

		public CategoryViewHolder (LinearLayout container)
		{
			Icon = container.FindViewById<ImageView> (Resource.Id.category_icon);
			Title = container.FindViewById<TextView> (Resource.Id.category_title);
		}
	}
}

