using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmApi.Migrations
{
    /// <inheritdoc />
    public partial class RemoveNumberFromCinema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Cinemas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Cinemas",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
