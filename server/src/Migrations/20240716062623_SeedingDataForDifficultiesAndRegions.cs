using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_course.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataForDifficultiesAndRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7e8e6a84-f821-4073-9c81-7a7d5f6fa60e"), "Easy" },
                    { new Guid("afd8b73e-1fb1-4c69-bcd1-9254ddf7729c"), "Medium" },
                    { new Guid("dd483d1c-c5aa-4a5f-b8cc-dc14fdd7c6b0"), "Hard" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("2ba8de48-1200-478a-b477-cd3085d265cb"), "BP", "Bay of Plenty", "https://www.doc.govt.nz/globalassets/images/conservation/parks-and-recreation/places-to-visit/bay-of-plenty/mt-maunganui.jpg" },
                    { new Guid("3682f395-e1a3-4fc9-abd1-b4ee65b1eaa5"), "AK", "Auckland", "https://www.doc.govt.nz/globalassets/images/conservation/parks-and-recreation/places-to-visit/auckland/auckland.jpg" },
                    { new Guid("8f20f419-e26a-42a0-bbd0-126e4139517d"), "GB", "Gisborne", null },
                    { new Guid("e8768a13-498f-472e-96cb-22a01d1eb4a1"), "NL", "Northland", "https://www.doc.govt.nz/globalassets/images/conservation/parks-and-recreation/places-to-visit/northland/tauranga-bay.jpg" },
                    { new Guid("ff1d8360-2245-4d6b-ae46-8fa42837713e"), "WK", "Waikato", "https://www.doc.govt.nz/globalassets/images/conservation/parks-and-recreation/places-to-visit/waikato/hamilton.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("7e8e6a84-f821-4073-9c81-7a7d5f6fa60e"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("afd8b73e-1fb1-4c69-bcd1-9254ddf7729c"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("dd483d1c-c5aa-4a5f-b8cc-dc14fdd7c6b0"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2ba8de48-1200-478a-b477-cd3085d265cb"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3682f395-e1a3-4fc9-abd1-b4ee65b1eaa5"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8f20f419-e26a-42a0-bbd0-126e4139517d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("e8768a13-498f-472e-96cb-22a01d1eb4a1"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("ff1d8360-2245-4d6b-ae46-8fa42837713e"));
        }
    }
}
