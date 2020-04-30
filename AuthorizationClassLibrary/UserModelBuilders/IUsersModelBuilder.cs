using AuthorizationClassLibrary.AuthModels;
using AuthorizationClassLibrary.AuthViewModels;

namespace DiaryOnlineAdmin.ModelBuilders
{
    public interface IUsersModelBuilder
    {
        UserViewModel[] BuildUserViewModels(UserModel[] users);
        UserModel BuildUserModelbyRegisterModel(RegisterModel user);
        UserViewModel BuildUserViewModel(UserModel user);
    }
}