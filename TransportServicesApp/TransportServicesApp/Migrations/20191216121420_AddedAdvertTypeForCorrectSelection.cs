using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportServicesApp.Migrations
{
    public partial class AddedAdvertTypeForCorrectSelection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdvertType",
                table: "Requests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdvertType",
                table: "Offers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdvertType",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "AdvertType",
                table: "Offers");
        }
    }
}
