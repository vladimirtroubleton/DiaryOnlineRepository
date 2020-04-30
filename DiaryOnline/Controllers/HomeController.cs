using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DiaryOnline.Models;
using Microsoft.AspNetCore.Authorization;
using AuthorizationClassLibrary.AuthModels;
using DiaryOnlineAdmin.Repositories;
using DiaryOnlineAdmin.ModelBuilders;
using AuthorizationClassLibrary.AuthViewModels;

namespace DiaryOnline.Controllers
{
    [Authorize(Roles ="teacher True, admin True, student True")]
    public class HomeController : Controller
    {
        private readonly IUsersRepository usersRepository;
        private readonly IUsersModelBuilder usersModelBuilder;

        private UserViewModel currentUser;
        public HomeController(IUsersRepository usersRepository , IUsersModelBuilder usersModelBuilder) 
        {
            this.usersRepository = usersRepository;
            this.usersModelBuilder = usersModelBuilder;
        }

        
      

        public IActionResult Index()
        {
           
            UserCurrent();
            ViewBag.CurrentUser = currentUser;
            return View();
        }

        public IActionResult Profile()
        {
            UserCurrent();
            return View(currentUser);
        }

      

        private Task UserCurrent()
        {
            currentUser =usersModelBuilder.BuildUserViewModel(usersRepository.GetUserById(Guid.Parse(User.Identity.Name)));
            return Task.CompletedTask;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
