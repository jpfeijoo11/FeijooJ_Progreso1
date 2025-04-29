using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeijooJ_Progreso1.Migrations
{
    /// <inheritdoc />
    public partial class FeijooJ_Progreso1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeijooJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Edad = table.Column<double>(type: "float", maxLength: 20, nullable: false),
                    SeHospedoAntes = table.Column<bool>(type: "bit", nullable: false),
                    FechaEntrada = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaSalida = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanRecompensa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaInicioP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NoReservas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanRecompensa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    FechaEntradaCliente = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FechaSalidaCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorAPagar = table.Column<double>(type: "float", maxLength: 20, nullable: false),
                    IdentificacionCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.FechaEntradaCliente);
                    table.ForeignKey(
                        name: "FK_Reserva_Cliente_IdentificacionCliente",
                        column: x => x.IdentificacionCliente,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_IdentificacionCliente",
                table: "Reserva",
                column: "IdentificacionCliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanRecompensa");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
