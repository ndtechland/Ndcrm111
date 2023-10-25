using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NdCRM.Models.entities;

namespace NdCRM.Models.admin_NDCrM;

public partial class AdminNdcrMContext : DbContext
{
    public AdminNdcrMContext()
    {
    }

    public AdminNdcrMContext(DbContextOptions<AdminNdcrMContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CustomerRegistration> CustomerRegistrations { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("server=103.83.81.251;database=admin_NDCrM;User ID=admin_NDCrM;Password=NDCrM@12345#;Trusted_Connection=false;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("admin_NDCrM");

        modelBuilder.Entity<CustomerRegistration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomerRegistration");

            entity.Property(e => e.BillingAddress).HasMaxLength(100);
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.ContactPersonName).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.GenerateInvoice).HasMaxLength(100);
            entity.Property(e => e.GstNumber).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.MobileNumber).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.ProductDetails).HasMaxLength(100);
            entity.Property(e => e.Renewaldate).HasColumnType("datetime");
            entity.Property(e => e.Role).HasMaxLength(100);
            entity.Property(e => e.Startdate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Product");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Price).HasMaxLength(255);
            entity.Property(e => e.Productname)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<NdCRM.Models.entities.Product1>? Product1 { get; set; }
}
