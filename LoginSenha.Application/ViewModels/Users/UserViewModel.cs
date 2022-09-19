using LoginSenha.Application.ViewModels.Profiles;

namespace LoginSenha.Application.ViewModels.Users
{
    public class UserViewModel: EntityViewModel
	{
        public string Name { get; set; }
        public string Email { get; set; }
        public ProfileViewModel? Profile { get; set; }
    }
}
