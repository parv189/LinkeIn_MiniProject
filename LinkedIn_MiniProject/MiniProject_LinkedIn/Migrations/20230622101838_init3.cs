using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniProject_LinkedIn.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Invitations");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedByDate",
                table: "Invitations",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByDate",
                table: "Invitations");

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Invitations",
                type: "int",
                nullable: true);
        }
    }
}
