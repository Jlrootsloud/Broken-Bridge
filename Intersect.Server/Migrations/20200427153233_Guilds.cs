using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations
{
    public partial class Guilds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GuildId",
                table: "Players",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Guilds",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Tag = table.Column<string>(nullable: true),
                    Members = table.Column<string>(nullable: true),
                    Ranks = table.Column<string>(nullable: true),
                    DefaultMemberRank = table.Column<Guid>(nullable: false),
                    LeaderRank = table.Column<Guid>(nullable: false),
                    FoundingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guilds", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_GuildId",
                table: "Players",
                column: "GuildId");

            // Wooo, Sqlite limitations!
            //migrationBuilder.AddForeignKey(
            //    name: "FK_Players_Guilds_GuildId",
            //    table: "Players",
            //    column: "GuildId",
            //    principalTable: "Guilds",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Wooo, Sqlite limitations!
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Players_Guilds_GuildId",
            //    table: "Players");

            migrationBuilder.DropTable(
                name: "Guilds");

            migrationBuilder.DropIndex(
                name: "IX_Players_GuildId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "GuildId",
                table: "Players");
        }
    }
}
