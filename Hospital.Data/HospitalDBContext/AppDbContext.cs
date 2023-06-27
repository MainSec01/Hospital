using Hospital.Domain.Entitys;
using Hospital.Domain.Entitys.DiseaseCauses;
using Hospital.Domain.Entitys.Files;
using Hospital.Domain.Entitys.HealthyFoods;
using Hospital.Domain.Entitys.Hospitals;
using Hospital.Domain.Entitys.TreatmentMethods;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.HospitalDBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options){ }

        public DbSet<DiseaseCause> DiseaseCauses { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        //public DbSet<FileModel> FileModels { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        //public DbSet<Response> Responses { get; set; }
        public DbSet<HealthyFood> HealthyFoods { get; set; }
        public DbSet<Infirmary> Infirations { get; set; }
        public DbSet<Sickness> Sickness { get; set; }
        public DbSet<Symptom> Symptoms { get; set;}
        public DbSet <TreatmentMethod> TreatmentMethods { get; set; }
    }
}