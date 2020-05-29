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
using AuthorizationClassLibrary.AuthUtils;

namespace DiaryOnline.Controllers
{
    [Authorize(Roles ="teacher True, admin True, student True")]
    public class HomeController : Controller
    {
        private readonly IUsersRepository usersRepository;
        private readonly IUsersModelBuilder usersModelBuilder;
        private ICurrentUserUtil currentUtil;

        private UserViewModel currentUser;

        public HomeController(IUsersRepository usersRepository, IUsersModelBuilder usersModelBuilder, ICurrentUserUtil currentUtil)
        {
            this.usersRepository = usersRepository;
            this.usersModelBuilder = usersModelBuilder;
            this.currentUtil = currentUtil;
        }

        public async Task<IActionResult> Index()
        {

            currentUser =await currentUtil.UserCurrent(User.Identity.Name);
            ViewBag.CurrentUser = currentUser;
            return View();
        }

       

      

      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
