using Core.Service;
using Core.ViewModel;
using MvvmCross;
using MvvmCross.ViewModels;

namespace Core
{
    public class App:MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<IUserListService, UserListService>();
            RegisterAppStart<UserListViewModel>();
        }
    }
}
