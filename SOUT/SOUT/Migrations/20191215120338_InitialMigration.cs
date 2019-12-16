using Microsoft.EntityFrameworkCore.Migrations;

namespace SOUT.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CityFrom = table.Column<string>(nullable: true),
                    CityTo = table.Column<string>(nullable: true),
                    OfferType = table.Column<string>(nullable: true),
                    PassengerLimit = table.Column<int>(nullable: false),
                    MaxSize = table.Column<string>(nullable: true),
                    MaxWeight = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UserID = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    UserImage = table.Column<string>(nullable: true),
                    AdditionalBaggage = table.Column<bool>(nullable: false)
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
                    CityFrom = table.Column<string>(nullable: true),
                    CityTo = table.Column<string>(nullable: true),
                    RequestType = table.Column<string>(nullable: true),
                    PassengerAmmount = table.Column<int>(nullable: false),
                    Size = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    IsFragile = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    UserID = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    UserImage = table.Column<string>(nullable: true),
                    AdditionalBaggage = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
