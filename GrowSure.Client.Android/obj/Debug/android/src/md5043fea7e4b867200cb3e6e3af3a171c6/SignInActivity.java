package md5043fea7e4b867200cb3e6e3af3a171c6;


public class SignInActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onStop:()V:GetOnStopHandler\n" +
			"";
		mono.android.Runtime.register ("GrowSure.Client.Android.Activities.SignInActivity, GrowSure.Cleint.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SignInActivity.class, __md_methods);
	}


	public SignInActivity ()
	{
		super ();
		if (getClass () == SignInActivity.class)
			mono.android.TypeManager.Activate ("GrowSure.Client.Android.Activities.SignInActivity, GrowSure.Cleint.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onStop ()
	{
		n_onStop ();
	}

	private native void n_onStop ();

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
