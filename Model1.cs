namespace AdmissionCommittee
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Gruppa> Gruppa { get; set; }
        public virtual DbSet<Specialty> Specialty { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gruppa>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Gruppa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Specialty>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Specialty)
                .WillCascadeOnDelete(false);
        }
    }
}
