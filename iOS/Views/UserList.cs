using System;
using System.Collections.Generic;
using Core.ViewModel;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
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
            var source = new MvxSimpleTableViewSource(UserListTabView, "UserList", UserViewCell.Key);
            UserListTabView.RowHeight = 130;

            UserListTabView.Source = source;
      
            var set = this.CreateBindingSet<UserList, UserListViewModel>();
            set.Bind(source).To(vm => vm.UserList);
            set.Apply();

            UserListTabView.ReloadData();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

