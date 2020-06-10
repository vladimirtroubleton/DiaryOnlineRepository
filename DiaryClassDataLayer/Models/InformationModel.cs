using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiaryClassDataLayer.Models
{
    public class InformationModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Заголовок")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Запись:")]
        public string Info { get; set; }
        [Required]
        [Display(Name = "Дата:")]
        public DateTime Date { get; set; }
    }
}
