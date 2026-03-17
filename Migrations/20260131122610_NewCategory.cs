 using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class NewCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryLidid",
                table: "ContactLids",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoryLids",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryLids", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactLids_CategoryLidid",
                table: "ContactLids",
                column: "CategoryLidid");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactLids_CategoryLids_CategoryLidid",
                table: "ContactLids",
                column: "CategoryLidid",
                principalTable: "CategoryLids",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactLids_CategoryLids_CategoryLidid",
                table: "ContactLids");

            migrationBuilder.DropTable(
                name: "CategoryLids");

            migrationBuilder.DropIndex(
                name: "IX_ContactLids_CategoryLidid",
                table: "ContactLids");

            migrationBuilder.DropColumn(
                name: "CategoryLidid",
                table: "ContactLids");
        }
    }
}
