using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceAPI.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 39, 3, 498, DateTimeKind.Local).AddTicks(4576), new DateTime(2023, 12, 26, 15, 39, 3, 498, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("88499694-269b-4308-a64d-0e903a1f503d"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 39, 3, 498, DateTimeKind.Local).AddTicks(4569), new DateTime(2023, 12, 26, 15, 39, 3, 498, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 39, 3, 498, DateTimeKind.Local).AddTicks(4580), new DateTime(2023, 12, 26, 15, 39, 3, 498, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 39, 3, 498, DateTimeKind.Local).AddTicks(4516), new DateTime(2023, 12, 26, 15, 39, 3, 498, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 39, 3, 498, DateTimeKind.Local).AddTicks(4508), new DateTime(2023, 12, 26, 15, 39, 3, 498, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 39, 3, 498, DateTimeKind.Local).AddTicks(4494), new DateTime(2023, 12, 26, 15, 39, 3, 498, DateTimeKind.Local).AddTicks(4497) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("88499694-269b-4308-a64d-0e903a1f503d"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
