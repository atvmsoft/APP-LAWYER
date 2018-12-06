using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.IO.Core.Migrations
{
    public partial class RDG2018120402 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdmUsersSystem",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdApplicationUser = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmUsersSystem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdmUsersSystem_AspNetUsers_IdApplicationUser",
                        column: x => x.IdApplicationUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdApplicationUser = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_IdApplicationUser",
                        column: x => x.IdApplicationUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdmUsersSystem_IdApplicationUser",
                table: "AdmUsersSystem",
                column: "IdApplicationUser");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IdApplicationUser",
                table: "Customers",
                column: "IdApplicationUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmUsersSystem");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
