using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportServicesApp.Migrations
{
    public partial class advertOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfferType",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "RequestType",
                table: "Adverts");

            migrationBuilder.AddColumn<int>(
                name: "AdvertOption",
                table: "Adverts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdvertOption",
                table: "Adverts");

            migrationBuilder.AddColumn<int>(
                name: "OfferType",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RequestType",
                table: "Adverts",
                nullable: true);
        }
    }
}
