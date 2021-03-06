﻿using DiaryClassDataLayer.Models;
using System.Threading.Tasks;

namespace DiaryClassDataLayer.Repositories
{
    public interface ISubjectsRepository
    {
        Task CreateSubj(SubjectModel subject);
        SubjectModel[] GetSubjects();
        SubjectModel GetSubjectById(int id);
        Task RemoveSubj(int id);
    }
}