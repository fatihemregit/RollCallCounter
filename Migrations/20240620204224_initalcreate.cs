using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace YoklamaTutucu.Migrations
{
    /// <inheritdoc />
    public partial class initalcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dersler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DersAdi = table.Column<string>(type: "text", nullable: false),
                    DersOgretimGorevlisiAdi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dersler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "devamsizliklar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DersId = table.Column<int>(type: "integer", nullable: false),
                    DevamsizlikSayisi = table.Column<int>(type: "integer", nullable: false),
                    devamsizlikTarihi = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_devamsizliklar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_devamsizliklar_dersler_DersId",
                        column: x => x.DersId,
                        principalTable: "dersler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_devamsizliklar_DersId",
                table: "devamsizliklar",
                column: "DersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "devamsizliklar");

            migrationBuilder.DropTable(
                name: "dersler");
        }
    }
}
