using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3Server.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "CoronaVaccine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceivingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VaccineManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoronaVaccine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoronaVaccine_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoronaVaccine_UserId",
                table: "CoronaVaccine",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoronaVaccine");

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
    }
}
