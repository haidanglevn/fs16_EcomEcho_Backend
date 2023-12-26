using System;
using EcommerceAPI.Core.src.Entity;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceAPI.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataImageVariant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "product_id",
                table: "variants",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "addresses",
                columns: new[] { "id", "city", "country", "created_at", "postal_code", "state", "street", "updated_at", "user_id" },
                values: new object[,]
                {
                    { new Guid("a1a1a1a1-1234-1234-1234-1234567890ab"), "Helsinki", "Finland", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2687), "00100", null, "Street 1", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2689), new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab") },
                    { new Guid("a2a2a2a2-1234-1234-1234-1234567890ab"), "Helsinki", "Finland", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2696), "00200", null, "Street 2", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2698), new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab") },
                    { new Guid("a3a3a3a3-1234-1234-1234-1234567890ab"), "Helsinki", "Finland", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2701), "00300", null, "Street 3", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2703), new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab") },
                    { new Guid("b1b1b1b1-1234-1234-1234-1234567890ab"), "Espoo", "Finland", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2707), "02100", null, "Street 1", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2709), new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9") },
                    { new Guid("b2b2b2b2-1234-1234-1234-1234567890ab"), "Espoo", "Finland", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2712), "02100", null, "Street 2", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2714), new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9") },
                    { new Guid("b3b3b3b3-1234-1234-1234-1234567890ab"), "Espoo", "Finland", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2718), "02100", null, "Street 3", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2720), new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9") },
                    { new Guid("c1c1c1c1-1234-1234-1234-1234567890ab"), "Tampere", "Finland", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2724), "33100", null, "Street 3", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2726), new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b") },
                    { new Guid("c2c2c2c2-1234-1234-1234-1234567890ab"), "Tampere", "Finland", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2729), "33100", null, "Street 4", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2731), new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b") },
                    { new Guid("c3c3c3c3-1234-1234-1234-1234567890ab"), "Tampere", "Finland", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2735), "33100", null, "Street 6", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2737), new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b") }
                });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1474), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("88499694-269b-4308-a64d-0e903a1f503d"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1466), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1480), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1482) });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "category_id", "created_at", "description", "price", "title", "updated_at" },
                values: new object[,]
                {
                    { new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1584), "Description for Home Product 1", 300m, "Home Product 1", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1586) },
                    { new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new Guid("88499694-269b-4308-a64d-0e903a1f503d"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1548), "Description for Fashion Product 5", 104m, "Fashion Product 5", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1550) },
                    { new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1567), "Description for Sport Product 3", 154m, "Sport Product 3", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1569) },
                    { new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1595), "Description for Home Product 3", 56m, "Home Product 3", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1597) },
                    { new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1561), "Description for Sport Product 2", 240m, "Sport Product 2", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1563) },
                    { new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1556), "Description for Sport Product 1", 200m, "Sport Product 1", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1558) },
                    { new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1572), "Description for Sport Product 4", 333m, "Sport Product 4", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1574) },
                    { new Guid("865770da-89af-4719-b00c-310b57d535e1"), new Guid("88499694-269b-4308-a64d-0e903a1f503d"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1537), "Description for Fashion Product 3", 120m, "Fashion Product 3", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1539) },
                    { new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1605), "Description for Home Product 5", 3000m, "Home Product 5", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1607) },
                    { new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1600), "Description for Home Product 4", 143m, "Home Product 4", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1602) },
                    { new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1589), "Description for Home Product 2", 32m, "Home Product 2", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1591) },
                    { new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new Guid("88499694-269b-4308-a64d-0e903a1f503d"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1522), "Description for Fashion Product 1", 100m, "Fashion Product 1", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1524) },
                    { new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new Guid("88499694-269b-4308-a64d-0e903a1f503d"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1542), "Description for Fashion Product 4", 200m, "Fashion Product 4", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1544) },
                    { new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1579), "Description for Sport Product 5", 205m, "Sport Product 5", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1581) },
                    { new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new Guid("88499694-269b-4308-a64d-0e903a1f503d"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1532), "Description for Fashion Product 2", 140m, "Fashion Product 2", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1534) }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1251), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1245), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1175), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.InsertData(
                table: "images",
                columns: new[] { "id", "created_at", "product_id", "updated_at", "url" },
                values: new object[,]
                {
                    { new Guid("01d76db6-d7ae-473e-983c-91fe55798378"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1917), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1919), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("0f2a958d-b5c4-4f63-b67e-dc2b712ec24b"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1934), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1936), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("0f8e96b0-9e0a-4b13-b7f0-6ba4fe6fc0db"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1880), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1882), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("14f19637-9e72-4c88-9331-9db22a01f582"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2051), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2054), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("17d4e91f-ab94-4dff-8854-c050679dd5d0"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1846), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1848), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("2325d6d6-385f-40b3-9d01-9304c5a5cb64"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1886), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1888), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("235c5768-d623-47fe-bc8c-2837fe5ce06f"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1824), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1826), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("3154e6f3-d876-4bf1-9627-8bf5afdc5a9a"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2081), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2083), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("4292d875-0f80-4bae-8406-6a6225b809e0"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1923), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1925), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("4de54c30-65f5-455b-a65e-c274a6de738b"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2058), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2060), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("50005c17-cc4c-4a63-8a85-e20daad8de68"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1891), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1893), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("5501d583-faca-4b9a-805e-8136355c6c94"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1908), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1910), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("557fb0e2-84e1-46ca-b68c-bed6ba7d7e6b"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1795), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1797), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("57444803-3a99-4881-9d7e-67b231cd3683"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2092), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2094), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("5e630f70-ac63-4f8e-a602-60f1fbdd93c7"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2106), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2108), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("60cf5393-e5ea-45ed-8134-e3747a971a57"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1946), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1947), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("63833f81-4c1e-4fed-a5ed-c51450656741"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2118), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2119), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("681c356b-ddfe-4c31-b3f2-ac07aa556fd6"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1858), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1860), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("68e30fd7-e65c-4edb-886a-07940a9a5d97"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1830), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1831), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("6c81ae2b-c043-4bf8-ac8e-b55f0e4c655c"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1897), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1899), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("705cd979-cf82-4d39-92e3-016de785bb78"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1818), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1820), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("83162160-b469-4183-bf50-0b7544dd9a37"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1903), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1905), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("8bf80804-448b-4a72-a86c-4e272c91f4bc"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1835), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1837), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("af1cba67-4cb2-40c5-88ae-8ef3690ce3c3"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1801), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1803), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("af32800e-f19e-48d2-b536-1c68bf3b2720"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1770), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1772), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("b006e8ea-920a-4362-9201-4d112ae237ff"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1869), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1871), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("b1718449-8399-4c09-9150-dc778b9c7967"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1875), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1876), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("b7fd9cc0-3b24-4f3e-954a-bcb581e409f7"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1928), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1930), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("ba712b32-d104-4ceb-97a1-6716a7f435a0"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1763), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1765), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("bdbb48d6-da5c-4652-8231-fd718f3ebfdc"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1782), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1784), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("bede00e2-6908-4ea8-a6a1-28c37aeb7fdf"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2087), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2088), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("c11abe29-cfa1-4bb1-ac44-74b241acb2a9"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1776), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1778), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("c6d59bdd-a599-434a-ac83-b6ddf2b88fc1"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1789), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1791), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("d5778faf-62d1-4eb7-81ad-755595874046"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2070), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2072), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("d78b23f0-3594-4513-9a2c-f98fd760e724"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2076), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2077), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("dd86d0f9-ae31-43e2-9c1a-e8feb9e0510d"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2101), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2103), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("e0bb61c7-9f5a-43dc-9f14-fe576f989515"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1807), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1809), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("e9505356-21b6-4f25-8067-fd7c557bb6d9"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1957), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1959), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("ece8b526-57ec-49e0-abf7-7c77c66f47b6"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1655), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1658), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("ed502e7b-06bb-44a0-8209-a2acc2ebe690"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1951), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1953), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("f11cc865-0192-4807-9a47-b7c9d7384094"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1841), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1843), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("f2cd0fba-be48-4778-a35b-9f40594295ac"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2112), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2114), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("f4e172e6-5d80-448d-9e9a-d171c29eca01"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2064), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2066), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("fa659308-5756-49af-be43-bf2581758c7e"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1852), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1854), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("fb1e9b66-9cde-4601-bb88-c133c90df2ae"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1940), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(1942), "https://picsum.photos/1000/1000?random=3" }
                });

            migrationBuilder.InsertData(
                table: "reviews",
                columns: new[] { "id", "comment", "created_at", "product_id", "rating", "updated_at", "user_id" },
                values: new object[,]
                {
                    { new Guid("30a4ff5e-3bd1-429d-9981-adbcd46e2537"), "Not as described, disappointed.", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2637), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 2, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2639), new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b") },
                    { new Guid("38fb4093-965e-4e3f-a7a2-c19103fc239e"), "Absolutely love this!", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2631), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 5, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2633), new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9") },
                    { new Guid("71dd6268-f87a-4816-a5bf-c94769a51473"), "Really enjoyed this.", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2594), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 4, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2595), new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9") },
                    { new Guid("9aa483ac-872b-468c-af4f-2c1f94beec3a"), "Loved the design!", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2604), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 4, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2606), new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9") },
                    { new Guid("a4438f9a-a573-4967-96c3-6a38fcfb6132"), "Nice product, quick delivery.", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2615), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 4, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2617), new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b") },
                    { new Guid("c2cd9d37-25d0-4b5d-a336-8214ce83b648"), "Outstanding quality!", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2621), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 5, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2622), new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b") },
                    { new Guid("c9e3c10d-b843-434d-bcbe-bfe35e17dd52"), "Great product!", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2583), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 5, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2587), new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab") },
                    { new Guid("ca5b7d5d-309c-4973-ad8c-132a4142b5c1"), "Perfect for my needs!", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2609), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 5, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2611), new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b") },
                    { new Guid("dfc6ffd5-140c-4505-9428-7fe852a93afc"), "Decent, but expected more.", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2626), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 3, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2628), new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab") },
                    { new Guid("eb57b891-c019-46c9-9c6e-630a79d19787"), "Good quality, but expensive.", new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2599), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 3, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2601), new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab") }
                });

            migrationBuilder.InsertData(
                table: "variants",
                columns: new[] { "id", "color", "created_at", "product_id", "quantity", "size", "updated_at" },
                values: new object[,]
                {
                    { new Guid("067f022f-9bfe-42dd-ab8f-0a12be6b5b35"), Color.Red, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2443), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 10, Size.L, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2445) },
                    { new Guid("0b042f83-7c72-4fa9-b2ae-2bd05e66d327"), Color.Black, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2302), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2304) },
                    { new Guid("1606684a-8f64-4184-bb0e-8ddfe4b8218f"), Color.Blue, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2197), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2199) },
                    { new Guid("18386a18-60ae-464a-8d32-9cc0314f3848"), Color.Red, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2329), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 10, Size.L, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2331) },
                    { new Guid("19c54258-2c40-4e20-a79c-a667c7093d34"), Color.Black, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2283), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2285) },
                    { new Guid("1b4b2abb-f191-46b5-b20a-c2782301db9f"), Color.Black, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2341), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2343) },
                    { new Guid("2908b6ef-2ea9-4931-88b9-15b009f657e9"), Color.Red, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2425), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 10, Size.L, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2427) },
                    { new Guid("2c56314a-da2c-49f2-b239-c6a059472184"), Color.Blue, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2295), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2297) },
                    { new Guid("35d4b9ac-fd39-49a0-bea3-1b71e0c0f34e"), Color.Blue, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2218), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2220) },
                    { new Guid("378fd054-6a06-4dd5-a204-d6902c38aebc"), Color.Red, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2187), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 10, Size.L, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2189) },
                    { new Guid("3dc2a021-f094-49d2-ac6f-e6c78f9189bf"), Color.Black, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2243), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2245) },
                    { new Guid("43e03655-6491-41ff-bbba-df7bfb312aea"), Color.Red, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2386), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 10, Size.L, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2388) },
                    { new Guid("44e151b6-fe81-44cc-af7e-ef01517692f7"), Color.Blue, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2467), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2469) },
                    { new Guid("45679303-ba7c-414e-8631-aa934efe63be"), Color.Black, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2437), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2439) },
                    { new Guid("48dcb9c5-14ec-48c8-b5a6-d2f27a54849b"), Color.Black, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2475), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2477) },
                    { new Guid("4e24c866-899a-4d52-a972-7f84c4e42bb8"), Color.Black, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2455), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2457) },
                    { new Guid("542605b3-9c69-4eb3-b14f-a7a8cb0f6022"), Color.Blue, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2237), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2239) },
                    { new Guid("5bdacdcf-3c94-45fc-b287-382390e61f21"), Color.Red, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2251), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 10, Size.L, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2253) },
                    { new Guid("5eacea73-4352-4339-a768-167cc44d2050"), Color.Red, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2347), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 10, Size.L, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2349) },
                    { new Guid("5ef886ec-d776-48e9-b21c-3a6adaf24551"), Color.Black, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2263), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2265) },
                    { new Guid("7036e9e1-e323-46fb-b779-8cc1a02b8f20"), Color.Black, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2323), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2325) },
                    { new Guid("7217a2bf-d31a-4055-aad3-b90d3e0e2ac0"), Color.Black, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2380), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2381) },
                    { new Guid("72185a29-da69-4b8a-9dcd-e3861099bc5b"), Color.Blue, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2431), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2433) },
                    { new Guid("736af532-4b0b-4183-9872-ab108949d295"), Color.Blue, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2257), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2259) },
                    { new Guid("7717ce33-7d0e-4c74-a590-ae2f773d00fe"), Color.Black, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2359), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2361) },
                    { new Guid("810a3fc0-ecd1-467c-b982-81b4fdc05571"), Color.Blue, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2315), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2317) },
                    { new Guid("90383e84-2272-467b-a1fa-2da7477ff602"), Color.Blue, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2411), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2413) },
                    { new Guid("9299821b-8f3c-4581-8806-857cdcdb3cb5"), Color.Red, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2365), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 10, Size.L, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2367) },
                    { new Guid("92b34406-d813-402e-b6f8-f558d4adec29"), Color.Red, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2309), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 10, Size.L, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2311) },
                    { new Guid("a5929240-ca2a-47ac-9970-b57f21fc41c2"), Color.Black, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2398), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2399) },
                    { new Guid("a5eaf264-5683-4013-b271-80e6dfafe53c"), Color.Black, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2225), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2227) },
                    { new Guid("a94d2b38-74a2-412d-9661-9efd1ba56db6"), Color.Blue, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2335), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2337) },
                    { new Guid("ad6a63fd-be69-4e22-ab1c-5bc27f837334"), Color.Blue, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2373), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2375) },
                    { new Guid("ade3d944-14c9-4f2d-8655-95408d00b66b"), Color.Red, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2461), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 10, Size.L, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2463) },
                    { new Guid("b9365cdf-fb4c-43d4-907a-45300544523f"), Color.Blue, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2392), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2393) },
                    { new Guid("bf311524-d844-4ca7-b2e6-7c0eea11471b"), Color.Blue, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2353), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2355) },
                    { new Guid("c326bbdb-9a62-4928-9311-274acb77317d"), Color.Red, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2271), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 10, Size.L, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2273) },
                    { new Guid("c5946cb5-a35d-480a-81e1-242bd8e4770e"), Color.Black, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2203), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2205) },
                    { new Guid("cdf2265e-99c5-4cc2-a9e7-4b8e60557f4e"), Color.Red, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2289), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 10, Size.L, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2291) },
                    { new Guid("d1fee03e-80c4-49f0-8611-cf92782eb9ed"), Color.Blue, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2449), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2451) },
                    { new Guid("e7d4d017-5dbd-46da-9db8-5e47011d8aca"), Color.Red, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2209), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 20, Size.L, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2211) },
                    { new Guid("ea584c29-9b4a-414d-acbe-2acf9569590c"), Color.Red, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2231), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 10, Size.L, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2233) },
                    { new Guid("edabe448-20b9-498d-b319-356bff9c7e9c"), Color.Blue, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2277), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2279) },
                    { new Guid("f0982c66-1311-4a0f-a06e-eca203500cda"), Color.Red, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2405), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 10, Size.L, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2407) },
                    { new Guid("f9f60e91-a11e-4527-84b0-e6b9b663c3cb"), Color.Black, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2417), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 21, 33, 993, DateTimeKind.Local).AddTicks(2419) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a1a1a1a1-1234-1234-1234-1234567890ab"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a2a2a2a2-1234-1234-1234-1234567890ab"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a3a3a3a3-1234-1234-1234-1234567890ab"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b1b1b1b1-1234-1234-1234-1234567890ab"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b2b2b2b2-1234-1234-1234-1234567890ab"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b3b3b3b3-1234-1234-1234-1234567890ab"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c1c1c1c1-1234-1234-1234-1234567890ab"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c2c2c2c2-1234-1234-1234-1234567890ab"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c3c3c3c3-1234-1234-1234-1234567890ab"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("01d76db6-d7ae-473e-983c-91fe55798378"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("0f2a958d-b5c4-4f63-b67e-dc2b712ec24b"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("0f8e96b0-9e0a-4b13-b7f0-6ba4fe6fc0db"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("14f19637-9e72-4c88-9331-9db22a01f582"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("17d4e91f-ab94-4dff-8854-c050679dd5d0"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("2325d6d6-385f-40b3-9d01-9304c5a5cb64"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("235c5768-d623-47fe-bc8c-2837fe5ce06f"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("3154e6f3-d876-4bf1-9627-8bf5afdc5a9a"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("4292d875-0f80-4bae-8406-6a6225b809e0"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("4de54c30-65f5-455b-a65e-c274a6de738b"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("50005c17-cc4c-4a63-8a85-e20daad8de68"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("5501d583-faca-4b9a-805e-8136355c6c94"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("557fb0e2-84e1-46ca-b68c-bed6ba7d7e6b"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("57444803-3a99-4881-9d7e-67b231cd3683"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("5e630f70-ac63-4f8e-a602-60f1fbdd93c7"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("60cf5393-e5ea-45ed-8134-e3747a971a57"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("63833f81-4c1e-4fed-a5ed-c51450656741"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("681c356b-ddfe-4c31-b3f2-ac07aa556fd6"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("68e30fd7-e65c-4edb-886a-07940a9a5d97"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("6c81ae2b-c043-4bf8-ac8e-b55f0e4c655c"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("705cd979-cf82-4d39-92e3-016de785bb78"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("83162160-b469-4183-bf50-0b7544dd9a37"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("8bf80804-448b-4a72-a86c-4e272c91f4bc"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("af1cba67-4cb2-40c5-88ae-8ef3690ce3c3"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("af32800e-f19e-48d2-b536-1c68bf3b2720"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("b006e8ea-920a-4362-9201-4d112ae237ff"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("b1718449-8399-4c09-9150-dc778b9c7967"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("b7fd9cc0-3b24-4f3e-954a-bcb581e409f7"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("ba712b32-d104-4ceb-97a1-6716a7f435a0"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("bdbb48d6-da5c-4652-8231-fd718f3ebfdc"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("bede00e2-6908-4ea8-a6a1-28c37aeb7fdf"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("c11abe29-cfa1-4bb1-ac44-74b241acb2a9"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("c6d59bdd-a599-434a-ac83-b6ddf2b88fc1"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("d5778faf-62d1-4eb7-81ad-755595874046"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("d78b23f0-3594-4513-9a2c-f98fd760e724"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("dd86d0f9-ae31-43e2-9c1a-e8feb9e0510d"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("e0bb61c7-9f5a-43dc-9f14-fe576f989515"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("e9505356-21b6-4f25-8067-fd7c557bb6d9"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("ece8b526-57ec-49e0-abf7-7c77c66f47b6"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("ed502e7b-06bb-44a0-8209-a2acc2ebe690"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("f11cc865-0192-4807-9a47-b7c9d7384094"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("f2cd0fba-be48-4778-a35b-9f40594295ac"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("f4e172e6-5d80-448d-9e9a-d171c29eca01"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("fa659308-5756-49af-be43-bf2581758c7e"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("fb1e9b66-9cde-4601-bb88-c133c90df2ae"));

            migrationBuilder.DeleteData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("30a4ff5e-3bd1-429d-9981-adbcd46e2537"));

            migrationBuilder.DeleteData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("38fb4093-965e-4e3f-a7a2-c19103fc239e"));

            migrationBuilder.DeleteData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("71dd6268-f87a-4816-a5bf-c94769a51473"));

            migrationBuilder.DeleteData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("9aa483ac-872b-468c-af4f-2c1f94beec3a"));

            migrationBuilder.DeleteData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("a4438f9a-a573-4967-96c3-6a38fcfb6132"));

            migrationBuilder.DeleteData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("c2cd9d37-25d0-4b5d-a336-8214ce83b648"));

            migrationBuilder.DeleteData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("c9e3c10d-b843-434d-bcbe-bfe35e17dd52"));

            migrationBuilder.DeleteData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("ca5b7d5d-309c-4973-ad8c-132a4142b5c1"));

            migrationBuilder.DeleteData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("dfc6ffd5-140c-4505-9428-7fe852a93afc"));

            migrationBuilder.DeleteData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("eb57b891-c019-46c9-9c6e-630a79d19787"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("067f022f-9bfe-42dd-ab8f-0a12be6b5b35"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("0b042f83-7c72-4fa9-b2ae-2bd05e66d327"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("1606684a-8f64-4184-bb0e-8ddfe4b8218f"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("18386a18-60ae-464a-8d32-9cc0314f3848"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("19c54258-2c40-4e20-a79c-a667c7093d34"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("1b4b2abb-f191-46b5-b20a-c2782301db9f"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("2908b6ef-2ea9-4931-88b9-15b009f657e9"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("2c56314a-da2c-49f2-b239-c6a059472184"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("35d4b9ac-fd39-49a0-bea3-1b71e0c0f34e"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("378fd054-6a06-4dd5-a204-d6902c38aebc"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("3dc2a021-f094-49d2-ac6f-e6c78f9189bf"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("43e03655-6491-41ff-bbba-df7bfb312aea"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("44e151b6-fe81-44cc-af7e-ef01517692f7"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("45679303-ba7c-414e-8631-aa934efe63be"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("48dcb9c5-14ec-48c8-b5a6-d2f27a54849b"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("4e24c866-899a-4d52-a972-7f84c4e42bb8"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("542605b3-9c69-4eb3-b14f-a7a8cb0f6022"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("5bdacdcf-3c94-45fc-b287-382390e61f21"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("5eacea73-4352-4339-a768-167cc44d2050"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("5ef886ec-d776-48e9-b21c-3a6adaf24551"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("7036e9e1-e323-46fb-b779-8cc1a02b8f20"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("7217a2bf-d31a-4055-aad3-b90d3e0e2ac0"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("72185a29-da69-4b8a-9dcd-e3861099bc5b"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("736af532-4b0b-4183-9872-ab108949d295"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("7717ce33-7d0e-4c74-a590-ae2f773d00fe"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("810a3fc0-ecd1-467c-b982-81b4fdc05571"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("90383e84-2272-467b-a1fa-2da7477ff602"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("9299821b-8f3c-4581-8806-857cdcdb3cb5"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("92b34406-d813-402e-b6f8-f558d4adec29"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("a5929240-ca2a-47ac-9970-b57f21fc41c2"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("a5eaf264-5683-4013-b271-80e6dfafe53c"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("a94d2b38-74a2-412d-9661-9efd1ba56db6"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("ad6a63fd-be69-4e22-ab1c-5bc27f837334"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("ade3d944-14c9-4f2d-8655-95408d00b66b"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("b9365cdf-fb4c-43d4-907a-45300544523f"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("bf311524-d844-4ca7-b2e6-7c0eea11471b"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("c326bbdb-9a62-4928-9311-274acb77317d"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("c5946cb5-a35d-480a-81e1-242bd8e4770e"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("cdf2265e-99c5-4cc2-a9e7-4b8e60557f4e"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("d1fee03e-80c4-49f0-8611-cf92782eb9ed"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("e7d4d017-5dbd-46da-9db8-5e47011d8aca"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("ea584c29-9b4a-414d-acbe-2acf9569590c"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("edabe448-20b9-498d-b319-356bff9c7e9c"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("f0982c66-1311-4a0f-a06e-eca203500cda"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("f9f60e91-a11e-4527-84b0-e6b9b663c3cb"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("865770da-89af-4719-b00c-310b57d535e1"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("8b441114-e030-4412-8952-2370a4b7f05a"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"));

            migrationBuilder.AlterColumn<Guid>(
                name: "product_id",
                table: "variants",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

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
    }
}
