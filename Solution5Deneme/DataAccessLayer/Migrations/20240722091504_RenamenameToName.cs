using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class RenamenameToName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "hotels",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "hotels",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "hotels",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "hotels",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "hotels",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "hotels",
                newName: "id");
        }
    }
}
