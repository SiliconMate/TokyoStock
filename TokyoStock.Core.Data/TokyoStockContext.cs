using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TokyoStock.Core.Entities;


namespace TokyoStock.Core.Data;

public partial class TokyoStockContext : DbContext
{
    public TokyoStockContext()
    {
    }

    public TokyoStockContext(DbContextOptions<TokyoStockContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Venta> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // Sacar de aca la cadena de conexion y ponerla en el archivo de configuracion o usar secret manager
        => optionsBuilder.UseSqlServer("Server=tcp:tpintegrador-server.database.windows.net,1433;Initial Catalog=db-tpintegrador;Persist Security Info=False;User ID=admin-server;Password=tpIntegrador1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.CategoriaId).HasName("PK__Categori__F353C1E5799C8C19");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.CompraId).HasName("PK__Compra__067DA7452BC33778");

            entity.ToTable("Compra");

            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.Producto).WithMany(p => p.Compras)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Compra__Producto__656C112C");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Compras)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Compra__UsuarioI__66603565");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK__Producto__A430AEA3F99A936C");

            entity.ToTable("Producto");

            entity.HasIndex(e => e.Nombre, "UQ__Producto__75E3EFCF9E6401A1").IsUnique();

            entity.Property(e => e.Habilitado).HasDefaultValue(true);
            entity.Property(e => e.Nombre).HasMaxLength(50);

            entity.HasOne(d => d.Categoria).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CategoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Producto__Catego__628FA481");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__Usuario__2B3DE7B80507C3E4");

            entity.ToTable("Usuario");

            entity.Property(e => e.Hash)
                .HasMaxLength(32)
                .IsFixedLength();
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Salt).HasMaxLength(32);
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.VentaId).HasName("PK__Venta__5B4150ACC7EAADDE");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Producto).WithMany(p => p.Venta)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Venta__ProductoI__6A30C649");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Venta)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Venta__UsuarioId__6B24EA82");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
