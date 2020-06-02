using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiaryClassDataLayer.ModelBuilders;
using DiaryClassDataLayer.Models;
using DiaryClassDataLayer.Repositories;
using DiaryClassDataLayer.ViewModels;
using DiaryOnlineAdmin.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DiaryOnline.Controllers
{
    [Authorize]
    public class JournalController : Controller
    {
        private ISubjectsRepository subjectsRepository;
        private IRatingRepository ratingRepository;
        private IUsersRepository usersRepository;
        private IClassesRepository classesRepository;
        private IRatingModelBuilder ratingModelBuilder;

        public JournalController(ISubjectsRepository subjectsRepository, IRatingRepository ratingRepository, IUsersRepository usersRepository, IClassesRepository classesRepository, IRatingModelBuilder ratingModelBuilder)
        {
            this.subjectsRepository = subjectsRepository;
            this.ratingRepository = ratingRepository;
            this.usersRepository = usersRepository;
            this.classesRepository = classesRepository;
            this.ratingModelBuilder = ratingModelBuilder;
        }

        [HttpGet]
        public IActionResult AddRating(Guid userId , Guid teacherId , int classId)
        {
            ViewBag.Subject = subjectsRepository.GetSubjects();
            return View(new RatingModel { StudentId = userId , TeacherId = teacherId , ClassId = classId});
        }

        [HttpPost]
        public async Task<IActionResult> AddRating(RatingModel ratingModel)
        {
            var urlForRedirect = string.Format("/Classes/GetTeacherClass?сlassId={0}",ratingModel.ClassId);
            ratingModel.Date = DateTime.Today;
            await ratingRepository.AddRating(ratingModel);

            return Redirect(urlForRedirect);
        }
        [HttpGet]
        
        public async Task<IActionResult> GetRatings(Guid userId)
        {
            RatingModel[] ratings = null;
            RatingViewModel[] ratingViews = null;
            var userByRatingGet = usersRepository.GetUserById(userId);
            try{

            
                switch (userByRatingGet.RoleName)
                {
                    case "teacher":
                        {
                            ratings= await ratingRepository.GetRatingsByTeacherId(userId);
                            ratingViews = ratingModelBuilder.CreateViewModels(ratings);
                            return View("TeacherRating", ratingViews);
                        }
                    case "student":
                        {
                            ratings = await ratingRepository.GetRatingsByStudentId(userId);
                            ratingViews = ratingModelBuilder.CreateViewModels(ratings);
                            return View("UserRating" , ratingViews);
                        }
                }
            }
            catch (Exception ex)
            {
                return View();
            }


            return View();
        }

        
    }
}