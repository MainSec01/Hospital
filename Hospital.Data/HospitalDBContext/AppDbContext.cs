using Hospital.Domain.Entitys;
using Hospital.Domain.Entitys.Hospitals;
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

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Infirmary> Infirations { get; set; }
        public DbSet<Sickness> Sickness { get; set; }
        public DbSet<Symptom> Symptoms { get; set;}
    }
}
