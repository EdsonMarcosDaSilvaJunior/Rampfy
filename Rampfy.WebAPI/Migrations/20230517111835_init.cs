using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rampfy.WebAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Codigo", "Email", "Senha" },
                values: new object[] { 1, 111, "email1@mail.com", "senha1" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Codigo", "Email", "Senha" },
                values: new object[] { 2, 222, "email2@mail.com", "senha2" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Codigo", "Email", "Senha" },
                values: new object[] { 3, 333, "email3@mail.com", "senha3" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Codigo", "Email", "Senha" },
                values: new object[] { 4, 444, "email4@mail.com", "senha4" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Codigo", "Email", "Senha" },
                values: new object[] { 5, 555, "email5@mail.com", "senha5" });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "Codigo", "Data", "Valor" },
                values: new object[] { 12, 3333, new DateTime(2023, 5, 15, 8, 18, 34, 997, DateTimeKind.Local).AddTicks(2313), 21.5 });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "Codigo", "Data", "Valor" },
                values: new object[] { 11, 2222, new DateTime(2023, 5, 14, 8, 18, 34, 997, DateTimeKind.Local).AddTicks(2311), 20.5 });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "Codigo", "Data", "Valor" },
                values: new object[] { 10, 1111, new DateTime(2023, 5, 13, 8, 18, 34, 997, DateTimeKind.Local).AddTicks(2309), 19.5 });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "Codigo", "Data", "Valor" },
                values: new object[] { 9, 999, new DateTime(2023, 5, 12, 8, 18, 34, 997, DateTimeKind.Local).AddTicks(2305), 18.5 });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "Codigo", "Data", "Valor" },
                values: new object[] { 8, 888, new DateTime(2023, 5, 11, 8, 18, 34, 997, DateTimeKind.Local).AddTicks(2303), 17.5 });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "Codigo", "Data", "Valor" },
                values: new object[] { 7, 777, new DateTime(2023, 5, 10, 8, 18, 34, 997, DateTimeKind.Local).AddTicks(2298), 16.5 });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "Codigo", "Data", "Valor" },
                values: new object[] { 5, 555, new DateTime(2023, 5, 8, 8, 18, 34, 997, DateTimeKind.Local).AddTicks(2283), 14.5 });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "Codigo", "Data", "Valor" },
                values: new object[] { 13, 4444, new DateTime(2023, 5, 16, 8, 18, 34, 997, DateTimeKind.Local).AddTicks(2315), 22.5 });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "Codigo", "Data", "Valor" },
                values: new object[] { 4, 444, new DateTime(2023, 5, 7, 8, 18, 34, 997, DateTimeKind.Local).AddTicks(2281), 13.5 });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "Codigo", "Data", "Valor" },
                values: new object[] { 3, 333, new DateTime(2023, 5, 6, 8, 18, 34, 997, DateTimeKind.Local).AddTicks(2278), 12.5 });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "Codigo", "Data", "Valor" },
                values: new object[] { 2, 222, new DateTime(2023, 5, 5, 8, 18, 34, 997, DateTimeKind.Local).AddTicks(2258), 11.5 });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "Codigo", "Data", "Valor" },
                values: new object[] { 1, 111, new DateTime(2023, 5, 5, 8, 18, 34, 993, DateTimeKind.Local).AddTicks(5560), 10.5 });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "Codigo", "Data", "Valor" },
                values: new object[] { 6, 666, new DateTime(2023, 5, 9, 8, 18, 34, 997, DateTimeKind.Local).AddTicks(2296), 15.5 });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "Codigo", "Data", "Valor" },
                values: new object[] { 14, 5555, new DateTime(2023, 5, 17, 8, 18, 34, 997, DateTimeKind.Local).AddTicks(2317), 23.5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
