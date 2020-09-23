using System;
using Core.ViewModel;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace iOS.Views
{
    public partial class UserList : MvxViewController<UserListViewModel>
    {
        public UserList() : base("UserList", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var set = CreateBindingSet();

            set.Bind(UserListTabView).To(vm => vm.UserList);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

