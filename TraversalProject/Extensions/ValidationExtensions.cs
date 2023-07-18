using FluentValidation;

namespace TraversalProject.Extensions
{
    public static class ValidationExtensions
    {
        public static IServiceCollection LoadWebUILayerExtension(this IServiceCollection services)
        {

            //services.AddTransient<IValidator<CreateGuestDto>, CreateGuestValidator>();
            //services.AddTransient<IValidator<UpdateGuestDto>, UpdateGuestValidator>();
            return services;


        }
    }
}
