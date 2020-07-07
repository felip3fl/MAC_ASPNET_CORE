using Microsoft.EntityFrameworkCore.Migrations;

namespace Artistas.DAL.Migrations
{
    public partial class ArtistasDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Artistas
            migrationBuilder.Sql("INSERT INTO Artistas(Nome,Pais,Cidade,Site,Nascimento) VALUES('Elvis Aaron Presley','USA','Tupelo','www.elvis.com','1935-01-08')");
            migrationBuilder.Sql("INSERT INTO Artistas(Nome,Pais,Cidade,Site,Nascimento) VALUES('Madonna Louise Veronica Ciccone ','USA','Bay City','www.madonna.com','1958-08-18')");
            migrationBuilder.Sql("INSERT INTO Artistas(Nome,Pais,Cidade,Site,Nascimento) VALUES('Robert Allen Zimmerman','USA','Duluth','www.bobdylan.com','1935-01-08')");

            //ArtistaDetalhes
            migrationBuilder.Sql("INSERT INTO ArtistaDetalhes(Talento,Detalhes,ArtistaId) VALUES('Cantor','Começou sua carreira em 1954 na lendária gravadora Sun Records',1)");
            migrationBuilder.Sql("INSERT INTO ArtistaDetalhes(Talento,Detalhes,ArtistaId) VALUES('Cantora','Em 1977, mudou-se para Nova Iorque para tentar a carreira artística.',2)");
            migrationBuilder.Sql("INSERT INTO ArtistaDetalhes(Talento,Detalhes,ArtistaId) VALUES('Cantor','Nascido no estado de Minnesota, neto de imigrantes judeus russos.',3)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
            migrationBuilder.Sql("DELETE FROM ArtistaDetalhes");
        }
    }
}
