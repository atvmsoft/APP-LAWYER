using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.IO.Core.Migrations
{
    public partial class rds2018120702 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdmUsersSystem_AspNetUsers_ApplicationUserId",
                table: "AdmUsersSystem");

            migrationBuilder.DropForeignKey(
                name: "FK_Lawyers_AspNetUsers_ApplicationUserId",
                table: "Lawyers");

            migrationBuilder.DropIndex(
                name: "IX_Lawyers_ApplicationUserId",
                table: "Lawyers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdmUsersSystem",
                table: "AdmUsersSystem");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Lawyers");

            migrationBuilder.RenameTable(
                name: "AdmUsersSystem",
                newName: "AdministratorsSystem");

            migrationBuilder.RenameIndex(
                name: "IX_AdmUsersSystem_ApplicationUserId",
                table: "AdministratorsSystem",
                newName: "IX_AdministratorsSystem_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdministratorsSystem",
                table: "AdministratorsSystem",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Lawyers_IdApplicationUser",
                table: "Lawyers",
                column: "IdApplicationUser");

            migrationBuilder.AddForeignKey(
                name: "FK_AdministratorsSystem_AspNetUsers_ApplicationUserId",
                table: "AdministratorsSystem",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lawyers_AspNetUsers_IdApplicationUser",
                table: "Lawyers",
                column: "IdApplicationUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdministratorsSystem_AspNetUsers_ApplicationUserId",
                table: "AdministratorsSystem");

            migrationBuilder.DropForeignKey(
                name: "FK_Lawyers_AspNetUsers_IdApplicationUser",
                table: "Lawyers");

            migrationBuilder.DropIndex(
                name: "IX_Lawyers_IdApplicationUser",
                table: "Lawyers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdministratorsSystem",
                table: "AdministratorsSystem");

            migrationBuilder.RenameTable(
                name: "AdministratorsSystem",
                newName: "AdmUsersSystem");

            migrationBuilder.RenameIndex(
                name: "IX_AdministratorsSystem_ApplicationUserId",
                table: "AdmUsersSystem",
                newName: "IX_AdmUsersSystem_ApplicationUserId");

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "Lawyers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdmUsersSystem",
                table: "AdmUsersSystem",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Lawyers_ApplicationUserId",
                table: "Lawyers",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdmUsersSystem_AspNetUsers_ApplicationUserId",
                table: "AdmUsersSystem",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lawyers_AspNetUsers_ApplicationUserId",
                table: "Lawyers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
