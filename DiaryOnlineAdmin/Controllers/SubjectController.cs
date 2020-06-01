using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiaryClassDataLayer.Models;
using DiaryClassDataLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DiaryOnlineAdmin.Controllers
{
    public class SubjectController : Controller
    {
        public ISubjectsRepository subjectsRepository;

        public SubjectController(ISubjectsRepository subjectsRepository)
        {
            this.subjectsRepository = subjectsRepository;
        }

        public IActionResult GetSubjects()
        {
            var subj = subjectsRepository.GetSubjects();
            return View("Subjects",subj);
        }
        [HttpGet]
        public IActionResult AddSubject()
        {
           
            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> AddSubject(SubjectModel subjectModel)
        {
            await subjectsRepository.CreateSubj(subjectModel);
            return RedirectToAction("GetSubjects");
        }
        [HttpGet]
        public async  Task<IActionResult> DeleteSubj(int id)
        {
            await subjectsRepository.RemoveSubj(id);
            return RedirectToAction("GetSubjects");
        }
    }
}