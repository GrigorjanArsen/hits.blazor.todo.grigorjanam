using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class kaif : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjId",
                table: "TaskItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProjectItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectItem", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProjectItem",
                columns: new[] { "Id", "CreatedDate", "Description", "FinishDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 10, 16, 58, 32, 361, DateTimeKind.Local).AddTicks(2739), "Описание проекта 1", null, "Проект 1" },
                    { 2, new DateTime(2024, 11, 10, 16, 58, 32, 361, DateTimeKind.Local).AddTicks(2743), "Описание проекта 2", null, "Проект 2" }
                });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProjId" },
                values: new object[] { new DateTime(2024, 11, 10, 16, 58, 32, 361, DateTimeKind.Local).AddTicks(2243), null });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProjId" },
                values: new object[] { new DateTime(2024, 11, 10, 16, 58, 32, 361, DateTimeKind.Local).AddTicks(2272), null });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProjId" },
                values: new object[] { new DateTime(2024, 11, 10, 16, 58, 32, 361, DateTimeKind.Local).AddTicks(2275), null });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProjId" },
                values: new object[] { new DateTime(2024, 11, 10, 16, 58, 32, 361, DateTimeKind.Local).AddTicks(2277), null });

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_ProjId",
                table: "TaskItems",
                column: "ProjId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_ProjectItem_ProjId",
                table: "TaskItems",
                column: "ProjId",
                principalTable: "ProjectItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_ProjectItem_ProjId",
                table: "TaskItems");

            migrationBuilder.DropTable(
                name: "ProjectItem");

            migrationBuilder.DropIndex(
                name: "IX_TaskItems_ProjId",
                table: "TaskItems");

            migrationBuilder.DropColumn(
                name: "ProjId",
                table: "TaskItems");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 8, 16, 51, 12, 604, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 8, 16, 51, 12, 604, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 8, 16, 51, 12, 604, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 8, 16, 51, 12, 604, DateTimeKind.Local).AddTicks(6988));
        }
    }
}
