using AuthorizationClassLibrary.AuthModels;
using AuthorizationClassLibrary.AuthViewModels;
using System.Threading.Tasks;

namespace AuthorizationClassLibrary.AuthUtils
{
    public interface ILoginUtil
    {
         Task<UserModel> GetUserByLoginData(LoginModel loginModel);
    }
}