using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Entity.Models
{
    public partial class CWAContext : DbContext
    {
        public CWAContext()
        {
        }

        public CWAContext(DbContextOptions<CWAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CarpetStatus> CarpetStatuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=HAYATDURGUT\\SQLEXPRESS01;Database=CWA;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<CarpetStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CARPET_STATUS");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUserId).HasColumnName("CREATE_USER_ID");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteUserId).HasColumnName("DELETE_USER_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IsDelete).HasColumnName("IS_DELETE");

                entity.Property(e => e.StatusClass)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("STATUS_CLASS");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("STATUS_NAME");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUserId).HasColumnName("UPDATE_USER_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
