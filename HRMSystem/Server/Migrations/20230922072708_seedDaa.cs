using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRMSystem.Server.Migrations
{
    /// <inheritdoc />
    public partial class seedDaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Created", "DepartmentId", "FirstName", "Gender", "IsDeleted", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 27, 8, 30, 39, 999, DateTimeKind.Unspecified), 1234, "FirstName1", "Male", false, "LastName1" },
                    { 2, new DateTime(2022, 8, 27, 8, 30, 39, 999, DateTimeKind.Unspecified), 1235, "FirstName2", "Male", false, "LastName2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
