using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceAPI.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddImageEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_image_products_product_id",
                table: "image");

            migrationBuilder.DropPrimaryKey(
                name: "pk_image",
                table: "image");

            migrationBuilder.RenameTable(
                name: "image",
                newName: "images");

            migrationBuilder.RenameIndex(
                name: "ix_image_product_id",
                table: "images",
                newName: "ix_images_product_id");

            migrationBuilder.AlterColumn<Guid>(
                name: "product_id",
                table: "images",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "images",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "images",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "pk_images",
                table: "images",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_images_products_product_id",
                table: "images",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_images_products_product_id",
                table: "images");

            migrationBuilder.DropPrimaryKey(
                name: "pk_images",
                table: "images");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "images");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "images");

            migrationBuilder.RenameTable(
                name: "images",
                newName: "image");

            migrationBuilder.RenameIndex(
                name: "ix_images_product_id",
                table: "image",
                newName: "ix_image_product_id");

            migrationBuilder.AlterColumn<Guid>(
                name: "product_id",
                table: "image",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddPrimaryKey(
                name: "pk_image",
                table: "image",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_image_products_product_id",
                table: "image",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
