using Microsoft.EntityFrameworkCore.Migrations;

namespace SOUT.Migrations
{
    public partial class OfferSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalBaggage", "CityFrom", "CityTo", "Description", "MaxSize", "MaxWeight", "OfferType", "PassengerLimit", "UserID", "UserImage", "UserName" },
                values: new object[] { "1", false, "Brzeszcze", "Wałbrzych", null, null, null, null, 0, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: "1");
        }
    }
}
