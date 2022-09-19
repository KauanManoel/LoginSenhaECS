using LoginSenha.Domain.Entities;

namespace LoginSenha.Domain.Interfaces
{
    public interface IProfileRepository
	{
		Profile GetDefault();
	}
}
