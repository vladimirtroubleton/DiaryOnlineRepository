using DiaryClassDataLayer.Models;

namespace DiaryClassDataLayer.Repositories
{
    public interface IInfoRepository
    {
        void CreateInfo(InformationModel model);
        void DeleteInfo(InformationModel model);
        InformationModel[] GetInformations();

        InformationModel GetInformationById(int id);
    }
}