using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class MyDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_ProjectItem_ProjId",
                table: "TaskItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectItem",
                table: "ProjectItem");

            migrationBuilder.RenameTable(
                name: "ProjectItem",
                newName: "ProjectItems");

            migrationBuilder.AddColumn<DateTime>(
                name: "RegisteredDate",
                table: "ProjectItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectItems",
                table: "ProjectItems",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ProjectItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "RegisteredDate" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "ProjectItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "RegisteredDate" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_ProjectItems_ProjId",
                table: "TaskItems",
                column: "ProjId",
                principalTable: "ProjectItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_ProjectItems_ProjId",
                table: "TaskItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectItems",
                table: "ProjectItems");

            migrationBuilder.DropColumn(
                name: "RegisteredDate",
                table: "ProjectItems");

            migrationBuilder.RenameTable(
                name: "ProjectItems",
                newName: "ProjectItem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectItem",
                table: "ProjectItem",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ProjectItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 10, 16, 58, 32, 361, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "ProjectItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 10, 16, 58, 32, 361, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 10, 16, 58, 32, 361, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 10, 16, 58, 32, 361, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 10, 16, 58, 32, 361, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 10, 16, 58, 32, 361, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_ProjectItem_ProjId",
                table: "TaskItems",
                column: "ProjId",
                principalTable: "ProjectItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
