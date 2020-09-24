using Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Service
{
    public interface IUserListService
    {
        IEnumerable<User> GetUserListFromApi();
    }
}
