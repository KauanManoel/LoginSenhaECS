using System.ComponentModel.DataAnnotations;

namespace LoginSenha.Application.ViewModels.Users
{
    public class UserRequestAuthenticateViewModel
	{
		[Required]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }
	}
}
