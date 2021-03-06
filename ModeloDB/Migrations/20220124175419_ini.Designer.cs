// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModeloDB;

namespace ModeloDB.Migrations
{
    [DbContext(typeof(PruebaDb))]
    [Migration("20220124175419_ini")]
    partial class ini
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modelo.Entidades.Customer", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("active")
                        .HasColumnType("int");

                    b.Property<string>("activebool")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("address_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("last_update")
                        .HasColumnType("datetime2");

                    b.Property<int>("store_id")
                        .HasColumnType("int");

                    b.HasKey("customerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Modelo.Entidades.Payment", b =>
                {
                    b.Property<int>("paymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("customerId")
                        .HasColumnType("int");

                    b.Property<int>("customer_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("payment_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("rentalId")
                        .HasColumnType("int");

                    b.Property<int>("rental_id")
                        .HasColumnType("int");

                    b.Property<int>("staff_id")
                        .HasColumnType("int");

                    b.HasKey("paymentId");

                    b.HasIndex("customerId");

                    b.HasIndex("rentalId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Modelo.Entidades.Rental", b =>
                {
                    b.Property<int>("rentalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("customerId")
                        .HasColumnType("int");

                    b.Property<int>("customer_id")
                        .HasColumnType("int");

                    b.Property<int>("inventory_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("last_update")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("rental_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("return_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("staff_id")
                        .HasColumnType("int");

                    b.HasKey("rentalId");

                    b.HasIndex("customerId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("Modelo.Entidades.Payment", b =>
                {
                    b.HasOne("Modelo.Entidades.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("customerId");

                    b.HasOne("Modelo.Entidades.Rental", "rental")
                        .WithMany()
                        .HasForeignKey("rentalId");

                    b.Navigation("customer");

                    b.Navigation("rental");
                });

            modelBuilder.Entity("Modelo.Entidades.Rental", b =>
                {
                    b.HasOne("Modelo.Entidades.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("customerId");

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
