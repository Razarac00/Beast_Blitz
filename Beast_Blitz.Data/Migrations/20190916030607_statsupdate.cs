using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Beast_Blitz.Data.Migrations
{
    public partial class statsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cleanliness",
                table: "CareStats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fullness",
                table: "CareStats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Happiness",
                table: "CareStats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastFed",
                table: "CareStats",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastPlayed",
                table: "CareStats",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Attack",
                table: "BattleStats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Defense",
                table: "BattleStats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Experience",
                table: "BattleStats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExperienceNeeded",
                table: "BattleStats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Health",
                table: "BattleStats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "BattleStats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Magic",
                table: "BattleStats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxHealth",
                table: "BattleStats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxMagic",
                table: "BattleStats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Speed",
                table: "BattleStats",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cleanliness",
                table: "CareStats");

            migrationBuilder.DropColumn(
                name: "Fullness",
                table: "CareStats");

            migrationBuilder.DropColumn(
                name: "Happiness",
                table: "CareStats");

            migrationBuilder.DropColumn(
                name: "LastFed",
                table: "CareStats");

            migrationBuilder.DropColumn(
                name: "LastPlayed",
                table: "CareStats");

            migrationBuilder.DropColumn(
                name: "Attack",
                table: "BattleStats");

            migrationBuilder.DropColumn(
                name: "Defense",
                table: "BattleStats");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "BattleStats");

            migrationBuilder.DropColumn(
                name: "ExperienceNeeded",
                table: "BattleStats");

            migrationBuilder.DropColumn(
                name: "Health",
                table: "BattleStats");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "BattleStats");

            migrationBuilder.DropColumn(
                name: "Magic",
                table: "BattleStats");

            migrationBuilder.DropColumn(
                name: "MaxHealth",
                table: "BattleStats");

            migrationBuilder.DropColumn(
                name: "MaxMagic",
                table: "BattleStats");

            migrationBuilder.DropColumn(
                name: "Speed",
                table: "BattleStats");
        }
    }
}
