using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class addcolumnDegreeOfCourseToDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseDegree",
                table: "CrsResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CrsResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseDegree",
                value: 0);

            migrationBuilder.UpdateData(
                table: "CrsResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseDegree",
                value: 0);

            migrationBuilder.UpdateData(
                table: "CrsResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "CourseDegree",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseDegree",
                table: "CrsResults");
        }
    }
}
