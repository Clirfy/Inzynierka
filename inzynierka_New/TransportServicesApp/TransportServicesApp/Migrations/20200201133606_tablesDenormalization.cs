using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportServicesApp.Migrations
{
    public partial class tablesDenormalization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PassengerRequest_AdditionalBaggage",
                table: "Adverts",
                newName: "Request_AdditionalBaggage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Request_AdditionalBaggage",
                table: "Adverts",
                newName: "PassengerRequest_AdditionalBaggage");
        }
    }
}
