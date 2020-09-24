using System;
using Core.Model;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using UIKit;

namespace iOS.Views
{
    public partial class UserViewCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString(nameof(UserViewCell));
        public static readonly UINib Nib = UINib.FromName(nameof(UserViewCell), NSBundle.MainBundle);


        protected UserViewCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<UserViewCell, User>();
                set.Bind(UserName).To(user => user.Name);
                set.Apply();
            });
        }
    }
}
