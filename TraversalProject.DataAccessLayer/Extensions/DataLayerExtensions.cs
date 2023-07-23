using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.DataAccessLayer.Abstract;
using TraversalProject.DataAccessLayer.Concrete;
using TraversalProject.DataAccessLayer.Concrete.EntityFramework;
using TraversalProject.DataAccessLayer.Repository;

namespace TraversalProject.DataAccessLayer.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services,IConfiguration config)
        {


            services.AddDbContext<TContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
            services.AddScoped<IAboutDal, EfAboutDal>();
            services.AddScoped<IAbout2Dal, EfAbout2Dal>();
            services.AddScoped<IAccountDal, EfAccountDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<IContactUsDal, EfContactUsDal>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();
            services.AddScoped<IFeatureDal, EfFeatureDal>();
            services.AddScoped<IFeature2Dal, EfFeature2Dal>();
            services.AddScoped<IGuideDal, EfGuideDal>();
            services.AddScoped<INewsLetterDal, EfNewsLetterDal>();
            services.AddScoped<IReservationDal, EfReservationDal>();
            services.AddScoped<ISubAboutDal, EfSubAboutDal>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            return services;


        }
    }
}
