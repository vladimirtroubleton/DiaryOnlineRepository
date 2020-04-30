using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthorizationClassLibrary.AuthViewModels;
using DiaryClassDataLayer.ModelBuilders;
using DiaryClassDataLayer.Models;
using DiaryClassDataLayer.Repositories;
using DiaryOnlineAdmin.ModelBuilders;
using DiaryOnlineAdmin.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DiaryOnline.Controllers
{
    [Authorize(Roles = "teacher True, student True")]
    public class ClassesController : Controller
    {
        private IUsersRepository usersRepository;
        private IClassesRepository classesRepository;
        private IUsersModelBuilder usersModelBuilder;
        private IClassModelBuilder classModelBuilder;
        private UserViewModel currentUser;
        public ClassesController(IUsersRepository usersRepository, IClassesRepository classesRepository, IUsersModelBuilder usersModelBuilder, IClassModelBuilder classModelBuilder)
        {
            this.usersRepository = usersRepository;
            this.classesRepository = classesRepository;
            this.usersModelBuilder = usersModelBuilder;
            this.classModelBuilder = classModelBuilder;
        }

        public IActionResult Index()
        {
            UserCurrent();
            if (classesRepository.CheckClassAvaible(currentUser.Id))
            {
                switch (currentUser.RoleName) {
                    case "Учитель":
                        {
                            return View("TeacherClasses");
                        }
                    case "Ученик":
                        {
                            var classId = classesRepository.GetClassIdByUserId(currentUser.Id);
                            var classModel = classModelBuilder.GetClassViewModel(classesRepository.GetClassById(classId));
                            var classNavigationRecords = classesRepository.GetClassesNavigationModels(classId);
                            var usersModelsInClass = usersRepository.GetListUsersByIds(classNavigationRecords.Select(x => x.UserId).ToArray());

                            var usersViewModelsInClass = usersModelBuilder.BuildUserViewModels(usersModelsInClass);

                            var teachers = usersViewModelsInClass.Where(x => x.RoleName == "Учитель").ToArray();
                            var students = usersViewModelsInClass.Where(x => x.RoleName == "Ученик").ToArray();

                            var navigationModel = classModelBuilder.getNavigationClassModel(classModel, teachers, students);
                            return View("UserClass", navigationModel);

                        }
                    default:
                        {
                            return View("Err");
                        }
                }
            }
            else
            {
                var classes = classesRepository.GetClasses();

                return View(classModelBuilder.GetClassViewModels(classes));
            }
        }


        [Authorize(Roles = "teacher True")]
        [HttpGet]
        public IActionResult CreateClass()
        {
            return View();
        }
        [Authorize(Roles = "teacher True")]
        [HttpPost]
        public IActionResult CreateClass(ClassModel classModel)
        {
            classModel.ClassLeadId = Guid.Parse(User.Identity.Name);
            classesRepository.ClassCreate(classModel);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult AddUserToClass(int classId)
        {
           
            UserCurrent();
            classesRepository.ClassesNavigationRecordCreate(new ClassesNavigationModel { ClassId = classId , UserId = currentUser.Id });

            return RedirectToAction("Index");
        }


        private Task UserCurrent()
        {
            currentUser = usersModelBuilder.BuildUserViewModel(usersRepository.GetUserById(Guid.Parse(User.Identity.Name)));
            return Task.CompletedTask;
        }
    }
}