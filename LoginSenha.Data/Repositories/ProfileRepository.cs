using LoginSenha.Data.Context;
using LoginSenha.Domain.Entities;
using LoginSenha.Domain.Interfaces;

namespace LoginSenha.Data.Repositories
{
    public class ProfileRepository: Repository<Profile>, IProfileRepository
	{
		public ProfileRepository(MySQLContext context)
			: base(context) { }

		public Profile GetDefault()
		{
			return Find(x => x.IsDefault);
		}
	}
}
