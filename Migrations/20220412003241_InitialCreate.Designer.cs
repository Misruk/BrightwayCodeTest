// <auto-generated />
using BrightwayCodeTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BrightwayCodeTest.Migrations
{
    [DbContext(typeof(TripContext))]
    [Migration("20220412003241_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BrightwayCodeTest.Models.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TripId"), 1L, 1);

                    b.Property<double>("ConvertedCurrency")
                        .HasColumnType("float");

                    b.Property<double>("Currency")
                        .HasColumnType("float");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TripId");

                    b.ToTable("Trips");
                });
#pragma warning restore 612, 618
        }
    }
}
