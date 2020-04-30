using AuthorizationClassLibrary.AuthModels;
using AuthorizationClassLibrary.AuthViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuthorizationClassLibrary.ValidationUtils
{
    public class CheckDataUtils : ICheckDataUtils
    {
        private UsersContext context;

        public CheckDataUtils(UsersContext context)
        {
            this.context = context;
        }

        public bool CheckLoginAtFree(RegisterModel userRegModel)
        {
            return context.UsersTable.Select(x => x.Login).Contains(userRegModel.Login);
        }
    }
}
