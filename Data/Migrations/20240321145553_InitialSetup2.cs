using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactsApp.Data.Migrations
{
    public partial class InitialSetup2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Contact",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Contact");
        }
    }
}
