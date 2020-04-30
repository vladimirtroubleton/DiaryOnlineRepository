using AuthorizationClassLibrary.AuthModels;
using AuthorizationClassLibrary.AuthUtils;
using AuthorizationClassLibrary.AuthViewModels;
using AuthorizationClassLibrary.Repositories;
using AuthorizationClassLibrary.ValidationUtils;
using DiaryOnlineAdmin.ModelBuilders;
using DiaryOnlineAdmin.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DiaryOnline.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILoginUtil loginUtil;
        private IUsersRepository usersRepository;
        private readonly ICheckDataUtils checkDataUtils;
        private readonly IUsersModelBuilder usersModelBuilder;
        private readonly IRolesRepository rolesRepository;

        public AccountController(ILoginUtil loginUtil, IUsersRepository usersRepository, ICheckDataUtils checkDataUtils, IUsersModelBuilder usersModelBuilder, IRolesRepository rolesRepository)
        {
            this.loginUtil = loginUtil;
            this.usersRepository = usersRepository;
            this.checkDataUtils = checkDataUtils;
            this.usersModelBuilder = usersModelBuilder;
            this.rolesRepository = rolesRepository;
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

                if (userLoginDataValidation != null)
                {
                    await Authenticate(userLoginDataValidation);

               
                    return RedirectToAction("Index", "Home");
                } 
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
                return View(loginModel);
            }

            [HttpGet]
            public IActionResult Register()
            {
                ViewBag.Roles = rolesRepository.GetRoles();
                return View();
            }
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Register(RegisterModel model)
            {
                if (ModelState.IsValid)
                {

                    if (!checkDataUtils.CheckLoginAtFree(model))
                    {
                        UserModel user = usersModelBuilder.BuildUserModelbyRegisterModel(model);

                        usersRepository.CreateUser(user);

                        await Authenticate(user); // аутентификация

                        
                        return RedirectToAction("Index", "Home");
                    }
                    else
                        ModelState.AddModelError("", "Такие данные уже использовались");
                }
                ViewBag.Roles = rolesRepository.GetRoles();
                return View(model);
            }
    



            private async Task Authenticate(UserModel user)
            {

                    var claims = new List<Claim>
                    {
                         new Claim(ClaimsIdentity.DefaultNameClaimType, user.Id.ToString()),
                        new Claim(ClaimsIdentity.DefaultRoleClaimType, user.RoleName +" "+user.ActiveAccount)
                    };
                    // создаем объект ClaimsIdentity
                    ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
       
               
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
            }


            [Authorize]
            public async Task<IActionResult> OutUserAtSystem()
            {
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                return RedirectToAction("Login", "Account");
            }

            public IActionResult ErrorMessage()
            {
                
                return View();
            }

    }
}
