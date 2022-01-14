package crc64be8929a8e3f1e3b6;


public class AgregarPage
	extends crc64a5a37c43dff01024.Page
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("UNOUI.Pages.AgregarPage, UNOUI.Droid", AgregarPage.class, __md_methods);
	}


	public AgregarPage (android.content.Context p0)
	{
		super (p0);
		if (getClass () == AgregarPage.class)
			mono.android.TypeManager.Activate ("UNOUI.Pages.AgregarPage, UNOUI.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
