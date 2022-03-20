using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AeonsEndApi.Data.Migrations
{
    public partial class ProjectRebuilded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameVersions",
                columns: table => new
                {
                    GameVersionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameVersions", x => x.GameVersionId);
                });

            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackStory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AbilityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AbilityDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Breach1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Breach2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Breach3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Breach4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandCount = table.Column<int>(type: "int", nullable: false),
                    DeckCount = table.Column<int>(type: "int", nullable: false),
                    SparkCount = table.Column<int>(type: "int", nullable: false),
                    CrystalCount = table.Column<int>(type: "int", nullable: false),
                    CrystalHandCount = table.Column<int>(type: "int", nullable: false),
                    SparkHandCount = table.Column<int>(type: "int", nullable: false),
                    GameVersionId = table.Column<int>(type: "int", nullable: false),
                    VersionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Heroes_GameVersions_GameVersionId",
                        column: x => x.GameVersionId,
                        principalTable: "GameVersions",
                        principalColumn: "GameVersionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nemeses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackStory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameStart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Release = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameVersionId = table.Column<int>(type: "int", nullable: false),
                    VersionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nemeses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nemeses_GameVersions_GameVersionId",
                        column: x => x.GameVersionId,
                        principalTable: "GameVersions",
                        principalColumn: "GameVersionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    IsBasic = table.Column<bool>(type: "bit", nullable: false),
                    AmmountInHand = table.Column<int>(type: "int", nullable: true),
                    MarketAmmount = table.Column<int>(type: "int", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    GameVersionId = table.Column<int>(type: "int", nullable: false),
                    HeroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_CardTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "CardTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_GameVersions_GameVersionId",
                        column: x => x.GameVersionId,
                        principalTable: "GameVersions",
                        principalColumn: "GameVersionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_GameVersionId",
                table: "Cards",
                column: "GameVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_HeroId",
                table: "Cards",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_TypeId",
                table: "Cards",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_GameVersionId",
                table: "Heroes",
                column: "GameVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Nemeses_GameVersionId",
                table: "Nemeses",
                column: "GameVersionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Nemeses");

            migrationBuilder.DropTable(
                name: "CardTypes");

            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "GameVersions");
        }
    }
}
