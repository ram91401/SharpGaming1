using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SG_Database.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    translation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    sportId = table.Column<int>(type: "int", nullable: false),
                    tournamentId = table.Column<int>(type: "int", nullable: false),
                    countryId = table.Column<int>(type: "int", nullable: false),
                    dateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isLive = table.Column<bool>(type: "bit", nullable: false),
                    isRacingEvent = table.Column<bool>(type: "bit", nullable: false),
                    outright = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    translation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    home = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    homeTranslation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    away = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    awayTranslation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    translation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sportId = table.Column<int>(type: "int", nullable: false),
                    countryId = table.Column<int>(type: "int", nullable: false),
                    preMatch = table.Column<int>(type: "int", nullable: false),
                    live = table.Column<int>(type: "int", nullable: false),
                    meetingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Sports");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Tournaments");
        }
    }
}
