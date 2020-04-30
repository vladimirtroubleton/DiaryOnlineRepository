using AuthorizationClassLibrary.AuthViewModels;

namespace AuthorizationClassLibrary.ValidationUtils
{
    public interface ICheckDataUtils
    {
        bool CheckLoginAtFree(RegisterModel userRegModel);
    }
}