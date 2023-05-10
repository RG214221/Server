using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3Server.Repository.Migrations
{
    /// <inheritdoc />
    public partial class createTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoronaInformation",
                columns: table => new
                {
                    CoronaInformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceivingCoronaVaccineDate1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceivingCoronaVaccineDate2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceivingCoronaVaccineDate3 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceivingCoronaVaccineDate4 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VaccineManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceivingPositiveResultDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecoveryDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoronaInformation", x => x.CoronaInformationId);
                });

            migrationBuilder.CreateTable(
                name: "PersonalInformation",
                columns: table => new
                {
                    PersonalInformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInformation", x => x.PersonalInformationId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalInformationId = table.Column<int>(type: "int", nullable: false),
                    CoronaInformationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_CoronaInformation_CoronaInformationId",
                        column: x => x.CoronaInformationId,
                        principalTable: "CoronaInformation",
                        principalColumn: "CoronaInformationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_PersonalInformation_PersonalInformationId",
                        column: x => x.PersonalInformationId,
                        principalTable: "PersonalInformation",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CoronaInformationId",
                table: "Users",
                column: "CoronaInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PersonalInformationId",
                table: "Users",
                column: "PersonalInformationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CoronaInformation");

            migrationBuilder.DropTable(
                name: "PersonalInformation");
        }
    }
}
