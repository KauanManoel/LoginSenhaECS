using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginSenha.Application.Interfaces;
using LoginSenha.CrossCutting.Auth.Interfaces;
using LoginSenha.CrossCutting.Auth.ViewModels;

namespace LoginSenha.Controllers
{
	[Route("api/[controller]"), ApiController]
	public class ProfilesController : ControllerBase
	{
        private readonly IProfileService service;
        private readonly IAuthService authService;

        public ProfilesController(IProfileService service, IAuthService authService)
        {
            this.service = service;
            this.authService = authService;
        }

    }
}
