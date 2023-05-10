using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3Server.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_CoronaInformation_CoronaInformationId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_PersonalInformation_PersonalInformationId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "CoronaInformation");

            migrationBuilder.DropTable(
                name: "PersonalInformation");

            migrationBuilder.DropIndex(
                name: "IX_Users_CoronaInformationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PersonalInformationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CoronaInformationId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "PersonalInformationId",
                table: "Users",
                newName: "HouseNumber");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IDNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReceivingCoronaVaccineDate1",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReceivingCoronaVaccineDate2",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReceivingCoronaVaccineDate3",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReceivingCoronaVaccineDate4",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReceivingPositiveResultDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RecoveryDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TelNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VaccineManufacturerVaccine1",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VaccineManufacturerVaccine2",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VaccineManufacturerVaccine3",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VaccineManufacturerVaccine4",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DOB",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IDNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ReceivingCoronaVaccineDate1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ReceivingCoronaVaccineDate2",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ReceivingCoronaVaccineDate3",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ReceivingCoronaVaccineDate4",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ReceivingPositiveResultDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RecoveryDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TelNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "VaccineManufacturerVaccine1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "VaccineManufacturerVaccine2",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "VaccineManufacturerVaccine3",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "VaccineManufacturerVaccine4",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "HouseNumber",
                table: "Users",
                newName: "PersonalInformationId");

            migrationBuilder.AddColumn<int>(
                name: "CoronaInformationId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                    ReceivingPositiveResultDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecoveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VaccineManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<int>(type: "int", nullable: false),
                    IDNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInformation", x => x.PersonalInformationId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CoronaInformationId",
                table: "Users",
                column: "CoronaInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PersonalInformationId",
                table: "Users",
                column: "PersonalInformationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_CoronaInformation_CoronaInformationId",
                table: "Users",
                column: "CoronaInformationId",
                principalTable: "CoronaInformation",
                principalColumn: "CoronaInformationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_PersonalInformation_PersonalInformationId",
                table: "Users",
                column: "PersonalInformationId",
                principalTable: "PersonalInformation",
                principalColumn: "PersonalInformationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
