using Android.App;
using Android.OS;
using AndroidX.AppCompat.Widget;
using Core.ViewModel;
using MvvmCross.Platforms.Android.Views;

namespace Droid.Views
{
    [Activity(Label = "User List", MainLauncher = true)]
    class UserListView : MvxActivity<UserListViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.UserList);


            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayShowHomeEnabled(true);
        }
    }
}