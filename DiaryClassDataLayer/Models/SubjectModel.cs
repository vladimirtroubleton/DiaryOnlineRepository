using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiaryClassDataLayer.Models
{
    public class SubjectModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Название предмета")]
        [Required]
        [MinLength(5 , ErrorMessage ="Ну не бывает таких коротких названий предмета")]
        public string SubjectName { get; set; }
    }
}
