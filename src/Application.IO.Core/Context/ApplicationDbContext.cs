using Application.IO.Core.Context.Extensions;
using Application.IO.Core.Context.Mappings.Customers;
using Application.IO.Core.Context.Mappings.Lawyers;
using Application.IO.Core.Context.Mappings.System;
using Application.IO.Core.Domain.Customers;
using Application.IO.Core.Domain.Lawyers;
using Application.IO.Core.Domain.System;
using Application.IO.Core.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Application.IO.Core.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public virtual DbSet<AdministratorSystem> AdministratorsSystem { get; set; }
        public virtual DbSet<PostalCodeAdress> PostalCodesAdress { get; set; }

        public virtual DbSet<Lawyer> Lawyers { get; set; }
        public virtual DbSet<LawyerOccupationArea> LawyerOccupationAreas { get; set; }
        public virtual DbSet<OccupationAreaLawyer> OccupationAreas { get; set; }
        public virtual DbSet<LawyerSociety> LawyersSociety { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Sistema
            modelBuilder.AddConfiguration(new AdministratorSystemMapping());
            modelBuilder.AddConfiguration(new PostalCodeAdressMapping());

            //Advogados
            modelBuilder.AddConfiguration(new LawyerMapping());
            modelBuilder.AddConfiguration(new LawyerOccupationAreaMapping());
            modelBuilder.AddConfiguration(new OccupationAreaLawyerMapping());
            modelBuilder.AddConfiguration(new LawyerSocietyMapping());

            //Litigiantes
            modelBuilder.AddConfiguration(new CustomerMapping());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
