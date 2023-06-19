using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniProject_LinkedIn.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Location_Location_Id",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Objects_City_Id",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Objects_State_Id",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Objects_country_Id",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_City_Id",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_country_Id",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_State_Id",
                table: "Location");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "Location_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_City_Id",
                table: "Locations",
                column: "City_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_country_Id",
                table: "Locations",
                column: "country_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_State_Id",
                table: "Locations",
                column: "State_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Locations_Location_Id",
                table: "Company",
                column: "Location_Id",
                principalTable: "Locations",
                principalColumn: "Location_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Objects_City_Id",
                table: "Locations",
                column: "City_Id",
                principalTable: "Objects",
                principalColumn: "Object_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Objects_State_Id",
                table: "Locations",
                column: "State_Id",
                principalTable: "Objects",
                principalColumn: "Object_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Objects_country_Id",
                table: "Locations",
                column: "country_Id",
                principalTable: "Objects",
                principalColumn: "Object_Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Locations_Location_Id",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Objects_City_Id",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Objects_State_Id",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Objects_country_Id",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_City_Id",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_country_Id",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_State_Id",
                table: "Locations");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "Location_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Location_City_Id",
                table: "Location",
                column: "City_Id",
                unique: true,
                filter: "[City_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Location_country_Id",
                table: "Location",
                column: "country_Id",
                unique: true,
                filter: "[country_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Location_State_Id",
                table: "Location",
                column: "State_Id",
                unique: true,
                filter: "[State_Id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Location_Location_Id",
                table: "Company",
                column: "Location_Id",
                principalTable: "Location",
                principalColumn: "Location_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Objects_City_Id",
                table: "Location",
                column: "City_Id",
                principalTable: "Objects",
                principalColumn: "Object_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Objects_State_Id",
                table: "Location",
                column: "State_Id",
                principalTable: "Objects",
                principalColumn: "Object_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Objects_country_Id",
                table: "Location",
                column: "country_Id",
                principalTable: "Objects",
                principalColumn: "Object_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
