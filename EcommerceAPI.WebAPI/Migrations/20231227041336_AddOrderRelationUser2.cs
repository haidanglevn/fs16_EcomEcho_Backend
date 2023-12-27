using System;
using EcommerceAPI.Core.src.Entity;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceAPI.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderRelationUser2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
