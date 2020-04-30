using AuthorizationClassLibrary.AuthViewModels;
using DiaryClassDataLayer.Models;
using DiaryClassDataLayer.ViewModels;
using System.Collections.Generic;

namespace DiaryClassDataLayer.ModelBuilders
{
    public interface IClassModelBuilder
    {
        ClassViewModel[] GetClassViewModels(ClassModel[] classModels);
        ClassViewModel GetClassViewModel(ClassModel classModels);
        NavigationViewModel getNavigationClassModel(ClassViewModel classModel , UserViewModel[] teachers , UserViewModel[] studens);

    }
}