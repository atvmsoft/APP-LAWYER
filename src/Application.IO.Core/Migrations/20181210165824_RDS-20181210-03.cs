using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.IO.Core.Migrations
{
    public partial class RDS2018121003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IDX_Code",
                table: "PostalCodeAdress");

            migrationBuilder.CreateIndex(
                name: "IDX_Code",
                table: "PostalCodeAdress",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IDX_Code",
                table: "PostalCodeAdress");

            migrationBuilder.CreateIndex(
                name: "IDX_Code",
                table: "PostalCodeAdress",
                column: "Code");
        }
    }
}
