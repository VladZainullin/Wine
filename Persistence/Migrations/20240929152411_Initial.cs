using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "color",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_color", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sugar_content",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sugar_content", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "wines",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    color_id = table.Column<Guid>(type: "uuid", nullable: false),
                    sugar_content_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_wines", x => x.id);
                    table.ForeignKey(
                        name: "fk_wines_color_color_id",
                        column: x => x.color_id,
                        principalTable: "color",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_wines_sugar_content_sugar_content_id",
                        column: x => x.sugar_content_id,
                        principalTable: "sugar_content",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_color_title",
                table: "color",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_sugar_content_title",
                table: "sugar_content",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_wines_color_id",
                table: "wines",
                column: "color_id");

            migrationBuilder.CreateIndex(
                name: "ix_wines_sugar_content_id",
                table: "wines",
                column: "sugar_content_id");

            migrationBuilder.CreateIndex(
                name: "ix_wines_title",
                table: "wines",
                column: "title",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wines");

            migrationBuilder.DropTable(
                name: "color");

            migrationBuilder.DropTable(
                name: "sugar_content");
        }
    }
}
