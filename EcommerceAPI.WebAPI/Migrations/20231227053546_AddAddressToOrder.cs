using System;
using EcommerceAPI.Core.src.Entity;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceAPI.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("02be318d-e2e0-4eec-8a5a-08820d565d01"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("0e9f35c5-ba7a-4869-a09c-ecc9ebc49f23"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("11d6bc24-03e9-493e-b807-384c264faeeb"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("1d10d282-f6c7-4a95-9807-9bd1df8a483f"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("2c57004a-280b-4edf-89b4-12ddcbe4d28b"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("2e28d637-41c7-4cee-9122-ca36d216ebbf"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("2f174b02-9432-4fe3-8e37-07b12e867951"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("2ff033c1-ce64-43d2-bee7-1df40620370e"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("36515797-65a5-4f1d-8b74-a3ac0d74d06d"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("37e6d1ef-6b52-4e7a-8a75-affb6d4f9e0a"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("3af328ed-9a3e-446e-a2ce-c0b393d80352"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("465a6ef2-3d54-49c1-9d12-f37ff592d5fa"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("498fdb21-4cfc-4403-aabe-3c3896a0a490"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("4ea1d228-e802-4b34-b449-fd2d85d8c391"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("50064b67-fed0-44ad-80df-a0bb6f60b003"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("5bc83b83-cbf0-408f-82d8-f1d37343a8d1"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("64fd0472-6edd-4c60-922d-e2ef2f6ba63e"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("77eb52a3-e705-4f8c-b5c8-fe05452fbe27"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("7c7b8160-0d5a-4099-b347-e42aa27a8643"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("817e9c0e-f066-49ad-92cc-b2a850015d58"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("86914db0-0f5b-46d5-982a-e65a03ccff10"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("8ad3623e-fab3-4b3b-aea1-81b3c49e0bbd"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("8da5fbac-aecc-4b92-bf01-345ddf484fcc"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("8e08155f-8889-4b6a-a618-18b47d13388c"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("94a81ce2-310b-41d3-8aa1-7cda15d6122e"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("950b7228-4cd7-4b0b-86d4-b5a79f04115f"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("9a9ffcfc-db72-4a91-866b-2a3c09778a11"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("9f3d6fb3-5d8a-41fb-8ef0-7cab7201c8e9"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("9f4a8833-2b02-421c-af15-903a5d3c8af7"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("a1eed97c-122b-409e-811d-57e54075a7fc"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("a3ace735-345f-48d6-9b56-afe68c19e6e5"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("a9825585-10a9-4743-8f15-4275a936e456"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("b4b532b0-cf7a-4f77-953a-acdc3c47429d"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("b503a738-6b47-4775-b6a8-514c2191e2e3"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("b5129947-ba1a-461f-bfe0-7780a94eaf6a"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("c5e04b99-2bcf-40c5-91c2-216479ac3add"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("cbe6ea41-b379-4fe6-8816-e346d9826eb0"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("cc8ab216-0cf1-45b2-94f1-6e91367174d0"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("d238e6f6-5b15-494d-a5c9-e5d9dca8b0fd"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("d743f218-2cca-4d8a-956e-4cb550ec62ef"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("d8a852a1-5784-4e9a-8e2b-f4367f8d5d04"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("e64afa39-2e3b-4d0a-930b-2e1e81e78cff"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("e9a8a09e-693c-4936-a445-e6a0c5dfd314"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("f2e572a6-9e50-4add-8fea-7a9bd9413e98"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("ff484588-ceb8-452c-b23a-d7911a6fef2f"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("07677433-f8e7-4520-9cc5-927537383019"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("0c0545d5-ad12-4a9b-9e8c-70036875643a"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("1228a483-d400-44bf-ab38-6737de33835b"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("1a268b61-14af-48c3-a373-ce7d9c138f9e"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("1b59c5e5-1ec0-41a0-ac46-0e328826d0a2"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("1df4e8bc-62d6-4d73-95e0-904fc80df670"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("21759c8e-cc17-4252-80e0-11b43592b8c7"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("24bcffdc-4f92-42b1-81ed-17db71e4b8f2"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("24cda3f0-f41d-4c0e-aa90-3b6b442445cf"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("26b7133e-f33e-4e31-b833-47ff3fd8b995"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("2fea385c-37ee-4b19-a336-9e12745f6778"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("301cc04d-3618-4a60-9f74-a34743f3c0fa"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("379c36d5-9c41-4dc2-99a3-0917e9fabdca"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("37a9f6d2-abe8-4226-b98a-c9724fad1f51"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("3e4d79f5-2844-4744-9c4d-035c539e51b7"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("3ea43075-1e66-4e34-8389-86f2dc93cbb4"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("491dc0fa-ff52-4b52-bf5b-e9e19d82fa93"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("4c22b11d-6704-429a-ae91-6658aecc5cba"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("4dd078cf-22c6-4345-9553-2fe60427c5ce"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("506f6fb7-c219-4002-9d3e-fa08ad44d0bb"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("542a6d72-05a4-4a0f-a1c0-e9edb7a12141"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("5e2aad41-bf11-4c41-8e42-60cc38b5b1b5"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("6cc47e02-03db-455a-9506-4ce9327b5cbe"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("772c5bc9-6339-48de-b8d1-6be7872e4e5a"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("8308c842-4a3a-4be1-8518-e31fde3b499c"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("850348bb-bdc5-428e-ad9a-dd4a4ed437f7"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("851c8219-53bb-4575-86d3-e24bc7c61b3d"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("86443275-b7e0-401d-ba98-adfd69fe54e4"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("9860cd50-814a-4969-9578-ba2652a44b98"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("99f349df-499f-46ac-bd61-b168f3da7649"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("a2cdea24-7801-4c07-a199-928b8be1b637"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("a7234533-8ef5-413c-838e-d92a0cdd3e9c"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("a933f209-7ac4-41e2-9ec5-150fb283769e"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("b4854c5b-0e94-466f-9082-09920afa0ae8"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("b579b676-cc66-44fd-b5ca-f27da43118e9"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("bf099820-cec2-4ec4-bc80-5ae416f002bb"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("c4908643-d8a7-4660-9fb0-8ef682805e4e"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("e60e3cbd-8028-4902-b9d7-cefc297e0434"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("e858ce85-2270-4bb3-98db-6733b2be279d"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("ec60f1d9-112f-455a-8c89-ea8b1dd9dc5b"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("edc6c946-ca54-49de-9588-cacfabd96b65"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("ef0d410b-7a6e-4043-8928-c63c9ceb4498"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("f02656fc-8e71-4391-a9f2-a7aad4ce33bd"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("f25fe360-c4fb-4c28-94b9-425e8c23deab"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("ff96a9a2-77fa-4a02-a3bc-ea2b88bb76f9"));

            migrationBuilder.AddColumn<Guid>(
                name: "address_id",
                table: "orders",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a1a1a1a1-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8010), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a2a2a2a2-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8018), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a3a3a3a3-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8023), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b1b1b1b1-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8027), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b2b2b2b2-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8032), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b3b3b3b3-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8037), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c1c1c1c1-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8042), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c2c2c2c2-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8047), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c3c3c3c3-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8051), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(6939), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("88499694-269b-4308-a64d-0e903a1f503d"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(6929), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(6943), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(6944) });

            migrationBuilder.InsertData(
                table: "images",
                columns: new[] { "id", "created_at", "product_id", "updated_at", "url" },
                values: new object[,]
                {
                    { new Guid("05240f98-3d7b-4f6f-a7da-a717e8ddb518"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7405), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7407), "https://picsum.photos/1000/1000?random=30" },
                    { new Guid("0540e46c-73fd-45e9-8d07-f0ba970df1b7"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7391), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7392), "https://picsum.photos/1000/1000?random=27" },
                    { new Guid("08e514d1-ee14-4a88-960c-f7490a70ee98"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7172), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7173), "https://picsum.photos/1000/1000?random=6" },
                    { new Guid("0b8385d3-25a5-44b0-b149-61907c243bb0"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7165), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7167), "https://picsum.photos/1000/1000?random=5" },
                    { new Guid("0e11f75f-996a-4b1b-9f95-d0164e1aeec1"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7377), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7379), "https://picsum.photos/1000/1000?random=25" },
                    { new Guid("0e136c72-3d18-48c3-933c-dac2078927d9"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7367), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7369), "https://picsum.photos/1000/1000?random=23" },
                    { new Guid("1724e13c-44d3-4108-a87a-5fe119eccc0a"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7196), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7198), "https://picsum.photos/1000/1000?random=10" },
                    { new Guid("1d5d98bf-32cd-45fe-85de-b4623f40b0dd"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7472), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7474), "https://picsum.photos/1000/1000?random=42" },
                    { new Guid("28d00078-9bd3-4502-8e65-8c2c89ce7ba5"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7342), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7344), "https://picsum.photos/1000/1000?random=18" },
                    { new Guid("3c49d643-c68d-4350-b720-01bd43ee7e3e"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7487), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7489), "https://picsum.photos/1000/1000?random=45" },
                    { new Guid("3c685680-2f35-4656-8e11-3f2f24d74c6e"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7207), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7209), "https://picsum.photos/1000/1000?random=12" },
                    { new Guid("4a31c082-faf5-4476-ac7c-e1ef978f75a3"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7385), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7387), "https://picsum.photos/1000/1000?random=26" },
                    { new Guid("4fd9a6f9-8dd8-4e8b-a233-6e7355962d8b"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7357), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7359), "https://picsum.photos/1000/1000?random=21" },
                    { new Guid("53269afb-bb93-4c98-bc1b-721da536685a"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7410), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7412), "https://picsum.photos/1000/1000?random=31" },
                    { new Guid("54261b25-58d9-4f34-86a1-29b4ef35591b"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7149), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7151), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("6bf64500-14db-4f3d-a436-702e08331f42"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7212), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7214), "https://picsum.photos/1000/1000?random=13" },
                    { new Guid("77e414ce-8299-4084-b72a-f154393d964e"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7332), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7334), "https://picsum.photos/1000/1000?random=17" },
                    { new Guid("7901a1cb-ccfc-41c9-8dc2-caf3824265ba"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7155), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7156), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("7c72c343-eb6b-40bc-9221-efaa1407a30c"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7440), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7442), "https://picsum.photos/1000/1000?random=36" },
                    { new Guid("818054da-cad8-46cf-876e-2973d7dc2651"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7460), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7462), "https://picsum.photos/1000/1000?random=40" },
                    { new Guid("82f7442b-d5d9-45b2-b2b2-c9c141396194"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7327), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7329), "https://picsum.photos/1000/1000?random=16" },
                    { new Guid("86523fef-e547-4fd6-a7c2-624e1c32af34"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7182), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7183), "https://picsum.photos/1000/1000?random=8" },
                    { new Guid("93edf3d7-4f1d-4345-8453-ed6d97dc6ec8"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7450), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7451), "https://picsum.photos/1000/1000?random=38" },
                    { new Guid("952d5a63-e305-4c9a-9b8f-aaadcfa7e9dd"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7160), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7162), "https://picsum.photos/1000/1000?random=4" },
                    { new Guid("97418f83-0f7a-4c1d-8fb3-406362ecb3de"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7202), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7203), "https://picsum.photos/1000/1000?random=11" },
                    { new Guid("9fe43dd5-d0aa-4cf8-859b-83f18f2e878c"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7465), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7467), "https://picsum.photos/1000/1000?random=41" },
                    { new Guid("a0ab2194-d776-460e-84e9-18ccd2037c8e"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7430), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7432), "https://picsum.photos/1000/1000?random=34" },
                    { new Guid("a4a6a758-4aad-4129-a8d2-7ef73c552049"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7455), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7456), "https://picsum.photos/1000/1000?random=39" },
                    { new Guid("aedbfeba-2bd1-4536-9637-b1469783436e"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7352), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7354), "https://picsum.photos/1000/1000?random=20" },
                    { new Guid("b402de49-22ec-433c-a9d8-9fc733cb5199"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7316), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7318), "https://picsum.photos/1000/1000?random=14" },
                    { new Guid("b6541dc1-6037-431f-baec-5511c5e1cdd5"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7187), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7188), "https://picsum.photos/1000/1000?random=9" },
                    { new Guid("bb6fb117-2ada-4c60-b83a-1d02c565efd5"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7482), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7484), "https://picsum.photos/1000/1000?random=44" },
                    { new Guid("bef9db7f-1f28-4084-a010-b3082b4876d4"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7322), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7323), "https://picsum.photos/1000/1000?random=15" },
                    { new Guid("c32e666e-935d-4ded-a598-1bdd2ec13286"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7362), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7364), "https://picsum.photos/1000/1000?random=22" },
                    { new Guid("c8e41a26-680b-4bb6-8b75-fff58a9a56bb"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7477), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7479), "https://picsum.photos/1000/1000?random=43" },
                    { new Guid("c9f7a2e1-4daa-4620-988d-b245fe072ccd"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7400), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7402), "https://picsum.photos/1000/1000?random=29" },
                    { new Guid("ca18ff7b-fd18-4962-9350-fc38e6fe2fcd"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7435), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7437), "https://picsum.photos/1000/1000?random=35" },
                    { new Guid("d2f3943e-a01e-4205-a8bb-11abb62228d8"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7109), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7111), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("d7d78aa5-1671-4521-960f-8b719bf43a3b"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7445), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7446), "https://picsum.photos/1000/1000?random=37" },
                    { new Guid("d90317cd-f169-487d-9183-90de00bf9b8f"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7347), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7349), "https://picsum.photos/1000/1000?random=19" },
                    { new Guid("e915dee1-9fd5-4122-ac31-98bef82932fb"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7177), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7178), "https://picsum.photos/1000/1000?random=7" },
                    { new Guid("ec0c277f-3dd9-4caf-a8f9-b0a07e20c0a1"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7420), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7422), "https://picsum.photos/1000/1000?random=33" },
                    { new Guid("ed2a0aec-ee3c-4bcb-998e-134e16d18e98"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7395), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7397), "https://picsum.photos/1000/1000?random=28" },
                    { new Guid("f3647104-3528-4204-bf22-ce25b2398092"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7415), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7417), "https://picsum.photos/1000/1000?random=32" },
                    { new Guid("f8fa93f7-8afa-4a49-9704-a4a5f1b8f48a"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7372), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7374), "https://picsum.photos/1000/1000?random=24" }
                });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7037), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7004), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7021), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7045), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7017), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7012), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7026), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("865770da-89af-4719-b00c-310b57d535e1"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(6995), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("8b441114-e030-4412-8952-2370a4b7f05a"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7054), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7050), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7041), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(6981), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(6999), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7032), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(6990), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("30a4ff5e-3bd1-429d-9981-adbcd46e2537"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7970), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("38fb4093-965e-4e3f-a7a2-c19103fc239e"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7965), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("71dd6268-f87a-4816-a5bf-c94769a51473"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7934), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("9aa483ac-872b-468c-af4f-2c1f94beec3a"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7943), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("a4438f9a-a573-4967-96c3-6a38fcfb6132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7952), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("c2cd9d37-25d0-4b5d-a336-8214ce83b648"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7957), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("c9e3c10d-b843-434d-bcbe-bfe35e17dd52"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7926), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("ca5b7d5d-309c-4973-ad8c-132a4142b5c1"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7947), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("dfc6ffd5-140c-4505-9428-7fe852a93afc"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7961), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("eb57b891-c019-46c9-9c6e-630a79d19787"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7939), new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 455, DateTimeKind.Local).AddTicks(1878), "EK0YIZsJ/Vhq+ckGgLgFGA==;+BEV2Lm1j5nq0/2DES3HiuetSr8enH/aunnlatG/IhU=", new DateTime(2023, 12, 27, 7, 35, 46, 455, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 453, DateTimeKind.Local).AddTicks(7384), "PF/NRP2kFdpp8D8nRMTxOg==;D7XDsVqsmg7rDJ5L23IT05/TwoHhdqyms/sHCzmzyOw=", new DateTime(2023, 12, 27, 7, 35, 46, 453, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 35, 46, 452, DateTimeKind.Local).AddTicks(2479), "UW+fszjBieakY7+gbKYIIw==;9E7m+Gy7LtzcwAF0OYJIiO+X3igqtr3kphjIbXoAUmg=", new DateTime(2023, 12, 27, 7, 35, 46, 452, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.InsertData(
                table: "variants",
                columns: new[] { "id", "color", "created_at", "product_id", "quantity", "size", "updated_at" },
                values: new object[,]
                {
                    { new Guid("067877d3-097e-4507-8a09-016c46f51349"), Color.Red, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7795), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 10, Size.L, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7797) },
                    { new Guid("0aabc0e7-ac38-40da-a851-26c7d80c7840"), Color.Red, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7814), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 10, Size.L, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7816) },
                    { new Guid("10509d07-e968-4297-8eb5-2b021cda8bf4"), Color.Red, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7725), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 10, Size.L, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7726) },
                    { new Guid("18905cab-67de-4708-9c7d-13d266da6d35"), Color.Red, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7551), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 10, Size.L, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7553) },
                    { new Guid("18ea00d7-0f2d-4f18-bdfe-6c19bf0e65a6"), Color.Black, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7840), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 30, Size.XXXL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7841) },
                    { new Guid("233089e2-f77c-41bf-b578-8892b013aedc"), Color.Black, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7857), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 30, Size.XXXL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7859) },
                    { new Guid("240ffac6-935f-4768-ab60-7ea131c40f62"), Color.Black, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7636), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 30, Size.XXXL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7638) },
                    { new Guid("295a8832-62a1-49be-88f2-51af3ce3b58f"), Color.Blue, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7631), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 20, Size.XL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7633) },
                    { new Guid("37cb6e02-b9c3-4cc9-8a74-8a16fcf59c8c"), Color.Red, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7692), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 10, Size.L, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7693) },
                    { new Guid("3c472e03-4152-4be0-81a5-2984f7974b4f"), Color.Red, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7626), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 10, Size.L, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7627) },
                    { new Guid("3d75c869-b7ab-4d5f-b418-159135762679"), Color.Black, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7686), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 30, Size.XXXL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7688) },
                    { new Guid("4102f553-14aa-441a-8278-c0f3ec8da8cb"), Color.Black, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7824), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 30, Size.XXXL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7826) },
                    { new Guid("43c74052-ff24-4ace-b6da-83a3ab65e129"), Color.Red, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7658), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 10, Size.L, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7660) },
                    { new Guid("44f936bb-3280-4d7f-9a61-eee7243e8580"), Color.Blue, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7664), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 20, Size.XL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7665) },
                    { new Guid("47cda36f-581c-4694-bba8-14672e939bad"), Color.Red, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7608), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 10, Size.L, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7610) },
                    { new Guid("512db5e3-d9d4-49eb-bb52-6c073056e5fd"), Color.Red, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7707), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 10, Size.L, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7709) },
                    { new Guid("592d4c18-c41d-429e-bdbd-1c2f934cad81"), Color.Red, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7829), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 10, Size.L, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7831) },
                    { new Guid("595204a8-fc60-4568-83bc-0e86c4880102"), Color.Black, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7735), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 30, Size.XXXL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7736) },
                    { new Guid("5ffa57bb-6172-453d-8625-ce65e82eabb6"), Color.Black, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7653), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 30, Size.XXXL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7655) },
                    { new Guid("6034d7a6-fa2c-4d98-ab21-17d1ce0c2270"), Color.Black, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7806), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 30, Size.XXXL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7808) },
                    { new Guid("607d840a-54be-40f4-a82d-25a1e714dcbe"), Color.Red, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7845), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 10, Size.L, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7846) },
                    { new Guid("62f61535-1e3c-4e47-afbc-faf94c7fdff1"), Color.Black, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7602), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 30, Size.XXXL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7603) },
                    { new Guid("8343bb71-4ee3-4eed-aaf8-9e7bd72c38fb"), Color.Blue, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7562), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 20, Size.XL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7563) },
                    { new Guid("9f60d5a3-c687-4126-aa5c-028b59abf989"), Color.Blue, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7819), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 20, Size.XL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7821) },
                    { new Guid("a2036864-c935-4339-a31e-b88a5fd94258"), Color.Blue, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7850), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 20, Size.XL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7851) },
                    { new Guid("a73fc07d-6ac9-4b08-adc9-92552d97222f"), Color.Blue, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7613), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 20, Size.XL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7615) },
                    { new Guid("b1a5d64e-54b1-417c-8691-442c1c484992"), Color.Blue, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7580), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 20, Size.XL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7581) },
                    { new Guid("b6a3d278-567d-4eda-ad67-529513bea9f7"), Color.Black, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7586), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 30, Size.XXXL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7587) },
                    { new Guid("c21fdaf2-a8af-4c22-b4c5-6cc2bd199299"), Color.Blue, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7834), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 20, Size.XL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7836) },
                    { new Guid("c3ae01af-3bcf-4744-a071-0670ef9e8ecc"), Color.Blue, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7801), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 20, Size.XL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7803) },
                    { new Guid("c9c5a326-6df4-4a7c-a5f7-c58f82bfa818"), Color.Blue, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7647), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 20, Size.XL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7648) },
                    { new Guid("d8a0f9db-3a6d-4bd8-a704-a094cdd010ea"), Color.Red, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7591), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 10, Size.L, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7593) },
                    { new Guid("dc05ed7f-c868-46f9-9d51-c738161ea666"), Color.Black, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7702), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 30, Size.XXXL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7704) },
                    { new Guid("dc4f954c-4664-42b9-b2c9-f4bded44beee"), Color.Blue, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7714), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 20, Size.XL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7716) },
                    { new Guid("de9c2d5c-b920-444d-beac-2bce85bed493"), Color.Black, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7720), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 30, Size.XXXL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7721) },
                    { new Guid("e5239e24-d4f0-4571-ac9e-495913c9d769"), Color.Black, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7567), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 30, Size.XXXL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7568) },
                    { new Guid("e56aab04-505c-4f3f-a700-c25ed27a9ad6"), Color.Black, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7671), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 30, Size.XXXL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7673) },
                    { new Guid("e67872a9-9835-4f98-9924-733d19dd8490"), Color.Blue, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7596), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 20, Size.XL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7598) },
                    { new Guid("e694ad0f-33cb-47b2-9e02-c684f4f1c237"), Color.Red, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7676), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 10, Size.L, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7678) },
                    { new Guid("e9c4c892-2781-4fd4-aa39-6726bd8f7d1f"), Color.Blue, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7730), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 20, Size.XL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7731) },
                    { new Guid("eb30d735-1c90-4d99-bec5-27c4205ed817"), Color.Red, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7641), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 10, Size.L, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7643) },
                    { new Guid("ec582842-9dfd-4f8c-bd7d-0f466fd3cf8c"), Color.Blue, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7681), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 20, Size.XL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7683) },
                    { new Guid("f23a6b86-3658-4029-8aaa-e5d4c2377776"), Color.Blue, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7697), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 20, Size.XL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7699) },
                    { new Guid("fb814e85-8689-448f-a1c9-cb763c190543"), Color.Black, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7618), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 30, Size.XXXL, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7620) },
                    { new Guid("ff49ecc8-1455-4595-83ee-38dece47e6d4"), Color.Red, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7572), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 20, Size.L, new DateTime(2023, 12, 27, 7, 35, 46, 456, DateTimeKind.Local).AddTicks(7573) }
                });

            migrationBuilder.CreateIndex(
                name: "ix_orders_address_id",
                table: "orders",
                column: "address_id");

            migrationBuilder.AddForeignKey(
                name: "fk_orders_addresses_address_id",
                table: "orders",
                column: "address_id",
                principalTable: "addresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_orders_addresses_address_id",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "ix_orders_address_id",
                table: "orders");

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("05240f98-3d7b-4f6f-a7da-a717e8ddb518"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("0540e46c-73fd-45e9-8d07-f0ba970df1b7"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("08e514d1-ee14-4a88-960c-f7490a70ee98"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("0b8385d3-25a5-44b0-b149-61907c243bb0"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("0e11f75f-996a-4b1b-9f95-d0164e1aeec1"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("0e136c72-3d18-48c3-933c-dac2078927d9"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("1724e13c-44d3-4108-a87a-5fe119eccc0a"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("1d5d98bf-32cd-45fe-85de-b4623f40b0dd"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("28d00078-9bd3-4502-8e65-8c2c89ce7ba5"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("3c49d643-c68d-4350-b720-01bd43ee7e3e"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("3c685680-2f35-4656-8e11-3f2f24d74c6e"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("4a31c082-faf5-4476-ac7c-e1ef978f75a3"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("4fd9a6f9-8dd8-4e8b-a233-6e7355962d8b"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("53269afb-bb93-4c98-bc1b-721da536685a"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("54261b25-58d9-4f34-86a1-29b4ef35591b"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("6bf64500-14db-4f3d-a436-702e08331f42"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("77e414ce-8299-4084-b72a-f154393d964e"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("7901a1cb-ccfc-41c9-8dc2-caf3824265ba"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("7c72c343-eb6b-40bc-9221-efaa1407a30c"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("818054da-cad8-46cf-876e-2973d7dc2651"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("82f7442b-d5d9-45b2-b2b2-c9c141396194"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("86523fef-e547-4fd6-a7c2-624e1c32af34"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("93edf3d7-4f1d-4345-8453-ed6d97dc6ec8"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("952d5a63-e305-4c9a-9b8f-aaadcfa7e9dd"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("97418f83-0f7a-4c1d-8fb3-406362ecb3de"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("9fe43dd5-d0aa-4cf8-859b-83f18f2e878c"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("a0ab2194-d776-460e-84e9-18ccd2037c8e"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("a4a6a758-4aad-4129-a8d2-7ef73c552049"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("aedbfeba-2bd1-4536-9637-b1469783436e"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("b402de49-22ec-433c-a9d8-9fc733cb5199"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("b6541dc1-6037-431f-baec-5511c5e1cdd5"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("bb6fb117-2ada-4c60-b83a-1d02c565efd5"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("bef9db7f-1f28-4084-a010-b3082b4876d4"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("c32e666e-935d-4ded-a598-1bdd2ec13286"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("c8e41a26-680b-4bb6-8b75-fff58a9a56bb"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("c9f7a2e1-4daa-4620-988d-b245fe072ccd"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("ca18ff7b-fd18-4962-9350-fc38e6fe2fcd"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("d2f3943e-a01e-4205-a8bb-11abb62228d8"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("d7d78aa5-1671-4521-960f-8b719bf43a3b"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("d90317cd-f169-487d-9183-90de00bf9b8f"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("e915dee1-9fd5-4122-ac31-98bef82932fb"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("ec0c277f-3dd9-4caf-a8f9-b0a07e20c0a1"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("ed2a0aec-ee3c-4bcb-998e-134e16d18e98"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("f3647104-3528-4204-bf22-ce25b2398092"));

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "id",
                keyValue: new Guid("f8fa93f7-8afa-4a49-9704-a4a5f1b8f48a"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("067877d3-097e-4507-8a09-016c46f51349"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("0aabc0e7-ac38-40da-a851-26c7d80c7840"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("10509d07-e968-4297-8eb5-2b021cda8bf4"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("18905cab-67de-4708-9c7d-13d266da6d35"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("18ea00d7-0f2d-4f18-bdfe-6c19bf0e65a6"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("233089e2-f77c-41bf-b578-8892b013aedc"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("240ffac6-935f-4768-ab60-7ea131c40f62"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("295a8832-62a1-49be-88f2-51af3ce3b58f"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("37cb6e02-b9c3-4cc9-8a74-8a16fcf59c8c"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("3c472e03-4152-4be0-81a5-2984f7974b4f"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("3d75c869-b7ab-4d5f-b418-159135762679"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("4102f553-14aa-441a-8278-c0f3ec8da8cb"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("43c74052-ff24-4ace-b6da-83a3ab65e129"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("44f936bb-3280-4d7f-9a61-eee7243e8580"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("47cda36f-581c-4694-bba8-14672e939bad"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("512db5e3-d9d4-49eb-bb52-6c073056e5fd"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("592d4c18-c41d-429e-bdbd-1c2f934cad81"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("595204a8-fc60-4568-83bc-0e86c4880102"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("5ffa57bb-6172-453d-8625-ce65e82eabb6"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("6034d7a6-fa2c-4d98-ab21-17d1ce0c2270"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("607d840a-54be-40f4-a82d-25a1e714dcbe"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("62f61535-1e3c-4e47-afbc-faf94c7fdff1"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("8343bb71-4ee3-4eed-aaf8-9e7bd72c38fb"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("9f60d5a3-c687-4126-aa5c-028b59abf989"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("a2036864-c935-4339-a31e-b88a5fd94258"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("a73fc07d-6ac9-4b08-adc9-92552d97222f"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("b1a5d64e-54b1-417c-8691-442c1c484992"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("b6a3d278-567d-4eda-ad67-529513bea9f7"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("c21fdaf2-a8af-4c22-b4c5-6cc2bd199299"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("c3ae01af-3bcf-4744-a071-0670ef9e8ecc"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("c9c5a326-6df4-4a7c-a5f7-c58f82bfa818"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("d8a0f9db-3a6d-4bd8-a704-a094cdd010ea"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("dc05ed7f-c868-46f9-9d51-c738161ea666"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("dc4f954c-4664-42b9-b2c9-f4bded44beee"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("de9c2d5c-b920-444d-beac-2bce85bed493"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("e5239e24-d4f0-4571-ac9e-495913c9d769"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("e56aab04-505c-4f3f-a700-c25ed27a9ad6"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("e67872a9-9835-4f98-9924-733d19dd8490"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("e694ad0f-33cb-47b2-9e02-c684f4f1c237"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("e9c4c892-2781-4fd4-aa39-6726bd8f7d1f"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("eb30d735-1c90-4d99-bec5-27c4205ed817"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("ec582842-9dfd-4f8c-bd7d-0f466fd3cf8c"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("f23a6b86-3658-4029-8aaa-e5d4c2377776"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("fb814e85-8689-448f-a1c9-cb763c190543"));

            migrationBuilder.DeleteData(
                table: "variants",
                keyColumn: "id",
                keyValue: new Guid("ff49ecc8-1455-4595-83ee-38dece47e6d4"));

            migrationBuilder.DropColumn(
                name: "address_id",
                table: "orders");

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a1a1a1a1-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4458), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a2a2a2a2-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4465), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("a3a3a3a3-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4469), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b1b1b1b1-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4473), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b2b2b2b2-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4478), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("b3b3b3b3-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4483), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c1c1c1c1-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4487), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c2c2c2c2-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4491), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "id",
                keyValue: new Guid("c3c3c3c3-1234-1234-1234-1234567890ab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4496), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3462), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("88499694-269b-4308-a64d-0e903a1f503d"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3452), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3466), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.InsertData(
                table: "images",
                columns: new[] { "id", "created_at", "product_id", "updated_at", "url" },
                values: new object[,]
                {
                    { new Guid("02be318d-e2e0-4eec-8a5a-08820d565d01"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3746), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3748), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("0e9f35c5-ba7a-4869-a09c-ecc9ebc49f23"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3919), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3920), "https://picsum.photos/1000/1000?random=34" },
                    { new Guid("11d6bc24-03e9-493e-b807-384c264faeeb"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3818), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3820), "https://picsum.photos/1000/1000?random=13" },
                    { new Guid("1d10d282-f6c7-4a95-9807-9bd1df8a483f"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3900), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3901), "https://picsum.photos/1000/1000?random=30" },
                    { new Guid("2c57004a-280b-4edf-89b4-12ddcbe4d28b"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3883), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3885), "https://picsum.photos/1000/1000?random=27" },
                    { new Guid("2e28d637-41c7-4cee-9122-ca36d216ebbf"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3871), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3872), "https://picsum.photos/1000/1000?random=24" },
                    { new Guid("2f174b02-9432-4fe3-8e37-07b12e867951"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3935), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3936), "https://picsum.photos/1000/1000?random=37" },
                    { new Guid("2ff033c1-ce64-43d2-bee7-1df40620370e"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3957), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3958), "https://picsum.photos/1000/1000?random=42" },
                    { new Guid("36515797-65a5-4f1d-8b74-a3ac0d74d06d"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3786), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3787), "https://picsum.photos/1000/1000?random=7" },
                    { new Guid("37e6d1ef-6b52-4e7a-8a75-affb6d4f9e0a"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3952), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3954), "https://picsum.photos/1000/1000?random=41" },
                    { new Guid("3af328ed-9a3e-446e-a2ce-c0b393d80352"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3939), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3941), "https://picsum.photos/1000/1000?random=38" },
                    { new Guid("465a6ef2-3d54-49c1-9d12-f37ff592d5fa"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3831), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3833), "https://picsum.photos/1000/1000?random=16" },
                    { new Guid("498fdb21-4cfc-4403-aabe-3c3896a0a490"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3841), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3843), "https://picsum.photos/1000/1000?random=18" },
                    { new Guid("4ea1d228-e802-4b34-b449-fd2d85d8c391"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3895), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3897), "https://picsum.photos/1000/1000?random=29" },
                    { new Guid("50064b67-fed0-44ad-80df-a0bb6f60b003"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3853), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3855), "https://picsum.photos/1000/1000?random=20" },
                    { new Guid("5bc83b83-cbf0-408f-82d8-f1d37343a8d1"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3827), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3828), "https://picsum.photos/1000/1000?random=15" },
                    { new Guid("64fd0472-6edd-4c60-922d-e2ef2f6ba63e"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3801), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3802), "https://picsum.photos/1000/1000?random=10" },
                    { new Guid("77eb52a3-e705-4f8c-b5c8-fe05452fbe27"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3875), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3876), "https://picsum.photos/1000/1000?random=25" },
                    { new Guid("7c7b8160-0d5a-4099-b347-e42aa27a8643"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3846), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3847), "https://picsum.photos/1000/1000?random=19" },
                    { new Guid("817e9c0e-f066-49ad-92cc-b2a850015d58"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3739), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3741), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("86914db0-0f5b-46d5-982a-e65a03ccff10"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3867), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3868), "https://picsum.photos/1000/1000?random=23" },
                    { new Guid("8ad3623e-fab3-4b3b-aea1-81b3c49e0bbd"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3944), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3945), "https://picsum.photos/1000/1000?random=39" },
                    { new Guid("8da5fbac-aecc-4b92-bf01-345ddf484fcc"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3904), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3906), "https://picsum.photos/1000/1000?random=31" },
                    { new Guid("8e08155f-8889-4b6a-a618-18b47d13388c"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3930), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3932), "https://picsum.photos/1000/1000?random=36" },
                    { new Guid("94a81ce2-310b-41d3-8aa1-7cda15d6122e"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3780), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3782), "https://picsum.photos/1000/1000?random=6" },
                    { new Guid("950b7228-4cd7-4b0b-86d4-b5a79f04115f"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3909), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3910), "https://picsum.photos/1000/1000?random=32" },
                    { new Guid("9a9ffcfc-db72-4a91-866b-2a3c09778a11"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3967), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3969), "https://picsum.photos/1000/1000?random=44" },
                    { new Guid("9f3d6fb3-5d8a-41fb-8ef0-7cab7201c8e9"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3790), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3792), "https://picsum.photos/1000/1000?random=8" },
                    { new Guid("9f4a8833-2b02-421c-af15-903a5d3c8af7"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3913), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3914), "https://picsum.photos/1000/1000?random=33" },
                    { new Guid("a1eed97c-122b-409e-811d-57e54075a7fc"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3836), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3837), "https://picsum.photos/1000/1000?random=17" },
                    { new Guid("a3ace735-345f-48d6-9b56-afe68c19e6e5"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3795), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3797), "https://picsum.photos/1000/1000?random=9" },
                    { new Guid("a9825585-10a9-4743-8f15-4275a936e456"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3805), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3807), "https://picsum.photos/1000/1000?random=11" },
                    { new Guid("b4b532b0-cf7a-4f77-953a-acdc3c47429d"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3972), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3973), "https://picsum.photos/1000/1000?random=45" },
                    { new Guid("b503a738-6b47-4775-b6a8-514c2191e2e3"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3879), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3881), "https://picsum.photos/1000/1000?random=26" },
                    { new Guid("b5129947-ba1a-461f-bfe0-7780a94eaf6a"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3773), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3775), "https://picsum.photos/1000/1000?random=5" },
                    { new Guid("c5e04b99-2bcf-40c5-91c2-216479ac3add"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3961), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3963), "https://picsum.photos/1000/1000?random=43" },
                    { new Guid("cbe6ea41-b379-4fe6-8816-e346d9826eb0"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3713), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3716), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("cc8ab216-0cf1-45b2-94f1-6e91367174d0"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3823), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3824), "https://picsum.photos/1000/1000?random=14" },
                    { new Guid("d238e6f6-5b15-494d-a5c9-e5d9dca8b0fd"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3891), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3892), "https://picsum.photos/1000/1000?random=28" },
                    { new Guid("d743f218-2cca-4d8a-956e-4cb550ec62ef"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3766), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3768), "https://picsum.photos/1000/1000?random=4" },
                    { new Guid("d8a852a1-5784-4e9a-8e2b-f4367f8d5d04"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3923), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3925), "https://picsum.photos/1000/1000?random=35" },
                    { new Guid("e64afa39-2e3b-4d0a-930b-2e1e81e78cff"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3814), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3815), "https://picsum.photos/1000/1000?random=12" },
                    { new Guid("e9a8a09e-693c-4936-a445-e6a0c5dfd314"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3862), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3864), "https://picsum.photos/1000/1000?random=22" },
                    { new Guid("f2e572a6-9e50-4add-8fea-7a9bd9413e98"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3858), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3859), "https://picsum.photos/1000/1000?random=21" },
                    { new Guid("ff484588-ceb8-452c-b23a-d7911a6fef2f"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3948), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3949), "https://picsum.photos/1000/1000?random=40" }
                });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3638), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3599), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3620), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3648), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3615), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3610), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3626), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("865770da-89af-4719-b00c-310b57d535e1"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3589), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("8b441114-e030-4412-8952-2370a4b7f05a"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3658), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3653), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3643), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3505), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3594), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3632), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3582), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("30a4ff5e-3bd1-429d-9981-adbcd46e2537"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4389), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("38fb4093-965e-4e3f-a7a2-c19103fc239e"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4384), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("71dd6268-f87a-4816-a5bf-c94769a51473"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4355), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("9aa483ac-872b-468c-af4f-2c1f94beec3a"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4363), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("a4438f9a-a573-4967-96c3-6a38fcfb6132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4372), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("c2cd9d37-25d0-4b5d-a336-8214ce83b648"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4377), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("c9e3c10d-b843-434d-bcbe-bfe35e17dd52"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4346), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("ca5b7d5d-309c-4973-ad8c-132a4142b5c1"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4367), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("dfc6ffd5-140c-4505-9428-7fe852a93afc"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4380), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "id",
                keyValue: new Guid("eb57b891-c019-46c9-9c6e-630a79d19787"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4359), new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 194, DateTimeKind.Local).AddTicks(9321), "5HWsTxCY7xKJpIPZVWzq/A==;c0iRygi4RSsyycvNDV4kVpNjCR3J/Agcilsi9xX/yhY=", new DateTime(2023, 12, 27, 6, 13, 36, 194, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 193, DateTimeKind.Local).AddTicks(5357), "nbQ2gFwaaoJ+ChuZum9jhw==;GZY9V+rm5lTtI2hzVucxo+qRUF9I+WwpmW3UFC4o8hw=", new DateTime(2023, 12, 27, 6, 13, 36, 193, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 13, 36, 192, DateTimeKind.Local).AddTicks(1143), "4UTu46u/WlG0vRUY032dmw==;xGzf2AkGZ3biLh5zLhDWM3JE+3Lxk8md5hm+MczmfMY=", new DateTime(2023, 12, 27, 6, 13, 36, 192, DateTimeKind.Local).AddTicks(1194) });

            migrationBuilder.InsertData(
                table: "variants",
                columns: new[] { "id", "color", "created_at", "product_id", "quantity", "size", "updated_at" },
                values: new object[,]
                {
                    { new Guid("07677433-f8e7-4520-9cc5-927537383019"), Color.Red, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4237), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 10, Size.L, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4238) },
                    { new Guid("0c0545d5-ad12-4a9b-9e8c-70036875643a"), Color.Black, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4275), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4277) },
                    { new Guid("1228a483-d400-44bf-ab38-6737de33835b"), Color.Black, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4079), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4080) },
                    { new Guid("1a268b61-14af-48c3-a373-ce7d9c138f9e"), Color.Red, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4083), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 20, Size.L, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4085) },
                    { new Guid("1b59c5e5-1ec0-41a0-ac46-0e328826d0a2"), Color.Red, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4174), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 10, Size.L, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4176) },
                    { new Guid("1df4e8bc-62d6-4d73-95e0-904fc80df670"), Color.Black, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4289), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4290) },
                    { new Guid("21759c8e-cc17-4252-80e0-11b43592b8c7"), Color.Red, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4220), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 10, Size.L, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4222) },
                    { new Guid("24bcffdc-4f92-42b1-81ed-17db71e4b8f2"), Color.Black, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4262), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4263) },
                    { new Guid("24cda3f0-f41d-4c0e-aa90-3b6b442445cf"), Color.Blue, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4105), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4107) },
                    { new Guid("26b7133e-f33e-4e31-b833-47ff3fd8b995"), Color.Black, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4094), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4095) },
                    { new Guid("2fea385c-37ee-4b19-a336-9e12745f6778"), Color.Blue, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4120), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4122) },
                    { new Guid("301cc04d-3618-4a60-9f74-a34743f3c0fa"), Color.Red, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4280), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 10, Size.L, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4281) },
                    { new Guid("379c36d5-9c41-4dc2-99a3-0917e9fabdca"), Color.Black, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4141), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4142) },
                    { new Guid("37a9f6d2-abe8-4226-b98a-c9724fad1f51"), Color.Blue, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4134), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4136) },
                    { new Guid("3e4d79f5-2844-4744-9c4d-035c539e51b7"), Color.Black, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4170), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4171) },
                    { new Guid("3ea43075-1e66-4e34-8389-86f2dc93cbb4"), Color.Blue, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4195), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4197) },
                    { new Guid("491dc0fa-ff52-4b52-bf5b-e9e19d82fa93"), Color.Blue, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4255), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4257) },
                    { new Guid("4c22b11d-6704-429a-ae91-6658aecc5cba"), Color.Blue, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4271), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4272) },
                    { new Guid("4dd078cf-22c6-4345-9553-2fe60427c5ce"), Color.Black, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4186), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4187) },
                    { new Guid("506f6fb7-c219-4002-9d3e-fa08ad44d0bb"), Color.Blue, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4284), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4286) },
                    { new Guid("542a6d72-05a4-4a0f-a1c0-e9edb7a12141"), Color.Black, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4246), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4247) },
                    { new Guid("5e2aad41-bf11-4c41-8e42-60cc38b5b1b5"), Color.Red, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4145), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 10, Size.L, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4147) },
                    { new Guid("6cc47e02-03db-455a-9506-4ce9327b5cbe"), Color.Blue, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4165), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4167) },
                    { new Guid("772c5bc9-6339-48de-b8d1-6be7872e4e5a"), Color.Red, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4130), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 10, Size.L, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4131) },
                    { new Guid("8308c842-4a3a-4be1-8518-e31fde3b499c"), Color.Blue, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4181), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4182) },
                    { new Guid("850348bb-bdc5-428e-ad9a-dd4a4ed437f7"), Color.Black, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4156), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4157) },
                    { new Guid("851c8219-53bb-4575-86d3-e24bc7c61b3d"), Color.Red, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4190), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 10, Size.L, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4192) },
                    { new Guid("86443275-b7e0-401d-ba98-adfd69fe54e4"), Color.Red, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4204), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 10, Size.L, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4206) },
                    { new Guid("9860cd50-814a-4969-9578-ba2652a44b98"), Color.Blue, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4088), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4090) },
                    { new Guid("99f349df-499f-46ac-bd61-b168f3da7649"), Color.Red, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4116), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 10, Size.L, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4117) },
                    { new Guid("a2cdea24-7801-4c07-a199-928b8be1b637"), Color.Black, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4125), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4126) },
                    { new Guid("a7234533-8ef5-413c-838e-d92a0cdd3e9c"), Color.Red, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4250), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 10, Size.L, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4252) },
                    { new Guid("a933f209-7ac4-41e2-9ec5-150fb283769e"), Color.Blue, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4209), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4210) },
                    { new Guid("b4854c5b-0e94-466f-9082-09920afa0ae8"), Color.Blue, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4150), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4152) },
                    { new Guid("b579b676-cc66-44fd-b5ca-f27da43118e9"), Color.Blue, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4241), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4243) },
                    { new Guid("bf099820-cec2-4ec4-bc80-5ae416f002bb"), Color.Black, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4200), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4201) },
                    { new Guid("c4908643-d8a7-4660-9fb0-8ef682805e4e"), Color.Red, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4266), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 10, Size.L, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4268) },
                    { new Guid("e60e3cbd-8028-4902-b9d7-cefc297e0434"), Color.Black, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4214), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4215) },
                    { new Guid("e858ce85-2270-4bb3-98db-6733b2be279d"), Color.Black, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4110), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4112) },
                    { new Guid("ec60f1d9-112f-455a-8c89-ea8b1dd9dc5b"), Color.Red, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4101), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 10, Size.L, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4102) },
                    { new Guid("edc6c946-ca54-49de-9588-cacfabd96b65"), Color.Red, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4065), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 10, Size.L, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4067) },
                    { new Guid("ef0d410b-7a6e-4043-8928-c63c9ceb4498"), Color.Blue, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4225), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4226) },
                    { new Guid("f02656fc-8e71-4391-a9f2-a7aad4ce33bd"), Color.Blue, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4074), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 20, Size.XL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4076) },
                    { new Guid("f25fe360-c4fb-4c28-94b9-425e8c23deab"), Color.Black, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4230), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 30, Size.XXXL, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4232) },
                    { new Guid("ff96a9a2-77fa-4a02-a3bc-ea2b88bb76f9"), Color.Red, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4161), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 10, Size.L, new DateTime(2023, 12, 27, 6, 13, 36, 196, DateTimeKind.Local).AddTicks(4162) }
                });
        }
    }
}
