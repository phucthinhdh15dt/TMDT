using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TemplateWebApiPhucThinh.Data.Models
{
    public partial class demoTemplateContext : DbContext
    {
        public demoTemplateContext()
        {
        }

        public demoTemplateContext(DbContextOptions<demoTemplateContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=PHUCTHINH\\SQL;Database=demoTemplate;User Id=sa;Password=1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .ValueGeneratedNever();
                    
                

                entity.Property(e => e.Identity).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(300);

                entity.Property(e => e.Phone).HasMaxLength(11);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.Identity).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(300);
            });
        }
    }
}
