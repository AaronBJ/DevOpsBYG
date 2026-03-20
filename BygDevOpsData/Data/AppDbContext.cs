using System;
using System.Collections.Generic;
using BygDevOpsData.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace BygDevOpsData.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<inventory> inventory { get; set; }

    public virtual DbSet<inventory_tags> inventory_tags { get; set; }

    public virtual DbSet<tags> tags { get; set; }

    public virtual DbSet<vista_inventory_tags> vista_inventory_tags { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=BYGOPERATIONS;user=aaronbj;password=aaron123", Microsoft.EntityFrameworkCore.ServerVersion.Parse("9.6.0-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<inventory>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.HasIndex(e => e.details, "details").IsUnique();

            entity.Property(e => e.details).HasMaxLength(30);
            entity.Property(e => e.imageurl).HasMaxLength(50);
        });

        modelBuilder.Entity<inventory_tags>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.inventario_id, "inventario_id");

            entity.HasIndex(e => e.tags_id, "tags_id");

            entity.HasOne(d => d.inventario).WithMany()
                .HasForeignKey(d => d.inventario_id)
                .HasConstraintName("inventory_tags_ibfk_1");

            entity.HasOne(d => d.tags).WithMany()
                .HasForeignKey(d => d.tags_id)
                .HasConstraintName("inventory_tags_ibfk_2");


        });

        modelBuilder.Entity<inventory_tags>().HasKey(it => new { it.inventario_id, it.tags_id });

        modelBuilder.Entity<inventory_tags>()
            .HasOne(it => it.inventario)
            .WithMany(i => i.inventory_tags)
            .HasForeignKey(it => it.inventario_id);

        modelBuilder.Entity<inventory_tags>()
            .HasOne(it => it.tags)
            .WithMany()
            .HasForeignKey(it => it.tags_id);

        modelBuilder.Entity<tags>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.HasIndex(e => e.details, "details").IsUnique();

            entity.Property(e => e.color).HasMaxLength(6);
            entity.Property(e => e.details).HasMaxLength(30);
            entity.Property(e => e.iconos).HasMaxLength(20);
            entity.Property(e => e.is_deleted).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<vista_inventory_tags>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vista_inventory_tags");

            entity.Property(e => e.inventory_details).HasMaxLength(30);
            entity.Property(e => e.inventory_image).HasMaxLength(50);
            entity.Property(e => e.tags_color).HasMaxLength(6);
            entity.Property(e => e.tags_details).HasMaxLength(30);
            entity.Property(e => e.tags_icons).HasMaxLength(20);
            entity.Property(e => e.tags_id).HasDefaultValueSql("'0'");
            entity.Property(e => e.tags_is_deleted).HasDefaultValueSql("'0'");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
