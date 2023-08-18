using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.BusinessLayer.Concrete;
using TraversalProject.DataAccessLayer.UnıtOfWorks;

namespace TraversalProject.BusinessLayer.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {

            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAbout2Service, About2Manager>();
            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IFeature2Service, Feature2Manager>();
            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<INewsLetterService, NewsLetterManager>();
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<ISubAboutService, SubAboutManager>();
            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<IUnıtOfWork, UnıtOfWork>();

            return services;


        }
    }
}
