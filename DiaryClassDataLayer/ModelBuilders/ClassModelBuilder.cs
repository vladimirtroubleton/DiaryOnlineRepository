using AuthorizationClassLibrary.AuthViewModels;
using DiaryClassDataLayer.Models;
using DiaryClassDataLayer.ViewModels;
using DiaryOnlineAdmin.ModelBuilders;
using DiaryOnlineAdmin.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiaryClassDataLayer.ModelBuilders
{
    public class ClassModelBuilder : IClassModelBuilder
    {
        private IUsersRepository usersRepository;
        private IUsersModelBuilder usersModelBuilder;

        public ClassModelBuilder(IUsersRepository usersRepository, IUsersModelBuilder usersModelBuilder)
        {
            this.usersRepository = usersRepository;
            this.usersModelBuilder = usersModelBuilder;
        }

        public ClassViewModel[] GetClassViewModels(ClassModel[] classModels)
        {
            return classModels.Select(x => new ClassViewModel {ClassId = x.Id, ClassLead = usersModelBuilder.BuildUserViewModel(usersRepository.GetUserById(x.ClassLeadId)) , ClassName = x.ClassName}).ToArray();
        }

        public ClassViewModel GetClassViewModel(ClassModel classModels)
        {
            return  new ClassViewModel { ClassId = classModels.Id, ClassLead = usersModelBuilder.BuildUserViewModel(usersRepository.GetUserById(classModels.ClassLeadId)), ClassName = classModels.ClassName };
        }

        public NavigationViewModel getNavigationClassModel(ClassViewModel classModel, UserViewModel[] teachers, UserViewModel[] studens)
        {
            return new NavigationViewModel { Class = classModel, TeachersInClassInClass = teachers, UsersInClass = studens };
        }
    }
}
