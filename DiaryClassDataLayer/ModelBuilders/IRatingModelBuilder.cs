using DiaryClassDataLayer.Models;
using DiaryClassDataLayer.ViewModels;

namespace DiaryClassDataLayer.ModelBuilders
{
    public interface IRatingModelBuilder
    {
        RatingViewModel CreateViewModel(RatingModel rating);
        RatingViewModel[] CreateViewModels(RatingModel[] ratings);
    }
}