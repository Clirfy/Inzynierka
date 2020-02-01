using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportServicesApp.Migrations
{
    public partial class initialv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropColumn(
                name: "AdditionalBaggage",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "AdvertOption",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "IsFragile",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "IsOcuppied",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "MaxSize",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "MaxWeight",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "PassengerAmmount",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "PassengerLimit",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "SeatsTaken",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Adverts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AdditionalBaggage",
                table: "Adverts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AdvertOption",
                table: "Adverts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsFragile",
                table: "Adverts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsOcuppied",
                table: "Adverts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MaxSize",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaxWeight",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassengerAmmount",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassengerLimit",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeatsTaken",
                table: "Adverts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Adverts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "Adverts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AdditionalBaggage = table.Column<bool>(nullable: false),
                    AdvertType = table.Column<string>(nullable: true),
                    CityFrom = table.Column<string>(nullable: true),
                    CityTo = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    MaxSize = table.Column<string>(nullable: true),
                    MaxWeight = table.Column<string>(nullable: true),
                    OfferType = table.Column<string>(nullable: true),
                    PassengerLimit = table.Column<int>(nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    UserImage = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AdditionalBaggage = table.Column<bool>(nullable: false),
                    AdvertType = table.Column<string>(nullable: true),
                    CityFrom = table.Column<string>(nullable: true),
                    CityTo = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsFragile = table.Column<bool>(nullable: false),
                    PassengerAmmount = table.Column<int>(nullable: false),
                    RequestType = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    UserID = table.Column<string>(nullable: true),
                    UserImage = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                });
        }
    }
}
