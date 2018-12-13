using Microsoft.EntityFrameworkCore.Migrations;

namespace MyRestfulApi.Migrations
{
    public partial class useMySqlDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    UserName = table.Column<string>(nullable: true),
                    UserGruop = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "UserGruop", "UserName" },
                values: new object[] { 1, "admin", "user1" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "UserGruop", "UserName" },
                values: new object[] { 2, "admin", "user2" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "UserGruop", "UserName" },
                values: new object[] { 3, "user", "user3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
