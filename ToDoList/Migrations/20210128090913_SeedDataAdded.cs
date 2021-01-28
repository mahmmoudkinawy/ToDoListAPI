using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoList.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ToDoItems",
                columns: new[] { "Id", "Completed", "Text" },
                values: new object[,]
                {
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), true, "Playing football" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), true, "Watching TV" },
                    { new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), false, "Swimming" },
                    { new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"), false, "Traveling abroad" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"));

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: new Guid("2902b665-1190-4c70-9915-b9c2d7680450"));

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"));

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"));
        }
    }
}
