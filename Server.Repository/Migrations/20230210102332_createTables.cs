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
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrivateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserIDNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HMO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Child",
                columns: table => new
                {
                    ChildID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChildName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChildIDNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Child", x => x.ChildID);
                    table.ForeignKey(
                        name: "FK_Child_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Child_UserId",
                table: "Child",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Child");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
