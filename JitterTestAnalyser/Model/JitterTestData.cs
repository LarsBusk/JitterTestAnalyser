using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JitterTestAnalyser.Model
{
    public partial class JitterTestData : DbContext
    {
        public virtual DbSet<Delays> Delays { get; set; }
        public virtual DbSet<TestSetup> TestSetup { get; set; }
        public virtual DbSet<TestSystem> TestSystem { get; set; }

        // Parameterless constructor uses the named connection string from App.config
        public JitterTestData() : base("name=JitterTestData")
        {
            // Disable database initializer in production; use MigrateDatabaseToLatestVersion if using migrations
            Database.SetInitializer<JitterTestData>(null);
        }

        // Optional: constructor that accepts a full connection string
        public JitterTestData(string connectionString) : base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Primary keys
            modelBuilder.Entity<Delays>().HasKey(d => d.DelayId);
            modelBuilder.Entity<TestSetup>().HasKey(t => t.SetupID);
            modelBuilder.Entity<TestSystem>().HasKey(s => s.SystemID);

            // Column types (example: ensure datetime2)
            modelBuilder.Entity<Delays>()
                .Property(d => d.Timestamp)
                .HasColumnType("datetime2");

            // If you have navigation properties, configure relationships here.
            // Example if Delays had navigation properties:
            // modelBuilder.Entity<Delays>()
            //     .HasRequired<TestSystem>(d => d.TestSystem)
            //     .WithMany(s => s.Delays)
            //     .HasForeignKey(d => d.SystemID)
            //     .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
