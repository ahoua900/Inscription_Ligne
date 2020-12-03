using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Inscription_Ligne.Models;
using System.Web;

namespace Inscription_Ligne.DAL
{
    public class SchoolContext : DbContext
    {
        public DbSet<Etablissement> Etablissements { get; set; }
        public DbSet<Eleves> Eleves { get; set; }
        public DbSet<Niveau> Niveaus { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-1MOS7C0;Initial Catalog=SchoolDb;Integrated Security=True"));
        }
    }
}