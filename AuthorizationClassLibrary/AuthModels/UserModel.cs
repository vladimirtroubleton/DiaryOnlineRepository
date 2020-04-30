using DiaryOnlineAdmin.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationClassLibrary.AuthModels
{
    public class UserModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool ActiveAccount { get; set; }
        public int? RoleId { get; set; }
        public string RoleName { get; set; }
    }

    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ViewName { get; set; }
        public List<UserModel> Users { get; set; }
        public Role()
        {
            Users = new List<UserModel>();
        }
    }
}
