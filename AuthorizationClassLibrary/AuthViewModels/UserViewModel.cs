using AuthorizationClassLibrary.AuthModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationClassLibrary.AuthViewModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        [Display(Name ="Логин")]
        public string Login { get; set; }
        [Display(Name = "Электронная почта")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        public string Surname { get; set; }  
        [Display(Name = "Роль")]
        public string RoleName { get; set; }
        [Display(Name = "Статус аккаунта")]
        public string Status { get; set; }
    }
}
