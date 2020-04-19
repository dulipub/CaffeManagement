using Microsoft.EntityFrameworkCore.Migrations;

namespace CaffeManagementCore.Migrations
{
    public partial class locationentityupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Location",
                newName: "Street");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Location",
                newName: "Address");
        }
    }
}
