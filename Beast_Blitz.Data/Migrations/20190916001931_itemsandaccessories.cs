using Microsoft.EntityFrameworkCore.Migrations;

namespace Beast_Blitz.Data.Migrations
{
    public partial class itemsandaccessories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Users_PlayerUserID",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Locations_ShopLocationID",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Monsters_Item_RewardItemID",
                table: "Monsters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_Item_ShopLocationID",
                table: "Items",
                newName: "IX_Items_ShopLocationID");

            migrationBuilder.RenameIndex(
                name: "IX_Item_PlayerUserID",
                table: "Items",
                newName: "IX_Items_PlayerUserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "ItemID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Monsters_Items_RewardItemID",
                table: "Monsters",
                column: "RewardItemID",
                principalTable: "Items",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_PlayerUserID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Locations_ShopLocationID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Monsters_Items_RewardItemID",
                table: "Monsters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ShopLocationID",
                table: "Item",
                newName: "IX_Item_ShopLocationID");

            migrationBuilder.RenameIndex(
                name: "IX_Items_PlayerUserID",
                table: "Item",
                newName: "IX_Item_PlayerUserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "ItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Users_PlayerUserID",
                table: "Item",
                column: "PlayerUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Locations_ShopLocationID",
                table: "Item",
                column: "ShopLocationID",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monsters_Item_RewardItemID",
                table: "Monsters",
                column: "RewardItemID",
                principalTable: "Item",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
