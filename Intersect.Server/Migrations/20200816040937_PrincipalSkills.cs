using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations
{
    public partial class PrincipalSkills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "FishingExp",
                table: "Players",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "FishingLevel",
                table: "Players",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "MiningExp",
                table: "Players",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "MiningLevel",
                table: "Players",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "WoodExp",
                table: "Players",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "WoodLevel",
                table: "Players",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FishingExp",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "FishingLevel",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "MiningExp",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "MiningLevel",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "WoodExp",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "WoodLevel",
                table: "Players");
        }
    }
}
