using AuthorizationClassLibrary.AuthViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiaryClassDataLayer.ViewModels
{
    public class ClassViewModel
    {
        public int ClassId { get; set; }
        [Display(Name ="Класс")]
         public string ClassName { get; set; }
        [Display(Name = "Классный руководитель")]
         public UserViewModel ClassLead { get; set; }

    }
}
