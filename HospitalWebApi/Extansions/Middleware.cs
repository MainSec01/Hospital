using Hospital.Data.HospitalDBContext;
using Hospital.Data.IRepsitory;
using Hospital.Data.Repsitory;
using Hospital.Servise.Servises;
using HospitalWebApi.Controllers;
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

            //services.AddTransient<IDoctorRepsitory, DoctorRepsitory>();
            services.AddTransient<IDiseaseCauseRepsitory, DiseaseCauseRepsitory>();
            services.AddTransient<IHealthyFoodRepsitory, HealthyFoodRepsitory>();
            services.AddTransient<IInfirmaryRepsitory, InfirmaryRepsitory>();
            services.AddTransient<ISicknessRepsitory, SicknessRepsitory>();
            services.AddTransient<ISymptomRepsitory, SymptomRepsitory>();
           // services.AddTransient<ITreatmentMethodRepsitory, TreatmentMethodRepsitory>();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
           // services.AddTransient<IDoctorServise, DoctorServise>();
            services.AddTransient<IDiseaseCauseServise, DiseaseCauseServise>();
            services.AddTransient<IHealthyFoodServise, HealthyFoodServise>();
            services.AddTransient<IInfirmaryServise, InfirmaryServise>();
            services.AddTransient<ISicknessServise, SicknessServise>();
            services.AddTransient<ISymptomServise, SymptomServise>();
           // services.AddTransient<ITreatmentMethodServise, TreatmentMethodServise>();
        }
    }
}
