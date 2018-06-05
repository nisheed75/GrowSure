package md53050bbe22a07d573ff6ddbd895699ec3;


public class RoundOutlineProvider
	extends android.view.ViewOutlineProvider
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getOutline:(Landroid/view/View;Landroid/graphics/Outline;)V:GetGetOutline_Landroid_view_View_Landroid_graphics_Outline_Handler\n" +
			"";
		mono.android.Runtime.register ("GrowSure.Client.Android.Widgets.OutlineProviders.RoundOutlineProvider, GrowSure.Cleint.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RoundOutlineProvider.class, __md_methods);
	}


	public RoundOutlineProvider ()
	{
		super ();
		if (getClass () == RoundOutlineProvider.class)
			mono.android.TypeManager.Activate ("GrowSure.Client.Android.Widgets.OutlineProviders.RoundOutlineProvider, GrowSure.Cleint.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public RoundOutlineProvider (int p0)
	{
		super ();
		if (getClass () == RoundOutlineProvider.class)
			mono.android.TypeManager.Activate ("GrowSure.Client.Android.Widgets.OutlineProviders.RoundOutlineProvider, GrowSure.Cleint.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0 });
	}


	public void getOutline (android.view.View p0, android.graphics.Outline p1)
	{
		n_getOutline (p0, p1);
	}

	private native void n_getOutline (android.view.View p0, android.graphics.Outline p1);

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
