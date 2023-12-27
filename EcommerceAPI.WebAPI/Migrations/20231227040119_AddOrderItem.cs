using System;
using EcommerceAPI.Core.src.Entity;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceAPI.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("091189d3-0dc7-455c-8d38-f65e4c3fda99"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("0b1f5ba8-b4c0-491d-b4c3-a5810b213588"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("12eed719-04d8-4a85-b833-45461162b2e9"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("1d47d935-c1df-431a-bb02-a1bc61a6fdd3"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("204f343e-4ce5-4963-b1db-0cb0cbc4097d"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("2125957f-3e0a-4dcb-94d0-3ea4c2a4e3f4"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("217d178c-37b3-4aa2-9f90-bc69c5f6ca6f"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("2a614741-6a57-4aa3-9c83-7b7d424f9852"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("38b105fd-7011-4bb9-be89-538fcd762767"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("3b83cf44-3426-41c9-af7d-202c0f26e50a"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("45df4140-40b8-444a-bf2c-7698b62830a0"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("4d36fab7-0b69-42b8-993f-f963496ce9fe"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("537fb337-90e7-4db3-90dc-2eb64d68c9af"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("588e56f4-30a3-4586-a304-94930f934284"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("63376c58-a131-409b-bb7e-7b1e68627e16"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("65b7a6a4-afab-4354-94e0-8eeadd935404"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("69488eeb-4d4e-4609-b9f3-ea93fcc7b090"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("6d123bea-1fbf-4c8a-81ae-6b4db0b026b7"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("6d47de4b-c598-40fc-8980-91324b59290e"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("6f4222d0-f00b-4564-a81e-5b916ad70585"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("7539b60a-79cc-4cd9-9b77-2b7c5c01d6b4"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("756c9bb1-b165-47e2-a7e7-093dd96c675d"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("79605568-d2ea-401e-ba38-c18e19cba37c"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("7fd0cfb8-ddab-42de-be44-a06ef6ccb47d"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("83117100-fa5f-4ce8-8ad0-246a50585c91"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("874461e1-87a2-4f3e-ace2-6719b934452a"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("887f0c8e-a4fa-4d50-a16c-4d860f839fb6"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("8be59bf3-d516-4538-9a5c-f63df401f96f"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("92166e50-71b4-4319-8d85-c2d198f1261c"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("92422218-d4d1-4cdf-9742-f1d5dc78a217"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("94bcd4d9-0a9e-4740-93a2-72840c00f6bb"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("a90106c4-ceaf-4c74-9e38-5ca6320f6b1e"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("ab40144e-563b-47dd-8468-b6051b8a0cef"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("b8a2db0b-0998-433a-a12a-43fb2cf063f7"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("c24f24a6-5008-4a82-a4e1-36b1be354382"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("ca2e59ab-6950-448b-8fcb-cec319367f29"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("d9cf9b62-0e3e-4f6e-b22b-d64a0e4e8ed7"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("dc4db791-0435-483f-8291-407c065e71c3"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("de2c5c7e-679b-4b71-bf3c-3cd87fafcad6"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("e2193852-d20d-4b0f-abaf-e4cb0e3bd6ee"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("eee8592f-d768-4368-9a34-6779c76fa18b"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("f25e7543-49a4-4d74-8352-66c12163ade5"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("f3a54208-7498-4494-a092-333412def51f"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("f8c974fe-b262-4a72-a2f9-7c6c59da4254"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("fc115cf7-20e9-437d-a25d-00d5f68f9aa3"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("07470445-7506-46fa-9a80-070c0b7233bf"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("11f16092-3dbd-4daa-a53a-667b2af9fc91"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("13ffb885-df7d-4378-9fcb-978fd54d66e8"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("15cacb38-2ca9-4848-89d7-f849b360be84"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("16b1ef96-6bfb-44d1-8e2b-f5678179fca8"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("199a773b-8621-4d69-a5b5-b8eb05d5918f"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("1bf0f6a4-3a15-4ac6-b2f8-9acec9a97eaf"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("1fb35f36-71fb-41cd-b6c0-acc9a4b54c6a"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("20c473c4-bb06-40ca-932f-b08380b6e0fa"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("210951e5-e2c3-42b1-a754-7928dc874b87"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("26e641f5-0ff4-4373-9a69-67b4212aec71"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("32f5d573-2a2b-492c-93f6-89f7f74d9144"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("3b80e272-7ed9-4479-91f8-f25b7ab4f6ce"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("3d8f7940-adb4-4a47-884f-33a8b42a2a68"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("4203b401-8480-4da0-b746-3354edfeb25b"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("4723dae1-6902-4582-8230-70017c2843f0"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("4cff25b7-ef4f-4e95-a091-2924da7eaca2"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("4eb9b560-de47-4e63-9929-212d7ed83ecb"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("599bb4a7-5cfd-453c-ba5f-07ecc34d31ba"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("61978e2a-1229-4bc8-94db-328734649c70"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("67a1c1a5-f3aa-4f91-b0f9-3d0d2538e222"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("6b913808-d1a4-4d95-80c0-29694688b672"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("75037c43-72cd-485d-bf4e-592f6cc9663f"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("752fedea-c423-4e6b-8dfb-8a4f7b0f0b5c"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("76dcd06a-930b-40ce-b138-0e388644889c"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("7e099b10-1ab6-48e4-89e6-dcb87843c5c0"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("818123c8-2ab3-41d4-8b11-e48cf71120c3"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("81f90565-cf28-42ea-8b73-a3d7d9b74c0e"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("852c2e77-b985-457e-9d6c-4dfcbe754e0d"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("958bace2-c7ab-443e-9640-3ea3ac06a8d2"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("a3868b49-737f-45fd-98a0-de7f89707d6c"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("a399a6eb-9478-4ea9-be73-d091a4d6e5e2"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("abaf746e-8f31-48e2-b015-e4dc49b3cdcc"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("c4616011-66b5-4d2d-ac4c-60aa5ad14d6e"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("c70d6dfa-81da-4535-8b5b-6fb513a06c4b"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("cc341cd8-a5dc-4084-a4fc-ec5b33a06b36"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("d216952b-34b7-402d-b2b0-4514abcf480c"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("eaf80cb8-cb4e-4d8b-8bc0-d1eb409e464f"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("ecf7eb06-ae5f-4f0d-bec7-7fcd39e08b8c"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("ed6623e0-8885-4123-b0e9-c88644f0abd9"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("f56d64f4-828b-41f7-9fe1-fda99e2038d8"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("f6208cfd-9094-4b8e-9d4a-56c0c561f6fc"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("f68efc8d-6c74-4073-bf0f-12e9df06ad66"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("faf347e1-124a-4367-bd47-dc247400ed72"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("ff69d11e-71b1-4d4f-96ec-0ad51a96247a"));

            migrationBuilder.AddColumn<Guid>(
                name: "variant_id",
                table: "order_items",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a1a1a1a1-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6219), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a2a2a2a2-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6229), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a3a3a3a3-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6233), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b1b1b1b1-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6238), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b2b2b2b2-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6242), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b3b3b3b3-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6248), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c1c1c1c1-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c2c2c2c2-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6258), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c3c3c3c3-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6262), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5179), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("88499694-269b-4308-a64d-0e903a1f503d"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5168), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5183), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5185) });

            migrationBuilder.InsertData(
                table: "images",
                columns: new[] { "id", "created_at", "product_id", "updated_at", "url" },
                values: new object[,]
                {
                    { new Guid("049a7814-ebb8-4fc9-beb6-0a9681ea0081"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5565), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5567), "https://picsum.photos/1000/1000?random=15" },
                    { new Guid("0ecceeb9-714c-4525-8ab3-1585b4e1a119"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5682), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5683), "https://picsum.photos/1000/1000?random=37" },
                    { new Guid("13eac297-914f-40f1-92a5-71424a0a4fc6"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5526), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5528), "https://picsum.photos/1000/1000?random=8" },
                    { new Guid("2113d83b-03b1-40f4-aeab-176e1f8810e7"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5516), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5518), "https://picsum.photos/1000/1000?random=6" },
                    { new Guid("2632e493-27cb-4c2b-9fd9-59f15f72e1a8"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5537), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5539), "https://picsum.photos/1000/1000?random=10" },
                    { new Guid("2a4fd27f-5984-498c-a91f-a1ea2cb9d680"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5531), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5533), "https://picsum.photos/1000/1000?random=9" },
                    { new Guid("31ececbe-4889-4b9e-a356-a2b9f52649b4"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5710), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5711), "https://picsum.photos/1000/1000?random=43" },
                    { new Guid("3222450d-bf8e-4764-af69-fd31ce6d0764"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5640), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5641), "https://picsum.photos/1000/1000?random=29" },
                    { new Guid("33f90292-9737-48b6-9c9e-6e267b8f92e3"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5551), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5552), "https://picsum.photos/1000/1000?random=12" },
                    { new Guid("36c5fc83-f2f8-44f5-9d2b-703d93cd8822"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5700), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5702), "https://picsum.photos/1000/1000?random=41" },
                    { new Guid("3a5301de-90a5-449d-84b1-80505a53b002"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5717), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5718), "https://picsum.photos/1000/1000?random=44" },
                    { new Guid("3c40208f-1896-4aaa-b422-a2a168775502"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5722), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5723), "https://picsum.photos/1000/1000?random=45" },
                    { new Guid("3df09fc8-d886-462e-8960-0e93ee03b638"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5622), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5624), "https://picsum.photos/1000/1000?random=26" },
                    { new Guid("554a28b7-89d7-4a82-97ad-8c4860e7a4e0"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5603), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5604), "https://picsum.photos/1000/1000?random=22" },
                    { new Guid("562a39f5-f087-44b5-bd80-a47302f9324e"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5521), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5523), "https://picsum.photos/1000/1000?random=7" },
                    { new Guid("5a9e15e2-64ef-480d-999e-ce036c507160"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5593), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5595), "https://picsum.photos/1000/1000?random=20" },
                    { new Guid("62b911f4-88cd-4c26-8434-01e74d9dea1b"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5635), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5636), "https://picsum.photos/1000/1000?random=28" },
                    { new Guid("66a23946-ec42-435a-99bc-e6d666306849"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5570), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5572), "https://picsum.photos/1000/1000?random=16" },
                    { new Guid("6773417f-fd5f-410c-a2fd-c1fc0c1e566e"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5580), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5582), "https://picsum.photos/1000/1000?random=18" },
                    { new Guid("69adae26-2a1c-41f9-bc9d-fe9b53de197b"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5480), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5482), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("6bc36e47-95f5-4aa2-bc6a-e3720b71eb22"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5645), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5646), "https://picsum.photos/1000/1000?random=30" },
                    { new Guid("6e2168a8-3605-4731-a905-8474a0933b5f"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5556), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5557), "https://picsum.photos/1000/1000?random=13" },
                    { new Guid("7c07100a-c961-4371-8bb6-47c21c0dc662"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5659), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5660), "https://picsum.photos/1000/1000?random=33" },
                    { new Guid("8082c257-a2b6-413e-a5fe-d9d42e23c0e1"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5665), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5666), "https://picsum.photos/1000/1000?random=34" },
                    { new Guid("80a66f5b-2912-4940-8d96-a7db807c0401"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5617), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5619), "https://picsum.photos/1000/1000?random=25" },
                    { new Guid("84a48997-3919-4bca-af3e-0beca4e372e3"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5560), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5562), "https://picsum.photos/1000/1000?random=14" },
                    { new Guid("884f7898-6180-4099-a077-84960d5c16f4"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5608), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5609), "https://picsum.photos/1000/1000?random=23" },
                    { new Guid("8ae242f2-1482-498e-8333-ae96b24866a8"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5696), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5697), "https://picsum.photos/1000/1000?random=40" },
                    { new Guid("92a21c96-5c6e-4d66-8012-02f059c04ffc"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5585), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5587), "https://picsum.photos/1000/1000?random=19" },
                    { new Guid("966842fc-8cde-4695-b28a-c979ff408e88"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5504), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5506), "https://picsum.photos/1000/1000?random=4" },
                    { new Guid("99c74606-edcc-4bae-8a6b-95df82108334"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5627), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5629), "https://picsum.photos/1000/1000?random=27" },
                    { new Guid("bf9daabb-bcba-414a-8370-69fbb1106d8d"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5485), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5487), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("c2c23263-0bc3-4d72-aa75-5ecc41c327e0"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5453), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5456), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("cc16a6c4-245c-4bc6-8910-f9d6e2fb32fb"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5686), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5688), "https://picsum.photos/1000/1000?random=38" },
                    { new Guid("d04c9f14-b62d-439b-9a07-b17dc74ed758"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5542), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5543), "https://picsum.photos/1000/1000?random=11" },
                    { new Guid("d83fd63e-d06f-4b91-8969-da229515ac7f"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5691), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5693), "https://picsum.photos/1000/1000?random=39" },
                    { new Guid("e15002dc-4c0a-41ed-9710-848231da7160"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5670), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5671), "https://picsum.photos/1000/1000?random=35" },
                    { new Guid("e32a9661-7122-44f1-b44e-7c43761a3ec5"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5575), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5576), "https://picsum.photos/1000/1000?random=17" },
                    { new Guid("e5f132d5-4b98-44a1-a02a-4ff6616b8544"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5598), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5600), "https://picsum.photos/1000/1000?random=21" },
                    { new Guid("f980b69b-9c2b-44dc-86e1-8200861c590f"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5510), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5511), "https://picsum.photos/1000/1000?random=5" },
                    { new Guid("f9f3b0f8-01bb-4239-963a-218aac774c7a"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5613), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5614), "https://picsum.photos/1000/1000?random=24" },
                    { new Guid("fa39fdc7-a333-4a5e-8895-4e601541b2e8"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5654), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5656), "https://picsum.photos/1000/1000?random=32" },
                    { new Guid("fe178187-3c75-45b6-b57c-a9fde7627451"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5649), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5651), "https://picsum.photos/1000/1000?random=31" },
                    { new Guid("ff9ebddc-61e1-47a5-8a68-1f952848ff0a"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5705), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5707), "https://picsum.photos/1000/1000?random=42" },
                    { new Guid("ffc4f945-779d-4556-b62c-0d8c93fb68ff"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5677), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5679), "https://picsum.photos/1000/1000?random=36" }
                });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5299), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5263), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5284), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5387), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5279), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5275), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5289), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("865770da-89af-4719-b00c-310b57d535e1"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5253), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("8b441114-e030-4412-8952-2370a4b7f05a"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5396), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5392), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5373), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5240), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5258), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5294), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5249), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("30a4ff5e-3bd1-429d-9981-adbcd46e2537"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6176), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("38fb4093-965e-4e3f-a7a2-c19103fc239e"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6170), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("71dd6268-f87a-4816-a5bf-c94769a51473"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6137), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("9aa483ac-872b-468c-af4f-2c1f94beec3a"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6146), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("a4438f9a-a573-4967-96c3-6a38fcfb6132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6157), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("c2cd9d37-25d0-4b5d-a336-8214ce83b648"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6162), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("c9e3c10d-b843-434d-bcbe-bfe35e17dd52"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6129), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("ca5b7d5d-309c-4973-ad8c-132a4142b5c1"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6151), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("dfc6ffd5-140c-4505-9428-7fe852a93afc"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6166), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("eb57b891-c019-46c9-9c6e-630a79d19787"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6142), new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 335, DateTimeKind.Local).AddTicks(113), "GJFgLtuNgwLnuNPZmuRyjQ==;mIKrMrMzy8wcEOSr9v06sSY9KKWziW7B6Sc7GB3aRAE=", new DateTime(2023, 12, 27, 6, 1, 19, 335, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 333, DateTimeKind.Local).AddTicks(5577), "5nq+Nes00jnE2gxs8J5PSw==;DxsK4oPAWqGrXt5p2R/8PTnVypjsYAsFCgiLRPM+73I=", new DateTime(2023, 12, 27, 6, 1, 19, 333, DateTimeKind.Local).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 1, 19, 332, DateTimeKind.Local).AddTicks(198), "7x0o3lLBaO1ANrtnYuCu6g==;FPwpYul9DCIfJ7VSKiTOZ77OUS23inh2V3eAZVK83HU=", new DateTime(2023, 12, 27, 6, 1, 19, 332, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.InsertData(
                table: "variants",
                columns: new[] { "id", "color", "created_at", "product_id", "quantity", "size", "updated_at" },
                values: new object[,]
                {
                    { new Guid("07f18fd0-f84c-4241-bcab-eab47b4e9ca3"), Color.Red, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5910), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 10, Size.L, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5912) },
                    { new Guid("0e77e3ee-95ab-49d6-964e-cdf7ceef0750"), Color.Black, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5922), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5923) },
                    { new Guid("0f8094db-6303-4ae3-9576-3483c99692ec"), Color.Red, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5927), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 10, Size.L, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5928) },
                    { new Guid("1885f665-9973-4c19-b210-4b0363578aff"), Color.Blue, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5832), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5833) },
                    { new Guid("245aedc1-12aa-42ea-ba27-6f5a2155bd0b"), Color.Black, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6066), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6067) },
                    { new Guid("30d5c7d8-aed1-46c1-a54f-9c12083d234b"), Color.Black, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5853), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5854) },
                    { new Guid("3c89a9db-d5d3-47ad-bb60-666faba13bbf"), Color.Blue, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5932), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5934) },
                    { new Guid("3f868604-3c57-4168-b50d-1893525c2b42"), Color.Red, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5892), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 10, Size.L, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5894) },
                    { new Guid("40dd2564-f3f6-4928-ab62-ca79293a4512"), Color.Blue, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5964), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5966) },
                    { new Guid("4ba1ce7d-ec6f-441f-82fd-0afbffaa6cbe"), Color.Black, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5819), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5821) },
                    { new Guid("4ce14e0d-dd13-4c55-b116-a367ec0390bb"), Color.Red, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6008), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 10, Size.L, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6009) },
                    { new Guid("5353d817-73a6-4dad-a679-1639ea0bc14c"), Color.Blue, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5898), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5900) },
                    { new Guid("557ee7d6-b90d-4ba3-b8cb-e54aedb60650"), Color.Black, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6018), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6020) },
                    { new Guid("5b8a1e36-8607-4b7f-a745-f5a406ca40fa"), Color.Blue, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5949), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5951) },
                    { new Guid("5d7a94aa-de57-4ffb-afc2-a3089480bf16"), Color.Black, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6001), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6003) },
                    { new Guid("5e6ec3b8-11e6-417b-b29e-231cd9bfe1c6"), Color.Red, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5787), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 10, Size.L, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5790) },
                    { new Guid("62238faf-db0f-4fd4-86c7-981d2136c3fc"), Color.Red, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5942), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 10, Size.L, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5944) },
                    { new Guid("6d03e62b-4005-4f0e-a3b0-09593a544764"), Color.Red, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5974), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 10, Size.L, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5976) },
                    { new Guid("7f1d95b1-6390-4cdb-9af5-9bb0066259f1"), Color.Red, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5843), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 10, Size.L, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5844) },
                    { new Guid("7fcd639e-48ab-417d-9790-3daa037e2222"), Color.Black, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6035), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6037) },
                    { new Guid("831de33e-5a72-4528-9b3f-0869d18d7fc4"), Color.Black, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5969), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5971) },
                    { new Guid("845562b6-c42c-436f-9348-ef57fd06d1f7"), Color.Black, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5837), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5838) },
                    { new Guid("8b0c57b4-8d10-4597-ac3f-51239d2d84eb"), Color.Blue, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5996), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5998) },
                    { new Guid("8c306ddd-f2a6-4401-b54d-88ac3bef1356"), Color.Red, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5991), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 10, Size.L, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5993) },
                    { new Guid("91579f8f-90c7-4548-9174-40d639334508"), Color.Black, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5954), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5956) },
                    { new Guid("94cd9c51-d0f7-416e-ae64-04e844b8bb77"), Color.Blue, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6028), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6030) },
                    { new Guid("a242dc3c-c9e8-489c-9ab4-07b743d10235"), Color.Red, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6056), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 10, Size.L, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6057) },
                    { new Guid("a44a22fc-ea52-4eed-aa90-0a91f7b00f37"), Color.Blue, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5915), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5917) },
                    { new Guid("a7f81ccb-0d33-47c2-ad8c-2d6222aabfa1"), Color.Red, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5959), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 10, Size.L, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5961) },
                    { new Guid("aa19cd59-9e03-4548-8d8f-cb3f0f83bf0f"), Color.Blue, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6045), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6047) },
                    { new Guid("ae8070e4-7bf9-41c5-a6e2-2dffad735417"), Color.Black, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5984), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5986) },
                    { new Guid("bc007b90-1e10-402e-82d1-5a527d6d9743"), Color.Blue, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5979), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5981) },
                    { new Guid("be071f93-8c23-42b7-b068-00e8ae2faaed"), Color.Black, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5937), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5939) },
                    { new Guid("c1a5fa0a-9436-4555-8619-e1ae14d60f95"), Color.Blue, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6061), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6062) },
                    { new Guid("c8d895b2-c007-4787-bcd3-b0a76741910f"), Color.Red, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6040), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 10, Size.L, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6042) },
                    { new Guid("d4971fd7-166f-446b-9cd9-06946da65eea"), Color.Black, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6050), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6052) },
                    { new Guid("df75e9ac-4468-46b1-8487-761495ad13f8"), Color.Blue, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5798), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5799) },
                    { new Guid("e0bba871-7283-43a6-bded-2bca067b605a"), Color.Blue, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5813), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5815) },
                    { new Guid("e8b284f0-87d1-40d3-b73d-2e35d74e7afa"), Color.Blue, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5848), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5849) },
                    { new Guid("ef0a1ce2-2e8d-4b08-9283-326569d658d4"), Color.Blue, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6013), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6015) },
                    { new Guid("f1c7654e-c497-4466-b994-0f9ad3b26443"), Color.Black, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5803), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5804) },
                    { new Guid("f208db2d-b0d1-42a2-b093-3862d3a60889"), Color.Red, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5827), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 10, Size.L, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5828) },
                    { new Guid("f819b2df-e960-4066-b2c7-c6b3783e325f"), Color.Black, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5905), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5907) },
                    { new Guid("f91bbd8b-3205-46dc-8f28-a6121ec0e683"), Color.Red, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5808), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 20, Size.L, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(5810) },
                    { new Guid("f9333300-e751-45b7-9bce-e383be3c4a7b"), Color.Red, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6023), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 10, Size.L, new DateTime(2023, 12, 27, 6, 1, 19, 336, DateTimeKind.Local).AddTicks(6025) }
                });

            migrationBuilder.CreateIndex(
                name: "ix_order_items_variant_id",
                table: "order_items",
                column: "variant_id");

            migrationBuilder.AddForeignKey(
                name: "fk_order_items_variants_variant_id",
                table: "order_items",
                column: "variant_id",
                principalTable: "variants",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_order_items_variants_variant_id",
                table: "order_items");

            migrationBuilder.DropIndex(
                name: "ix_order_items_variant_id",
                table: "order_items");

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("049a7814-ebb8-4fc9-beb6-0a9681ea0081"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("0ecceeb9-714c-4525-8ab3-1585b4e1a119"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("13eac297-914f-40f1-92a5-71424a0a4fc6"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("2113d83b-03b1-40f4-aeab-176e1f8810e7"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("2632e493-27cb-4c2b-9fd9-59f15f72e1a8"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("2a4fd27f-5984-498c-a91f-a1ea2cb9d680"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("31ececbe-4889-4b9e-a356-a2b9f52649b4"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("3222450d-bf8e-4764-af69-fd31ce6d0764"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("33f90292-9737-48b6-9c9e-6e267b8f92e3"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("36c5fc83-f2f8-44f5-9d2b-703d93cd8822"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("3a5301de-90a5-449d-84b1-80505a53b002"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("3c40208f-1896-4aaa-b422-a2a168775502"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("3df09fc8-d886-462e-8960-0e93ee03b638"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("554a28b7-89d7-4a82-97ad-8c4860e7a4e0"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("562a39f5-f087-44b5-bd80-a47302f9324e"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("5a9e15e2-64ef-480d-999e-ce036c507160"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("62b911f4-88cd-4c26-8434-01e74d9dea1b"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("66a23946-ec42-435a-99bc-e6d666306849"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("6773417f-fd5f-410c-a2fd-c1fc0c1e566e"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("69adae26-2a1c-41f9-bc9d-fe9b53de197b"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("6bc36e47-95f5-4aa2-bc6a-e3720b71eb22"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("6e2168a8-3605-4731-a905-8474a0933b5f"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("7c07100a-c961-4371-8bb6-47c21c0dc662"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("8082c257-a2b6-413e-a5fe-d9d42e23c0e1"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("80a66f5b-2912-4940-8d96-a7db807c0401"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("84a48997-3919-4bca-af3e-0beca4e372e3"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("884f7898-6180-4099-a077-84960d5c16f4"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("8ae242f2-1482-498e-8333-ae96b24866a8"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("92a21c96-5c6e-4d66-8012-02f059c04ffc"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("966842fc-8cde-4695-b28a-c979ff408e88"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("99c74606-edcc-4bae-8a6b-95df82108334"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("bf9daabb-bcba-414a-8370-69fbb1106d8d"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("c2c23263-0bc3-4d72-aa75-5ecc41c327e0"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("cc16a6c4-245c-4bc6-8910-f9d6e2fb32fb"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("d04c9f14-b62d-439b-9a07-b17dc74ed758"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("d83fd63e-d06f-4b91-8969-da229515ac7f"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("e15002dc-4c0a-41ed-9710-848231da7160"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("e32a9661-7122-44f1-b44e-7c43761a3ec5"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("e5f132d5-4b98-44a1-a02a-4ff6616b8544"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("f980b69b-9c2b-44dc-86e1-8200861c590f"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("f9f3b0f8-01bb-4239-963a-218aac774c7a"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("fa39fdc7-a333-4a5e-8895-4e601541b2e8"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("fe178187-3c75-45b6-b57c-a9fde7627451"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("ff9ebddc-61e1-47a5-8a68-1f952848ff0a"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("ffc4f945-779d-4556-b62c-0d8c93fb68ff"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("07f18fd0-f84c-4241-bcab-eab47b4e9ca3"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("0e77e3ee-95ab-49d6-964e-cdf7ceef0750"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("0f8094db-6303-4ae3-9576-3483c99692ec"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("1885f665-9973-4c19-b210-4b0363578aff"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("245aedc1-12aa-42ea-ba27-6f5a2155bd0b"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("30d5c7d8-aed1-46c1-a54f-9c12083d234b"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("3c89a9db-d5d3-47ad-bb60-666faba13bbf"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("3f868604-3c57-4168-b50d-1893525c2b42"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("40dd2564-f3f6-4928-ab62-ca79293a4512"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("4ba1ce7d-ec6f-441f-82fd-0afbffaa6cbe"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("4ce14e0d-dd13-4c55-b116-a367ec0390bb"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("5353d817-73a6-4dad-a679-1639ea0bc14c"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("557ee7d6-b90d-4ba3-b8cb-e54aedb60650"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("5b8a1e36-8607-4b7f-a745-f5a406ca40fa"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("5d7a94aa-de57-4ffb-afc2-a3089480bf16"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("5e6ec3b8-11e6-417b-b29e-231cd9bfe1c6"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("62238faf-db0f-4fd4-86c7-981d2136c3fc"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("6d03e62b-4005-4f0e-a3b0-09593a544764"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("7f1d95b1-6390-4cdb-9af5-9bb0066259f1"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("7fcd639e-48ab-417d-9790-3daa037e2222"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("831de33e-5a72-4528-9b3f-0869d18d7fc4"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("845562b6-c42c-436f-9348-ef57fd06d1f7"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("8b0c57b4-8d10-4597-ac3f-51239d2d84eb"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("8c306ddd-f2a6-4401-b54d-88ac3bef1356"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("91579f8f-90c7-4548-9174-40d639334508"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("94cd9c51-d0f7-416e-ae64-04e844b8bb77"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("a242dc3c-c9e8-489c-9ab4-07b743d10235"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("a44a22fc-ea52-4eed-aa90-0a91f7b00f37"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("a7f81ccb-0d33-47c2-ad8c-2d6222aabfa1"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("aa19cd59-9e03-4548-8d8f-cb3f0f83bf0f"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("ae8070e4-7bf9-41c5-a6e2-2dffad735417"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("bc007b90-1e10-402e-82d1-5a527d6d9743"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("be071f93-8c23-42b7-b068-00e8ae2faaed"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("c1a5fa0a-9436-4555-8619-e1ae14d60f95"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("c8d895b2-c007-4787-bcd3-b0a76741910f"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("d4971fd7-166f-446b-9cd9-06946da65eea"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("df75e9ac-4468-46b1-8487-761495ad13f8"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("e0bba871-7283-43a6-bded-2bca067b605a"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("e8b284f0-87d1-40d3-b73d-2e35d74e7afa"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("ef0a1ce2-2e8d-4b08-9283-326569d658d4"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("f1c7654e-c497-4466-b994-0f9ad3b26443"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("f208db2d-b0d1-42a2-b093-3862d3a60889"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("f819b2df-e960-4066-b2c7-c6b3783e325f"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("f91bbd8b-3205-46dc-8f28-a6121ec0e683"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("f9333300-e751-45b7-9bce-e383be3c4a7b"));

            migrationBuilder.DropColumn(
                name: "variant_id",
                table: "order_items");

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a1a1a1a1-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4566), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a2a2a2a2-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4576), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a3a3a3a3-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4582), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b1b1b1b1-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4587), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b2b2b2b2-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4593), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b3b3b3b3-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4599), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c1c1c1c1-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4605), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c2c2c2c2-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4610), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c3c3c3c3-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4616), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3392), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("88499694-269b-4308-a64d-0e903a1f503d"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3382), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3398), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.InsertData(
                table: "images",
                columns: new[] { "id", "created_at", "product_id", "updated_at", "url" },
                values: new object[,]
                {
                    { new Guid("091189d3-0dc7-455c-8d38-f65e4c3fda99"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3718), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3720), "https://picsum.photos/1000/1000?random=20" },
                    { new Guid("0b1f5ba8-b4c0-491d-b4c3-a5810b213588"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3654), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3656), "https://picsum.photos/1000/1000?random=10" },
                    { new Guid("12eed719-04d8-4a85-b833-45461162b2e9"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3617), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3619), "https://picsum.photos/1000/1000?random=5" },
                    { new Guid("1d47d935-c1df-431a-bb02-a1bc61a6fdd3"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3939), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3941), "https://picsum.photos/1000/1000?random=39" },
                    { new Guid("204f343e-4ce5-4963-b1db-0cb0cbc4097d"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3712), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3714), "https://picsum.photos/1000/1000?random=19" },
                    { new Guid("2125957f-3e0a-4dcb-94d0-3ea4c2a4e3f4"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3647), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3649), "https://picsum.photos/1000/1000?random=9" },
                    { new Guid("217d178c-37b3-4aa2-9f90-bc69c5f6ca6f"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3893), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3895), "https://picsum.photos/1000/1000?random=32" },
                    { new Guid("2a614741-6a57-4aa3-9c83-7b7d424f9852"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3671), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3673), "https://picsum.photos/1000/1000?random=13" },
                    { new Guid("38b105fd-7011-4bb9-be89-538fcd762767"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3624), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3626), "https://picsum.photos/1000/1000?random=6" },
                    { new Guid("3b83cf44-3426-41c9-af7d-202c0f26e50a"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3963), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3965), "https://picsum.photos/1000/1000?random=43" },
                    { new Guid("45df4140-40b8-444a-bf2c-7698b62830a0"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3866), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3869), "https://picsum.photos/1000/1000?random=28" },
                    { new Guid("4d36fab7-0b69-42b8-993f-f963496ce9fe"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3887), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3889), "https://picsum.photos/1000/1000?random=31" },
                    { new Guid("537fb337-90e7-4db3-90dc-2eb64d68c9af"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3599), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3601), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("588e56f4-30a3-4586-a304-94930f934284"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3951), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3953), "https://picsum.photos/1000/1000?random=41" },
                    { new Guid("63376c58-a131-409b-bb7e-7b1e68627e16"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3968), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3971), "https://picsum.photos/1000/1000?random=44" },
                    { new Guid("65b7a6a4-afab-4354-94e0-8eeadd935404"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3945), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3947), "https://picsum.photos/1000/1000?random=40" },
                    { new Guid("69488eeb-4d4e-4609-b9f3-ea93fcc7b090"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3849), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3851), "https://picsum.photos/1000/1000?random=25" },
                    { new Guid("6d123bea-1fbf-4c8a-81ae-6b4db0b026b7"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3575), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3577), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("6d47de4b-c598-40fc-8980-91324b59290e"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3698), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3700), "https://picsum.photos/1000/1000?random=17" },
                    { new Guid("6f4222d0-f00b-4564-a81e-5b916ad70585"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3730), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3732), "https://picsum.photos/1000/1000?random=22" },
                    { new Guid("7539b60a-79cc-4cd9-9b77-2b7c5c01d6b4"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3706), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3708), "https://picsum.photos/1000/1000?random=18" },
                    { new Guid("756c9bb1-b165-47e2-a7e7-093dd96c675d"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3919), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3921), "https://picsum.photos/1000/1000?random=36" },
                    { new Guid("79605568-d2ea-401e-ba38-c18e19cba37c"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3957), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3959), "https://picsum.photos/1000/1000?random=42" },
                    { new Guid("7fd0cfb8-ddab-42de-be44-a06ef6ccb47d"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3842), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3844), "https://picsum.photos/1000/1000?random=24" },
                    { new Guid("83117100-fa5f-4ce8-8ad0-246a50585c91"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3665), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3668), "https://picsum.photos/1000/1000?random=12" },
                    { new Guid("874461e1-87a2-4f3e-ace2-6719b934452a"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3855), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3857), "https://picsum.photos/1000/1000?random=26" },
                    { new Guid("887f0c8e-a4fa-4d50-a16c-4d860f839fb6"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3660), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3662), "https://picsum.photos/1000/1000?random=11" },
                    { new Guid("8be59bf3-d516-4538-9a5c-f63df401f96f"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3724), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3726), "https://picsum.photos/1000/1000?random=21" },
                    { new Guid("92166e50-71b4-4319-8d85-c2d198f1261c"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3677), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3679), "https://picsum.photos/1000/1000?random=14" },
                    { new Guid("92422218-d4d1-4cdf-9742-f1d5dc78a217"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3605), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3607), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("94bcd4d9-0a9e-4740-93a2-72840c00f6bb"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3739), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3741), "https://picsum.photos/1000/1000?random=23" },
                    { new Guid("a90106c4-ceaf-4c74-9e38-5ca6320f6b1e"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3860), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3862), "https://picsum.photos/1000/1000?random=27" },
                    { new Guid("ab40144e-563b-47dd-8468-b6051b8a0cef"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3925), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3927), "https://picsum.photos/1000/1000?random=37" },
                    { new Guid("b8a2db0b-0998-433a-a12a-43fb2cf063f7"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3878), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3880), "https://picsum.photos/1000/1000?random=30" },
                    { new Guid("c24f24a6-5008-4a82-a4e1-36b1be354382"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3907), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3909), "https://picsum.photos/1000/1000?random=34" },
                    { new Guid("ca2e59ab-6950-448b-8fcb-cec319367f29"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3611), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3613), "https://picsum.photos/1000/1000?random=4" },
                    { new Guid("d9cf9b62-0e3e-4f6e-b22b-d64a0e4e8ed7"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3913), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3915), "https://picsum.photos/1000/1000?random=35" },
                    { new Guid("dc4db791-0435-483f-8291-407c065e71c3"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3974), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3976), "https://picsum.photos/1000/1000?random=45" },
                    { new Guid("de2c5c7e-679b-4b71-bf3c-3cd87fafcad6"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3930), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3932), "https://picsum.photos/1000/1000?random=38" },
                    { new Guid("e2193852-d20d-4b0f-abaf-e4cb0e3bd6ee"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3872), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3874), "https://picsum.photos/1000/1000?random=29" },
                    { new Guid("eee8592f-d768-4368-9a34-6779c76fa18b"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3634), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3637), "https://picsum.photos/1000/1000?random=7" },
                    { new Guid("f25e7543-49a4-4d74-8352-66c12163ade5"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3686), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3688), "https://picsum.photos/1000/1000?random=15" },
                    { new Guid("f3a54208-7498-4494-a092-333412def51f"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3899), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3901), "https://picsum.photos/1000/1000?random=33" },
                    { new Guid("f8c974fe-b262-4a72-a2f9-7c6c59da4254"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3641), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3643), "https://picsum.photos/1000/1000?random=8" },
                    { new Guid("fc115cf7-20e9-437d-a25d-00d5f68f9aa3"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3692), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3694), "https://picsum.photos/1000/1000?random=16" }
                });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3504), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3468), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3487), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3515), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3481), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3476), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3492), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("865770da-89af-4719-b00c-310b57d535e1"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3456), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("8b441114-e030-4412-8952-2370a4b7f05a"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3526), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3520), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3509), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3442), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3463), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3499), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3451), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("30a4ff5e-3bd1-429d-9981-adbcd46e2537"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4515), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("38fb4093-965e-4e3f-a7a2-c19103fc239e"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4509), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("71dd6268-f87a-4816-a5bf-c94769a51473"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4470), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("9aa483ac-872b-468c-af4f-2c1f94beec3a"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4481), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("a4438f9a-a573-4967-96c3-6a38fcfb6132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4493), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("c2cd9d37-25d0-4b5d-a336-8214ce83b648"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4498), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("c9e3c10d-b843-434d-bcbe-bfe35e17dd52"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4461), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4464) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("ca5b7d5d-309c-4973-ad8c-132a4142b5c1"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4486), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("dfc6ffd5-140c-4505-9428-7fe852a93afc"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4504), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("eb57b891-c019-46c9-9c6e-630a79d19787"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4476), new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 404, DateTimeKind.Local).AddTicks(7429), "YaNAdWT5p4sFl2jTcRsnIQ==;cddOKylXN40qy0OYzb/DWZR7RzS+TAPEml3mCg5l8iU=", new DateTime(2023, 12, 26, 16, 36, 25, 404, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 403, DateTimeKind.Local).AddTicks(1317), "DyhLqU1CNtNzxD86FbOR+g==;p0UoxoyGeGtb8M5IBGZe+vwCYaky4cabWQ5V2QZjpKI=", new DateTime(2023, 12, 26, 16, 36, 25, 403, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 36, 25, 401, DateTimeKind.Local).AddTicks(5141), "2Pzm2EEXSkeRs5dMARKlZg==;okNXDtICDan/ZH11m+7VZ0ZaZ6/dUm4PMyhgSeKyQlY=", new DateTime(2023, 12, 26, 16, 36, 25, 401, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.InsertData(
                table: "variants",
                columns: new[] { "id", "color", "created_at", "product_id", "quantity", "size", "updated_at" },
                values: new object[,]
                {
                    { new Guid("07470445-7506-46fa-9a80-070c0b7233bf"), Color.Black, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4162), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4164) },
                    { new Guid("11f16092-3dbd-4daa-a53a-667b2af9fc91"), Color.Black, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4314), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4316) },
                    { new Guid("13ffb885-df7d-4378-9fcb-978fd54d66e8"), Color.Blue, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4094), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4096) },
                    { new Guid("15cacb38-2ca9-4848-89d7-f849b360be84"), Color.Black, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4276), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4278) },
                    { new Guid("16b1ef96-6bfb-44d1-8e2b-f5678179fca8"), Color.Red, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4242), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 10, Size.L, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4244) },
                    { new Guid("199a773b-8621-4d69-a5b5-b8eb05d5918f"), Color.Black, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4122), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4124) },
                    { new Guid("1bf0f6a4-3a15-4ac6-b2f8-9acec9a97eaf"), Color.Red, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4264), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 10, Size.L, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4266) },
                    { new Guid("1fb35f36-71fb-41cd-b6c0-acc9a4b54c6a"), Color.Blue, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4116), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4118) },
                    { new Guid("20c473c4-bb06-40ca-932f-b08380b6e0fa"), Color.Blue, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4152), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4154) },
                    { new Guid("210951e5-e2c3-42b1-a754-7928dc874b87"), Color.Red, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4146), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 10, Size.L, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4148) },
                    { new Guid("26e641f5-0ff4-4373-9a69-67b4212aec71"), Color.Red, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4204), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 10, Size.L, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4206) },
                    { new Guid("32f5d573-2a2b-492c-93f6-89f7f74d9144"), Color.Blue, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4192), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4194) },
                    { new Guid("3b80e272-7ed9-4479-91f8-f25b7ab4f6ce"), Color.Red, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4224), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 10, Size.L, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4226) },
                    { new Guid("3d8f7940-adb4-4a47-884f-33a8b42a2a68"), Color.Blue, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4212), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4215) },
                    { new Guid("4203b401-8480-4da0-b746-3354edfeb25b"), Color.Blue, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4248), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4250) },
                    { new Guid("4723dae1-6902-4582-8230-70017c2843f0"), Color.Red, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4300), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 10, Size.L, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4302) },
                    { new Guid("4cff25b7-ef4f-4e95-a091-2924da7eaca2"), Color.Blue, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4134), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4136) },
                    { new Guid("4eb9b560-de47-4e63-9929-212d7ed83ecb"), Color.Blue, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4270), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4272) },
                    { new Guid("599bb4a7-5cfd-453c-ba5f-07ecc34d31ba"), Color.Black, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4254), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4256) },
                    { new Guid("61978e2a-1229-4bc8-94db-328734649c70"), Color.Red, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4068), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 20, Size.L, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4070) },
                    { new Guid("67a1c1a5-f3aa-4f91-b0f9-3d0d2538e222"), Color.Black, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4101), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4103) },
                    { new Guid("6b913808-d1a4-4d95-80c0-29694688b672"), Color.Black, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4140), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4142) },
                    { new Guid("75037c43-72cd-485d-bf4e-592f6cc9663f"), Color.Black, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4332), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4335) },
                    { new Guid("752fedea-c423-4e6b-8dfb-8a4f7b0f0b5c"), Color.Red, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4043), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 10, Size.L, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4046) },
                    { new Guid("76dcd06a-930b-40ce-b138-0e388644889c"), Color.Red, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4110), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 10, Size.L, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4112) },
                    { new Guid("7e099b10-1ab6-48e4-89e6-dcb87843c5c0"), Color.Black, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4236), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4238) },
                    { new Guid("818123c8-2ab3-41d4-8b11-e48cf71120c3"), Color.Blue, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4056), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4058) },
                    { new Guid("81f90565-cf28-42ea-8b73-a3d7d9b74c0e"), Color.Blue, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4327), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4329) },
                    { new Guid("852c2e77-b985-457e-9d6c-4dfcbe754e0d"), Color.Black, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4062), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4064) },
                    { new Guid("958bace2-c7ab-443e-9640-3ea3ac06a8d2"), Color.Blue, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4230), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4232) },
                    { new Guid("a3868b49-737f-45fd-98a0-de7f89707d6c"), Color.Blue, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4074), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4077) },
                    { new Guid("a399a6eb-9478-4ea9-be73-d091a4d6e5e2"), Color.Red, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4128), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 10, Size.L, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4130) },
                    { new Guid("abaf746e-8f31-48e2-b015-e4dc49b3cdcc"), Color.Blue, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4288), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4290) },
                    { new Guid("c4616011-66b5-4d2d-ac4c-60aa5ad14d6e"), Color.Black, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4198), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4200) },
                    { new Guid("c70d6dfa-81da-4535-8b5b-6fb513a06c4b"), Color.Blue, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4174), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4176) },
                    { new Guid("cc341cd8-a5dc-4084-a4fc-ec5b33a06b36"), Color.Red, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4186), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 10, Size.L, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4188) },
                    { new Guid("d216952b-34b7-402d-b2b0-4514abcf480c"), Color.Black, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4180), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4182) },
                    { new Guid("eaf80cb8-cb4e-4d8b-8bc0-d1eb409e464f"), Color.Red, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4088), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 10, Size.L, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4090) },
                    { new Guid("ecf7eb06-ae5f-4f0d-bec7-7fcd39e08b8c"), Color.Blue, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4306), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 20, Size.XL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4308) },
                    { new Guid("ed6623e0-8885-4123-b0e9-c88644f0abd9"), Color.Black, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4294), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4296) },
                    { new Guid("f56d64f4-828b-41f7-9fe1-fda99e2038d8"), Color.Black, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4218), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4220) },
                    { new Guid("f6208cfd-9094-4b8e-9d4a-56c0c561f6fc"), Color.Red, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4320), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 10, Size.L, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4323) },
                    { new Guid("f68efc8d-6c74-4073-bf0f-12e9df06ad66"), Color.Red, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4282), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 10, Size.L, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4284) },
                    { new Guid("faf347e1-124a-4367-bd47-dc247400ed72"), Color.Red, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4168), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 10, Size.L, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4170) },
                    { new Guid("ff69d11e-71b1-4d4f-96ec-0ad51a96247a"), Color.Black, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4082), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 30, Size.XXXL, new DateTime(2023, 12, 26, 16, 36, 25, 406, DateTimeKind.Local).AddTicks(4084) }
                });
        }
    }
}
