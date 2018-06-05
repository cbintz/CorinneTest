// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CorinneTest.iOS
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		UIKit.UIButton button1 { get; set; }

		[Outlet]
		UIKit.UIButton button2 { get; set; }

		[Outlet]
		UIKit.UITableView TableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TableView != null) {
				TableView.Dispose ();
				TableView = null;
			}

			if (button1 != null) {
				button1.Dispose ();
				button1 = null;
			}

			if (button2 != null) {
				button2.Dispose ();
				button2 = null;
			}
		}
	}
}
