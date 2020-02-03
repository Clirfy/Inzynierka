using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportServicesApp.Migrations
{
    public partial class PermaIsActiveProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Adverts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Adverts");
        }
    }
}
