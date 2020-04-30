using AuthorizationClassLibrary;
using AuthorizationClassLibrary.AuthModels;
using AuthorizationClassLibrary.SecurityUtils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiaryOnlineAdmin.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly UsersContext context;

        public UsersRepository(UsersContext context)
        {
            this.context = context;
        }

        public UserModel[] GetAllUsers()
        {
            return context.UsersTable.ToArray();
        }

        public UserModel GetUserById(Guid userId)
        {
            return context.UsersTable.Find(userId);
        }

        public void ChangeUserData(UserModel model)
        {
            context.Entry(model).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void RemoveUser(UserModel model)
        {
            context.UsersTable.Remove(model);
            context.SaveChanges();
        }

      

        public void CreateUser(UserModel user)
        {
           
            context.UsersTable.Add(user);
            context.SaveChanges();
        }

        public UserModel[] GetTeachers()
        {
           return context.UsersTable.Where(x => x.RoleName == "teacher").ToArray();
        }

        public UserModel[] GetStudents()
        {
            return context.UsersTable.Where(x => x.RoleName == "student").ToArray();
        }

        public UserModel[] GetActiveUsers()
        {
           return context.UsersTable.Where(x => x.ActiveAccount == true).ToArray();
        }

        public UserModel[] GetNonActiveUsers()
        {
            return context.UsersTable.Where(x => x.ActiveAccount == false).ToArray();
        }

        public UserModel[] GetListUsersByIds(Guid[] ids)
        {
            List<UserModel> userModels = new List<UserModel>();
            foreach(var id in ids)
            {
                userModels.Add(context.UsersTable.Find(id));
            }
            return userModels.ToArray();
        }

        public UserModel[] GetUsersbyRole(Guid[] ids , string Role)
        {
            List<UserModel> userModels = new List<UserModel>();
            foreach (var id in ids)
            {
                userModels.Add(context.UsersTable.Where(x=> x.RoleName == Role && x.Id == id).FirstOrDefault());
            }
            return userModels.ToArray();
        }
    }
}
