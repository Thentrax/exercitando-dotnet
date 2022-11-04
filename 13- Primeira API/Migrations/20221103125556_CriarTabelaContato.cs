using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _13__Primeira_API.Migrations
{
    public partial class CriarTabelaContato : Migration
    {
        //Migration gerada automaticamente usando o comando dotnet-ef migration add AcaoTabelaNome.
        //Para que ela seja rodada basta rodar o comando dotnet-ef database update.
        protected override void Up(MigrationBuilder migrationBuilder) 
        {
            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");
        }
    }
}
