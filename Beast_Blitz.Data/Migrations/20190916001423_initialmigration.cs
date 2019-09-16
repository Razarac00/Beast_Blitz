using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Beast_Blitz.Data.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BattleStats",
                columns: table => new
                {
                    BattleStatsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleStats", x => x.BattleStatsID);
                });

            migrationBuilder.CreateTable(
                name: "CareStats",
                columns: table => new
                {
                    CareStatsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareStats", x => x.CareStatsID);
                });

            migrationBuilder.CreateTable(
                name: "Elements",
                columns: table => new
                {
                    ElementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elements", x => x.ElementID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Coins = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    SpeciesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ElementID = table.Column<int>(nullable: true),
                    BaseStatsBattleStatsID = table.Column<int>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.SpeciesID);
                    table.ForeignKey(
                        name: "FK_Species_BattleStats_BaseStatsBattleStatsID",
                        column: x => x.BaseStatsBattleStatsID,
                        principalTable: "BattleStats",
                        principalColumn: "BattleStatsID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Species_Elements_ElementID",
                        column: x => x.ElementID,
                        principalTable: "Elements",
                        principalColumn: "ElementID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Monsters",
                columns: table => new
                {
                    MonsterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SpeciesID = table.Column<int>(nullable: true),
                    BattleStatsID = table.Column<int>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    CoinReward = table.Column<int>(nullable: true),
                    BattlefieldLocationID = table.Column<int>(nullable: true),
                    RewardItemID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    CareStatsID = table.Column<int>(nullable: true),
                    PlayerUserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monsters", x => x.MonsterID);
                    table.ForeignKey(
                        name: "FK_Monsters_BattleStats_BattleStatsID",
                        column: x => x.BattleStatsID,
                        principalTable: "BattleStats",
                        principalColumn: "BattleStatsID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Monsters_Species_SpeciesID",
                        column: x => x.SpeciesID,
                        principalTable: "Species",
                        principalColumn: "SpeciesID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Monsters_CareStats_CareStatsID",
                        column: x => x.CareStatsID,
                        principalTable: "CareStats",
                        principalColumn: "CareStatsID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Monsters_Users_PlayerUserID",
                        column: x => x.PlayerUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    BossMonsterID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                    table.ForeignKey(
                        name: "FK_Locations_Monsters_BossMonsterID",
                        column: x => x.BossMonsterID,
                        principalTable: "Monsters",
                        principalColumn: "MonsterID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    BuyCost = table.Column<int>(nullable: false),
                    SellCost = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    PlayerUserID = table.Column<int>(nullable: true),
                    ShopLocationID = table.Column<int>(nullable: true),
                    FullnessAmt = table.Column<int>(nullable: true),
                    Happiness = table.Column<int>(nullable: true),
                    Stat = table.Column<string>(nullable: true),
                    Amt = table.Column<int>(nullable: true),
                    HappinessAmt = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemID);
                    table.ForeignKey(
                        name: "FK_Item_Users_PlayerUserID",
                        column: x => x.PlayerUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Locations_ShopLocationID",
                        column: x => x.ShopLocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_PlayerUserID",
                table: "Item",
                column: "PlayerUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ShopLocationID",
                table: "Item",
                column: "ShopLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_BossMonsterID",
                table: "Locations",
                column: "BossMonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_Monsters_BattleStatsID",
                table: "Monsters",
                column: "BattleStatsID");

            migrationBuilder.CreateIndex(
                name: "IX_Monsters_SpeciesID",
                table: "Monsters",
                column: "SpeciesID");

            migrationBuilder.CreateIndex(
                name: "IX_Monsters_RewardItemID",
                table: "Monsters",
                column: "RewardItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Monsters_BattlefieldLocationID",
                table: "Monsters",
                column: "BattlefieldLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Monsters_CareStatsID",
                table: "Monsters",
                column: "CareStatsID");

            migrationBuilder.CreateIndex(
                name: "IX_Monsters_PlayerUserID",
                table: "Monsters",
                column: "PlayerUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Species_BaseStatsBattleStatsID",
                table: "Species",
                column: "BaseStatsBattleStatsID");

            migrationBuilder.CreateIndex(
                name: "IX_Species_ElementID",
                table: "Species",
                column: "ElementID");

            migrationBuilder.AddForeignKey(
                name: "FK_Monsters_Locations_BattlefieldLocationID",
                table: "Monsters",
                column: "BattlefieldLocationID",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Users_PlayerUserID",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Monsters_Users_PlayerUserID",
                table: "Monsters");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Locations_ShopLocationID",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Monsters_Locations_BattlefieldLocationID",
                table: "Monsters");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Monsters");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "CareStats");

            migrationBuilder.DropTable(
                name: "BattleStats");

            migrationBuilder.DropTable(
                name: "Elements");
        }
    }
}
