using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AuthorizationClassLibrary.AuthViewModels
{
    public class LoginModel
    {
        [Display(Name = "Логин")]
        [Required]
        [MinLengthAttribute(4)]
        [MaxLength(16)]
        public string Login { get; set; }
        [Required]
        [PasswordPropertyText]
        [MinLengthAttribute(8)]
        [MaxLength(32)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}
