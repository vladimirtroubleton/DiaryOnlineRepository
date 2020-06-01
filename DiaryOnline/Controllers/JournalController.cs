using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiaryClassDataLayer.Models;
using DiaryClassDataLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DiaryOnline.Controllers
{
    public class JournalController : Controller
    {
        private ISubjectsRepository subjectsRepository;

        public JournalController(ISubjectsRepository subjectsRepository)
        {
            this.subjectsRepository = subjectsRepository;
        }

        [HttpGet]
        public IActionResult AddRating(Guid userId , Guid teacherId , int classId)
        {
            ViewBag.Subject = subjectsRepository.GetSubjects();
            return View(new RatingModel { StudentId = userId , TeacherId = teacherId , ClassId = classId});
        }

        [HttpPost]
        public IActionResult AddRating(RatingModel ratingModel)
        {
            var urlForRedirect = string.Format("/Classes/GetTeacherClass?сlassId={0}",ratingModel.ClassId);
            return Redirect(urlForRedirect);
        }
    }
}