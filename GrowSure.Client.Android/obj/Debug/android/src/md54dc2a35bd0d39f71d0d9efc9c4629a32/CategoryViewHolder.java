package md54dc2a35bd0d39f71d0d9efc9c4629a32;


public class CategoryViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("GrowSure.Client.Android.Adapters.CategoryViewHolder, GrowSure.Cleint.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CategoryViewHolder.class, __md_methods);
	}


	public CategoryViewHolder ()
	{
		super ();
		if (getClass () == CategoryViewHolder.class)
			mono.android.TypeManager.Activate ("GrowSure.Client.Android.Adapters.CategoryViewHolder, GrowSure.Cleint.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public CategoryViewHolder (android.widget.LinearLayout p0)
	{
		super ();
		if (getClass () == CategoryViewHolder.class)
			mono.android.TypeManager.Activate ("GrowSure.Client.Android.Adapters.CategoryViewHolder, GrowSure.Cleint.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Widget.LinearLayout, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

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
