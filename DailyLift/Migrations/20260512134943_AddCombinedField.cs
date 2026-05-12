using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DailyLift.Migrations
{
    /// <inheritdoc />
    public partial class AddCombinedField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Combined",
                table: "LiftItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Combined",
                table: "LiftItems");
        }
    }
}
