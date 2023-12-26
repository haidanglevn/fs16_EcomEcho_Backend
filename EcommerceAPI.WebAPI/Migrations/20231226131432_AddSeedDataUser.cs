using System;
using EcommerceAPI.Core.src.Entity;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceAPI.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "avatar",
                table: "users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "user_id",
                table: "addresses",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "avatar", "created_at", "email", "first_name", "last_name", "password", "role", "updated_at" },
                values: new object[,]
                {
                    { new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b"), "https://picsum.photos/1000/1000?random=1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doe@mail.com", "John", "Doe", "password", Role.Customer, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9"), "https://picsum.photos/1000/1000?random=1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cena@mail.com", "John", "Cena", "password", Role.Customer, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab"), "https://picsum.photos/1000/1000?random=1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@mail.com", "Admin", "admin", "admin", Role.Admin, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab"));

            migrationBuilder.DropColumn(
                name: "avatar",
                table: "users");

            migrationBuilder.AlterColumn<Guid>(
                name: "user_id",
                table: "addresses",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");
        }
    }
}
