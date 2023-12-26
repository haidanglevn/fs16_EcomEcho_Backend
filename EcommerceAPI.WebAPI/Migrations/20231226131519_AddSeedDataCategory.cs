using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceAPI.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "id", "created_at", "image", "name", "updated_at" },
                values: new object[,]
                {
                    { new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/1000/1000?random=2", "Sport", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88499694-269b-4308-a64d-0e903a1f503d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/1000/1000?random=1", "Fashion", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/1000/1000?random=3", "Home", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("88499694-269b-4308-a64d-0e903a1f503d"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"));
        }
    }
}
