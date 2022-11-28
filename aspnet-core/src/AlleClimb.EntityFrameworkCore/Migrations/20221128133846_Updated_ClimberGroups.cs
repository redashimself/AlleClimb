using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlleClimb.Migrations
{
    public partial class Updated_ClimberGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppAbp",
                table: "AppAbp");

            migrationBuilder.RenameTable(
                name: "AppAbp",
                newName: "AppClimberGroups");

            migrationBuilder.RenameIndex(
                name: "IX_AppAbp_Name",
                table: "AppClimberGroups",
                newName: "IX_AppClimberGroups_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppClimberGroups",
                table: "AppClimberGroups",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppClimberGroups",
                table: "AppClimberGroups");

            migrationBuilder.RenameTable(
                name: "AppClimberGroups",
                newName: "AppAbp");

            migrationBuilder.RenameIndex(
                name: "IX_AppClimberGroups_Name",
                table: "AppAbp",
                newName: "IX_AppAbp_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppAbp",
                table: "AppAbp",
                column: "Id");
        }
    }
}
