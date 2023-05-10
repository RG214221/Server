using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Repository.Entities;
using Repository.Interfaces;

namespace Server.Repository
{
    public class Context : DbContext, IDataSource
    {
        public DbSet<Patient> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =.; Initial Catalog = TehillaHadasim; Integrated Security = True; TrustServerCertificate =True ");
            optionsBuilder.UseLazyLoadingProxies(true).UseSqlServer(@"Data Source =.; Initial Catalog = TehillaHadasim; Integrated Security = True; TrustServerCertificate =True ");
        }
    }
}