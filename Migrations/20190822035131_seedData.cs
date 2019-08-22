using Microsoft.EntityFrameworkCore.Migrations;

namespace TestProject.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LoginModels",
                columns: new[] { "UserId", "Password", "UserName", "UserType" },
                values: new object[] { 1, "123456", "Mridul", 1 });

            migrationBuilder.InsertData(
                table: "LoginModels",
                columns: new[] { "UserId", "Password", "UserName", "UserType" },
                values: new object[] { 2, "123456", "Test", 1 });

            migrationBuilder.InsertData(
                table: "LoginModels",
                columns: new[] { "UserId", "Password", "UserName", "UserType" },
                values: new object[] { 3, "admin@12345", "Admin", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LoginModels",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LoginModels",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LoginModels",
                keyColumn: "UserId",
                keyValue: 3);
        }
    }
}
