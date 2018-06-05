using System.Collections.Generic;

using Android.OS;

using Java.Interop;
using GrowSure.Client.Android.Helpers;

namespace GrowSure.Client.Android.Models
{
    public class Category : Java.Lang.Object, IParcelable
	{
		
		public const string TAG = "Category";

		public string Name { get; private set; }

		public string Id { get; private set; }

		public Theme Theme { get; private set; }

	


		[ExportField ("CREATOR")]
		public static Creator<Category> InitializeCreator ()
		{
			var creator = new Creator<Category> ();
			creator.Created += (sender, e) => e.Result = new Category (e.Source);
			return creator;
		}

		public Category (string name, string id, Theme theme)
		{
			Name = name;
			Id = id;
			Theme = theme;
			
		}

		protected Category (Parcel inObj)
		{
			Name = inObj.ReadString ();
			Id = inObj.ReadString ();
			//TODO
//			Theme = (Theme)System.Enum.GetValues ()inObj.ReadInt ();
		
		}



		public override string ToString ()
		{
			return string.Format ("Category{name=\'{0}\', id=\'{1}\', theme={2} }", Name, Id, Theme );
		}

		public int DescribeContents ()
		{
			return 0;
		}

		public void WriteToParcel (Parcel dest, ParcelableWriteFlags flags)
		{
			dest.WriteString (Name);
			dest.WriteString (Id);
			dest.WriteInt (Theme.Ordinal ());
			
		}

		public override bool Equals (object obj)
		{
			if (this == obj)
				return true;

			if (obj == null || GetType () != obj.GetType ())
				return false;

			var category = (Category)obj;

			return Theme == category.Theme;
		}

		public override int GetHashCode ()
		{
			int result = Name.GetHashCode ();
			result = 31 * result + Id.GetHashCode ();
			result = 31 * result + Theme.GetHashCode ();
			return result;
		}
	}
}

