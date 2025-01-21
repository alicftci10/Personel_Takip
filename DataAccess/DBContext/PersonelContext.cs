using System;
using System.Collections.Generic;
using DataAccess.DBModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DBContext;

public partial class PersonelContext : DbContext
{
    public PersonelContext()
    {
    }

    public PersonelContext(DbContextOptions<PersonelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Kullanici> Kullanicis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ALI\\SQLEXPRESS;Database=Personel;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kullanici>(entity =>
        {
            entity.ToTable("Kullanici");

            entity.Property(e => e.Ad).HasMaxLength(50);
            entity.Property(e => e.KullaniciAdi).HasMaxLength(50);
            entity.Property(e => e.Sifre).HasMaxLength(50);
            entity.Property(e => e.Soyad).HasMaxLength(50);
            entity.Property(e => e.Tcno)
                .HasMaxLength(50)
                .HasColumnName("TCNO");
            entity.Property(e => e.Yetki).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
