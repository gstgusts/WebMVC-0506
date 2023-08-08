using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMVC_0506.Migrations
{
    /// <inheritdoc />
    public partial class BirtDataAddedd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Student",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Student");
        }
    }
}
