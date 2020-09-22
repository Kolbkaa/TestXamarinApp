using Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Service
{
    public interface IUserListService
    {
        Task<IEnumerable<User>> GetUserListFromApi();
    }
}
