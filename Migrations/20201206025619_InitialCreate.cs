using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab5_Jermaine.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    playerName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    playerNumber = table.Column<int>(type: "int", nullable: false),
                    playerTeam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    playerPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    playerCondition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.playerName);
                });
            
            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    teamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numberOfPlayers = table.Column<int>(type: "int", nullable: false),
                    playerName = table.Column<string>(type: "nvarchar(450)", nullable: false)


                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.teamName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
