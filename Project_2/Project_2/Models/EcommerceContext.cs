using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project_2.Models
{
    public partial class EcommerceContext : DbContext
    {
        public EcommerceContext()
        {
        }

        public EcommerceContext(DbContextOptions<EcommerceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-U064AL2;database=Ecommerce;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK__Orders__CB3E4F310A85B3B0");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Oaddress)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Odate).HasColumnType("date");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Products__C5705938B69966BE");

                entity.Property(e => e.Pid).ValueGeneratedNever();

                entity.Property(e => e.Pname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.OidNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Oid)
                    .HasConstraintName("FK__Products__Oid__4BAC3F29");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
