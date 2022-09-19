using System.Security.Claims;
using LoginSenha.CrossCutting.Auth.ViewModels;

namespace LoginSenha.CrossCutting.Auth.Interfaces
{
    public interface IAuthService
    {
        ContextUserViewModel GetLoggedUser();
        ClaimsIdentity GetClaimsIdentityByContextUser(ContextUserViewModel user, string authenticationType = "Bearer");
    }
}
