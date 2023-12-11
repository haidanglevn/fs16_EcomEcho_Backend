using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceAPI.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddDeleteBehavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_addresses_users_user_id",
                table: "addresses");

            migrationBuilder.CreateIndex(
                name: "ix_users_email",
                table: "users",
                column: "email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_addresses_users_user_id",
                table: "addresses",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_addresses_users_user_id",
                table: "addresses");

            migrationBuilder.DropIndex(
                name: "ix_users_email",
                table: "users");

            migrationBuilder.AddForeignKey(
                name: "fk_addresses_users_user_id",
                table: "addresses",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id");
        }
    }
}
