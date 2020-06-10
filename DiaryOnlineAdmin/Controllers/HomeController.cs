using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AuthorizationClassLibrary.AuthModels;
using DiaryOnlineAdmin.Repositories;
using AuthorizationClassLibrary.AuthViewModels;
using System;
using DiaryOnlineAdmin.ModelBuilders;
using System.Threading.Tasks;
using DiaryOnlineAdmin.Utils;
using DiaryClassDataLayer.Repositories;
using DiaryClassDataLayer.Models;

namespace DiaryOnlineAdmin.Controllers
{
    [Authorize(Roles = "admin")]
    public class HomeController : Controller
    {
        private IUsersRepository usersRepository;

        private IUsersModelBuilder usersModelBuilder;

        private IAdministrationUsersUtil administrationUtil;
        private IInfoRepository infoRepository;

        public HomeController(IUsersRepository usersRepository, IUsersModelBuilder usersModelBuilder, IAdministrationUsersUtil administrationUtil, IInfoRepository infoRepository)
        {
            this.usersRepository = usersRepository;
            this.usersModelBuilder = usersModelBuilder;
            this.administrationUtil = administrationUtil;
            this.infoRepository = infoRepository;
        }

        private UserModel currentUser;




        public IActionResult Index()
        {
            UserCurrent();
            ViewBag.NonActiveUsers = usersModelBuilder.BuildUserViewModels(usersRepository.GetNonActiveUsers());
            return View(usersModelBuilder.BuildUserViewModels(usersRepository.GetActiveUsers()));

        }

        private Task UserCurrent()
        {
            currentUser = usersRepository.GetUserById(Guid.Parse(User.Identity.Name));
            return Task.CompletedTask;
        }

        [HttpGet]
        public IActionResult ActivateAccount(Guid userId)
        {
            var activatingUser = usersRepository.GetUserById(userId);
            administrationUtil.ActivateUser(activatingUser);
            return RedirectToAction("Index","Home");
            
        }

        [HttpGet]
        public IActionResult DeactivateAccount(Guid userId)
        {
            var activatingUser = usersRepository.GetUserById(userId);
            administrationUtil.DectivateUser(activatingUser);
            return RedirectToAction("Index", "Home");

        }

        [HttpGet]
        public IActionResult RemoveUser(Guid userId)
        {
            usersRepository.RemoveUser(usersRepository.GetUserById(userId));
            return RedirectToAction("Index", "Home");

        }

        [HttpGet]
        public IActionResult GetInfo()
        {
            return View(infoRepository.GetInformations());
        }

        [HttpGet]
        public IActionResult CreateInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateInfo( InformationModel information )
        {
            infoRepository.CreateInfo(information);
            return RedirectToAction("GetInfo");
        }

        [HttpGet]
        public IActionResult DeleteInfo(int id)
        {
            var deletingInfo = infoRepository.GetInformationById(id);
            infoRepository.DeleteInfo(deletingInfo);
            return RedirectToAction("GetInfo");
        }
    }
}