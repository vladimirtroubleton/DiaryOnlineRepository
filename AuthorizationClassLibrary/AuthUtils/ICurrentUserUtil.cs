using AuthorizationClassLibrary.AuthViewModels;
using System.Threading.Tasks;

namespace AuthorizationClassLibrary.AuthUtils
{
    public interface ICurrentUserUtil
    {
        Task<UserViewModel> UserCurrent(string Id);
    }
}