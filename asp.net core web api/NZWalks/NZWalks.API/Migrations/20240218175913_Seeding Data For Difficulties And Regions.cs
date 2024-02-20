using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataForDifficultiesAndRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("bcca5656-b553-40a3-bc12-f082c05e10fc"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("cb74ecd4-67ab-400d-8e51-e6312ed315db"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("f1b78e80-0746-4df6-945b-13d48967f735"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("14ceba71-4b51-4777-9b17-46602cf66153"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f7248fc3-2585-4efb-8d1d-1c555f4087f6"));

            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3e26a9e3-b247-4ed1-848b-9a6cbf948854"), "Easy" },
                    { new Guid("42f72a32-d91d-4fc4-af70-60646e41bf8a"), "Medium" },
                    { new Guid("d4e8ad2b-ee8d-4371-bcc8-d9ed348ca0a7"), "Hard" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("08730daf-3793-4508-8103-7403f2064506"), "WGN", "Wellington", "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("392b1ced-cdb7-4e7c-9405-e0cbd18a3555"), "NTL", "Northland", null },
                    { new Guid("3a14b412-791b-4427-845a-07e6c5644e63"), "BOP", "Bay Of Plenty", null },
                    { new Guid("ea7c7efa-cdc0-4a5d-95f4-6fddf826adda"), "AKL", "Auckland", "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("3e26a9e3-b247-4ed1-848b-9a6cbf948854"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("42f72a32-d91d-4fc4-af70-60646e41bf8a"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("d4e8ad2b-ee8d-4371-bcc8-d9ed348ca0a7"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("08730daf-3793-4508-8103-7403f2064506"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("392b1ced-cdb7-4e7c-9405-e0cbd18a3555"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3a14b412-791b-4427-845a-07e6c5644e63"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("ea7c7efa-cdc0-4a5d-95f4-6fddf826adda"));

            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("bcca5656-b553-40a3-bc12-f082c05e10fc"), "Easy" },
                    { new Guid("cb74ecd4-67ab-400d-8e51-e6312ed315db"), "Hard" },
                    { new Guid("f1b78e80-0746-4df6-945b-13d48967f735"), "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("14ceba71-4b51-4777-9b17-46602cf66153"), "BOP", "Bay Of Plenty", null },
                    { new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"), "NTL", "Northland", null },
                    { new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"), "NSN", "Nelson", "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"), "WGN", "Wellington", "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"), "STL", "Southland", null },
                    { new Guid("f7248fc3-2585-4efb-8d1d-1c555f4087f6"), "AKL", "Auckland", "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" }
                });
        }
    }
}
