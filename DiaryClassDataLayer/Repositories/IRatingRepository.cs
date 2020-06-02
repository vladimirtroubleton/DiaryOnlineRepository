using DiaryClassDataLayer.Models;
using System;
using System.Threading.Tasks;

namespace DiaryClassDataLayer.Repositories
{
    public interface IRatingRepository
    {
        Task AddRating(RatingModel ratingModel);
        Task<RatingModel[]> GetRatings();
        Task<RatingModel[]> GetRatingsByStudentId(Guid id);
        Task<RatingModel[]> GetRatingsByTeacherId(Guid id);
        Task RemoveRating(RatingModel ratingModel);
    }
}