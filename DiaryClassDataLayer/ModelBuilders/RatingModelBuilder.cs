using DiaryClassDataLayer.Models;
using DiaryClassDataLayer.Repositories;
using DiaryClassDataLayer.ViewModels;
using DiaryOnlineAdmin.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiaryClassDataLayer.ModelBuilders
{
    public class RatingModelBuilder : IRatingModelBuilder
    {
        private ISubjectsRepository subjectsRepository;
        private IRatingRepository ratingRepository;
        private IUsersRepository usersRepository;
        private IClassesRepository classesRepository;

        public RatingModelBuilder(ISubjectsRepository subjectsRepository, IRatingRepository ratingRepository, IUsersRepository usersRepository, IClassesRepository classesRepository)
        {
            this.subjectsRepository = subjectsRepository;
            this.ratingRepository = ratingRepository;
            this.usersRepository = usersRepository;
            this.classesRepository = classesRepository;
        }

        public RatingViewModel[] CreateViewModels(RatingModel[] ratings)
        {
            List<RatingViewModel> ratingModels = new List<RatingViewModel>();
            foreach (var rating in ratings)
            {
                var teacher = usersRepository.GetUserById(rating.TeacherId);
                var user = usersRepository.GetUserById(rating.StudentId);

                ratingModels.Add(new RatingViewModel
                {
                    Id = rating.Id,
                    ClassId = rating.ClassId,
                    ClassName = classesRepository.GetClassById(rating.ClassId).ClassName,
                    IdSubject = rating.IdSubject,
                    SubjectName = subjectsRepository.GetSubjectById(rating.IdSubject).SubjectName,
                    StudentId = user.Id,
                    StudentName = user.Name + " " + user.Surname,
                    TeacherId = teacher.Id,
                    TeacherName = teacher.Name + " " + teacher.Surname,
                    Rating = rating.Rating,
                     Date= rating.Date.ToString("MM/dd/yyyy")

                });
            }
            return ratingModels.OrderBy(x=> x.Id).ToArray();

        }

        public RatingViewModel CreateViewModel(RatingModel rating)
        {
            var teacher = usersRepository.GetUserById(rating.TeacherId);
            var user = usersRepository.GetUserById(rating.StudentId);

            return new RatingViewModel
            {
                Id = rating.Id,
                ClassId = rating.ClassId,
                ClassName = classesRepository.GetClassById(rating.ClassId).ClassName,
                IdSubject = rating.IdSubject,
                SubjectName = subjectsRepository.GetSubjectById(rating.IdSubject).SubjectName,
                StudentId = user.Id,
                StudentName = user.Name + " " + user.Surname,
                TeacherId = teacher.Id,
                TeacherName = teacher.Name + " " + teacher.Surname,
                Rating = rating.Rating
            };
        }
    }
}
