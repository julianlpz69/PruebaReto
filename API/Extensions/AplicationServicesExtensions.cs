using API.Services;
using Aplication.UnitOfWork;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace API.Extensions
{
    public static class AplicationServicesExtensions
    {
         public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>{

                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader());
        });


        public static void AddAppServices(this IServiceCollection Services){
            Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
            Services.AddScoped<IUnitOfWork, UnitOfWork>();
            Services.AddScoped<IUserService, UserService>();
            Services.AddScoped<IAuthorizationHandler, GlobalVerbRoleHeader>();
            

        }

        
        
    }
}