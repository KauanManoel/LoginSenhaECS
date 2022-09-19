using LoginSenha.Application.Services;
using LoginSenha.Application.ViewModels.Modules;
using LoginSenha.Application.ViewModels.Profiles;
using LoginSenha.Application.ViewModels.Users;
using LoginSenha.CrossCutting.Auth.ViewModels;
using LoginSenha.Domain.Entities;
using Profile = AutoMapper.Profile;
using ProfileUser = LoginSenha.Domain.Entities.Profile;

namespace LoginSenha.Application.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {

            #region "ViewModel To Domain"

            CreateMap<UserRequestCreateAccountViewModel, User>()
                .ForMember(x => x.Password, y => y.MapFrom(m => UtilsService.EncryptPassword(m.Password)));

            #endregion

            #region "Domain to ViewModel"

            CreateMap<User, ContextUserViewModel>()
                .ForMember(x => x.Profile, m => m.MapFrom(map => map.ProfileId));
            CreateMap<User, UserViewModel>();
            CreateMap<User, UserResponseListViewModel>();
            CreateMap<User, UserResponseAuthenticateViewModel>()
                .ForMember(x => x.Profile, m => m.MapFrom(map => map.ProfileId));
            CreateMap<ProfileUser, ProfileViewModel>();
            CreateMap<Module, ModuleViewModel>();

            #endregion
        }
    }
}
