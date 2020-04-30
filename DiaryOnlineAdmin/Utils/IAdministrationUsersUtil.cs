using AuthorizationClassLibrary.AuthModels;

namespace DiaryOnlineAdmin.Utils
{
    public interface IAdministrationUsersUtil
    {
        void ActivateUser(UserModel user);
        void DectivateUser(UserModel user);
    }
}