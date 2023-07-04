using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniProject_LinkedIn.Migrations
{
    /// <inheritdoc />
    public partial class init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LikedBy",
                table: "Connection_sPosts",
                newName: "LikeCounts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LikeCounts",
                table: "Connection_sPosts",
                newName: "LikedBy");
        }
    }
}
