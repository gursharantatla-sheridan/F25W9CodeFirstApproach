using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F25W9CodeFirstApproach.Migrations
{
    /// <inheritdoc />
    public partial class ChangeStudentNameToName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Students",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "StudentName");
        }
    }
}
