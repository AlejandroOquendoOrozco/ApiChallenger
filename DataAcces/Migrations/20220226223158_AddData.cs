using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcces.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "TMovie",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "TCharacter",
                columns: new[] { "IdCharacters", "Age", "History", "Name", "Weight" },
                values: new object[] { "0A1S2D", 25, "Once upon a time, a king and a queen had a baby daughter, and when she saw her black hair, snowy white skin and red red lips she decided to call her Snow White. Snow White grew up to be a pretty child, but sadly, after a few years, her mother died and her father married again. The new queen, Snow White's stepmother, was a beautiful woman too, but she was very vain. More than anything else she wanted to be certain that she was the most beautiful woman in the world.", " Snow white", 50 });

            migrationBuilder.InsertData(
                table: "TGender",
                columns: new[] { "IdGender", "Name" },
                values: new object[] { "9V6O7T", "Action" });

            migrationBuilder.InsertData(
                table: "TMovie",
                columns: new[] { "IdMovie", "Date", "GenderIdGender", "History", "Qualification", "Title" },
                values: new object[] { "8G3H4K", "1923/21/12", null, "Eric es un cazador cuya mujer fue asesinada mientras él estaba luchando en una guerra. Después de que Blancanieves escapa al Bosque Oscuro, la Reina Ravenna y su hermano Finn contratan a Eric para que capture a Blancanieves, prometiéndole que devolvería a su mujer a la vida.", 4, " SNOW WHITE AND THE HUNTER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TCharacter",
                keyColumn: "IdCharacters",
                keyValue: "0A1S2D");

            migrationBuilder.DeleteData(
                table: "TGender",
                keyColumn: "IdGender",
                keyValue: "9V6O7T");

            migrationBuilder.DeleteData(
                table: "TMovie",
                keyColumn: "IdMovie",
                keyValue: "8G3H4K");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "TMovie",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
