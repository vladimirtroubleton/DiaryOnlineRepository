using AuthorizationClassLibrary.AuthModels;

namespace AuthorizationClassLibrary.Repositories
{
    public interface IRolesRepository
    {
        Role GetRoleByRoleName(string roleName);
        Role[] GetRoles();

        Role GetRoleById(int id);
    }
}