using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoList.Migrations
{
    public partial class UpdatedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                column: "UserId",
                value: new Guid("82cc16b8-b18f-4287-855d-a4e50f181e67"));

            migrationBuilder.UpdateData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                column: "UserId",
                value: new Guid("559f6897-fdc0-4270-abc4-6d9e578fbcba"));

            migrationBuilder.UpdateData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                column: "UserId",
                value: new Guid("821113c2-e93f-42b3-b392-0e09f5ac89b0"));

            migrationBuilder.UpdateData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                column: "UserId",
                value: new Guid("13f1612b-11e5-4af3-aaa2-fef6f992f36d"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
