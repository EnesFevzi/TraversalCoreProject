using FluentValidation;
using TraversalProject.WebUI.DtoS.LoginDto;

namespace TraversalProject.Extensions
{
    public static class ValidationExtensions
    {
        public static IServiceCollection LoadWebUILayerExtension(this IServiceCollection services)
        {

            //services.AddTransient<IValidator<LoginUserDto>, CreateGuestValidator>();
            //services.AddTransient<IValidator<UpdateGuestDto>, UpdateGuestValidator>();
            return services;


        }
    }
}
