using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebTranslateHelper.Migrations
{
    /// <inheritdoc />
    public partial class RenameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NativeSentence",
                table: "Sentences",
                newName: "NativeSentence");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NativeSentence",
                table: "Sentences",
                newName: "NativeSentence");
        }
    }
}
