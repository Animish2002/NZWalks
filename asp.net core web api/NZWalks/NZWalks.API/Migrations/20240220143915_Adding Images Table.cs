using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class AddingImagesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("487ab5d8-4d39-41c3-b64f-62d235307aef"), "Easy" },
                    { new Guid("500aff2a-b67d-425e-8656-0b5ed1464c79"), "Hard" },
                    { new Guid("d7d6d5bc-ea30-42cf-b94e-7b83640072c4"), "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("490df01d-b5c4-46c8-9e92-b47dd30a0481"), "AKL", "Auckland", "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("537fa8bf-37bf-4dc3-bdfb-5cc81dc13576"), "NTL", "Northland", null },
                    { new Guid("d8d7b43e-2a46-4e35-87a9-95756db213c2"), "WGN", "Wellington", "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("fd7cbf6e-f266-4466-8650-ece33d7e7c9f"), "BOP", "Bay Of Plenty", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("487ab5d8-4d39-41c3-b64f-62d235307aef"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("500aff2a-b67d-425e-8656-0b5ed1464c79"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("d7d6d5bc-ea30-42cf-b94e-7b83640072c4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("490df01d-b5c4-46c8-9e92-b47dd30a0481"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("537fa8bf-37bf-4dc3-bdfb-5cc81dc13576"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d8d7b43e-2a46-4e35-87a9-95756db213c2"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("fd7cbf6e-f266-4466-8650-ece33d7e7c9f"));

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
    }
}
