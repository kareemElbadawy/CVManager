using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExperienceInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyField = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CVs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PersonalInformationId = table.Column<int>(type: "int", nullable: false),
                    ExperienceInformationId = table.Column<int>(type: "int", nullable: false),
                    ExperienceInformationId1 = table.Column<int>(type: "int", nullable: true),
                    PersonalInformationId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CVs_ExperienceInformations_ExperienceInformationId",
                        column: x => x.ExperienceInformationId,
                        principalTable: "ExperienceInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CVs_ExperienceInformations_ExperienceInformationId1",
                        column: x => x.ExperienceInformationId1,
                        principalTable: "ExperienceInformations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CVs_PersonalInformations_PersonalInformationId",
                        column: x => x.PersonalInformationId,
                        principalTable: "PersonalInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CVs_PersonalInformations_PersonalInformationId1",
                        column: x => x.PersonalInformationId1,
                        principalTable: "PersonalInformations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CVs_ExperienceInformationId",
                table: "CVs",
                column: "ExperienceInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_CVs_ExperienceInformationId1",
                table: "CVs",
                column: "ExperienceInformationId1");

            migrationBuilder.CreateIndex(
                name: "IX_CVs_PersonalInformationId",
                table: "CVs",
                column: "PersonalInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_CVs_PersonalInformationId1",
                table: "CVs",
                column: "PersonalInformationId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CVs");

            migrationBuilder.DropTable(
                name: "ExperienceInformations");

            migrationBuilder.DropTable(
                name: "PersonalInformations");
        }
    }
}
