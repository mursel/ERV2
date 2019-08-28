using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entities
{
    public partial class MainContext : DbContext
    {
        public MainContext()
        {
        }

        public MainContext(DbContextOptions<MainContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EvidencijaRadnogVremena> Evidencijaradnogvremena { get; set; }
        public virtual DbSet<Izlaznice> Izlaznice { get; set; }
        public virtual DbSet<Kompanije> Kompanije { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Sektori> Sektori { get; set; }
        public virtual DbSet<Sysdiagrams> Sysdiagrams { get; set; }
        public virtual DbSet<Tipoviizlaznica> Tipoviizlaznica { get; set; }
        public virtual DbSet<Uposlenici> Uposlenici { get; set; }
    }
}
