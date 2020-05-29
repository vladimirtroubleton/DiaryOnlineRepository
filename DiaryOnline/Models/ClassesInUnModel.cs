using DiaryClassDataLayer.Models;
using DiaryClassDataLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiaryOnline.Models
{
    public class ClassesInUnModel
    {
        public ClassViewModel[] InClass { get; set; }
        public ClassViewModel[] UnClass { get; set; }
    }
}
