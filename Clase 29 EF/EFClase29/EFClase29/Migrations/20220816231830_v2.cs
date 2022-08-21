using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFClase29.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepositoId",
                table: "Productos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Depositos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucursalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depositos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Depositos_Sucursals_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_DepositoId",
                table: "Productos",
                column: "DepositoId");

            migrationBuilder.CreateIndex(
                name: "IX_Depositos_SucursalId",
                table: "Depositos",
                column: "SucursalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Depositos_DepositoId",
                table: "Productos",
                column: "DepositoId",
                principalTable: "Depositos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Depositos_DepositoId",
                table: "Productos");

            migrationBuilder.DropTable(
                name: "Depositos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_DepositoId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "DepositoId",
                table: "Productos");
        }
    }
}
