using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyectos_profesionales.Data.Migrations
{
    public partial class migrationEmpleado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Número = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Paterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Materno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Teléfono = table.Column<int>(type: "int", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Puesto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Departamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.EmpleadoId);
                });

            migrationBuilder.CreateTable(
                name: "Historial",
                columns: table => new
                {
                    HistorialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    A_Observación = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observación = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comportamiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripción = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Condición = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Criticidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Retroalmentada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aspectos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resposable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Archibos = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historial", x => x.HistorialId);
                });

            migrationBuilder.CreateTable(
                name: "Reporte",
                columns: table => new
                {
                    ReporteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    A_Observación = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observación = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comportamiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripción = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Condición = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Criticidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_Retroalmentada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aspectos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resposable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Archibos = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reporte", x => x.ReporteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Historial");

            migrationBuilder.DropTable(
                name: "Reporte");
        }
    }
}
