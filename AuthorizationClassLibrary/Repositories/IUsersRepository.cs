using AuthorizationClassLibrary.AuthModels;
using System;

namespace DiaryOnlineAdmin.Repositories
{
    public interface IUsersRepository
    {
 
        void ChangeUserData(UserModel model);
        UserModel[] GetAllUsers();
        UserModel GetUserById(Guid userId);
        void RemoveUser(UserModel model);

        void CreateUser(UserModel user);

        UserModel[] GetTeachers();

        UserModel[] GetStudents();

        UserModel[] GetActiveUsers();

        UserModel[] GetNonActiveUsers();

        UserModel[] GetListUsersByIds(Guid[] ids);
        UserModel[] GetUsersbyRole(Guid[] ids , string Role);
    }
}