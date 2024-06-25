﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UPBank.AgencyAPI.Data;

#nullable disable

namespace UPBank.AgencyAPI.Migrations
{
    [DbContext(typeof(UPBankAgencyAPIContext))]
    partial class UPBankAgencyAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Models.Agency", b =>
                {
                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressZipCode")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(19)
                        .HasColumnType("nvarchar(19)");

                    b.Property<bool>("Restriction")
                        .HasColumnType("bit");

                    b.HasKey("Number");

                    b.ToTable("Agency", (string)null);
                });

            modelBuilder.Entity("Models.AgencyEmployee", b =>
                {
                    b.Property<string>("Cpf")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("AgencyNumber")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Cpf");

                    b.HasIndex("AgencyNumber");

                    b.ToTable("AgencyEmployee", (string)null);
                });

            modelBuilder.Entity("Models.DeletedAgency", b =>
                {
                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressZipCode")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(19)
                        .HasColumnType("nvarchar(19)");

                    b.Property<bool>("Restriction")
                        .HasColumnType("bit");

                    b.HasKey("Number");

                    b.ToTable("DeletedAgency", (string)null);
                });

            modelBuilder.Entity("Models.DeletedAgencyEmployee", b =>
                {
                    b.Property<string>("Cpf")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("DeletedAgencyNumber")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Cpf");

                    b.HasIndex("DeletedAgencyNumber");

                    b.ToTable("DeletedAgencyEmployee", (string)null);
                });

            modelBuilder.Entity("Models.AgencyEmployee", b =>
                {
                    b.HasOne("Models.Agency", null)
                        .WithMany("EmployeesCpf")
                        .HasForeignKey("AgencyNumber");
                });

            modelBuilder.Entity("Models.DeletedAgencyEmployee", b =>
                {
                    b.HasOne("Models.DeletedAgency", null)
                        .WithMany("EmployeesCpf")
                        .HasForeignKey("DeletedAgencyNumber");
                });

            modelBuilder.Entity("Models.Agency", b =>
                {
                    b.Navigation("EmployeesCpf");
                });

            modelBuilder.Entity("Models.DeletedAgency", b =>
                {
                    b.Navigation("EmployeesCpf");
                });
#pragma warning restore 612, 618
        }
    }
}
