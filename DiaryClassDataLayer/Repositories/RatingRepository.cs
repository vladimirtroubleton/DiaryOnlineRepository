using DiaryClassDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryClassDataLayer.Repositories
{
    public class RatingRepository : IRatingRepository
    {
        DiaryContext context;

        object locker = new object();
        public RatingRepository(DiaryContext context)
        {
            this.context = context;
        }

        public async Task AddRating(RatingModel ratingModel)
        {
            lock (locker)
            {
                context.Ratings.Add(ratingModel);
            }
            await context.SaveChangesAsync();
        }

        public async Task RemoveRating(RatingModel ratingModel)
        {
            lock (locker)
            {
                context.Ratings.Remove(ratingModel);
            }
            await context.SaveChangesAsync();
        }

        public Task<RatingModel[]> GetRatingsByStudentId(Guid id)
        {
            return Task.FromResult(context.Ratings.Where(x => x.StudentId == id).ToArray());
        }

        public Task<RatingModel[]> GetRatingsByTeacherId(Guid id)
        {
            return Task.FromResult(context.Ratings.Where(x => x.TeacherId == id).ToArray());
        }

        public Task<RatingModel[]> GetRatings()
        {
            return Task.FromResult(context.Ratings.ToArray());
        }

    }
}
