﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaVentas.Persistence.Context;

#nullable disable

namespace SistemaVentas.Persistence.Migrations
{
    [DbContext(typeof(SistemaVentasContext))]
    partial class SistemaVentasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SistemaVentas.Domain.Entities.CategoriaProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idCategoriaProducto");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("descripcion");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit")
                        .HasColumnName("eliminado");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("SistemaVentas.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idCliente");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("celular");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("direccion");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit")
                        .HasColumnName("eliminado");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("email");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaNacimiento");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("nombreCompleto");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SistemaVentas.Domain.Entities.DetalleVenta", b =>
                {
                    b.Property<long>("idVenta")
                        .HasColumnType("bigint")
                        .HasColumnName("idVenta");

                    b.Property<int>("idProducto")
                        .HasColumnType("int")
                        .HasColumnName("idProducto");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("precioUnitario");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<long>("VentaId")
                        .HasColumnType("bigint");

                    b.HasKey("idVenta", "idProducto");

                    b.HasIndex("ProductoId");

                    b.HasIndex("VentaId");

                    b.ToTable("DetalleVenta", (string)null);
                });

            modelBuilder.Entity("SistemaVentas.Domain.Entities.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idMarca");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit")
                        .HasColumnName("eliminado");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("nombre");

                    b.Property<string>("Origen")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("paisOrigen");

                    b.HasKey("Id");

                    b.ToTable("Marca", (string)null);
                });

            modelBuilder.Entity("SistemaVentas.Domain.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idproducto");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Caracteristicas")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("caracteristicas");

                    b.Property<int>("CategoriaproductoId")
                        .HasColumnType("int");

                    b.Property<string>("Dimensiones")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("dimensiones");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit")
                        .HasColumnName("eliminado");

                    b.Property<int>("IdCategoriaProducto")
                        .HasColumnType("int")
                        .HasColumnName("idCategoriaproducto");

                    b.Property<int>("IdMarca")
                        .HasColumnType("int")
                        .HasColumnName("idMarca");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("modelo");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("nombre");

                    b.Property<decimal>("Peso")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("peso");

                    b.Property<decimal>("PrecioReferencial")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("precioReferencial");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaproductoId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("SistemaVentas.Domain.Entities.Venta", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("idVenta");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit")
                        .HasColumnName("eliminado");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("totalVenta");

                    b.Property<int>("idCliente")
                        .HasColumnType("int")
                        .HasColumnName("idCliente");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("SistemaVentas.Domain.Entities.DetalleVenta", b =>
                {
                    b.HasOne("SistemaVentas.Domain.Entities.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaVentas.Domain.Entities.Venta", "Venta")
                        .WithMany("DetallesVenta")
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("SistemaVentas.Domain.Entities.Producto", b =>
                {
                    b.HasOne("SistemaVentas.Domain.Entities.CategoriaProducto", "Categoriaproducto")
                        .WithMany()
                        .HasForeignKey("CategoriaproductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaVentas.Domain.Entities.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoriaproducto");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("SistemaVentas.Domain.Entities.Venta", b =>
                {
                    b.HasOne("SistemaVentas.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("SistemaVentas.Domain.Entities.Venta", b =>
                {
                    b.Navigation("DetallesVenta");
                });
#pragma warning restore 612, 618
        }
    }
}
