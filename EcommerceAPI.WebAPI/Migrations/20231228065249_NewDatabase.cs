using System;
using EcommerceAPI.Core.src.Entity;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceAPI.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class NewDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:color", "black,silver,gray,white,maroon,red,purple,fuchsia,green,lime,olive,yellow,navy,blue,teal,aqua,orange,alice_blue,coral,dark_blue")
                .Annotation("Npgsql:Enum:role", "customer,admin")
                .Annotation("Npgsql:Enum:size", "xs,s,m,l,xl,xxl,xxxl")
                .Annotation("Npgsql:Enum:status", "pending,shipping,received");

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    image = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    role = table.Column<Role>(type: "role", nullable: false),
                    first_name = table.Column<string>(type: "text", nullable: false),
                    last_name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    avatar = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false),
                    category_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_products", x => x.id);
                    table.ForeignKey(
                        name: "fk_products_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    country = table.Column<string>(type: "text", nullable: false),
                    city = table.Column<string>(type: "text", nullable: false),
                    state = table.Column<string>(type: "text", nullable: true),
                    street = table.Column<string>(type: "text", nullable: false),
                    postal_code = table.Column<string>(type: "text", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_addresses", x => x.id);
                    table.ForeignKey(
                        name: "fk_addresses_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "images",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    url = table.Column<string>(type: "text", nullable: false),
                    product_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_images", x => x.id);
                    table.ForeignKey(
                        name: "fk_images_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    rating = table.Column<int>(type: "integer", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    product_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_reviews", x => x.id);
                    table.ForeignKey(
                        name: "fk_reviews_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_reviews_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "variants",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    color = table.Column<Color>(type: "color", nullable: false),
                    size = table.Column<Size>(type: "size", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    product_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_variants", x => x.id);
                    table.ForeignKey(
                        name: "fk_variants_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    status = table.Column<Status>(type: "status", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    address_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_orders", x => x.id);
                    table.ForeignKey(
                        name: "fk_orders_addresses_address_id",
                        column: x => x.address_id,
                        principalTable: "addresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_orders_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order_items",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    order_id = table.Column<Guid>(type: "uuid", nullable: false),
                    product_id = table.Column<Guid>(type: "uuid", nullable: false),
                    variant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_order_items", x => x.id);
                    table.ForeignKey(
                        name: "fk_order_items_orders_order_id",
                        column: x => x.order_id,
                        principalTable: "orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_order_items_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_order_items_variants_variant_id",
                        column: x => x.variant_id,
                        principalTable: "variants",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "id", "created_at", "image", "name", "updated_at" },
                values: new object[,]
                {
                    { new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6386), "https://picsum.photos/1000/1000?random=100", "Sport", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6388) },
                    { new Guid("88499694-269b-4308-a64d-0e903a1f503d"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6373), "https://picsum.photos/1000/1000?random=99", "Fashion", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6380) },
                    { new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6390), "https://picsum.photos/1000/1000?random=101", "Home", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6392) }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "avatar", "created_at", "email", "first_name", "last_name", "password", "role", "updated_at" },
                values: new object[,]
                {
                    { new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b"), "https://picsum.photos/1000/1000?random=152", new DateTime(2023, 12, 28, 8, 52, 48, 912, DateTimeKind.Local).AddTicks(1984), "doe@mail.com", "John", "Doe", "Lj5PE0u9ehG6QAxIClgeyA==;1Zb/k888h9mRhBPpAnhQKb5flsuMzf50FAkI/yFGfjA=", Role.Customer, new DateTime(2023, 12, 28, 8, 52, 48, 912, DateTimeKind.Local).AddTicks(1987) },
                    { new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9"), "https://picsum.photos/1000/1000?random=151", new DateTime(2023, 12, 28, 8, 52, 48, 910, DateTimeKind.Local).AddTicks(7850), "cena@mail.com", "John", "Cena", "WQv+2GiPor82CbNDWMZYcg==;yuHeVDp04CWgJ/9J29d35ZCMkoUiRBtKLOly5kapLCI=", Role.Customer, new DateTime(2023, 12, 28, 8, 52, 48, 910, DateTimeKind.Local).AddTicks(7854) },
                    { new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab"), "https://picsum.photos/1000/1000?random=150", new DateTime(2023, 12, 28, 8, 52, 48, 909, DateTimeKind.Local).AddTicks(3346), "admin@mail.com", "Admin", "admin", "Hx0KKc/9jicJiRIlxT9I2Q==;BRDMk7nhCt4WS6104LVg3Ee4xMWbpwbEHehgo4RpMKg=", Role.Admin, new DateTime(2023, 12, 28, 8, 52, 48, 909, DateTimeKind.Local).AddTicks(3405) }
                });

            migrationBuilder.InsertData(
                table: "addresses",
                columns: new[] { "id", "city", "country", "created_at", "postal_code", "state", "street", "updated_at", "user_id" },
                values: new object[,]
                {
                    { new Guid("a1a1a1a1-1234-1234-1234-1234567890ab"), "Helsinki", "Finland", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7411), "00100", null, "Street 1", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7413), new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab") },
                    { new Guid("a2a2a2a2-1234-1234-1234-1234567890ab"), "Helsinki", "Finland", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7420), "00200", null, "Street 2", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7421), new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab") },
                    { new Guid("a3a3a3a3-1234-1234-1234-1234567890ab"), "Helsinki", "Finland", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7424), "00300", null, "Street 3", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7426), new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab") },
                    { new Guid("b1b1b1b1-1234-1234-1234-1234567890ab"), "Espoo", "Finland", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7429), "02100", null, "Street 1", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7430), new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9") },
                    { new Guid("b2b2b2b2-1234-1234-1234-1234567890ab"), "Espoo", "Finland", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7465), "02100", null, "Street 2", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7467), new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9") },
                    { new Guid("b3b3b3b3-1234-1234-1234-1234567890ab"), "Espoo", "Finland", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7471), "02100", null, "Street 3", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7473), new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9") },
                    { new Guid("c1c1c1c1-1234-1234-1234-1234567890ab"), "Tampere", "Finland", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7475), "33100", null, "Street 3", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7477), new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b") },
                    { new Guid("c2c2c2c2-1234-1234-1234-1234567890ab"), "Tampere", "Finland", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7480), "33100", null, "Street 4", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7481), new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b") },
                    { new Guid("c3c3c3c3-1234-1234-1234-1234567890ab"), "Tampere", "Finland", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7484), "33100", null, "Street 6", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7486), new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b") }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "category_id", "created_at", "description", "price", "title", "updated_at" },
                values: new object[,]
                {
                    { new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6542), "Description for Home Product 1", 300m, "Home Product 1", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6543) },
                    { new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new Guid("88499694-269b-4308-a64d-0e903a1f503d"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6454), "Description for Fashion Product 5", 104m, "Fashion Product 5", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6456) },
                    { new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6526), "Description for Sport Product 3", 154m, "Sport Product 3", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6528) },
                    { new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6550), "Description for Home Product 3", 56m, "Home Product 3", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6552) },
                    { new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6469), "Description for Sport Product 2", 240m, "Sport Product 2", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6470) },
                    { new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6464), "Description for Sport Product 1", 200m, "Sport Product 1", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6466) },
                    { new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6531), "Description for Sport Product 4", 333m, "Sport Product 4", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6533) },
                    { new Guid("865770da-89af-4719-b00c-310b57d535e1"), new Guid("88499694-269b-4308-a64d-0e903a1f503d"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6446), "Description for Fashion Product 3", 120m, "Fashion Product 3", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6447) },
                    { new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6559), "Description for Home Product 5", 3000m, "Home Product 5", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6560) },
                    { new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6554), "Description for Home Product 4", 143m, "Home Product 4", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6556) },
                    { new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new Guid("e842529a-ac4a-48f4-9377-1786d94dd4e8"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6546), "Description for Home Product 2", 32m, "Home Product 2", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6547) },
                    { new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new Guid("88499694-269b-4308-a64d-0e903a1f503d"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6433), "Description for Fashion Product 1", 100m, "Fashion Product 1", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6435) },
                    { new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new Guid("88499694-269b-4308-a64d-0e903a1f503d"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6450), "Description for Fashion Product 4", 200m, "Fashion Product 4", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6451) },
                    { new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new Guid("23b984f8-26f7-49a5-82ea-f4f5ddd16eca"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6537), "Description for Sport Product 5", 205m, "Sport Product 5", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6539) },
                    { new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new Guid("88499694-269b-4308-a64d-0e903a1f503d"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6441), "Description for Fashion Product 2", 140m, "Fashion Product 2", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6443) }
                });

            migrationBuilder.InsertData(
                table: "images",
                columns: new[] { "id", "created_at", "product_id", "updated_at", "url" },
                values: new object[,]
                {
                    { new Guid("01177626-488d-430c-a8f2-84a3a7b0f393"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6664), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6665), "https://picsum.photos/1000/1000?random=8" },
                    { new Guid("0931ed46-1718-4e68-ba16-574df562f742"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6778), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6780), "https://picsum.photos/1000/1000?random=29" },
                    { new Guid("0f0fd4d8-a64c-45a8-ad8a-8ac726cfcf71"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6639), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6640), "https://picsum.photos/1000/1000?random=3" },
                    { new Guid("0f3f4c77-ba0e-4587-927f-e7fbf7ab6527"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6810), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6812), "https://picsum.photos/1000/1000?random=35" },
                    { new Guid("133a3a86-0679-466b-847c-de5beeffb95f"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6644), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6645), "https://picsum.photos/1000/1000?random=4" },
                    { new Guid("16744737-7f50-4d27-aa72-350eaa2d7ac0"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6800), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6801), "https://picsum.photos/1000/1000?random=33" },
                    { new Guid("16b8428b-050e-4b39-a866-2ecc43d24732"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6764), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6766), "https://picsum.photos/1000/1000?random=26" },
                    { new Guid("19039599-c446-4686-9741-249c68908525"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6659), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6661), "https://picsum.photos/1000/1000?random=7" },
                    { new Guid("1eca6f5a-1197-445d-92cc-03267f8c6902"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6855), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6856), "https://picsum.photos/1000/1000?random=44" },
                    { new Guid("47d03919-cbfc-4373-abc3-103dfe408321"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6793), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6794), "https://picsum.photos/1000/1000?random=32" },
                    { new Guid("48d8baf0-d0a2-4929-bb27-e1242ccd9b3e"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6699), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6701), "https://picsum.photos/1000/1000?random=14" },
                    { new Guid("49b0ff7d-d743-4a67-8509-c1aac6004fc0"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6733), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6734), "https://picsum.photos/1000/1000?random=20" },
                    { new Guid("4f70ec5c-8bc5-4dc4-afc4-99d077c9201d"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6752), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6754), "https://picsum.photos/1000/1000?random=24" },
                    { new Guid("506ef132-7015-494e-a686-27bfd87a2bcb"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6723), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6725), "https://picsum.photos/1000/1000?random=18" },
                    { new Guid("5356a547-c393-4570-b6b6-bcc3bfcc9164"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6788), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6789), "https://picsum.photos/1000/1000?random=31" },
                    { new Guid("56c3b50e-889a-495a-9626-958adbe6a062"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6829), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6830), "https://picsum.photos/1000/1000?random=39" },
                    { new Guid("583eb570-6231-44b6-af9c-f8927482615c"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6783), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6785), "https://picsum.photos/1000/1000?random=30" },
                    { new Guid("5ac36c75-4aa7-43b8-ac11-9ca4720b8fee"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6824), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6826), "https://picsum.photos/1000/1000?random=38" },
                    { new Guid("5aedfe52-762a-4333-a0bc-4278fa7aa333"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6859), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6861), "https://picsum.photos/1000/1000?random=45" },
                    { new Guid("67dde20c-023e-4355-928b-d59acdc1b300"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6845), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6847), "https://picsum.photos/1000/1000?random=42" },
                    { new Guid("75d56a26-b372-4987-89c3-0aad58ce073c"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6834), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6835), "https://picsum.photos/1000/1000?random=40" },
                    { new Guid("7dc21ee4-b3e4-4e13-a832-58e0cda76ccb"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6759), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6761), "https://picsum.photos/1000/1000?random=25" },
                    { new Guid("7e78c9b6-cbf9-4078-ad65-cf815bcd31d3"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6674), new Guid("865770da-89af-4719-b00c-310b57d535e1"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6676), "https://picsum.photos/1000/1000?random=9" },
                    { new Guid("7f700383-2ce8-4e4d-8b3f-b7296a71b12c"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6820), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6821), "https://picsum.photos/1000/1000?random=37" },
                    { new Guid("83422ee7-9f8e-4d65-b227-0cea03dc292a"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6705), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6706), "https://picsum.photos/1000/1000?random=15" },
                    { new Guid("8e2bbdde-955b-4a87-811d-7e264d6ece81"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6604), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6608), "https://picsum.photos/1000/1000?random=1" },
                    { new Guid("91527473-c3c5-49cd-a795-fb9e7ee184bb"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6709), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6711), "https://picsum.photos/1000/1000?random=16" },
                    { new Guid("91bc8ffd-e147-4816-9c1b-a8b984746dad"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6841), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6842), "https://picsum.photos/1000/1000?random=41" },
                    { new Guid("952414b8-c59e-4f9c-9c33-4e56205d9a69"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6774), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6775), "https://picsum.photos/1000/1000?random=28" },
                    { new Guid("ad551945-15c3-4a0c-a06e-1518d3168b00"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6681), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6682), "https://picsum.photos/1000/1000?random=10" },
                    { new Guid("ae7047e6-18f1-430c-88df-92ea8240d323"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6747), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6749), "https://picsum.photos/1000/1000?random=23" },
                    { new Guid("b1429bd7-1085-471f-8196-e8301fd48f72"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6728), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6730), "https://picsum.photos/1000/1000?random=19" },
                    { new Guid("b25e01ef-52c7-4b5c-935e-b50d53689a77"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6648), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6650), "https://picsum.photos/1000/1000?random=5" },
                    { new Guid("b2b74b93-1025-4b7f-b34e-53634b2ee831"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6717), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6719), "https://picsum.photos/1000/1000?random=17" },
                    { new Guid("b945a2ad-8d9f-4668-9e73-a64ac316f70c"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6738), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6739), "https://picsum.photos/1000/1000?random=21" },
                    { new Guid("e4703bd3-c0ef-4cb5-8ade-52c744811245"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6634), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6635), "https://picsum.photos/1000/1000?random=2" },
                    { new Guid("e74da698-0f1d-4516-a3fa-e035b91b0fe9"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6742), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6744), "https://picsum.photos/1000/1000?random=22" },
                    { new Guid("f04e4134-acb0-416a-8fbf-b10efa8ef25c"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6695), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6696), "https://picsum.photos/1000/1000?random=13" },
                    { new Guid("f1e93587-a4b3-40c1-a127-b78f133ff215"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6690), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6692), "https://picsum.photos/1000/1000?random=12" },
                    { new Guid("f417c476-c833-496d-a65d-aea95d5e2201"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6654), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6656), "https://picsum.photos/1000/1000?random=6" },
                    { new Guid("f5450d06-0777-4e0d-9ab8-0b05620a395b"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6769), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6770), "https://picsum.photos/1000/1000?random=27" },
                    { new Guid("f6caf7cb-8e60-409f-a8d1-300e4b214dab"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6685), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6687), "https://picsum.photos/1000/1000?random=11" },
                    { new Guid("fc93c429-18ce-4118-8ab2-b7ab656809dc"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6850), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6851), "https://picsum.photos/1000/1000?random=43" },
                    { new Guid("fdef4179-59e4-482d-9084-1593520ad111"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6805), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6807), "https://picsum.photos/1000/1000?random=34" },
                    { new Guid("ffb1a640-679f-4d44-a269-5c31d3a70369"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6815), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6816), "https://picsum.photos/1000/1000?random=36" }
                });

            migrationBuilder.InsertData(
                table: "reviews",
                columns: new[] { "id", "comment", "created_at", "product_id", "rating", "updated_at", "user_id" },
                values: new object[,]
                {
                    { new Guid("30a4ff5e-3bd1-429d-9981-adbcd46e2537"), "Not as described, disappointed.", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7367), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 2, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7368), new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b") },
                    { new Guid("38fb4093-965e-4e3f-a7a2-c19103fc239e"), "Absolutely love this!", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7362), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 5, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7363), new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9") },
                    { new Guid("71dd6268-f87a-4816-a5bf-c94769a51473"), "Really enjoyed this.", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7331), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 4, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7333), new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9") },
                    { new Guid("9aa483ac-872b-468c-af4f-2c1f94beec3a"), "Loved the design!", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7340), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 4, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7341), new Guid("760454fa-4af1-4ae6-9b18-ed3aec4be2a9") },
                    { new Guid("a4438f9a-a573-4967-96c3-6a38fcfb6132"), "Nice product, quick delivery.", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7349), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 4, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7351), new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b") },
                    { new Guid("c2cd9d37-25d0-4b5d-a336-8214ce83b648"), "Outstanding quality!", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7353), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 5, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7355), new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b") },
                    { new Guid("c9e3c10d-b843-434d-bcbe-bfe35e17dd52"), "Great product!", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7323), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 5, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7325), new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab") },
                    { new Guid("ca5b7d5d-309c-4973-ad8c-132a4142b5c1"), "Perfect for my needs!", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7344), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 5, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7345), new Guid("611a0192-8b2e-4997-a8c8-59b93674d33b") },
                    { new Guid("dfc6ffd5-140c-4505-9428-7fe852a93afc"), "Decent, but expected more.", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7357), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 3, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7359), new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab") },
                    { new Guid("eb57b891-c019-46c9-9c6e-630a79d19787"), "Good quality, but expensive.", new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7336), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 3, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7337), new Guid("ad0ad1be-f7e5-47c7-b4c3-c17250cbebab") }
                });

            migrationBuilder.InsertData(
                table: "variants",
                columns: new[] { "id", "color", "created_at", "product_id", "quantity", "size", "updated_at" },
                values: new object[,]
                {
                    { new Guid("020e8252-77d0-4ff6-a380-ca7fbb6558ef"), Color.Red, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7218), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 10, Size.L, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7220) },
                    { new Guid("0a5dae77-d10f-4a6a-8cef-67304c3fd6ba"), Color.Red, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7233), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 10, Size.L, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7235) },
                    { new Guid("0bcd2360-c5f4-426f-9bd2-6d156bdcaa63"), Color.Red, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7056), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 10, Size.L, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7058) },
                    { new Guid("0dc7c958-f17f-4e7c-9dcb-dfad7aa66304"), Color.Blue, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7082), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 20, Size.XL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7084) },
                    { new Guid("196b96ab-dc99-48d6-92ef-a9707ed93540"), Color.Red, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7094), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 10, Size.L, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7096) },
                    { new Guid("252b193f-98e8-4294-8205-b4cd0f3f50dd"), Color.Black, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7260), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 30, Size.XXXL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7261) },
                    { new Guid("2921b63c-8417-465b-9ca5-17baba9cdc3d"), Color.Black, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7067), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 30, Size.XXXL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7069) },
                    { new Guid("2e5bcc25-cb03-472c-83ab-e3be3dfbb2ad"), Color.Red, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7125), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 10, Size.L, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7126) },
                    { new Guid("3a424648-4dc9-45c2-8d38-1d3d17d73d9a"), Color.Black, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6958), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 30, Size.XXXL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6960) },
                    { new Guid("3bb256dc-3b46-4904-baaa-8926f40d4cb4"), Color.Blue, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7114), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 20, Size.XL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7115) },
                    { new Guid("465edb9b-d80d-4e56-8d41-2f3e1fdb01ac"), Color.Red, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6947), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 20, Size.L, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6949) },
                    { new Guid("4744c413-fe49-4952-a26d-87a6dc6232ae"), Color.Blue, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7099), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 20, Size.XL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7100) },
                    { new Guid("48f2444f-667a-4cf3-bf6e-61060331ea65"), Color.Red, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7141), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 10, Size.L, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7142) },
                    { new Guid("4ac3a217-3b16-485a-a4fc-ee8a0b8d7fd1"), Color.Red, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7248), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 10, Size.L, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7250) },
                    { new Guid("4d103c38-6034-4068-ba85-97092c008859"), Color.Red, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7109), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 10, Size.L, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7111) },
                    { new Guid("52f9b15e-3c8c-48ff-80dc-7dd48af47445"), Color.Blue, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6952), new Guid("fedfd1c9-a73a-47bf-a635-370c193fc1df"), 20, Size.XL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6954) },
                    { new Guid("654e2f25-09a3-4abd-bfb6-e90acdde0241"), Color.Blue, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7160), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 20, Size.XL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7162) },
                    { new Guid("671c618b-0e94-4f47-b4cb-e645c28bd559"), Color.Red, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6925), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 10, Size.L, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6927) },
                    { new Guid("67c9c79d-eddd-496f-ab63-cd4124719f1e"), Color.Black, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7104), new Guid("271309f9-03ae-4a21-a98c-cb2b911d7996"), 30, Size.XXXL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7105) },
                    { new Guid("7eb88e33-c9ec-4faa-93e1-62233781417d"), Color.Black, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7136), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 30, Size.XXXL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7138) },
                    { new Guid("807b485e-ae76-45f8-b964-a0a653ac1bc2"), Color.Black, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7089), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 30, Size.XXXL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7091) },
                    { new Guid("8907b530-a9d4-464e-94f2-e86214b3b200"), Color.Black, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7214), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 30, Size.XXXL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7215) },
                    { new Guid("8c647e8e-a319-496d-bf08-3f40a892a610"), Color.Black, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7151), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 30, Size.XXXL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7152) },
                    { new Guid("9348956b-905b-4a97-ba00-40f82951b090"), Color.Blue, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7191), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 20, Size.XL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7192) },
                    { new Guid("9a9a8700-28b0-4849-9865-23a5e9ebafaa"), Color.Black, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7196), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 30, Size.XXXL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7197) },
                    { new Guid("9b202036-51c1-4664-93a8-065398b657b8"), Color.Black, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7243), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 30, Size.XXXL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7245) },
                    { new Guid("a0838293-3b6e-4197-b8e3-cf67229b36cc"), Color.Red, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7077), new Guid("bf49c60a-9173-4533-8ca6-182cc7f685eb"), 10, Size.L, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7078) },
                    { new Guid("a57b4bb8-52e0-4294-8075-2df091c1b9d5"), Color.Blue, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7131), new Guid("425f57d3-5bcd-42cd-a401-9a3a9af83c8f"), 20, Size.XL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7133) },
                    { new Guid("a96ee623-999c-43ee-9afe-67f57dd76be8"), Color.Blue, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7207), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 20, Size.XL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7208) },
                    { new Guid("afa84b58-651a-45c9-bd07-c8911a6988b7"), Color.Blue, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7146), new Guid("30c4e1a7-3b0f-40e9-be69-903936c22290"), 20, Size.XL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7147) },
                    { new Guid("b933c25f-6a63-4507-ba71-2d50db74d8e4"), Color.Red, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7172), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 10, Size.L, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7173) },
                    { new Guid("bb945515-cde8-4a45-881a-066c2ef4a0d0"), Color.Black, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6940), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 30, Size.XXXL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6941) },
                    { new Guid("c5ea3679-6091-41ae-a1a9-db0f53dd3a11"), Color.Red, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7186), new Guid("052e6003-3e9b-43f3-9d59-0656df90989e"), 10, Size.L, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7188) },
                    { new Guid("cc1b8c19-fa4f-4e6d-a0c8-e926be3885d7"), Color.Black, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7181), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 30, Size.XXXL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7183) },
                    { new Guid("ce11d5e9-e66a-4b52-b41c-dfb02d6c644e"), Color.Black, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7165), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 30, Size.XXXL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7166) },
                    { new Guid("d0d2ecdf-b74a-492d-98c3-e8f35c0eae32"), Color.Red, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7155), new Guid("7f49c05a-d60c-49e6-b804-f3eb5a65522f"), 10, Size.L, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7157) },
                    { new Guid("d1ed2918-6199-46bf-b3f2-2b4193b54ba8"), Color.Black, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7120), new Guid("46e235cb-57a7-4eaa-b8c0-fc8096daee7b"), 30, Size.XXXL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7121) },
                    { new Guid("d38b8889-3d8a-4eda-bdf4-4e0f6511a216"), Color.Red, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7202), new Guid("b4143d6b-c302-4215-82e9-c9123d2f2ee5"), 10, Size.L, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7203) },
                    { new Guid("d4c93685-5b4d-4bce-8e3b-97276377bb90"), Color.Blue, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7177), new Guid("ead99f26-fbfb-4b83-bf74-2ef2fd2b4754"), 20, Size.XL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7178) },
                    { new Guid("d62b2df2-a6f2-4971-9222-d07bc826a81d"), Color.Blue, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7223), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 20, Size.XL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7225) },
                    { new Guid("da7f0237-aa03-435e-8afc-f59fa2f6c86b"), Color.Blue, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6934), new Guid("bc2983a5-b13c-49a4-9a6c-29c4dad9c355"), 20, Size.XL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(6936) },
                    { new Guid("e1f8ed2f-3c48-431e-9030-cb4b33c26b82"), Color.Black, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7228), new Guid("41dde13b-dbcc-4f51-a31c-2231f94ddcab"), 30, Size.XXXL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7230) },
                    { new Guid("eb4a2f4b-f440-490a-b385-86a88f0eefaa"), Color.Blue, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7255), new Guid("8b441114-e030-4412-8952-2370a4b7f05a"), 20, Size.XL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7257) },
                    { new Guid("eba616fe-38bb-46ae-9de8-a9622d1ed72e"), Color.Blue, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7062), new Guid("865770da-89af-4719-b00c-310b57d535e1"), 20, Size.XL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7064) },
                    { new Guid("f63eb685-2212-40f6-947c-ce4e1df26401"), Color.Blue, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7238), new Guid("9101df8f-38e3-40de-a46a-8ca66c26222d"), 20, Size.XL, new DateTime(2023, 12, 28, 8, 52, 48, 913, DateTimeKind.Local).AddTicks(7240) }
                });

            migrationBuilder.CreateIndex(
                name: "ix_addresses_user_id",
                table: "addresses",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_images_product_id",
                table: "images",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "ix_order_items_order_id",
                table: "order_items",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "ix_order_items_product_id",
                table: "order_items",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "ix_order_items_variant_id",
                table: "order_items",
                column: "variant_id");

            migrationBuilder.CreateIndex(
                name: "ix_orders_address_id",
                table: "orders",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "ix_orders_user_id",
                table: "orders",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_products_category_id",
                table: "products",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "ix_reviews_product_id",
                table: "reviews",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "ix_reviews_user_id_product_id",
                table: "reviews",
                columns: new[] { "user_id", "product_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_users_email",
                table: "users",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_variants_product_id",
                table: "variants",
                column: "product_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "images");

            migrationBuilder.DropTable(
                name: "order_items");

            migrationBuilder.DropTable(
                name: "reviews");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "variants");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
