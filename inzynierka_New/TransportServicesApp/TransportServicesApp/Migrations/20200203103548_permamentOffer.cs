using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportServicesApp.Migrations
{
    public partial class permamentOffer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Permanent_AdditionalBaggage",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Permanent_IsOccupied",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Permanent_MaxSize",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Permanent_MaxWeight",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Permanent_PassengerLimit",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RefreshPeriod",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Permanent_SeatsTaken",
                table: "Adverts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Permanent_AdditionalBaggage",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "Permanent_IsOccupied",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "Permanent_MaxSize",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "Permanent_MaxWeight",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "Permanent_PassengerLimit",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "RefreshPeriod",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "Permanent_SeatsTaken",
                table: "Adverts");
        }
    }
}
