using LoginSenha.Application.ViewModels.Profiles;

namespace LoginSenha.Application.ViewModels.Users
{
    public class UserResponseListViewModel : EntityViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public bool IsAuthorised { get; set; }
        public ProfileViewModel Profile { get; set; }
    }
}
