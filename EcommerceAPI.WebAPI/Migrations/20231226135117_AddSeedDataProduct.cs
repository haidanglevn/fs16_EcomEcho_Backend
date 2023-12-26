using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceAPI.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 51, 17, 620, DateTimeKind.Local).AddTicks(7159), new DateTime(2023, 12, 26, 15, 51, 17, 620, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("88499694-269b-4308-a64d-0e903a1f503d"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 51, 17, 620, DateTimeKind.Local).AddTicks(7152), new DateTime(2023, 12, 26, 15, 51, 17, 620, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 51, 17, 620, DateTimeKind.Local).AddTicks(7163), new DateTime(2023, 12, 26, 15, 51, 17, 620, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 51, 17, 620, DateTimeKind.Local).AddTicks(7094), new DateTime(2023, 12, 26, 15, 51, 17, 620, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 51, 17, 620, DateTimeKind.Local).AddTicks(7089), new DateTime(2023, 12, 26, 15, 51, 17, 620, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 51, 17, 620, DateTimeKind.Local).AddTicks(7030), new DateTime(2023, 12, 26, 15, 51, 17, 620, DateTimeKind.Local).AddTicks(7079) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 42, 26, 20, DateTimeKind.Local).AddTicks(5473), new DateTime(2023, 12, 26, 15, 42, 26, 20, DateTimeKind.Local).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("88499694-269b-4308-a64d-0e903a1f503d"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 42, 26, 20, DateTimeKind.Local).AddTicks(5467), new DateTime(2023, 12, 26, 15, 42, 26, 20, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 42, 26, 20, DateTimeKind.Local).AddTicks(5477), new DateTime(2023, 12, 26, 15, 42, 26, 20, DateTimeKind.Local).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 42, 26, 20, DateTimeKind.Local).AddTicks(5412), new DateTime(2023, 12, 26, 15, 42, 26, 20, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 42, 26, 20, DateTimeKind.Local).AddTicks(5407), new DateTime(2023, 12, 26, 15, 42, 26, 20, DateTimeKind.Local).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 42, 26, 20, DateTimeKind.Local).AddTicks(5341), new DateTime(2023, 12, 26, 15, 42, 26, 20, DateTimeKind.Local).AddTicks(5398) });
        }
    }
}
