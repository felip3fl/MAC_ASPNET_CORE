using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Artistas.DAL.Migrations
{
    public partial class ArtistasInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artistas",
                columns: table => new
                {
                    ArtistaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 80, nullable: false),
                    Pais = table.Column<string>(maxLength: 80, nullable: true),
                    Cidade = table.Column<string>(maxLength: 80, nullable: true),
                    Site = table.Column<string>(maxLength: 80, nullable: true),
                    Nascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artistas", x => x.ArtistaId);
                });

            migrationBuilder.CreateTable(
                name: "ArtistaDetalhes",
                columns: table => new
                {
                    ArtistaDetalheId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Talento = table.Column<string>(maxLength: 80, nullable: false),
                    Detalhes = table.Column<string>(maxLength: 255, nullable: true),
                    ArtistaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistaDetalhes", x => x.ArtistaDetalheId);
                    table.ForeignKey(
                        name: "FK_ArtistaDetalhes_Artistas_ArtistaId",
                        column: x => x.ArtistaId,
                        principalTable: "Artistas",
                        principalColumn: "ArtistaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistaDetalhes_ArtistaId",
                table: "ArtistaDetalhes",
                column: "ArtistaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistaDetalhes");

            migrationBuilder.DropTable(
                name: "Artistas");
        }
    }
}
