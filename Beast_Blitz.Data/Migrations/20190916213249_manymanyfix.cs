using Microsoft.EntityFrameworkCore.Migrations;

namespace Beast_Blitz.Data.Migrations
{
    public partial class manymanyfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_PlayerUserID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Locations_ShopLocationID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_PlayerUserID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ShopLocationID",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "PlayerUserID",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ShopLocationID",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "Defense",
                table: "Items",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ShopItem",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false),
                    ItemID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopItem", x => new { x.LocationID, x.ItemID });
                    table.ForeignKey(
                        name: "FK_ShopItem_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShopItem_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserItem",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false),
                    ItemID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserItem", x => new { x.UserID, x.ItemID });
                    table.ForeignKey(
                        name: "FK_UserItem_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserItem_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShopItem_ItemID",
                table: "ShopItem",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_UserItem_ItemID",
                table: "UserItem",
                column: "ItemID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopItem");

            migrationBuilder.DropTable(
                name: "UserItem");

            migrationBuilder.DropIndex(
                name: "IX_Users_Username",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Defense",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "PlayerUserID",
                table: "Items",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShopLocationID",
                table: "Items",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_PlayerUserID",
                table: "Items",
                column: "PlayerUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ShopLocationID",
                table: "Items",
                column: "ShopLocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_PlayerUserID",
                table: "Items",
                column: "PlayerUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Locations_ShopLocationID",
                table: "Items",
                column: "ShopLocationID",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
