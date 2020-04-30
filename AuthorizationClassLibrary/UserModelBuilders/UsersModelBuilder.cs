using AuthorizationClassLibrary.AuthModels;
using AuthorizationClassLibrary.AuthViewModels;
using AuthorizationClassLibrary.Repositories;
using AuthorizationClassLibrary.SecurityUtils;
using Nancy.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiaryOnlineAdmin.ModelBuilders
{
    public class UsersModelBuilder : IUsersModelBuilder
    {
        private IRolesRepository rolesRepository;

        public UsersModelBuilder(IRolesRepository rolesRepository)
        {
            this.rolesRepository = rolesRepository;
        }

        Dictionary<string, string> RolesDictionary = new Dictionary<string, string>()
        {
            {"teacher", "Учитель"},
            {"student", "Ученик"},
            {"admin", "Админ"}

        };

        Dictionary<bool, string> UsersActive = new Dictionary<bool, string>()
        {
            {true, "Активен"},
            {false, "Неактивен"}

        };
        public UserViewModel[] BuildUserViewModels(UserModel[] users)
        {
            return users.Select(p => new UserViewModel { Id = p.Id,Login = p.Login, Email = p.Email, Name = p.Name, Surname = p.Surname, RoleName = RolesDictionary[p.RoleName] , Status = UsersActive[p.ActiveAccount] }).ToArray();
        }

        public UserViewModel BuildUserViewModel(UserModel user)
        {
            return new UserViewModel 
            {
                Id = user.Id,
                Login = user.Login,
                Email = user.Email,
                Name = user.Name,
                Surname = user.Surname,
                RoleName = RolesDictionary[user.RoleName],
                Status = UsersActive[user.ActiveAccount] 
            };

        }

        public UserModel BuildUserModelbyRegisterModel(RegisterModel user)
        {
            var roleCreatingUser = rolesRepository.GetRoleById(user.RoleId);

            return new UserModel
            {
                Id = Guid.NewGuid(),
                Login = user.Login,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Password = PasswordHashUtil.GetHash(user.Password),
                RoleId = roleCreatingUser.Id,
                RoleName = roleCreatingUser.Name

            };
        }

    }
}
