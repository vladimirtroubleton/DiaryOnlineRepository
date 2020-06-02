using DiaryClassDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryClassDataLayer.Repositories
{
    public class SubjectsRepository : ISubjectsRepository
    {
        DiaryContext context;

        public SubjectsRepository(DiaryContext context)
        {
            this.context = context;
        }

        object locker = new object();

        public async Task CreateSubj(SubjectModel subject)
        {
            lock (locker)
            {
                context.Subjects.Add(subject);
            }

            await context.SaveChangesAsync();
        }


        public async Task RemoveSubj(int id)
        {
            var subj = await context.Subjects.FindAsync(id);
            lock (locker)
            {
                context.Subjects.Remove(subj);
            }

            await context.SaveChangesAsync();
        }

        public SubjectModel[] GetSubjects()
        {
            return context.Subjects.ToArray();
        }

        public SubjectModel GetSubjectById(int id)
        {
            return context.Subjects.Find(id);
        }
    }
}
