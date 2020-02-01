using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportServicesApp.Migrations
{
    public partial class AdvertOptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfferType",
                table: "Adverts");

            migrationBuilder.RenameColumn(
                name: "RequestType",
                table: "Adverts",
                newName: "AdvertOption");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdvertOption",
                table: "Adverts",
                newName: "RequestType");

            migrationBuilder.AddColumn<int>(
                name: "OfferType",
                table: "Adverts",
                nullable: false,
                defaultValue: 0);
        }
    }
}
