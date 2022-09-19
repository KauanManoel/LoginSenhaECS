using System.Collections.Generic;
using LoginSenha.Application.ViewModels.Modules;

namespace LoginSenha.Application.Interfaces
{
	public interface IModuleService
	{
		List<ModuleViewModel> GetByProfile(int profileId);
	}
}
