using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportServicesApp.Migrations
{
    public partial class adjust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Adverts",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaxSize",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaxWeight",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFragile",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsOccupied",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OfferType",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeatsTaken",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AdditionalBaggage",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassengerLimit",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PassengerRequest_AdditionalBaggage",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassengerAmmount",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RequestType",
                table: "Adverts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "MaxSize",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "MaxWeight",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "IsFragile",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "IsOccupied",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "OfferType",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "SeatsTaken",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "AdditionalBaggage",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "PassengerLimit",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "PassengerRequest_AdditionalBaggage",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "PassengerAmmount",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "RequestType",
                table: "Adverts");
        }
    }
}
