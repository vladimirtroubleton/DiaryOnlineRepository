using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiaryClassDataLayer.Models
{
    public class RatingModel
    {
        [Key]
        public int Id { get; set; }
        public int ClassId { get; set; }

        [Display(Name ="Выберите предмет")]
        public int IdSubject { get; set; }
     
        public Guid StudentId { get; set; }
        public Guid TeacherId { get; set; }
        [Display(Name = "Выберите оценку")]
        public int Rating { get; set; }
    }
}
