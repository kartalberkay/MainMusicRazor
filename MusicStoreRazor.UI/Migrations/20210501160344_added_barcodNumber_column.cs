using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicStoreRazor.UI.Migrations
{
    public partial class added_barcodNumber_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BarcodeNumber",
                table: "Musics",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BarcodeNumber",
                table: "Musics");
        }
    }
}
