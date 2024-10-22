using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeDirectoryWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactInformationEmployeeProfile");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformations_EmployeeId",
                table: "ContactInformations",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInformations_EmployeeProfiles_EmployeeId",
                table: "ContactInformations",
                column: "EmployeeId",
                principalTable: "EmployeeProfiles",
                principalColumn: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformations_EmployeeProfiles_EmployeeId",
                table: "ContactInformations");

            migrationBuilder.DropIndex(
                name: "IX_ContactInformations_EmployeeId",
                table: "ContactInformations");

            migrationBuilder.CreateTable(
                name: "ContactInformationEmployeeProfile",
                columns: table => new
                {
                    ContactInformationsContactId = table.Column<int>(type: "int", nullable: false),
                    EmployeeProfilesEmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInformationEmployeeProfile", x => new { x.ContactInformationsContactId, x.EmployeeProfilesEmployeeId });
                    table.ForeignKey(
                        name: "FK_ContactInformationEmployeeProfile_ContactInformations_ContactInformationsContactId",
                        column: x => x.ContactInformationsContactId,
                        principalTable: "ContactInformations",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactInformationEmployeeProfile_EmployeeProfiles_EmployeeProfilesEmployeeId",
                        column: x => x.EmployeeProfilesEmployeeId,
                        principalTable: "EmployeeProfiles",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformationEmployeeProfile_EmployeeProfilesEmployeeId",
                table: "ContactInformationEmployeeProfile",
                column: "EmployeeProfilesEmployeeId");
        }
    }
}
