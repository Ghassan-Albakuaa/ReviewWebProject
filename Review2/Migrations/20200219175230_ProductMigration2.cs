using Microsoft.EntityFrameworkCore.Migrations;

namespace Review2.Migrations
{
    public partial class ProductMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Name", "Review" },
                values: new object[] { 1, "Yellow fruit-eating monster", "/img/pacman.jpg", "Pac-Man", "I bought this arcade game, now I hate ghosts!" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Name", "Review" },
                values: new object[] { 2, "Save the Realms from certain doom", "/img/GauntletLegends.jpg", "Gauntlet Legends", "Wtf I love this game?" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Name", "Review" },
                values: new object[] { 3, "Dig and dug", "/img/digdug.jpg", "DigDug", "Being inflated till you explode has got to hurt!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
