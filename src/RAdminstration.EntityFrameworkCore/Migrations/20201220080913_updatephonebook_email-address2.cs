using Microsoft.EntityFrameworkCore.Migrations;

namespace RAdminstration.Migrations
{
    public partial class updatephonebook_emailaddress2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                schema: "PB",
                table: "Person",
                newName: "Address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                schema: "PB",
                table: "Person",
                newName: "Email");
        }
    }
}
