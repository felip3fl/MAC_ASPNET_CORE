using Microsoft.EntityFrameworkCore.Migrations;

namespace Mvc_EFCore2.Migrations
{
    public partial class SeedDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //PARA CRIAR
            migrationBuilder.Sql("INSERT INTO ALUNOS(NOME,SEXO,EMAIL,NASCIMENTO) VALUES('Felipe Lima','Masculino','felip3.fl@gmail.com','1998/02/02')");
            migrationBuilder.Sql("INSERT INTO ALUNOS(NOME,SEXO,EMAIL,NASCIMENTO) VALUES('Joao','Masculino','Joao@gmail.com','2001/06/15')");
            migrationBuilder.Sql("INSERT INTO ALUNOS(NOME,SEXO,EMAIL,NASCIMENTO) VALUES('Maria','Feminino','Maria@gmail.com','1993/07/01')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //PARA DESFAZER
            migrationBuilder.Sql("DELETE ALUNOS");
        }
    }
}
