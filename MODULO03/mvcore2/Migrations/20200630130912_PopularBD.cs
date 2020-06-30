using Microsoft.EntityFrameworkCore.Migrations;

namespace mvcore2.Migrations
{
    public partial class PopularBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Clientes ([Nome], [Email])  VALUES('Felipe', 'felip3.fl@gmail.com')");
            migrationBuilder.Sql("INSERT INTO Clientes ([Nome], [Email]) VALUES('Joao', 'pedro@gmail.com')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE [Clientes]");

        }
    }
}
