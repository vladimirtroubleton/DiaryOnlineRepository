using AuthorizationClassLibrary.AuthModels;
using AuthorizationClassLibrary.SecurityUtils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationClassLibrary
{
    public class UsersContext : DbContext
    {
       public  DbSet<UserModel> UsersTable { get; set; }
       public DbSet<Role> Roles { get; set; }
        public UsersContext(DbContextOptions<UsersContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
      

            string adminPassword = PasswordHashUtil.GetHash("NikolyaLox1234"); ;

            // добавляем роли
            Role adminRole = new Role { Id = 1, Name = "admin", ViewName = "Администратор" };
            Role userRole = new Role { Id = 2, Name = "student", ViewName = "Ученик" };
            Role teacherRole = new Role { Id = 3, Name = "teacher", ViewName = "Учитель" };
            UserModel adminUser = new UserModel { Id = Guid.NewGuid(), Email = "kolyaKochetov@gmail.com", Login = "Admin", ActiveAccount = true,Password = adminPassword, RoleName = adminRole.Name,Name = "Nikolay", Surname = "Kochetov", RoleId = adminRole.Id };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole , teacherRole });
            modelBuilder.Entity<UserModel>().HasData(new UserModel[] { adminUser });
            base.OnModelCreating(modelBuilder);




        }
       
    }
}
