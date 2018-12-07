using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.IO.Core.Migrations
{
    public partial class rds2018120703 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdministratorsSystem_AspNetUsers_ApplicationUserId",
                table: "AdministratorsSystem");

            migrationBuilder.DropForeignKey(
                name: "FK_LawyersSociety_Lawyers_LawyerId",
                table: "LawyersSociety");

            migrationBuilder.DropForeignKey(
                name: "FK_LawyersSociety_PostalCodesAdress_PostalCodeAdressId",
                table: "LawyersSociety");

            migrationBuilder.DropForeignKey(
                name: "FK_OccupationAreasLawyer_Lawyers_LawyerId",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropIndex(
                name: "IX_OccupationAreasLawyer_LawyerId",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropIndex(
                name: "IX_LawyersSociety_LawyerId",
                table: "LawyersSociety");

            migrationBuilder.DropIndex(
                name: "IX_LawyersSociety_PostalCodeAdressId",
                table: "LawyersSociety");

            migrationBuilder.DropIndex(
                name: "IX_AdministratorsSystem_ApplicationUserId",
                table: "AdministratorsSystem");

            migrationBuilder.DropColumn(
                name: "LawyerId",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropColumn(
                name: "LawyerId",
                table: "LawyersSociety");

            migrationBuilder.DropColumn(
                name: "PostalCodeAdressId",
                table: "LawyersSociety");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AdministratorsSystem");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationAreasLawyer_IdLawyer",
                table: "OccupationAreasLawyer",
                column: "IdLawyer");

            migrationBuilder.CreateIndex(
                name: "IX_LawyersSociety_IdLawyer",
                table: "LawyersSociety",
                column: "IdLawyer");

            migrationBuilder.CreateIndex(
                name: "IX_LawyersSociety_IdPostalCodeAdress",
                table: "LawyersSociety",
                column: "IdPostalCodeAdress");

            migrationBuilder.CreateIndex(
                name: "IX_AdministratorsSystem_IdApplicationUser",
                table: "AdministratorsSystem",
                column: "IdApplicationUser");

            migrationBuilder.AddForeignKey(
                name: "FK_AdministratorsSystem_AspNetUsers_IdApplicationUser",
                table: "AdministratorsSystem",
                column: "IdApplicationUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LawyersSociety_Lawyers_IdLawyer",
                table: "LawyersSociety",
                column: "IdLawyer",
                principalTable: "Lawyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LawyersSociety_PostalCodesAdress_IdPostalCodeAdress",
                table: "LawyersSociety",
                column: "IdPostalCodeAdress",
                principalTable: "PostalCodesAdress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OccupationAreasLawyer_Lawyers_IdLawyer",
                table: "OccupationAreasLawyer",
                column: "IdLawyer",
                principalTable: "Lawyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdministratorsSystem_AspNetUsers_IdApplicationUser",
                table: "AdministratorsSystem");

            migrationBuilder.DropForeignKey(
                name: "FK_LawyersSociety_Lawyers_IdLawyer",
                table: "LawyersSociety");

            migrationBuilder.DropForeignKey(
                name: "FK_LawyersSociety_PostalCodesAdress_IdPostalCodeAdress",
                table: "LawyersSociety");

            migrationBuilder.DropForeignKey(
                name: "FK_OccupationAreasLawyer_Lawyers_IdLawyer",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropIndex(
                name: "IX_OccupationAreasLawyer_IdLawyer",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropIndex(
                name: "IX_LawyersSociety_IdLawyer",
                table: "LawyersSociety");

            migrationBuilder.DropIndex(
                name: "IX_LawyersSociety_IdPostalCodeAdress",
                table: "LawyersSociety");

            migrationBuilder.DropIndex(
                name: "IX_AdministratorsSystem_IdApplicationUser",
                table: "AdministratorsSystem");

            migrationBuilder.AddColumn<Guid>(
                name: "LawyerId",
                table: "OccupationAreasLawyer",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LawyerId",
                table: "LawyersSociety",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PostalCodeAdressId",
                table: "LawyersSociety",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "AdministratorsSystem",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OccupationAreasLawyer_LawyerId",
                table: "OccupationAreasLawyer",
                column: "LawyerId");

            migrationBuilder.CreateIndex(
                name: "IX_LawyersSociety_LawyerId",
                table: "LawyersSociety",
                column: "LawyerId");

            migrationBuilder.CreateIndex(
                name: "IX_LawyersSociety_PostalCodeAdressId",
                table: "LawyersSociety",
                column: "PostalCodeAdressId");

            migrationBuilder.CreateIndex(
                name: "IX_AdministratorsSystem_ApplicationUserId",
                table: "AdministratorsSystem",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdministratorsSystem_AspNetUsers_ApplicationUserId",
                table: "AdministratorsSystem",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LawyersSociety_Lawyers_LawyerId",
                table: "LawyersSociety",
                column: "LawyerId",
                principalTable: "Lawyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LawyersSociety_PostalCodesAdress_PostalCodeAdressId",
                table: "LawyersSociety",
                column: "PostalCodeAdressId",
                principalTable: "PostalCodesAdress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OccupationAreasLawyer_Lawyers_LawyerId",
                table: "OccupationAreasLawyer",
                column: "LawyerId",
                principalTable: "Lawyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
