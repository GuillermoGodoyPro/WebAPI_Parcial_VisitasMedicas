using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI_Parcial_VisitasMedicas.Migrations
{
    public partial class CreacionBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ambulancias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empresa = table.Column<string>(type: "varchar(30)", nullable: false),
                    Codigo = table.Column<string>(type: "varchar(30)", nullable: false),
                    ObraSocial = table.Column<string>(type: "varchar(30)", nullable: false),
                    Afiliado = table.Column<string>(type: "varchar(50)", nullable: false),
                    DNI = table.Column<int>(nullable: false),
                    Precio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambulancias", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ambulancias");
        }
    }
}
