using Hospital.Data.HospitalDBContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System;
using System.Text;

namespace RoboMarketApi.Service
{
    public static class Middleware
    {
        public static void AddDbContexts(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(p => p.UseNpgsql(config.GetConnectionString("Hospitaldb")));
        }

        public static void AddService(this IServiceCollection services)
        {
           /*services.AddTransient<IAuthManager, AuthManager>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IProducService, ProducService>();
            services.AddTransient<IProductCategoryService, ProductCategoryService>();
            services.AddTransient<ILocationCategoryService, LocationCategoryService>();
            services.AddTransient<ILocationUserService, LocationUserService>();*/
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            /*services.AddTransient<IUserRepositori, UserRepositori>();
            services.AddTransient<IProductRepositori, ProductRepositori>();
            services.AddTransient<IProductCategoryRepositori, ProductCategoryRepositori>();
            services.AddTransient <ILocationUserRepositori, LocationUserRepositori>();
            services.AddTransient<ILocationCategoryRepositori, LocationCategoryRepositori>();*/
        }

     
        
    }
}
