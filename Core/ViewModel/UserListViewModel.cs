using Core.Model;
using Core.Service;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Core.ViewModel
{
    public class UserListViewModel : MvxViewModel
    {
        private readonly IUserListService _userListService;
        private readonly IMvxNavigationService _navigationService;

        private MvxObservableCollection<User> _userList;
        private ICommand _goToDetail;

        public ICommand GoToDetail
        {
            get
            {
                return _goToDetail = _goToDetail ?? new MvxCommand<User>(async user =>
                {
                    //var b = _navigationService.CanNavigate<DetailViewModel>();
                    await _navigationService.Navigate<DetailViewModel, User>(user);
                });
            }
        }

        public UserListViewModel(IUserListService userListService, IMvxNavigationService navigationService)
        {
            _userListService = userListService;
            _navigationService = navigationService;
        }
        public MvxObservableCollection<User> UserList
        {
            get => _userList; private set
            {
                _userList = value;
                RaisePropertyChanged(() => UserList);
            }
        }


        public override async Task Initialize()
        {
            await base.Initialize();

            UserList = new MvxObservableCollection<User>(_userListService.GetUserListFromApi());

        }
    }
}
