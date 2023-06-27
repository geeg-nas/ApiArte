using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiArte.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localizacao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Artes",
                columns: new[] { "Id", "Artista", "Categoria", "Data", "Descricao", "Localizacao", "Titulo" },
                values: new object[,]
                {
                    { 1, "Leonardo da Vinci", "Pintura", 1503, "Mona Lisa também conhecida como A Gioconda ou ainda Mona Lisa del Giocondo é a mais notável e conhecida obra de Leonardo da Vinci", "Museu lo Louvre", "Monalisa" },
                    { 2, "Arthur Sasse", "Fotográfia", 1951, "Uma das imagens mais conhecidas da história é a do físico Albert Einstein mostrando a língua.", "indefinida", "Einstein mostrando a língua" },
                    { 3, "Leonardo da Vinci", "Pintura", 1503, "Mona Lisa também conhecida como A Gioconda ou ainda Mona Lisa del Giocondo é a mais notável e conhecida obra de Leonardo da Vinci", "Museu lo Louvre", "Monalisa" },
                    { 4, "Leonardo da Vinci", "Pintura", 1503, "Mona Lisa também conhecida como A Gioconda ou ainda Mona Lisa del Giocondo é a mais notável e conhecida obra de Leonardo da Vinci", "Museu lo Louvre", "Monalisa" },
                    { 5, "Leonardo da Vinci", "Pintura", 1503, "Mona Lisa também conhecida como A Gioconda ou ainda Mona Lisa del Giocondo é a mais notável e conhecida obra de Leonardo da Vinci", "Museu lo Louvre", "Monalisa" },
                    { 6, "Leonardo da Vinci", "Pintura", 1503, "Mona Lisa também conhecida como A Gioconda ou ainda Mona Lisa del Giocondo é a mais notável e conhecida obra de Leonardo da Vinci", "Museu lo Louvre", "Monalisa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artes");
        }
    }
}
