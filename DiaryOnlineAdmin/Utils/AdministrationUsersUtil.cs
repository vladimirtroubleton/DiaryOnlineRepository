using AuthorizationClassLibrary;
using AuthorizationClassLibrary.AuthModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiaryOnlineAdmin.Utils
{
    public class AdministrationUsersUtil : IAdministrationUsersUtil
    {
        private UsersContext context;

        public AdministrationUsersUtil(UsersContext context)
        {
            this.context = context;
        }
        public void ActivateUser(UserModel user)
        {
            user.ActiveAccount = true;
            context.UsersTable.Update(user);
            context.SaveChanges();
        }

        public void DectivateUser(UserModel user)
        {
            user.ActiveAccount = false;
            context.UsersTable.Update(user);
            context.SaveChanges();
        }
    }
}
