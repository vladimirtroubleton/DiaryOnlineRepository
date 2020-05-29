using AuthorizationClassLibrary.AuthModels;
using AuthorizationClassLibrary.AuthViewModels;
using DiaryOnlineAdmin.ModelBuilders;
using DiaryOnlineAdmin.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationClassLibrary.AuthUtils
{
    public class CurrentUserUtil : ICurrentUserUtil
    {
        private readonly IUsersRepository usersRepository;
        private readonly IUsersModelBuilder usersModelBuilder;

        public CurrentUserUtil(IUsersRepository usersRepository, IUsersModelBuilder usersModelBuilder)
        {
            this.usersRepository = usersRepository;
            this.usersModelBuilder = usersModelBuilder;
        }

        public Task<UserViewModel> UserCurrent(string Id)
        {

            return Task.FromResult(usersModelBuilder.BuildUserViewModel(usersRepository.GetUserById(Guid.Parse(Id))));
        }
    }
}
