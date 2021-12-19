using Microsoft.EntityFrameworkCore.Migrations;

namespace AP.Oefenproject.DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Circuit");

            migrationBuilder.EnsureSchema(
                name: "Country");

            migrationBuilder.EnsureSchema(
                name: "Pilot");

            migrationBuilder.EnsureSchema(
                name: "RacePilotTeam");

            migrationBuilder.EnsureSchema(
                name: "Race");

            migrationBuilder.EnsureSchema(
                name: "Season");

            migrationBuilder.EnsureSchema(
                name: "Serie");

            migrationBuilder.EnsureSchema(
                name: "Team");

            migrationBuilder.CreateTable(
                name: "tblCountries",
                schema: "Country",
                columns: table => new
                {
                    Country_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCountries", x => x.Country_id);
                });

            migrationBuilder.CreateTable(
                name: "tblPilots",
                schema: "Pilot",
                columns: table => new
                {
                    Pilot_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    License_nr = table.Column<int>(type: "int", maxLength: 9, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Date_of_birth = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Length = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    Weight = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    Picture_path = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPilots", x => x.Pilot_id);
                });

            migrationBuilder.CreateTable(
                name: "tblSeries",
                schema: "Serie",
                columns: table => new
                {
                    Serie_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Serie_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Start_date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    End_date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Sort_order = table.Column<int>(type: "int", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSeries", x => x.Serie_id);
                });

            migrationBuilder.CreateTable(
                name: "tblTeams",
                schema: "Team",
                columns: table => new
                {
                    Team_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Team_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTeams", x => x.Team_id);
                });

            migrationBuilder.CreateTable(
                name: "tblCircuits",
                schema: "Circuit",
                columns: table => new
                {
                    Circuit_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country_id = table.Column<int>(type: "int", nullable: false),
                    Circuit_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    City = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    House_number = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Length = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCircuits", x => x.Circuit_id);
                    table.ForeignKey(
                        name: "FK_tblCircuits_tblCountries_Country_id",
                        column: x => x.Country_id,
                        principalSchema: "Country",
                        principalTable: "tblCountries",
                        principalColumn: "Country_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblSeasons",
                schema: "Season",
                columns: table => new
                {
                    Season_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Serie_id = table.Column<int>(type: "int", nullable: false),
                    Season_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Start_date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    End_date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSeasons", x => x.Season_id);
                    table.ForeignKey(
                        name: "FK_tblSeasons_tblSeries_Serie_id",
                        column: x => x.Serie_id,
                        principalSchema: "Serie",
                        principalTable: "tblSeries",
                        principalColumn: "Serie_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblRaces",
                schema: "Race",
                columns: table => new
                {
                    Race_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Season_id = table.Column<int>(type: "int", nullable: false),
                    Circuit_id = table.Column<int>(type: "int", nullable: false),
                    Race_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Start_date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    End_date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRaces", x => x.Race_id);
                    table.ForeignKey(
                        name: "FK_tblRaces_tblCircuits_Circuit_id",
                        column: x => x.Circuit_id,
                        principalSchema: "Circuit",
                        principalTable: "tblCircuits",
                        principalColumn: "Circuit_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblRaces_tblSeasons_Season_id",
                        column: x => x.Season_id,
                        principalSchema: "Season",
                        principalTable: "tblSeasons",
                        principalColumn: "Season_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblRacePilotTeams",
                schema: "RacePilotTeam",
                columns: table => new
                {
                    Pilot_id = table.Column<int>(type: "int", nullable: false),
                    Race_id = table.Column<int>(type: "int", nullable: false),
                    Team_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRacePilotTeams", x => new { x.Pilot_id, x.Race_id });
                    table.ForeignKey(
                        name: "FK_tblRacePilotTeams_tblPilots_Pilot_id",
                        column: x => x.Pilot_id,
                        principalSchema: "Pilot",
                        principalTable: "tblPilots",
                        principalColumn: "Pilot_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblRacePilotTeams_tblRaces_Race_id",
                        column: x => x.Race_id,
                        principalSchema: "Race",
                        principalTable: "tblRaces",
                        principalColumn: "Race_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblRacePilotTeams_tblTeams_Team_id",
                        column: x => x.Team_id,
                        principalSchema: "Team",
                        principalTable: "tblTeams",
                        principalColumn: "Team_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCircuits_Country_id",
                schema: "Circuit",
                table: "tblCircuits",
                column: "Country_id");

            migrationBuilder.CreateIndex(
                name: "IX_tblPilots_License_nr",
                schema: "Pilot",
                table: "tblPilots",
                column: "License_nr",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblRacePilotTeams_Race_id",
                schema: "RacePilotTeam",
                table: "tblRacePilotTeams",
                column: "Race_id");

            migrationBuilder.CreateIndex(
                name: "IX_tblRacePilotTeams_Team_id",
                schema: "RacePilotTeam",
                table: "tblRacePilotTeams",
                column: "Team_id");

            migrationBuilder.CreateIndex(
                name: "IX_tblRaces_Circuit_id",
                schema: "Race",
                table: "tblRaces",
                column: "Circuit_id");

            migrationBuilder.CreateIndex(
                name: "IX_tblRaces_Season_id",
                schema: "Race",
                table: "tblRaces",
                column: "Season_id");

            migrationBuilder.CreateIndex(
                name: "IX_tblSeasons_Serie_id",
                schema: "Season",
                table: "tblSeasons",
                column: "Serie_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblRacePilotTeams",
                schema: "RacePilotTeam");

            migrationBuilder.DropTable(
                name: "tblPilots",
                schema: "Pilot");

            migrationBuilder.DropTable(
                name: "tblRaces",
                schema: "Race");

            migrationBuilder.DropTable(
                name: "tblTeams",
                schema: "Team");

            migrationBuilder.DropTable(
                name: "tblCircuits",
                schema: "Circuit");

            migrationBuilder.DropTable(
                name: "tblSeasons",
                schema: "Season");

            migrationBuilder.DropTable(
                name: "tblCountries",
                schema: "Country");

            migrationBuilder.DropTable(
                name: "tblSeries",
                schema: "Serie");
        }
    }
}
