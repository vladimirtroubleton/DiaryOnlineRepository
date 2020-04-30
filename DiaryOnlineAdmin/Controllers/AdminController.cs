using System.Threading.Tasks;
using AuthorizationClassLibrary.AuthUtils;
using AuthorizationClassLibrary.AuthViewModels;

using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using AuthorizationClassLibrary.AuthModels;
using System;
using DiaryOnlineAdmin.Repositories;

namespace DiaryOnlineAdmin.Controllers
{
   
    public class AdminController : Controller
    {
        private readonly ILoginUtil loginUtil;
        private IUsersRepository usersRepository;

        public AdminController(ILoginUtil loginUtil, IUsersRepository usersRepository)
        {
            this.loginUtil = loginUtil;
            this.usersRepository = usersRepository;
        }

        [HttpGet]
        public IActionResult Login()
        {
       
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
       
            UserModel userLoginDataValidation = await loginUtil.GetUserByLoginData(loginModel);

            if (userLoginDataValidation!= null)
            {
                await Authenticate(userLoginDataValidation);

                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            return View(loginModel);
        }


        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult InfoForAdmin()
        {
            return View();
        }



        private async Task Authenticate(UserModel user)
        {
            
            var claims = new List<Claim>
            {
                 new Claim(ClaimsIdentity.DefaultNameClaimType, user.Id.ToString()),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.RoleName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        [Authorize]
        public async Task<IActionResult> OutUserAtSystem()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Admin");
        }
    }
}