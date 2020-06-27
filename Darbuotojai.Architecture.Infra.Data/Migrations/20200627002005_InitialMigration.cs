using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Darbuotojai.Architecture.Infra.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Darbuotojai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Vardas = table.Column<string>(type: "TEXT", nullable: true),
                    Pavardė = table.Column<string>(type: "TEXT", nullable: true),
                    AsmensKodas = table.Column<string>(type: "TEXT", nullable: true),
                    GimimoData = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NamoNumeris = table.Column<int>(type: "INTEGER", nullable: false),
                    Gatve = table.Column<string>(type: "TEXT", nullable: true),
                    Miestas = table.Column<string>(type: "TEXT", nullable: true),
                    PastoKodas = table.Column<string>(type: "TEXT", nullable: true),
                    Aktyvus = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Darbuotojai", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Darbuotojai");
        }
    }
}
