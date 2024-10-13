using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class addedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "ManagerName", "Name" },
                values: new object[,]
                {
                    { 1, "Alice Johnson", "Computer Science" },
                    { 2, "Bob Smith", "Mathematics" },
                    { 3, "Carol White", "Physics" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Degree", "DeptId", "MinDegree", "Name" },
                values: new object[,]
                {
                    { 1, 3, 1, 50, "Introduction to Programming" },
                    { 2, 4, 2, 60, "Calculus I" },
                    { 3, 4, 3, 65, "Classical Mechanics" }
                });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "Id", "Address", "DeptId", "Grade", "Imag", "Name" },
                values: new object[,]
                {
                    { 1, "321 Pine St", 1, 75, "trainee1.jpg", "Michael Green" },
                    { 2, "654 Maple St", 2, 80, "trainee2.jpg", "Sarah Lee" },
                    { 3, "987 Birch St", 3, 70, "trainee3.jpg", "David Black" }
                });

            migrationBuilder.InsertData(
                table: "CrsResults",
                columns: new[] { "Id", "CrsId", "Degree", "DeptId", "TraineeId" },
                values: new object[,]
                {
                    { 1, 1, 85, 1, 1 },
                    { 2, 2, 90, 2, 2 },
                    { 3, 3, 75, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Address", "CourseId", "DeptId", "Imag", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "123 Main St", 1, 1, "image1.jpg", "Dr. John Doe", 80000.0 },
                    { 2, "456 Elm St", 2, 2, "image2.jpg", "Dr. Jane Smith", 85000.0 },
                    { 3, "789 Oak St", 3, 3, "image3.jpg", "Dr. Jim Brown", 78000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CrsResults",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CrsResults",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CrsResults",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
