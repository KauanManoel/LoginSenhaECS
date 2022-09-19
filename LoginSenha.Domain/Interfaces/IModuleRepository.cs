using System.Collections.Generic;
using System.Linq;
using LoginSenha.Domain.Entities;

namespace LoginSenha.Domain.Interfaces
{
    public interface IModuleRepository
	{
		IQueryable<Module> GetByProfileId(int profileId);
	}
}
