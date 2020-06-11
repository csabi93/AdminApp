namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=WE2DashboardContext")
        {
        }

        public virtual DbSet<BusFunc> BusFuncs { get; set; }
        public virtual DbSet<BusPar> BusPars { get; set; }
        public virtual DbSet<BusParOfBusFunc> BusParOfBusFuncs { get; set; }
        public virtual DbSet<TechFunc> TechFuncs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusFunc>()
                .Property(e => e.DsbTileCssClass)
                .IsUnicode(false);

            modelBuilder.Entity<BusFunc>()
                .HasMany(e => e.BusParOfBusFunc)
                .WithRequired(e => e.BusFunc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusPar>()
                .HasMany(e => e.BusParOfBusFunc)
                .WithRequired(e => e.BusPar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TechFunc>()
                .HasMany(e => e.BusFunc)
                .WithRequired(e => e.TechFunc)
                .WillCascadeOnDelete(false);
        }
    }
}
