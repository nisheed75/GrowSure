package md597b9959102970772ef8dc05a0fbb1207;


public class Player
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.os.Parcelable
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_InitializeCreator:()Lmd520b9005dcba2a6a663f06ab20fcc5130/Creator_1;:__export__\n" +
			"n_hashCode:()I:GetGetHashCodeHandler\n" +
			"n_describeContents:()I:GetDescribeContentsHandler:Android.OS.IParcelableInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_writeToParcel:(Landroid/os/Parcel;I)V:GetWriteToParcel_Landroid_os_Parcel_IHandler:Android.OS.IParcelableInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("GrowSure.Client.Android.Models.Player, GrowSure.Cleint.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Player.class, __md_methods);
	}


	public Player ()
	{
		super ();
		if (getClass () == Player.class)
			mono.android.TypeManager.Activate ("GrowSure.Client.Android.Models.Player, GrowSure.Cleint.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public Player (java.lang.String p0, java.lang.String p1, int p2)
	{
		super ();
		if (getClass () == Player.class)
			mono.android.TypeManager.Activate ("GrowSure.Client.Android.Models.Player, GrowSure.Cleint.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:GrowSure.Client.Android.Models.Avatar, GrowSure.Cleint.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0, p1, p2 });
	}

	public Player (android.os.Parcel p0)
	{
		super ();
		if (getClass () == Player.class)
			mono.android.TypeManager.Activate ("GrowSure.Client.Android.Models.Player, GrowSure.Cleint.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.OS.Parcel, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public static md520b9005dcba2a6a663f06ab20fcc5130.Creator_1 CREATOR = InitializeCreator ();

	public static md520b9005dcba2a6a663f06ab20fcc5130.Creator_1 InitializeCreator ()
	{
		return n_InitializeCreator ();
	}

	private static native md520b9005dcba2a6a663f06ab20fcc5130.Creator_1 n_InitializeCreator ();


	public int hashCode ()
	{
		return n_hashCode ();
	}

	private native int n_hashCode ();


	public int describeContents ()
	{
		return n_describeContents ();
	}

	private native int n_describeContents ();


	public void writeToParcel (android.os.Parcel p0, int p1)
	{
		n_writeToParcel (p0, p1);
	}

	private native void n_writeToParcel (android.os.Parcel p0, int p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
