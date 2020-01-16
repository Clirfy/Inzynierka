using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportServicesApp.Migrations
{
    public partial class occupiedProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsOcuppied",
                table: "Adverts",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOcuppied",
                table: "Adverts");
        }
    }
}
