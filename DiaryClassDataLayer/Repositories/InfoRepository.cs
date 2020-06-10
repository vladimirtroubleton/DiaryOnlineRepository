using DiaryClassDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiaryClassDataLayer.Repositories
{
    public class InfoRepository : IInfoRepository
    {
        DiaryContext context;

        public InfoRepository(DiaryContext context)
        {
            this.context = context;
        }

        public void CreateInfo(InformationModel model)
        {
            context.Info.Add(model);
            context.SaveChanges();
        }
        public void DeleteInfo(InformationModel model)
        {
            context.Info.Remove(model);
            context.SaveChanges();
        }

        public InformationModel GetInformationById(int id)
        {
            return context.Info.Find(id);
        }

        public InformationModel[] GetInformations()
        {
            return context.Info.OrderByDescending(x => x.Id).ToArray();
        }
    }
}
