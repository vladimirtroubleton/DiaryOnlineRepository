using DiaryClassDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiaryClassDataLayer.Repositories
{
    public class ClassesRepository : IClassesRepository
    {
        private DiaryContext context;

        public ClassesRepository(DiaryContext context)
        {
            this.context = context;
        }

        public ClassModel[] GetClasses()
        {
            return context.Classes.ToArray();
        }

        public void ClassCreate(ClassModel model)
        {
            context.Classes.Add(model);
            context.SaveChanges();
        }
        public void ClassRemove(ClassModel model)
        {
            context.Classes.Add(model);
            context.SaveChanges();
        }

        public ClassModel GetClassById(int id)
        {
            return context.Classes.Find(id);
        }

        public ClassesNavigationModel[] GetClassesNavigationModels(int classId)
        {
            return context.ClassesNavigation.Where(x => x.ClassId == classId).ToArray();
        }


        public void ClassesNavigationRecordCreate(ClassesNavigationModel model)
        {
            context.ClassesNavigation.Add(model);
            context.SaveChanges();
        }
        public void ClassesNavigationRecordRemove(ClassesNavigationModel model)
        {
            context.ClassesNavigation.Add(model);
            context.SaveChanges();
        }

        public int GetCountClassUsers(int classId)
        {
            return context.ClassesNavigation.Where(x => x.ClassId == classId).Count();
        }

        public bool CheckClassAvaible(Guid id)
        {
           return context.ClassesNavigation.Select(x => x.UserId).Contains(id);
        }

        public int GetClassIdByUserId(Guid id)
        {
            return context.ClassesNavigation.Where(x => x.UserId == id).Select(x => x.ClassId).First();
        }

        public int[] GetClassesIdsByUserId(Guid id)
        {
            return context.ClassesNavigation.Where(x => x.UserId == id).Select(x => x.ClassId).ToArray();
        }
    }
}
