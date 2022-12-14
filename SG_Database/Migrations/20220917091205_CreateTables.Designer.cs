// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharpGaming;

namespace SG_Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220917091205_CreateTables")]
    partial class CreateTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SG_Database.Model.Country", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("translation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("SG_Database.Model.Event", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("countryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateStart")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isLive")
                        .HasColumnType("bit");

                    b.Property<bool>("isRacingEvent")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("outright")
                        .HasColumnType("bit");

                    b.Property<int>("sportId")
                        .HasColumnType("int");

                    b.Property<int>("tournamentId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("SG_Database.Model.Sport", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("translation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Sports");
                });

            modelBuilder.Entity("SG_Database.Model.Team", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("away")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("awayTranslation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("home")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("homeTranslation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("SG_Database.Model.Tournament", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("countryId")
                        .HasColumnType("int");

                    b.Property<int>("live")
                        .HasColumnType("int");

                    b.Property<DateTime>("meetingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("preMatch")
                        .HasColumnType("int");

                    b.Property<int>("sportId")
                        .HasColumnType("int");

                    b.Property<string>("translation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Tournaments");
                });
#pragma warning restore 612, 618
        }
    }
}
