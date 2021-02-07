using Microsoft.EntityFrameworkCore.Migrations;

namespace PUG.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guilds",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guilds", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TextChannels",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    GuildID = table.Column<decimal>(type: "decimal(20,0)", nullable: true),
                    ChannelType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextChannels", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TextChannels_Guilds_GuildID",
                        column: x => x.GuildID,
                        principalTable: "Guilds",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TextChannels_GuildID",
                table: "TextChannels",
                column: "GuildID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TextChannels");

            migrationBuilder.DropTable(
                name: "Guilds");
        }
    }
}
