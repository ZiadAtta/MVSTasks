using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class addTraineeIdToCrc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TraineeId",
                table: "CrsResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CrsResults_TraineeId",
                table: "CrsResults",
                column: "TraineeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrsResults_Trainees_TraineeId",
                table: "CrsResults");

            migrationBuilder.DropIndex(
                name: "IX_CrsResults_TraineeId",
                table: "CrsResults");

            migrationBuilder.DropColumn(
                name: "TraineeId",
                table: "CrsResults");
        }
    }
}
