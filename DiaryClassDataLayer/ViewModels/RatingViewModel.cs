using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiaryClassDataLayer.ViewModels
{
    public class RatingViewModel
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        [Display(Name ="Название класса")]
        public string ClassName { get; set; }
        public int IdSubject { get; set; }
        [Display(Name = "Название предмета")]
        public string SubjectName { get; set; }

        public Guid StudentId { get; set; }
        [Display(Name = "Имя студента")]
        public string StudentName { get; set; }

        public Guid TeacherId { get; set; }
        [Display(Name = "Имя учителя")]
        public string TeacherName { get; set; }
        [Display(Name = "Оценка")]
        public int Rating { get; set; }

        [Display(Name = "Дата")]
        public string Date { get; set; }
    }
}
