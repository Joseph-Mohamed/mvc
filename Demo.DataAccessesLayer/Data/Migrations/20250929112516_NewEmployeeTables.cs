using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.DataAccessesLayer.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewEmployeeTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_departements",
                table: "departements");

            migrationBuilder.RenameTable(
                name: "departements",
                newName: "GetDepartements");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GetDepartements",
                table: "GetDepartements",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GetDepartements",
                table: "GetDepartements");

            migrationBuilder.RenameTable(
                name: "GetDepartements",
                newName: "departements");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departements",
                table: "departements",
                column: "Id");
        }
    }
}
