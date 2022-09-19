using LoginSenha.CrossCutting.Auth.ViewModels;

namespace LoginSenha.CrossCutting.Auth.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(ContextUserViewModel usuario);
    }
}
