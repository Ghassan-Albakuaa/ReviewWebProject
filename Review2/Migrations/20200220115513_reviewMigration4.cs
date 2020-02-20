using Microsoft.EntityFrameworkCore.Migrations;

namespace Review2.Migrations
{
    public partial class reviewMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Reviews",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Description", "Image", "Name" },
                values: new object[] { 1, "hlkjhlkjhkjlh", null, "ghassan" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Description", "Image", "Name" },
                values: new object[] { 2, "hlkjhlkjhkjlh", null, "ghassan" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Description", "Image", "Name" },
                values: new object[] { 3, "nbgkljglkjghlkjhl", null, "ali" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReviewId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReviewId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReviewId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ReviewId",
                table: "Products",
                column: "ReviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Reviews_ReviewId",
                table: "Products",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Reviews_ReviewId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ReviewId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                table: "Products");
        }
    }
}
