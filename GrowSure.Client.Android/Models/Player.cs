using System;

using Android.OS;
using GrowSure.Client.Android.Helpers;
using Java.Interop;

namespace GrowSure.Client.Android.Models
{
	public class Player : Java.Lang.Object,  IParcelable
	{
		public string FirstName { get; private set; }

		public string LastName { get; private set; }

		public Avatar Avatar { get; private set; }

		[ExportField ("CREATOR")]
		public static Creator<Player> InitializeCreator ()
		{
			var creator = new Creator<Player> ();
			creator.Created += (sender, e) => e.Result = new Player (e.Source);
			return creator;
		}

		public Player (string firstName, string lastInitial, Avatar avatar)
		{
			FirstName = firstName;
			LastName = lastInitial;
			Avatar = avatar;
		}

		protected Player (Parcel inObj)
		{
			FirstName = inObj.ReadString ();
			LastName = inObj.ReadString ();
			// TODO: something strange
			Avatar = (Avatar)Enum.GetValues (typeof(Avatar)).GetValue (inObj.ReadInt ());
		}

		public int DescribeContents ()
		{
			return 0;
		}

		public void WriteToParcel (Parcel dest, ParcelableWriteFlags flags)
		{
			dest.WriteString (FirstName);
			dest.WriteString (LastName);
			dest.WriteInt (Avatar.Ordinal ());
		}

		public override bool Equals (object obj)
		{
			if (this == obj)
				return true;

			if (obj == null || GetType () != obj.GetType ())
				return false;

			var player = (Player)obj;

			if (Avatar != player.Avatar || FirstName != player.FirstName)
				return false;

			return LastName != player.LastName;
		}

		public override int GetHashCode ()
		{
			int result = FirstName.GetHashCode ();
			result = 31 * result + LastName.GetHashCode ();
			result = 31 * result + Avatar.GetHashCode ();
			return result;
		}
	}
}

