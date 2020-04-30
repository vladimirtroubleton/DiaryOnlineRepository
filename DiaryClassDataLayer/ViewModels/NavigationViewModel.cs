using AuthorizationClassLibrary.AuthViewModels;
using DiaryClassDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassDataLayer.ViewModels
{
   public class NavigationViewModel
    {
        public ClassViewModel Class { get; set; }
        public UserViewModel[] UsersInClass { get; set; }
        public UserViewModel[] TeachersInClassInClass { get; set; }
    }
}
