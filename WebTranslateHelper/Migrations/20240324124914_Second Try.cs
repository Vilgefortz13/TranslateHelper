using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebTranslateHelper.Migrations
{
    /// <inheritdoc />
    public partial class SecondTry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sentences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ForeignSentence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NativeSentece = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sentences", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sentences");
        }
    }
}
