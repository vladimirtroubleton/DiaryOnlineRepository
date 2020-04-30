using AuthorizationClassLibrary.AuthModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuthorizationClassLibrary.Repositories
{
    public class RolesRepository : IRolesRepository
    {
        private UsersContext context;

        public RolesRepository(UsersContext context)
        {
            this.context = context;
        }

        public Role GetRoleById(int id)
        {
            return context.Roles.Find(id);
        }

        public Role GetRoleByRoleName(string roleName)
        {
            return context.Roles.Where(x => x.Name == roleName).FirstOrDefault();
        }

        public Role[] GetRoles()
        {
            return context.Roles.ToArray();
        }
    }
}
