using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab5_Jermaine.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "playerTeam",
                table: "Player",
                newName: "PlayerTeam");

            migrationBuilder.RenameColumn(
                name: "playerPosition",
                table: "Player",
                newName: "PlayerPosition");

            migrationBuilder.RenameColumn(
                name: "playerNumber",
                table: "Player",
                newName: "PlayerNumber");

            migrationBuilder.RenameColumn(
                name: "playerCondition",
                table: "Player",
                newName: "PlayerCondition");

            migrationBuilder.RenameColumn(
                name: "playerName",
                table: "Player",
                newName: "PlayerName");

            migrationBuilder.AddColumn<string>(
                name: "NBAteamName",
                table: "Player",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    NBAteamName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    numberOfPlayers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerNames = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.NBAteamName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropColumn(
                name: "NBAteamName",
                table: "Player");

            migrationBuilder.RenameColumn(
                name: "PlayerTeam",
                table: "Player",
                newName: "playerTeam");

            migrationBuilder.RenameColumn(
                name: "PlayerPosition",
                table: "Player",
                newName: "playerPosition");

            migrationBuilder.RenameColumn(
                name: "PlayerNumber",
                table: "Player",
                newName: "playerNumber");

            migrationBuilder.RenameColumn(
                name: "PlayerCondition",
                table: "Player",
                newName: "playerCondition");

            migrationBuilder.RenameColumn(
                name: "PlayerName",
                table: "Player",
                newName: "playerName");
        }
    }
}
