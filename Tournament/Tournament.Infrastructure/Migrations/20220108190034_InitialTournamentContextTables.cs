using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tournament.Infrastructure.Migrations
{
    public partial class InitialTournamentContextTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuarterFinals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuarterFinals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoundOf16s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoundOf16s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SemiFinals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SemiFinals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    NumberOfTeams = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    RoundOf16Id = table.Column<int>(nullable: true),
                    QuarterFinalsId = table.Column<int>(nullable: true),
                    SemiFinalsId = table.Column<int>(nullable: true),
                    FinalId = table.Column<int>(nullable: true),
                    TournamentStatisticsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tournaments_QuarterFinals_QuarterFinalsId",
                        column: x => x.QuarterFinalsId,
                        principalTable: "QuarterFinals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournaments_RoundOf16s_RoundOf16Id",
                        column: x => x.RoundOf16Id,
                        principalTable: "RoundOf16s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournaments_SemiFinals_SemiFinalsId",
                        column: x => x.SemiFinalsId,
                        principalTable: "SemiFinals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    TournamentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerStatisticsId = table.Column<int>(nullable: false),
                    MatchStatisticsId = table.Column<int>(nullable: false),
                    RefereeId = table.Column<Guid>(nullable: false),
                    GroupId = table.Column<int>(nullable: true),
                    QuarterFinalsId = table.Column<int>(nullable: true),
                    RoundOf16Id = table.Column<int>(nullable: true),
                    SemiFinalsId = table.Column<int>(nullable: true),
                    TournamentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_QuarterFinals_QuarterFinalsId",
                        column: x => x.QuarterFinalsId,
                        principalTable: "QuarterFinals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_RoundOf16s_RoundOf16Id",
                        column: x => x.RoundOf16Id,
                        principalTable: "RoundOf16s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_SemiFinals_SemiFinalsId",
                        column: x => x.SemiFinalsId,
                        principalTable: "SemiFinals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Finals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Finals_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    LogoUrl = table.Column<string>(maxLength: 2048, nullable: false),
                    YearFounded = table.Column<int>(nullable: false),
                    Country = table.Column<string>(maxLength: 20, nullable: false),
                    Stadium = table.Column<string>(maxLength: 20, nullable: false),
                    GroupPoints = table.Column<int>(nullable: false),
                    PresidentId = table.Column<Guid>(nullable: false),
                    CoachId = table.Column<Guid>(nullable: false),
                    GroupId = table.Column<int>(nullable: true),
                    MatchId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teams_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Finals_MatchId",
                table: "Finals",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_TournamentId",
                table: "Groups",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_GroupId",
                table: "Matches",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_QuarterFinalsId",
                table: "Matches",
                column: "QuarterFinalsId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_RoundOf16Id",
                table: "Matches",
                column: "RoundOf16Id");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_SemiFinalsId",
                table: "Matches",
                column: "SemiFinalsId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TournamentId",
                table: "Matches",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_GroupId",
                table: "Teams",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_MatchId",
                table: "Teams",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Tournaments_FinalId",
                table: "Tournaments",
                column: "FinalId");

            migrationBuilder.CreateIndex(
                name: "IX_Tournaments_QuarterFinalsId",
                table: "Tournaments",
                column: "QuarterFinalsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tournaments_RoundOf16Id",
                table: "Tournaments",
                column: "RoundOf16Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tournaments_SemiFinalsId",
                table: "Tournaments",
                column: "SemiFinalsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tournaments_Finals_FinalId",
                table: "Tournaments",
                column: "FinalId",
                principalTable: "Finals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Finals_Matches_MatchId",
                table: "Finals");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Tournaments");

            migrationBuilder.DropTable(
                name: "Finals");

            migrationBuilder.DropTable(
                name: "QuarterFinals");

            migrationBuilder.DropTable(
                name: "RoundOf16s");

            migrationBuilder.DropTable(
                name: "SemiFinals");
        }
    }
}
