using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CVs_ExperienceInformations_ExperienceInformationId1",
                table: "CVs");

            migrationBuilder.DropForeignKey(
                name: "FK_CVs_PersonalInformations_PersonalInformationId1",
                table: "CVs");

            migrationBuilder.DropIndex(
                name: "IX_CVs_ExperienceInformationId1",
                table: "CVs");

            migrationBuilder.DropIndex(
                name: "IX_CVs_PersonalInformationId1",
                table: "CVs");

            migrationBuilder.DropColumn(
                name: "ExperienceInformationId1",
                table: "CVs");

            migrationBuilder.DropColumn(
                name: "PersonalInformationId1",
                table: "CVs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExperienceInformationId1",
                table: "CVs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonalInformationId1",
                table: "CVs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CVs_ExperienceInformationId1",
                table: "CVs",
                column: "ExperienceInformationId1");

            migrationBuilder.CreateIndex(
                name: "IX_CVs_PersonalInformationId1",
                table: "CVs",
                column: "PersonalInformationId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CVs_ExperienceInformations_ExperienceInformationId1",
                table: "CVs",
                column: "ExperienceInformationId1",
                principalTable: "ExperienceInformations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CVs_PersonalInformations_PersonalInformationId1",
                table: "CVs",
                column: "PersonalInformationId1",
                principalTable: "PersonalInformations",
                principalColumn: "Id");
        }
    }
}
