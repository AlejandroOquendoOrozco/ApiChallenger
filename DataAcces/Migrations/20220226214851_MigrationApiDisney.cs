using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcces.Migrations
{
    public partial class MigrationApiDisney : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TCharacter",
                columns: table => new
                {
                    IdCharacters = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    History = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCharacter", x => x.IdCharacters);
                });

            migrationBuilder.CreateTable(
                name: "TGender",
                columns: table => new
                {
                    IdGender = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TGender", x => x.IdGender);
                });

            migrationBuilder.CreateTable(
                name: "TUser",
                columns: table => new
                {
                    IdUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TUser", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "TMovie",
                columns: table => new
                {
                    IdMovie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Date = table.Column<string>(type: "datetime2", nullable: false),
                    Qualification = table.Column<int>(type: "int", nullable: false),
                    History = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    GenderIdGender = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMovie", x => x.IdMovie);
                    table.ForeignKey(
                        name: "FK_TMovie_TGender_GenderIdGender",
                        column: x => x.GenderIdGender,
                        principalTable: "TGender",
                        principalColumn: "IdGender",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharactersMovie",
                columns: table => new
                {
                    CharacterIdCharacters = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MoviesIdMovie = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharactersMovie", x => new { x.CharacterIdCharacters, x.MoviesIdMovie });
                    table.ForeignKey(
                        name: "FK_CharactersMovie_TCharacter_CharacterIdCharacters",
                        column: x => x.CharacterIdCharacters,
                        principalTable: "TCharacter",
                        principalColumn: "IdCharacters",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharactersMovie_TMovie_MoviesIdMovie",
                        column: x => x.MoviesIdMovie,
                        principalTable: "TMovie",
                        principalColumn: "IdMovie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharactersMovie_MoviesIdMovie",
                table: "CharactersMovie",
                column: "MoviesIdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_TMovie_GenderIdGender",
                table: "TMovie",
                column: "GenderIdGender");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharactersMovie");

            migrationBuilder.DropTable(
                name: "TUser");

            migrationBuilder.DropTable(
                name: "TCharacter");

            migrationBuilder.DropTable(
                name: "TMovie");

            migrationBuilder.DropTable(
                name: "TGender");
        }
    }
}
