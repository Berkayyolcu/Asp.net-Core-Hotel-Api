using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class add_update_contact2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Youtube",
                table: "Contact2s",
                newName: "İlçe");

            migrationBuilder.RenameColumn(
                name: "Twitter",
                table: "Contact2s",
                newName: "İl");

            migrationBuilder.RenameColumn(
                name: "SocialMediaUrl",
                table: "Contact2s",
                newName: "MailTecnihal");

            migrationBuilder.RenameColumn(
                name: "SocialMediaIcon",
                table: "Contact2s",
                newName: "MailGeneral");

            migrationBuilder.RenameColumn(
                name: "Linkedin",
                table: "Contact2s",
                newName: "MailBooking");

            migrationBuilder.RenameColumn(
                name: "Instagram",
                table: "Contact2s",
                newName: "Mail2");

            migrationBuilder.RenameColumn(
                name: "Facebook",
                table: "Contact2s",
                newName: "Mahalle");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Contact2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Konum",
                table: "Contact2s",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Contact2s");

            migrationBuilder.DropColumn(
                name: "Konum",
                table: "Contact2s");

            migrationBuilder.RenameColumn(
                name: "İlçe",
                table: "Contact2s",
                newName: "Youtube");

            migrationBuilder.RenameColumn(
                name: "İl",
                table: "Contact2s",
                newName: "Twitter");

            migrationBuilder.RenameColumn(
                name: "MailTecnihal",
                table: "Contact2s",
                newName: "SocialMediaUrl");

            migrationBuilder.RenameColumn(
                name: "MailGeneral",
                table: "Contact2s",
                newName: "SocialMediaIcon");

            migrationBuilder.RenameColumn(
                name: "MailBooking",
                table: "Contact2s",
                newName: "Linkedin");

            migrationBuilder.RenameColumn(
                name: "Mail2",
                table: "Contact2s",
                newName: "Instagram");

            migrationBuilder.RenameColumn(
                name: "Mahalle",
                table: "Contact2s",
                newName: "Facebook");
        }
    }
}
