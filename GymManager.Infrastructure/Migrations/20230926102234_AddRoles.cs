using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GymManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5A7D9370-C37A-4790-B6AA-E8E390F6786D", "7112EDD5-EAC4-46C0-BCD5-B987E9DB4D92", "Klient", "KLIENT" },
                    { "62FD9D71-3104-406F-97F0-0BFC0DE4CB21", "A32752AF-C53C-4178-A52B-3EEA7224C1DC", "Administrator", "ADMINISTRATOR" },
                    { "81F09BDC-7DE0-4B6B-8CE9-6269CD3D04D1", "7EC72C51-7B61-41FB-B991-204956012AAB", "Pracownik", "PRACOWNIK" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5A7D9370-C37A-4790-B6AA-E8E390F6786D");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62FD9D71-3104-406F-97F0-0BFC0DE4CB21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81F09BDC-7DE0-4B6B-8CE9-6269CD3D04D1");
        }
    }
}
