using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.IO.Core.Migrations
{
    public partial class rds2018120705 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OccupationAreasLawyer_LawyerOccupationAreas_LawyerOccupationAreasId",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropIndex(
                name: "IX_OccupationAreasLawyer_LawyerOccupationAreasId",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropColumn(
                name: "LawyerOccupationAreasId",
                table: "OccupationAreasLawyer");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationAreasLawyer_IdLawyerOccupationArea",
                table: "OccupationAreasLawyer",
                column: "IdLawyerOccupationArea");

            migrationBuilder.AddForeignKey(
                name: "FK_OccupationAreasLawyer_LawyerOccupationAreas_IdLawyerOccupationArea",
                table: "OccupationAreasLawyer",
                column: "IdLawyerOccupationArea",
                principalTable: "LawyerOccupationAreas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OccupationAreasLawyer_LawyerOccupationAreas_IdLawyerOccupationArea",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropIndex(
                name: "IX_OccupationAreasLawyer_IdLawyerOccupationArea",
                table: "OccupationAreasLawyer");

            migrationBuilder.AddColumn<Guid>(
                name: "LawyerOccupationAreasId",
                table: "OccupationAreasLawyer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OccupationAreasLawyer_LawyerOccupationAreasId",
                table: "OccupationAreasLawyer",
                column: "LawyerOccupationAreasId");

            migrationBuilder.AddForeignKey(
                name: "FK_OccupationAreasLawyer_LawyerOccupationAreas_LawyerOccupationAreasId",
                table: "OccupationAreasLawyer",
                column: "LawyerOccupationAreasId",
                principalTable: "LawyerOccupationAreas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
