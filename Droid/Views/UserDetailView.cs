
using Android.App;
using Android.OS;
using AndroidX.AppCompat.Widget;
using Core.ViewModel;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;


namespace Droid.Views
{
    [MvxActivityPresentation]
    [Activity(Label = "User Detail", MainLauncher = false)]
    class UserDetailView : MvxActivity<DetailViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.user_detail);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetDisplayShowHomeEnabled(true);
        }
        public override bool OnSupportNavigateUp()
        {
            OnBackPressed();
            return true;
        }
    }
}