using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techtestpaymentapi.Migrations
{
    /// <inheritdoc />
    public partial class TabelaVendaEVendedores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    idvenda = table.Column<int>(name: "id_venda", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datavenda = table.Column<DateTime>(name: "data_venda", type: "datetime2", nullable: false),
                    statusvenda = table.Column<int>(name: "status_venda", type: "int", nullable: false),
                    idvendedor = table.Column<int>(name: "id_vendedor", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.idvenda);
                    table.ForeignKey(
                        name: "FK_Vendas_Vendedores_id_vendedor",
                        column: x => x.idvendedor,
                        principalTable: "Vendedores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemVenda",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idvenda = table.Column<int>(name: "id_venda", type: "int", nullable: false),
                    nomeitem = table.Column<string>(name: "nome_item", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemVenda", x => x.id);
                    table.ForeignKey(
                        name: "FK_ItemVenda_Vendas_id_venda",
                        column: x => x.idvenda,
                        principalTable: "Vendas",
                        principalColumn: "id_venda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemVenda_id_venda",
                table: "ItemVenda",
                column: "id_venda");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_id_vendedor",
                table: "Vendas",
                column: "id_vendedor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemVenda");

            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropTable(
                name: "Vendedores");
        }
    }
}
