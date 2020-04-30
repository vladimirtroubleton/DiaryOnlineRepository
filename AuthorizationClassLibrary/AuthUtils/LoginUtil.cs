using AuthorizationClassLibrary.AuthModels;
using AuthorizationClassLibrary.AuthViewModels;
using AuthorizationClassLibrary.SecurityUtils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationClassLibrary.AuthUtils
{
    public class LoginUtil : ILoginUtil
    {
        private UsersContext context;

        public LoginUtil(UsersContext context)
        {
            this.context = context;
        }


        public async  Task<UserModel> GetUserByLoginData(LoginModel loginModel)
        {

            string hashPassword = PasswordHashUtil.GetHash(loginModel.Password);
            UserModel loggingUser = await context.UsersTable.FirstOrDefaultAsync(x => x.Login == loginModel.Login && x.Password == hashPassword) ;
           
            return loggingUser;
           
           
            
        }

       
    }
}
