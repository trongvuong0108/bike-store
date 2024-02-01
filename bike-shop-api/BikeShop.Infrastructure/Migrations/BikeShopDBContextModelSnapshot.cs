﻿// <auto-generated />
using BikeShop.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BikeShop.Infrastructure.Migrations
{
    [DbContext(typeof(BikeShopDBContext))]
    partial class BikeShopDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BikeShop.Domain.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<decimal>("ListPrice")
                        .HasMaxLength(50)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("list_price");

                    b.Property<short>("ModelYear")
                        .HasMaxLength(50)
                        .HasColumnType("smallint")
                        .HasColumnName("model_year");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("product_name");

                    b.HasKey("ProductId");

                    b.ToTable("products", "production");
                });
#pragma warning restore 612, 618
        }
    }
}