using System;
using EcommerceAPI.Core.src.Entity;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceAPI.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderRelationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_orders_users_user_id",
                table: "orders");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "user_id",
                table: "orders",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a1a1a1a1-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1015), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a2a2a2a2-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1024), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a3a3a3a3-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1028), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b1b1b1b1-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1032), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b2b2b2b2-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1037), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b3b3b3b3-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1042), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c1c1c1c1-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1047), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c2c2c2c2-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1051), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c3c3c3c3-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1055), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(63), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("88499694-269b-4308-a64d-0e903a1f503d"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(54), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(68), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.InsertData(
                table: "images",
                columns: new[] { "id", "created_at", "product_id", "updated_at", "url" },
                values: new object[,]
                {
                    { new Guid("0479fe41-3c2d-4761-a26c-65518033a792"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(336), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(338), "https://picsum.photos/1000/1000?random=9" },
                    { new Guid("093689ca-88fc-4ec4-b826-2a3e8386c17d"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(370), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(372), "https://picsum.photos/1000/1000?random=15" },
                    { new Guid("13e9e1c1-2c80-4c49-bcdc-83a8ed700331"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(403), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(404), "https://picsum.photos/1000/1000?random=21" },
                    { new Guid("15372313-6eaf-4d0c-bc8d-f9e5d86fa2eb"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(361), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(362), "https://picsum.photos/1000/1000?random=13" },
                    { new Guid("19e8a5cd-b958-444c-b848-45d2ff31c4f6"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(456), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(458), "https://picsum.photos/1000/1000?random=32" },
                    { new Guid("1e75b35b-c046-4b1a-8cae-2c98d7ca7fba"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(327), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(328), "https://picsum.photos/1000/1000?random=7" },
                    { new Guid("20e02d24-6d8d-4c87-88f4-0b93e67cdb50"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(356), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(358), "https://picsum.photos/1000/1000?random=12" },
                    { new Guid("28ffa330-a2d4-4495-8e64-d57c7318af9d"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(493), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(495), "https://picsum.photos/1000/1000?random=39" },
                    { new Guid("2aa81a8b-1c03-4713-bf2b-a361980cc7ea"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(321), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(323), "https://picsum.photos/1000/1000?random=6" },
                    { new Guid("2f2bc863-63f5-458c-b457-ac157290b484"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(512), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(514), "https://picsum.photos/1000/1000?random=43" },
                    { new Guid("2f56e7a6-3a68-4444-8162-97889ca164bf"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(375), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(376), "https://picsum.photos/1000/1000?random=16" },
                    { new Guid("303628d2-94e3-4db8-966c-bf10172db3d8"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(507), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(509), "https://picsum.photos/1000/1000?random=42" },
                    { new Guid("452cb007-034e-4390-9c76-c2c27ac3f744"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(437), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(439), "https://picsum.photos/1000/1000?random=28" },
                    { new Guid("4aa245b6-1ce8-4fce-b017-e69327c2a79f"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(215), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(218), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("4da44e7e-2302-4428-8ba5-7f79c81e03f1"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(498), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(499), "https://picsum.photos/1000/1000?random=40" },
                    { new Guid("562b6f0f-ce87-42ff-b87b-f171001e3ea4"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(426), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(427), "https://picsum.photos/1000/1000?random=26" },
                    { new Guid("59af1e5a-410a-40cd-b8b1-0e9b6783887a"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(447), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(448), "https://picsum.photos/1000/1000?random=30" },
                    { new Guid("5c8e313b-4abe-4553-994b-9c61c8714bbd"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(421), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(423), "https://picsum.photos/1000/1000?random=25" },
                    { new Guid("64fbca37-7c17-4579-9eb5-ea2ae0de10b2"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(342), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(344), "https://picsum.photos/1000/1000?random=10" },
                    { new Guid("68362c1e-27fb-4a9a-a792-d01f2fc1b87f"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(523), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(525), "https://picsum.photos/1000/1000?random=45" },
                    { new Guid("6a5bd554-2ae4-4309-af21-d7ef93d66170"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(398), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(400), "https://picsum.photos/1000/1000?random=20" },
                    { new Guid("6fd1c619-76d3-4da7-a533-8768d3f04e25"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(332), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(333), "https://picsum.photos/1000/1000?random=8" },
                    { new Guid("70ba13fb-30c7-45a9-8377-a5a5f04215dc"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(407), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(409), "https://picsum.photos/1000/1000?random=22" },
                    { new Guid("736eb0a6-64f5-4997-a008-d692b0b06920"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(417), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(418), "https://picsum.photos/1000/1000?random=24" },
                    { new Guid("7b6ce604-68b2-4449-91c0-d970b269d093"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(379), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(381), "https://picsum.photos/1000/1000?random=17" },
                    { new Guid("7c600a30-567d-47a2-83f3-ebf3c5067cb1"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(487), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(490), "https://picsum.photos/1000/1000?random=38" },
                    { new Guid("7e671b03-4966-43ab-b214-960e5b99fa43"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(483), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(484), "https://picsum.photos/1000/1000?random=37" },
                    { new Guid("82280075-2f24-4e02-b3f9-8377363c5511"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(519), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(520), "https://picsum.photos/1000/1000?random=44" },
                    { new Guid("851584fc-7db7-4b49-a890-31a1e1b1a191"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(390), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(392), "https://picsum.photos/1000/1000?random=19" },
                    { new Guid("8d067035-9f25-4f56-b212-c6f1784323fe"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(466), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(468), "https://picsum.photos/1000/1000?random=34" },
                    { new Guid("8fc1de31-95d7-4bf5-95d9-bb2b6e5400e5"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(478), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(480), "https://picsum.photos/1000/1000?random=36" },
                    { new Guid("91ea1d13-ac57-46f1-9847-a76ff16bf2bf"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(452), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(453), "https://picsum.photos/1000/1000?random=31" },
                    { new Guid("96e84063-90f1-41af-bb0e-49d0e9f312f1"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(503), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(504), "https://picsum.photos/1000/1000?random=41" },
                    { new Guid("9844b8df-0ff1-4c11-a7c3-d9242431b2c1"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(385), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(387), "https://picsum.photos/1000/1000?random=18" },
                    { new Guid("a7fad9e7-1e3e-4938-9fcf-127dd7443907"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(245), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(247), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("aa0ea44d-6b50-4db4-8b5d-d0d8c2816e92"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(442), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(444), "https://picsum.photos/1000/1000?random=29" },
                    { new Guid("b803dff6-a23f-49b1-b62e-958219b86249"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(461), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(462), "https://picsum.photos/1000/1000?random=33" },
                    { new Guid("b8f69670-9748-402e-bb97-bffb54192ed8"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(347), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(349), "https://picsum.photos/1000/1000?random=11" },
                    { new Guid("bccc654c-77f0-42bd-968b-6d3fbc359c3f"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(471), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(473), "https://picsum.photos/1000/1000?random=35" },
                    { new Guid("d09395ac-f28a-4501-a07a-a449b3a60c01"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(430), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(432), "https://picsum.photos/1000/1000?random=27" },
                    { new Guid("e5b7751d-d577-439e-beda-80562b55b46d"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(240), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(242), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("f445a83a-321f-460c-9e53-db2c80db13ac"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(412), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(414), "https://picsum.photos/1000/1000?random=23" },
                    { new Guid("f473b495-49df-4fd3-8575-03d8f89f53a2"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(264), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(265), "https://picsum.photos/1000/1000?random=4" },
                    { new Guid("f4b1871c-dfb5-423f-9680-3d43d3cf2abd"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(269), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(270), "https://picsum.photos/1000/1000?random=5" },
                    { new Guid("fb6f6da5-cc0c-4591-b7de-15d24da57245"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(366), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(367), "https://picsum.photos/1000/1000?random=14" }
                });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(156), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(124), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(142), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(165), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(138), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(133), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(146), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("865770da-89af-4719-b00c-310b57d535e1"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(115), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("8b441114-e030-4412-8952-2370a4b7f05a"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(174), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(169), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(161), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(102), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(120), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(152), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(111), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("30a4ff5e-3bd1-429d-9981-adbcd46e2537"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(981), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("38fb4093-965e-4e3f-a7a2-c19103fc239e"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(976), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("71dd6268-f87a-4816-a5bf-c94769a51473"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(946), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("9aa483ac-872b-468c-af4f-2c1f94beec3a"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(954), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("a4438f9a-a573-4967-96c3-6a38fcfb6132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(963), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("c2cd9d37-25d0-4b5d-a336-8214ce83b648"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(968), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("c9e3c10d-b843-434d-bcbe-bfe35e17dd52"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(938), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("ca5b7d5d-309c-4973-ad8c-132a4142b5c1"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(958), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("dfc6ffd5-140c-4505-9428-7fe852a93afc"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(972), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("eb57b891-c019-46c9-9c6e-630a79d19787"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(950), new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 703, DateTimeKind.Local).AddTicks(6186), "WjhRaHfkXXnjkoJE49qNqg==;Tz4FCmlU9hOXg/UVMmBDRSGiHzwBRa2uf/cZbeJnVkM=", new DateTime(2023, 12, 27, 6, 11, 36, 703, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 702, DateTimeKind.Local).AddTicks(2337), "x1JiYkgmGRpsKImu90Sl5A==;jC+EAd/d++utQbHVdUaU2g2lJU7WbwUxPykqSA/oQRg=", new DateTime(2023, 12, 27, 6, 11, 36, 702, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 11, 36, 700, DateTimeKind.Local).AddTicks(8069), "17Yap0lCscNWHQt+nC+ENg==;vzQz9TMmpCpjpZMuTK8LDnu4yVHu1h8LUIC6aYhZrTM=", new DateTime(2023, 12, 27, 6, 11, 36, 700, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.InsertData(
                table: "variants",
                columns: new[] { "id", "color", "created_at", "product_id", "quantity", "size", "updated_at" },
                values: new object[,]
                {
                    { new Guid("0df37962-6e33-49b8-9818-2e90b1a8b3ac"), Color.Black, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(669), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(671) },
                    { new Guid("13af832a-d063-4eb0-a19a-be6ee3e7be8a"), Color.Red, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(689), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 10, Size.L, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(690) },
                    { new Guid("22c852b7-c40e-4972-b7d2-4a6a7922163d"), Color.Blue, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(876), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(878) },
                    { new Guid("27183f63-8861-4ece-8d57-62fee63eb37c"), Color.Black, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(819), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(821) },
                    { new Guid("2d3c7bdb-54fb-4055-a309-11936001fb21"), Color.Blue, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(862), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(863) },
                    { new Guid("324a470b-96bc-4fb5-b8c4-23486d0beaa4"), Color.Red, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(841), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 10, Size.L, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(842) },
                    { new Guid("4265f5d6-5573-46ca-a270-739f1a37bd41"), Color.Blue, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(710), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(712) },
                    { new Guid("4c83accd-cf0a-4312-8cce-1fbd89168175"), Color.Black, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(803), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(804) },
                    { new Guid("4e88069c-1f12-4e77-9cdf-3568e9c66467"), Color.Red, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(872), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 10, Size.L, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(873) },
                    { new Guid("50c5133e-4908-49c6-a1d7-adcbb5248052"), Color.Red, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(642), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 10, Size.L, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(643) },
                    { new Guid("5fbc682e-d162-4f18-aa7e-457a0bb40739"), Color.Blue, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(679), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(680) },
                    { new Guid("6d0653e8-3686-4f3e-b2c5-419ab80a878d"), Color.Blue, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(815), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(816) },
                    { new Guid("72829400-68ea-4400-a093-ce943ed15ef3"), Color.Red, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(571), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 10, Size.L, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(573) },
                    { new Guid("750d4dc7-e19d-426d-a91d-4bb25fd7aafd"), Color.Blue, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(831), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(833) },
                    { new Guid("790d9a32-4a75-4799-818b-4892cf1ac56a"), Color.Blue, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(598), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(600) },
                    { new Guid("79f301f3-6459-447c-bc24-afacb9f42253"), Color.Red, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(857), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 10, Size.L, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(859) },
                    { new Guid("7df304e2-8233-4376-b913-9dc8c21aef63"), Color.Black, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(836), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(838) },
                    { new Guid("80fe813b-a9de-43c6-bbda-c525668f972a"), Color.Blue, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(663), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(665) },
                    { new Guid("824965ff-4daf-408d-835f-68e9f83ed3be"), Color.Black, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(881), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(883) },
                    { new Guid("8c20135e-5b2d-481d-ad96-4706f28e3b24"), Color.Black, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(684), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(685) },
                    { new Guid("8ea9d007-b98e-4f52-ac73-4a7b90400031"), Color.Black, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(867), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(868) },
                    { new Guid("95af4017-2791-4788-bfb9-69584343229a"), Color.Black, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(852), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(854) },
                    { new Guid("973d3bb3-774a-4d35-835b-0c5089e82454"), Color.Blue, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(632), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(634) },
                    { new Guid("9a839cab-a105-465f-b447-c6ac4b7edc89"), Color.Red, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(593), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 20, Size.L, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(595) },
                    { new Guid("9c2e1419-39f1-4bfa-8987-a310c9de006a"), Color.Blue, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(583), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(585) },
                    { new Guid("9ea97a8f-6237-47cc-96e7-7fa9fc150c03"), Color.Red, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(611), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 10, Size.L, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(613) },
                    { new Guid("a3a92041-ba6c-4ce4-8ddc-47e497e52b42"), Color.Black, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(588), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(590) },
                    { new Guid("a65686cf-42aa-411e-ab99-cc6e035b8960"), Color.Red, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(810), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 10, Size.L, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(811) },
                    { new Guid("a7c2ecde-e664-4d9e-bb81-051e1c4dbb5c"), Color.Red, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(705), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 10, Size.L, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(707) },
                    { new Guid("aa883094-c34c-4d48-8f1c-90c9fd8cb9a4"), Color.Black, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(621), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(623) },
                    { new Guid("afe6d847-2fee-453f-a354-cc6d7510b012"), Color.Red, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(826), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 10, Size.L, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(827) },
                    { new Guid("c3271210-374e-4459-b6b7-a75cff8dca31"), Color.Blue, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(798), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(799) },
                    { new Guid("c37f3dba-11a2-4e00-bff0-4ad53d6aaf4f"), Color.Red, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(627), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 10, Size.L, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(629) },
                    { new Guid("c4fa462c-36b3-4c09-ab76-7c47bcccd175"), Color.Red, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(658), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 10, Size.L, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(660) },
                    { new Guid("cabd12b7-ba5e-43f3-baed-b28cc3bc3308"), Color.Blue, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(846), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(847) },
                    { new Guid("daaab28c-83bc-4517-b523-9bd7a52c65dd"), Color.Blue, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(647), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(648) },
                    { new Guid("dbd1b725-a977-46a0-8758-be53fde11f12"), Color.Black, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(700), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(702) },
                    { new Guid("e794ef55-2200-40ca-94f8-15679b8dfda2"), Color.Black, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(604), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(606) },
                    { new Guid("ee8f6c8c-e5ec-468a-b26b-d3d0a3464123"), Color.Red, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(793), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 10, Size.L, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(795) },
                    { new Guid("f25ccc86-22f0-4cc4-9704-eaa65276aa38"), Color.Black, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(637), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(638) },
                    { new Guid("f5afcfdc-0c12-4135-8f9d-4bb89d58fe40"), Color.Blue, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(616), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(618) },
                    { new Guid("f607cdd7-7479-4fda-86ca-10ae3573e49f"), Color.Black, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(787), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(789) },
                    { new Guid("f69ace15-8eac-4f5d-8e9d-ce1f8de42e12"), Color.Blue, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(695), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(697) },
                    { new Guid("fb0fa79f-0e75-4cac-a098-0b23b4a3cf08"), Color.Red, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(674), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 10, Size.L, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(675) },
                    { new Guid("fca326db-e062-452c-be14-30b630837392"), Color.Black, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(653), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 11, 36, 705, DateTimeKind.Local).AddTicks(655) }
                });

            migrationBuilder.AddForeignKey(
                name: "fk_orders_users_user_id",
                table: "orders",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_orders_users_user_id",
                table: "orders");

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("0479fe41-3c2d-4761-a26c-65518033a792"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("093689ca-88fc-4ec4-b826-2a3e8386c17d"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("13e9e1c1-2c80-4c49-bcdc-83a8ed700331"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("15372313-6eaf-4d0c-bc8d-f9e5d86fa2eb"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("19e8a5cd-b958-444c-b848-45d2ff31c4f6"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("1e75b35b-c046-4b1a-8cae-2c98d7ca7fba"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("20e02d24-6d8d-4c87-88f4-0b93e67cdb50"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("28ffa330-a2d4-4495-8e64-d57c7318af9d"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("2aa81a8b-1c03-4713-bf2b-a361980cc7ea"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("2f2bc863-63f5-458c-b457-ac157290b484"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("2f56e7a6-3a68-4444-8162-97889ca164bf"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("303628d2-94e3-4db8-966c-bf10172db3d8"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("452cb007-034e-4390-9c76-c2c27ac3f744"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("4aa245b6-1ce8-4fce-b017-e69327c2a79f"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("4da44e7e-2302-4428-8ba5-7f79c81e03f1"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("562b6f0f-ce87-42ff-b87b-f171001e3ea4"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("59af1e5a-410a-40cd-b8b1-0e9b6783887a"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("5c8e313b-4abe-4553-994b-9c61c8714bbd"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("64fbca37-7c17-4579-9eb5-ea2ae0de10b2"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("68362c1e-27fb-4a9a-a792-d01f2fc1b87f"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("6a5bd554-2ae4-4309-af21-d7ef93d66170"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("6fd1c619-76d3-4da7-a533-8768d3f04e25"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("70ba13fb-30c7-45a9-8377-a5a5f04215dc"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("736eb0a6-64f5-4997-a008-d692b0b06920"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("7b6ce604-68b2-4449-91c0-d970b269d093"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("7c600a30-567d-47a2-83f3-ebf3c5067cb1"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("7e671b03-4966-43ab-b214-960e5b99fa43"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("82280075-2f24-4e02-b3f9-8377363c5511"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("851584fc-7db7-4b49-a890-31a1e1b1a191"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("8d067035-9f25-4f56-b212-c6f1784323fe"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("8fc1de31-95d7-4bf5-95d9-bb2b6e5400e5"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("91ea1d13-ac57-46f1-9847-a76ff16bf2bf"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("96e84063-90f1-41af-bb0e-49d0e9f312f1"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("9844b8df-0ff1-4c11-a7c3-d9242431b2c1"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("a7fad9e7-1e3e-4938-9fcf-127dd7443907"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("aa0ea44d-6b50-4db4-8b5d-d0d8c2816e92"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("b803dff6-a23f-49b1-b62e-958219b86249"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("b8f69670-9748-402e-bb97-bffb54192ed8"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("bccc654c-77f0-42bd-968b-6d3fbc359c3f"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("d09395ac-f28a-4501-a07a-a449b3a60c01"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("e5b7751d-d577-439e-beda-80562b55b46d"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("f445a83a-321f-460c-9e53-db2c80db13ac"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("f473b495-49df-4fd3-8575-03d8f89f53a2"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("f4b1871c-dfb5-423f-9680-3d43d3cf2abd"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("fb6f6da5-cc0c-4591-b7de-15d24da57245"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("0df37962-6e33-49b8-9818-2e90b1a8b3ac"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("13af832a-d063-4eb0-a19a-be6ee3e7be8a"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("22c852b7-c40e-4972-b7d2-4a6a7922163d"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("27183f63-8861-4ece-8d57-62fee63eb37c"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("2d3c7bdb-54fb-4055-a309-11936001fb21"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("324a470b-96bc-4fb5-b8c4-23486d0beaa4"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("4265f5d6-5573-46ca-a270-739f1a37bd41"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("4c83accd-cf0a-4312-8cce-1fbd89168175"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("4e88069c-1f12-4e77-9cdf-3568e9c66467"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("50c5133e-4908-49c6-a1d7-adcbb5248052"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("5fbc682e-d162-4f18-aa7e-457a0bb40739"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("6d0653e8-3686-4f3e-b2c5-419ab80a878d"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("72829400-68ea-4400-a093-ce943ed15ef3"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("750d4dc7-e19d-426d-a91d-4bb25fd7aafd"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("790d9a32-4a75-4799-818b-4892cf1ac56a"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("79f301f3-6459-447c-bc24-afacb9f42253"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("7df304e2-8233-4376-b913-9dc8c21aef63"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("80fe813b-a9de-43c6-bbda-c525668f972a"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("824965ff-4daf-408d-835f-68e9f83ed3be"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("8c20135e-5b2d-481d-ad96-4706f28e3b24"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("8ea9d007-b98e-4f52-ac73-4a7b90400031"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("95af4017-2791-4788-bfb9-69584343229a"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("973d3bb3-774a-4d35-835b-0c5089e82454"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("9a839cab-a105-465f-b447-c6ac4b7edc89"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("9c2e1419-39f1-4bfa-8987-a310c9de006a"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("9ea97a8f-6237-47cc-96e7-7fa9fc150c03"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("a3a92041-ba6c-4ce4-8ddc-47e497e52b42"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("a65686cf-42aa-411e-ab99-cc6e035b8960"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("a7c2ecde-e664-4d9e-bb81-051e1c4dbb5c"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("aa883094-c34c-4d48-8f1c-90c9fd8cb9a4"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("afe6d847-2fee-453f-a354-cc6d7510b012"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("c3271210-374e-4459-b6b7-a75cff8dca31"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("c37f3dba-11a2-4e00-bff0-4ad53d6aaf4f"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("c4fa462c-36b3-4c09-ab76-7c47bcccd175"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("cabd12b7-ba5e-43f3-baed-b28cc3bc3308"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("daaab28c-83bc-4517-b523-9bd7a52c65dd"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("dbd1b725-a977-46a0-8758-be53fde11f12"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("e794ef55-2200-40ca-94f8-15679b8dfda2"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("ee8f6c8c-e5ec-468a-b26b-d3d0a3464123"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("f25ccc86-22f0-4cc4-9704-eaa65276aa38"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("f5afcfdc-0c12-4135-8f9d-4bb89d58fe40"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("f607cdd7-7479-4fda-86ca-10ae3573e49f"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("f69ace15-8eac-4f5d-8e9d-ce1f8de42e12"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("fb0fa79f-0e75-4cac-a098-0b23b4a3cf08"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("fca326db-e062-452c-be14-30b630837392"));

            migrationBuilder.AlterColumn<Guid>(
                name: "user_id",
                table: "orders",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

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

            migrationBuilder.AddForeignKey(
                name: "fk_orders_users_user_id",
                table: "orders",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id");
        }
    }
}
