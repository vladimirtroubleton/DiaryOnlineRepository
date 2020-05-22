using DiaryClassDataLayer.Models;
using System;

namespace DiaryClassDataLayer.Repositories
{
    public interface IClassesRepository
    {
        void ClassCreate(ClassModel model);
        void ClassesNavigationRecordCreate(ClassesNavigationModel model);
        void ClassesNavigationRecordRemove(ClassesNavigationModel model);
        void ClassRemove(ClassModel model);
        int GetCountClassUsers(int classId);
        bool CheckClassAvaible(Guid id);

        ClassModel GetClassById(int id);

        int GetClassIdByUserId(Guid id);

        int[] GetClassesIdsByUserId(Guid id);
        ClassModel[] GetClasses();
        ClassesNavigationModel[] GetClassesNavigationModels(int classId);

    }
}