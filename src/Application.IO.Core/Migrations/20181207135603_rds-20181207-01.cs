using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.IO.Core.Migrations
{
    public partial class rds2018120701 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdmUsersSystem_AspNetUsers_IdApplicationUser",
                table: "AdmUsersSystem");

            migrationBuilder.DropForeignKey(
                name: "FK_Lawyers_AspNetUsers_IdApplicationUser",
                table: "Lawyers");

            migrationBuilder.DropForeignKey(
                name: "FK_OccupationAreasLawyer_Lawyers_IdLawyer",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropForeignKey(
                name: "FK_OccupationAreasLawyer_LawyerOccupationAreas_IdLawyerOccupationArea",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropIndex(
                name: "IX_OccupationAreasLawyer_IdLawyer",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropIndex(
                name: "IX_OccupationAreasLawyer_IdLawyerOccupationArea",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropIndex(
                name: "IX_Lawyers_IdApplicationUser",
                table: "Lawyers");

            migrationBuilder.DropIndex(
                name: "IX_AdmUsersSystem_IdApplicationUser",
                table: "AdmUsersSystem");

            migrationBuilder.DropColumn(
                name: "BusinessCellPhone",
                table: "Lawyers");

            migrationBuilder.DropColumn(
                name: "BusinessFax",
                table: "Lawyers");

            migrationBuilder.DropColumn(
                name: "BusinessPhone",
                table: "Lawyers");

            migrationBuilder.AddColumn<Guid>(
                name: "LawyerId",
                table: "OccupationAreasLawyer",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LawyerOccupationAreasId",
                table: "OccupationAreasLawyer",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "Lawyers",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "AdmUsersSystem",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PostalCodesAdress",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(maxLength: 8, nullable: false),
                    Place = table.Column<string>(maxLength: 100, nullable: false),
                    Neighborhood = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false),
                    StateName = table.Column<string>(maxLength: 30, nullable: false),
                    Country = table.Column<string>(maxLength: 40, nullable: false),
                    InsertByUser = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostalCodesAdress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LawyersSociety",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdLawyer = table.Column<Guid>(nullable: false),
                    IdPostalCodeAdress = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    Number = table.Column<string>(maxLength: 10, nullable: false),
                    Complement = table.Column<string>(maxLength: 100, nullable: true),
                    BusinessPhone = table.Column<string>(maxLength: 20, nullable: false),
                    BusinessFax = table.Column<string>(maxLength: 20, nullable: true),
                    BusinessEmail = table.Column<string>(maxLength: 256, nullable: true),
                    LawyerId = table.Column<Guid>(nullable: true),
                    PostalCodeAdressId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LawyersSociety", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LawyersSociety_Lawyers_LawyerId",
                        column: x => x.LawyerId,
                        principalTable: "Lawyers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LawyersSociety_PostalCodesAdress_PostalCodeAdressId",
                        column: x => x.PostalCodeAdressId,
                        principalTable: "PostalCodesAdress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OccupationAreasLawyer_LawyerId",
                table: "OccupationAreasLawyer",
                column: "LawyerId");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationAreasLawyer_LawyerOccupationAreasId",
                table: "OccupationAreasLawyer",
                column: "LawyerOccupationAreasId");

            migrationBuilder.CreateIndex(
                name: "IX_Lawyers_ApplicationUserId",
                table: "Lawyers",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AdmUsersSystem_ApplicationUserId",
                table: "AdmUsersSystem",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LawyersSociety_LawyerId",
                table: "LawyersSociety",
                column: "LawyerId");

            migrationBuilder.CreateIndex(
                name: "IX_LawyersSociety_PostalCodeAdressId",
                table: "LawyersSociety",
                column: "PostalCodeAdressId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_OccupationAreasLawyer_Lawyers_LawyerId",
                table: "OccupationAreasLawyer",
                column: "LawyerId",
                principalTable: "Lawyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OccupationAreasLawyer_LawyerOccupationAreas_LawyerOccupationAreasId",
                table: "OccupationAreasLawyer",
                column: "LawyerOccupationAreasId",
                principalTable: "LawyerOccupationAreas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdmUsersSystem_AspNetUsers_ApplicationUserId",
                table: "AdmUsersSystem");

            migrationBuilder.DropForeignKey(
                name: "FK_Lawyers_AspNetUsers_ApplicationUserId",
                table: "Lawyers");

            migrationBuilder.DropForeignKey(
                name: "FK_OccupationAreasLawyer_Lawyers_LawyerId",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropForeignKey(
                name: "FK_OccupationAreasLawyer_LawyerOccupationAreas_LawyerOccupationAreasId",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropTable(
                name: "LawyersSociety");

            migrationBuilder.DropTable(
                name: "PostalCodesAdress");

            migrationBuilder.DropIndex(
                name: "IX_OccupationAreasLawyer_LawyerId",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropIndex(
                name: "IX_OccupationAreasLawyer_LawyerOccupationAreasId",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropIndex(
                name: "IX_Lawyers_ApplicationUserId",
                table: "Lawyers");

            migrationBuilder.DropIndex(
                name: "IX_AdmUsersSystem_ApplicationUserId",
                table: "AdmUsersSystem");

            migrationBuilder.DropColumn(
                name: "LawyerId",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropColumn(
                name: "LawyerOccupationAreasId",
                table: "OccupationAreasLawyer");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Lawyers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AdmUsersSystem");

            migrationBuilder.AddColumn<string>(
                name: "BusinessCellPhone",
                table: "Lawyers",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessFax",
                table: "Lawyers",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BusinessPhone",
                table: "Lawyers",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationAreasLawyer_IdLawyer",
                table: "OccupationAreasLawyer",
                column: "IdLawyer");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationAreasLawyer_IdLawyerOccupationArea",
                table: "OccupationAreasLawyer",
                column: "IdLawyerOccupationArea");

            migrationBuilder.CreateIndex(
                name: "IX_Lawyers_IdApplicationUser",
                table: "Lawyers",
                column: "IdApplicationUser");

            migrationBuilder.CreateIndex(
                name: "IX_AdmUsersSystem_IdApplicationUser",
                table: "AdmUsersSystem",
                column: "IdApplicationUser");

            migrationBuilder.AddForeignKey(
                name: "FK_AdmUsersSystem_AspNetUsers_IdApplicationUser",
                table: "AdmUsersSystem",
                column: "IdApplicationUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lawyers_AspNetUsers_IdApplicationUser",
                table: "Lawyers",
                column: "IdApplicationUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OccupationAreasLawyer_Lawyers_IdLawyer",
                table: "OccupationAreasLawyer",
                column: "IdLawyer",
                principalTable: "Lawyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OccupationAreasLawyer_LawyerOccupationAreas_IdLawyerOccupationArea",
                table: "OccupationAreasLawyer",
                column: "IdLawyerOccupationArea",
                principalTable: "LawyerOccupationAreas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
