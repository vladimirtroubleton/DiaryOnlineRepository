using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AuthorizationClassLibrary.AuthViewModels
{
    public class RegisterModel
    {
        [Display(Name = "Логин")]
        [Required]
        [MinLengthAttribute(4)]
        [MaxLength(16)]
        public string Login { get; set; }
        [Display(Name = "Электронная почта")]
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [MinLengthAttribute(8)]
        [MaxLength(24)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }
        [Display(Name = "Ваш статус в образовательной организации")]
        [Required]
        public int RoleId { get; set; }
    }
}
