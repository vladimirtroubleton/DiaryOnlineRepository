using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiaryClassDataLayer.Models
{
    public class ClassModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Название класса")]
        public string ClassName { get; set; }
        public Guid ClassLeadId { get; set; }
    }
    public class ClassesNavigationModel
    {
        [Key]
        public int NavId { get; set; }
        public int ClassId { get; set; }
        public Guid UserId { get; set; }

    }
}
