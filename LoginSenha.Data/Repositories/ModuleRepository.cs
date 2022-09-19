using System.Collections.Generic;
using System.Linq;
using LoginSenha.Data.Context;
using LoginSenha.Domain.Entities;
using LoginSenha.Domain.Interfaces;

namespace LoginSenha.Data.Repositories
{
    public class ModuleRepository: Repository<Module>, IModuleRepository
	{
        public ModuleRepository(MySQLContext context)
            : base(context) { }

        public IQueryable<Module> GetByProfileId(int profileId)
        {
            return (from m in context.Modules
                    join mp in context.ModuleProfiles on m.Id equals mp.ModuleId
                    where mp.ProfileId == profileId
                    select m);
        }
    }
}
