using Microsoft.Extensions.DependencyInjection;
using System;
using LoginSenha.Application.Interfaces;
using LoginSenha.Application.Services;
using LoginSenha.CrossCutting.Auth.Interfaces;
using LoginSenha.CrossCutting.Auth.Services;
using LoginSenha.CrossCutting.Notification.Interfaces;
using LoginSenha.CrossCutting.Notification.Services;
using LoginSenha.Data.Repositories;
using LoginSenha.Domain.Interfaces;

namespace LoginSenha.CrossCutting.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IEmailSender, EmailSender>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ITokenService, TokenService>();

            #region Services

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<IModuleService, ModuleService>();

            #endregion

            #region Repositories

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProfileRepository, ProfileRepository>();
            services.AddScoped<IModuleRepository, ModuleRepository>();

            #endregion
        }
    }
}
