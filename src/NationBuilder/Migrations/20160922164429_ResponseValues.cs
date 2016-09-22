using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NationBuilder.Migrations
{
    public partial class ResponseValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Response",
                table: "Events");

            migrationBuilder.AddColumn<string>(
                name: "TextResponse1",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextResponse2",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextResponse3",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ValueResponse1",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ValueResponse2",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ValueResponse3",
                table: "Events",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TextResponse1",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "TextResponse2",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "TextResponse3",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ValueResponse1",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ValueResponse2",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ValueResponse3",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "Response",
                table: "Events",
                nullable: false,
                defaultValue: 0);
        }
    }
}
