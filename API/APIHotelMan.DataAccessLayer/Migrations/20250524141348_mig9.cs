using Microsoft.EntityFrameworkCore.Migrations;

namespace APIHotelMan.DataAccessLayer.Migrations
{
    public partial class mig9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactMessageCategoryId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ContactMessageCategories",
                columns: table => new
                {
                    ContactMessageCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactMessageCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMessageCategories", x => x.ContactMessageCategoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ContactMessageCategoryId",
                table: "Contacts",
                column: "ContactMessageCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_ContactMessageCategories_ContactMessageCategoryId",
                table: "Contacts",
                column: "ContactMessageCategoryId",
                principalTable: "ContactMessageCategories",
                principalColumn: "ContactMessageCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_ContactMessageCategories_ContactMessageCategoryId",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "ContactMessageCategories");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_ContactMessageCategoryId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "ContactMessageCategoryId",
                table: "Contacts");
        }
    }
}
