// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace iOS.Views
{
	[Register ("UserList")]
	partial class UserList
	{
		[Outlet]
		UIKit.UITableView UserListTabView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (UserListTabView != null) {
				UserListTabView.Dispose ();
				UserListTabView = null;
			}
		}
	}
}
