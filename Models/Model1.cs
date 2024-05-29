using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Test.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Requests> Requests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Requests>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Requests>()
                .Property(e => e.Equipment)
                .IsUnicode(false);

            modelBuilder.Entity<Requests>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Requests>()
                .Property(e => e.Descrip)
                .IsUnicode(false);

            modelBuilder.Entity<Requests>()
                .Property(e => e.Client)
                .IsUnicode(false);

            modelBuilder.Entity<Requests>()
                .Property(e => e.Status)
                .IsUnicode(false);
        }
    }
}
