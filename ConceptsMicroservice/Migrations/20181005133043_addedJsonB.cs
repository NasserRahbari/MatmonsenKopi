using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ConceptsMicroservice.Migrations
{
    public partial class addedJsonB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ConceptMetas",
                table: "ConceptMetas");

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 17, 9 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 18, 9 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 19, 9 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 20, 9 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 21, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 22, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 25, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 25, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 26, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 26, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 27, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 27, 9 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 28, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 28, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 28, 9 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 35, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 35, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 36, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 36, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 41, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 41, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 41, 13 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 42, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 42, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 42, 13 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 43, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 43, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 44, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 44, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 59, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 59, 13 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 60, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 60, 13 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 64, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 65, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 65, 12 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 70, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 70, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 70, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 71, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 71, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 71, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 72, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 72, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 72, 7 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 73, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 73, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 73, 7 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 76, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 76, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 76, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 77, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 77, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 77, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 78, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 78, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 78, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 79, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 79, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 79, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 80, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 80, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 81, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 81, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 86, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 86, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 86, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 87, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 87, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 87, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 90, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 90, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 90, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 91, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 91, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 91, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 92, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 92, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 92, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 93, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 93, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 93, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 96, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 96, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 96, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 97, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 97, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 97, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 98, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 98, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 98, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 99, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 99, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 99, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 100, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 100, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 101, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 101, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 102, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 102, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 102, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 103, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 103, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 103, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 108, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 108, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 108, 11 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 109, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 109, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 109, 11 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 110, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 110, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 110, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 111, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 111, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 111, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 112, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 112, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 112, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 113, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 113, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 113, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 114, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 114, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 114, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 115, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 115, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 115, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 116, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 116, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 116, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 117, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 117, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 117, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 118, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 118, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 119, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 119, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 120, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 120, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 120, 10 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 123, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 123, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 123, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 124, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 124, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 124, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 125, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 125, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 126, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 126, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 131, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 131, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 132, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 132, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 133, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 133, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 133, 10 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 134, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 134, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 134, 10 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 139, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 139, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 139, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 140, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 140, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 140, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 141, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 141, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 142, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 142, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 143, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 144, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 144, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 145, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 145, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 146, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 146, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 146, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 147, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 147, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 147, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 150, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 150, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 150, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 151, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 151, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 151, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 162, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 162, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 162, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 163, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 163, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 163, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 168, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 168, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 168, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 169, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 169, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 169, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 170, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 170, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 170, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 171, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 171, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 171, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 172, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 172, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 172, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 173, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 173, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 173, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 174, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 174, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 174, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 175, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 175, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 175, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 176, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 176, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 176, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 177, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 177, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 177, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 184, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 184, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 184, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 185, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 185, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 185, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 186, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 186, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 186, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 187, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 187, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 187, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 190, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 190, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 190, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 191, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 191, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 191, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 192, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 192, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 192, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 193, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 193, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 193, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 194, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 194, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 194, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 195, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 195, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 195, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 198, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 198, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 198, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 199, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 199, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 199, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 204, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 204, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 204, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 205, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 205, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 205, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 208, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 208, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 208, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 209, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 209, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 209, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 212, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 212, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 212, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 213, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 213, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 213, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 214, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 214, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 214, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 215, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 215, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 215, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 216, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 216, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 217, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 217, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 218, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 218, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 218, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 219, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 219, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 219, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 220, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 220, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 220, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 221, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 221, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 221, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 222, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 222, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 222, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 223, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 223, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 223, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 230, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 230, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 230, 8 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 231, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 231, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 231, 8 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 232, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 232, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 232, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 233, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 233, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 233, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 234, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 234, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 235, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 235, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 242, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 242, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 242, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 243, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 243, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 243, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 246, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 246, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 246, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 247, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 247, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 247, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 248, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 248, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 248, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 249, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 249, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 249, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 250, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 250, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 250, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 251, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 251, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 251, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 259, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 259, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 259, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 260, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 260, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 260, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 261, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 261, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 261, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 262, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 262, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 262, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 263, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 263, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 263, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 264, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 264, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 264, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 265, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 265, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 265, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 266, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 266, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 266, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 273, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 273, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 273, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 274, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 274, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 274, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 277, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 277, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 277, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 278, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 278, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 278, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 281, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 281, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 281, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 282, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 282, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 282, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 291, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 291, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 291, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 292, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 292, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 292, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 293, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 293, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 293, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 294, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 294, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 294, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 297, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 297, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 297, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 298, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 298, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 298, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 299, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 299, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 299, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 300, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 300, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 300, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 301, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 301, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 301, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 302, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 302, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 302, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 309, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 309, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 309, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 310, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 310, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 310, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 311, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 311, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 311, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 312, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 312, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 312, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 315, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 315, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 315, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 316, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 316, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 316, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 317, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 317, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 317, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 318, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 318, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 318, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 321, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 321, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 321, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 322, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 322, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 322, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 323, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 323, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 323, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 324, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 324, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 324, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 325, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 325, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 325, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 326, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 326, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 326, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 329, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 329, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 329, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 330, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 330, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 330, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 331, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 331, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 331, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 332, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 332, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 332, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 341, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 341, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 342, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 342, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 343, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 343, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 344, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 344, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 345, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 345, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 346, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 346, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 347, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 347, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 347, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 348, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 348, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 348, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 351, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 351, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 351, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 352, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 352, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 352, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 367, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 367, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 367, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 368, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 368, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 368, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 371, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 371, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 371, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 372, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 372, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 372, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 373, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 373, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 374, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 374, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 377, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 377, 13 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 380, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 380, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 380, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 381, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 381, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 381, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 384, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 384, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 384, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 385, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 385, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 385, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 386, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 386, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 386, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 387, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 387, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 387, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 388, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 388, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 388, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 389, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 389, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 389, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 394, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 394, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 394, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 395, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 395, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 395, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 396, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 396, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 396, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 397, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 397, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 397, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 398, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 398, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 398, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 399, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 399, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 399, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 400, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 400, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 400, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 401, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 401, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 401, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 402, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 402, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 402, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 403, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 403, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 403, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 404, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 404, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 405, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 405, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 406, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 406, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 406, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 407, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 407, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 407, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 408, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 408, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 408, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 409, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 409, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 409, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 410, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 410, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 410, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 411, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 411, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 411, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 412, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 412, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 412, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 413, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 413, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 413, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 414, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 414, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 414, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 415, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 415, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 415, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 416, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 416, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 416, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 417, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 417, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 417, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 418, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 418, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 418, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 419, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 419, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 419, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 420, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 420, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 420, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 421, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 421, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 421, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 422, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 422, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 422, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 423, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 423, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 423, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 424, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 424, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 424, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 425, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 425, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 425, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 433, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 433, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 433, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 434, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 434, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 434, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 437, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 437, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 437, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 438, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 438, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 438, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 439, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 439, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 439, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 440, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 440, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 440, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 441, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 441, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 441, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 442, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 442, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 442, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 443, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 443, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 443, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 444, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 444, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 444, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 445, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 445, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 445, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 446, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 446, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 446, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 447, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 447, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 447, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 448, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 448, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 448, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 449, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 449, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 449, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 450, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 450, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 450, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 463, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 463, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 463, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 464, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 464, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 464, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 465, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 465, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 465, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 466, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 466, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 466, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 469, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 469, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 469, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 470, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 470, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 470, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 477, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 477, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 477, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 478, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 478, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 478, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 483, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 483, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 483, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 484, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 484, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 484, 6 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 495, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 495, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 495, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 496, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 496, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 496, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 497, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 497, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 497, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 498, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 498, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 498, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 499, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 499, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 499, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 500, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 500, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 500, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 505, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 505, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 505, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 506, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 506, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 506, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 511, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 511, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 511, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 512, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 512, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 512, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 513, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 513, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 514, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 514, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 515, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 515, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 515, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 516, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 516, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 516, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 517, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 517, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 518, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 518, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 519, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 519, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 519, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 520, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 520, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 520, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 521, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 521, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 521, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 522, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 522, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 522, 5 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 523, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 523, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 524, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 524, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 525, 2 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 525, 4 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 526, 1 });

            migrationBuilder.DeleteData(
                table: "ConceptMetas",
                keyColumns: new[] { "ConceptId", "MetadataId" },
                keyValues: new object[] { 526, 4 });

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Metadata",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Metadata",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Metadata",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Metadata",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Metadata",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Metadata",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Metadata",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Metadata",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Metadata",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Metadata",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Metadata",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Metadata",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Metadata",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PublishingStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "MetadataId",
                table: "Concepts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ConceptMetas",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConceptMetas",
                table: "ConceptMetas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MetaJson",
                columns: table => new
                {
                    Value = table.Column<string>(type: "json", nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaJson", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Concepts_MetadataId",
                table: "Concepts",
                column: "MetadataId");

            migrationBuilder.CreateIndex(
                name: "IX_ConceptMetas_ConceptId",
                table: "ConceptMetas",
                column: "ConceptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Concepts_MetaJson_MetadataId",
                table: "Concepts",
                column: "MetadataId",
                principalTable: "MetaJson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Concepts_MetaJson_MetadataId",
                table: "Concepts");

            migrationBuilder.DropTable(
                name: "MetaJson");

            migrationBuilder.DropIndex(
                name: "IX_Concepts_MetadataId",
                table: "Concepts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConceptMetas",
                table: "ConceptMetas");

            migrationBuilder.DropIndex(
                name: "IX_ConceptMetas_ConceptId",
                table: "ConceptMetas");

            migrationBuilder.DropColumn(
                name: "MetadataId",
                table: "Concepts");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ConceptMetas",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConceptMetas",
                table: "ConceptMetas",
                columns: new[] { "ConceptId", "MetadataId" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "", "Type" },
                    { 2, "", "Language" },
                    { 3, "", "Subject" }
                });

            migrationBuilder.InsertData(
                table: "PublishingStatus",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Published" });

            migrationBuilder.InsertData(
                table: "Concepts",
                columns: new[] { "Id", "Author", "Content", "Created", "ExternalId", "StatusId", "Title", "Updated" },
                values: new object[,]
                {
                    { 71, "Sissel Paaske", "Droppe vinkel i en brønn betyr å redusere vinkelen ned mot 0° (vertikal).", "2018-06-22T15:34:11Z", 149579, 1, "Droppe vinkel", "2018-09-04T08:43:33Z" },
                    { 152, "", "Asfaltener (uttale: asfaltˈener), kompliserte hydrokarboner som også kan inneholde mindre mengder nitrogen, oksygen og svovel. Utgjør hovedkomponentene i asfalt og er en av komponentene i tunge fyringsoljer. Visse råoljer (særlig i Venezuela) inneholder asfaltener, for øvrig dannes de ved raffinering av olje. De er løselige i benzen og karbondisulfid, uløselige i n-heptan.", "2018-06-22T15:39:31Z", 146360, 1, "Asfaltener", "2018-09-04T08:44:35Z" },
                    { 149, "", "DP; Dynamic Positioning, datastyrt navigeringssystem som bruker satelittkommunikasjon for å holde fartøyet i samme posisjon uansett bølger, vind og strøm i havet. Navigasjonssystemet kommuniserer med systemet for sidepropeller (truster) for å holde fartøyet i posisjon.", "2018-06-22T15:29:52Z", 141020, 1, "DP - Dynamisk Posisjonering", "2018-08-17T14:22:15Z" },
                    { 148, "", "DP: Dynamic Positioning, datastyrt navigasjonssystem som bruker satellittkommunikasjon for å holde fartøyet i samme posisjon uansett bølger, vind og strøm i havet. Navigasjonssystemet kommuniserer med systemet for sidepropeller (truster) for å holde fartøyet i posisjon.", "2018-06-22T15:29:52Z", 141020, 1, "DP - Dynamisk Posisjonering", "2018-08-17T14:22:15Z" },
                    { 138, "", "Naturgasskondensat er i gassform i reservoaret, men kondenserer til væske når temperaturen blir redusert til under duggpunktet til rågass. Temperaturfallet inntreffer vanligvis i produksjonsrøret på vei fra reservoar til overflaten, eller i overflateutstyret.", "2018-06-22T15:42:09Z", 151148, 1, "Kondensat", "2018-09-04T08:43:46Z" },
                    { 137, "", "Naturgasskondensat er i gassform i reservoaret, men kondenserer til væske når temperaturen blir redusert til under duggpunktet til rågass. Temperaturfallet inntreffer vanligvis i produksjonsrøret på vei fra reservoar til overflaten, eller i overflateutstyret.", "2018-06-22T15:42:09Z", 151148, 1, "Kondensat", "2018-09-04T08:43:46Z" },
                    { 136, "", "Empati er evna til å forstå sinnstilstanden eller kjenslene til ein annan person.", "2018-05-27T22:42:41Z", 120539, 1, "Empati", "2018-09-04T06:06:54Z" },
                    { 135, "", "Empati er evnen til å forstå en annens sinnstilstand eller følelser.", "2018-05-27T22:42:41Z", 120539, 1, "Empati", "2018-09-04T06:06:54Z" },
                    { 130, "", "Bruttonasjonalproduktet (BNP) syner verdien av alt som blir skapt/produsert i eit land. BNP omfattar verdiskapinga i all marknadsretta næringsverksemd, dessutan offentleg forvalting, ideelle organisasjonar og produksjon for eigen bruk. BNP per innbyggjar blir ofte nytta som eit mål på velstandsnivået i eit land. SSB", "2018-05-09T15:56:08Z", 1798, 1, "Bruttonasjonalprodukt (BNP)", "2018-09-04T08:31:26Z" },
                    { 129, "", "Bruttonasjonalproduktet (BNP) viser verdien av alt som skapes/produseres i et land. BNP omfatter verdiskapingen i all markedsrettet næringsvirksomhet, dessuten offentlig forvaltning, ideelle organisasjoner og produksjon for eget bruk. BNP per innbygger brukes ofte som et mål på velstandsnivået i et land. SSB", "2018-05-09T15:56:08Z", 1798, 1, "Bruttonasjonalprodukt (BNP)", "2018-09-04T08:31:26Z" },
                    { 128, "", "Mistillitsforslag kan fremjast for Stortinget av ein eller fleire stortingsrepresentantar. Dersom det blir vedteke, inneber det eit mistillitsvotum. Det er ei ytring som uttrykkjer at stortingsfleirtalet ikkje har tillit til regjeringa eller til ein einskild statsråd. Regjeringa eller statsråden blir med det tvinga til å gå av.", "2018-05-09T15:17:35Z", 11254, 1, "mistillitsforslag", "2018-09-04T08:51:49Z" },
                    { 127, "", "Mistillitsforslag kan fremmes for Stortinget av en eller flere stortingsrepresentanter. Dersom det blir vedtatt, innebærer det et mistillitsvotum. Det er en uttalelse som uttrykker at stortingsflertallet ikke har tillit til regjeringen eller til en enkelt statsråd. Regjeringen eller statsråden tvinges dermed til å gå av.", "2018-05-09T15:17:35Z", 11254, 1, "mistillitsforslag", "2018-09-04T08:51:49Z" },
                    { 122, "", "Heculus' søyler er eit område i dag kjent som Gibraltar i nord og fjella i Marokko. Namnet Gibraltar er utleidd frå det arabiske Tariqs fjell, etter hærføraren Tariq ibn Ziyad som leidde ein berbardominert hær over stretet frå Ceuta i 711.", "2018-05-09T14:55:38Z", 182746, 1, "Herculus' søyler", "2018-09-04T06:45:38Z" },
                    { 121, "", "Hercules `søyler er et område i dag kjent som Gibraltar i nord og fjellene i Marokko. Navnet Gibraltar er utledet fra det arabiske Tariqs fjell, etter hærføreren Tariq ibn Ziyad som ledet en berberdominert hær over stredet fra Ceuta i 711.", "2018-05-09T14:55:38Z", 182746, 1, "Hercules `søyler", "2018-09-04T06:45:38Z" },
                    { 107, "", "Med kassekreditt kan bedrifta overtrekkje driftskontoen sin inntil ei avtalt kredittramme hos banken sin.", "2018-05-27T22:40:08Z", 187648, 1, "Kassekreditt", "2018-09-04T08:45:33Z" },
                    { 106, "", "Med kassekreditt kan bedriften overtrekke sin driftskonto inntil en avtalt kredittramme hos banken sin.", "2018-05-27T22:40:08Z", 187648, 1, "Kassekreditt", "2018-09-04T08:45:33Z" },
                    { 105, "", "Koeffisient er en konstant størrelse som skal multipliseres med andre størrelser for å beregne egenskaper. Konstanten kan brukes for ulike material- eller systemegenskaper: friksjonskoeffisienten, utvidelseskoeffisienten og så videre.", "2018-06-22T15:36:55Z", 148141, 1, "Koeffisient", "2018-09-04T08:43:41Z" },
                    { 104, "", "Koeffisient er en konstant størrelse som skal multipliseres med andre størrelser for å beregne egenskaper. Konstanten kan brukes for ulike material- eller systemegenskaper: friksjonskoeffisienten, utvidelseskoeffisienten og så videre.", "2018-06-22T15:36:55Z", 148141, 1, "Koeffisient", "2018-09-04T08:43:41Z" },
                    { 95, "", "Tungtvatn: deuteriumoksid, D2O, ei vassklar væske utan lukt og smak som mellom anna blir brukt i kjernereaktorar. Dei allierte frykta at nazistane skulle bruke tungtvatnet til å utvikle ei atombombe.", "2018-05-09T15:49:16Z", 185394, 1, "Tungtvatn", "2018-09-04T06:48:59Z" },
                    { 94, "", "Tungtvann: deuteriumoksid, D2O, en vannklar væske uten lukt og smak som blant annet brukes i kjernereaktorer. De allierte fryktet at nazistene skulle bruke tungtvannet til å utvikle en atombombe.", "2018-05-09T15:49:16Z", 185394, 1, "Tungtvann", "2018-09-04T06:48:59Z" },
                    { 89, "", "Borestrengens nøytralpunkt er der strengen hverken har strekk- eller kompresjonskrefter. Nøytralpunktets plassering kan beregnes ved å ta hensyn til vekt på borestrengen, vekt som settes ned på borekronen, oppdrift i borevæsken og vinkel på brønnen.", "2018-06-22T15:33:51Z", 162797, 1, "Nøytralpunkt", "2018-09-04T06:39:30Z" },
                    { 88, "", "Borestrengens nøytralpunkt er der strengen hverken har strekk- eller kompresjonskrefter. Nøytralpunktets plassering kan beregnes ved å ta hensyn til vekt på borestrengen, vekt som settes ned på borekronen, oppdrift i borevæsken og vinkel på brønnen.", "2018-06-22T15:33:51Z", 162797, 1, "Nøytralpunkt", "2018-09-04T06:39:30Z" },
                    { 85, "", "Faststoffinnhold beskriver innholdet av partikler som ikke løser seg i syre eller væske. Partiklene er tilsatt borevæske for å bidra til å tette porer i formasjonen slik at ikke væske fra borevæsken lekker ut i formasjonen fra brønnen som bores.", "2018-06-22T15:35:21Z", 153314, 1, "Faststoffinnhold ", "2018-09-04T08:43:32Z" },
                    { 84, "", "Faststoffinnhold beskriver innholdet av partikler som ikke løser seg i syre eller væske. Partiklene er tilsatt borevæske for å bidra til å tette porer i formasjonen slik at ikke væske fra borevæsken lekker ut i formasjonen fra brønnen som bores.", "2018-06-22T15:35:21Z", 153314, 1, "Faststoffinnhold ", "2018-09-04T08:43:32Z" },
                    { 83, "", "Russland og Tyskland inngjekk fredsavtalen utan å involvere alliansepartnarane sine.", "2018-05-09T15:35:35Z", 185059, 1, "Separatfred", "2018-09-04T08:03:22Z" },
                    { 82, "", "Russland og Tyskland inngikk fredsavtalen uten å involvere alliansepartnerne sine.", "2018-05-09T15:35:35Z", 185059, 1, "Separatfred", "2018-09-04T08:03:22Z" },
                    { 75, "", "Moriskar (liten maurar). Nemninga på dei spanske muslimane (og etterkomarane deira) som hadde latt seg døype etter erobringa av Granada i 1492.", "2018-05-09T14:55:20Z", 182735, 1, "Moriskar", "2018-09-04T06:49:00Z" },
                    { 74, "", "Morisker (liten maurer). Betegnelsen på de spanske muslimene (og deres etterkommere) som hadde latt seg døpe etter erobringen av Granada i 1492.", "2018-05-09T14:55:20Z", 182735, 1, "Morisker", "2018-09-04T06:49:00Z" },
                    { 69, "", "Ein taifa var i realiteten ein bystat med kontroll av landdistrikta ikring. Dei mange små taifa-kongedømma vart etter kvart erobra av dei større. Rundt 1050 fanst det seks store, Badajoz, Toledo, Valencia, Granada, Zaragoza og Sevilla.", "2018-05-09T14:55:48Z", 182749, 1, "Taifa", "2018-09-04T06:45:37Z" },
                    { 68, "", "En taifa var i realiteten en bystat med kontroll av landdistriktene omkring. De mange små taifa-kongedømmene ble etter hvert erobret av de større. Rundt 1050 fantes det seks store, Badajoz, Toledo, Valencia, Granada, Zaragoza og Sevilla.", "2018-05-09T14:55:48Z", 182749, 1, "Taifa", "2018-09-04T06:45:37Z" },
                    { 153, "", "Asfaltener (uttale: asfaltˈener), kompliserte hydrokarboner som også kan inneholde mindre mengder nitrogen, oksygen og svovel. Utgjør hovedkomponentene i asfalt og er en av komponentene i tunge fyringsoljer. Visse råoljer (særlig i Venezuela) inneholder asfaltener, for øvrig dannes de ved raffinering av olje. De er løselige i benzen og karbondisulfid, uløselige i n-heptan.", "2018-06-22T15:39:31Z", 146360, 1, "Asfaltener", "2018-09-04T08:44:35Z" },
                    { 154, "", "Kaliper; et måleinstrument som kan gi avtrykk av utvendig eller innvendig diameter. To (eller flere for innvendig type) \"armer\" i stål er festet i et sentralt punkt. Armene er enten kurvet utover (for innvendig måling) eller innover (for utvendig måling). Når kaliper føres over diameteren justeres armene inn til veggen. Kaliperen leses av med skyvelære eller digitalt for å finne nøyaktig diameter.", "2018-06-22T15:43:21Z", 148218, 1, "Kaliper", "2018-09-04T08:44:45Z" },
                    { 155, "", "Kaliper; et måleinstrument som kan gi avtrykk av utvendig eller innvendig diameter. To (eller flere for innvendig type) \"armer\" i stål er festet i et sentralt punkt. Armene er enten kurvet utover (for innvendig måling) eller innover (for utvendig måling). Når kaliper føres over diameteren justeres armene inn til veggen. Kaliperen leses av med skyvelære eller digitalt for å finne nøyaktig diameter.", "2018-06-22T15:43:21Z", 148218, 1, "Kaliper", "2018-09-04T08:44:45Z" },
                    { 156, "", "Middelvannstanden er havets gjennomsnittshøyde fra havbunnen, målt i tidsrommet mellom høy- og lavvann. På engelsk MSL: Mean Sea Level.", "2018-06-22T15:29:59Z", 141018, 1, "middelavstand", "2018-08-17T14:21:38Z" },
                    { 226, "", "Gelstyrke er væskens evne til å stivne når den stå i ro.", "2018-06-22T15:36:19Z", 142350, 1, "gelstyrke", "2018-09-04T08:43:41Z" },
                    { 225, "", "Impermeabel: ugjennomtrengelig, tett.", "2018-06-22T15:36:18Z", 151878, 1, "Impermeabel", "2018-09-04T08:43:36Z" },
                    { 224, "", "Impermeabel: ugjennomtrengelig, tett.", "2018-06-22T15:36:18Z", 151878, 1, "Impermeabel", "2018-09-04T08:43:36Z" },
                    { 211, "", "Reologi, læren om flyte- og deformasjonsegenskapene, spesielt i seige væsker. Reologi omhandler hvordan viskositeten endrer seg med endringer i ytre påkjenninger som skjærspenning, trykk m.m. (Kilde: SNL)", "2018-06-22T15:36:23Z", 142348, 1, "reologi", "2018-09-04T08:44:00Z" },
                    { 210, "", "Reologi, læren om flyte- og deformasjonsegenskapene, spesielt i seige væsker. Reologi omhandler hvordan viskositeten endrer seg med endringer i ytre påkjenninger som skjærspenning, trykk m.m. (Kilde: SNL)", "2018-06-22T15:36:23Z", 142348, 1, "reologi", "2018-09-04T08:44:00Z" },
                    { 207, "", "Bygge vinkel i en brønn vil si å endre brønnens vinkel fra vertikal (0°) mot horisontal (90°).", "2018-06-22T15:34:13Z", 149577, 1, "Bygge vinkel", "2018-09-04T08:43:37Z" },
                    { 206, "", "Å bygge vinkel i en brønn vil si å endre brønnens vinkel fra vertikal (0°) mot horisontal (90°).", "2018-06-22T15:34:13Z", 149577, 1, "Bygge vinkel", "2018-09-04T08:43:37Z" },
                    { 203, "", "Chokeventil (egentlig strupeventil). Strupeventil brukes til å begrense utstrømning av væske fra en kilde (brønnen). Når strupeventilen er delvis åpen vil det forekomme et trykkfall forbi ventilen.", "2018-06-22T15:38:59Z", 156209, 1, "Chokeventil", "2018-09-04T08:43:41Z" },
                    { 202, "", "Chokeventil (egentlig strupeventil). Strupeventil brukes til å begrense utstrømning av væske fra en kilde (brønnen). Når strupeventilen er delvis åpen vil det forekomme et trykkfall forbi ventilen.", "2018-06-22T15:38:59Z", 156209, 1, "Chokeventil", "2018-09-04T08:43:41Z" },
                    { 201, "", "ID (Inner Diameter). Diameter målt innvendig i et rør eller en sylinder (hull).", "2018-06-22T15:31:50Z", 140968, 1, "ID", "2018-09-04T08:43:29Z" },
                    { 200, "", "ID (Inner Diameter). Diameter målt innvendig i et rør eller en sylinder (hull).", "2018-06-22T15:31:50Z", 140968, 1, "ID", "2018-09-04T08:43:29Z" },
                    { 197, "", "Å gi et pådrag betyr å tilføre noe mer; det kan være energi, masse, væske, lyd, hastighet osv.", "2018-06-22T15:32:07Z", 156621, 1, "Pådrag", "2018-08-17T14:22:04Z" },
                    { 196, "", "Å gi et pådrag betyr å tilføre noe mer; det kan være energi, masse, væske, lyd, hastighet osv.", "2018-06-22T15:32:07Z", 156621, 1, "Pådrag", "2018-08-17T14:22:04Z" },
                    { 189, "", "Moment er resultatet av kraft multiplisert med arm når noe skal skrus sammen. En momenttrekker kan stilles inn slik at den stopper når ønsket moment er oppnådd.", "2018-06-22T15:30:54Z", 161839, 1, "Moment", "2018-08-17T14:18:42Z" },
                    { 67, "", "Genutgåve, alternativ utgåve av eit gen. Alle individ har to allel for kvart gen. Det eine allelet er nedarva frå far og det andre frå mor. Eksempel: Det finnast allel for blå og brun augefarge. Det brune dominerer over det blå, så dersom du har blå auge kan du være viss på at du har to allel med kode for blå auge.", "2018-05-27T23:41:29Z", 9104, 1, "Allel", "2018-06-11T09:17:58Z" },
                    { 188, "", "Moment er resultatet av kraft multiplisert med arm når noe skal skrus sammen. En momenttrekker kan stilles inn slik at den stopper når ønsket moment er oppnådd.", "2018-06-22T15:30:54Z", 161839, 1, "Moment", "2018-08-17T14:18:42Z" },
                    { 182, "", "Å holde vinkel i en brønn betyr at man fortsetter boringen i den retningen (vinkelen) man har, uten å droppe eller bygge vinkel.", "2018-06-22T15:34:12Z", 149580, 1, "Holde vinkel", "2018-09-04T08:43:31Z" },
                    { 181, "", "Rensetog; en rad av små volum med væsker (kalles piller) som har ulike oppgaver innen rensing. Oppgavene kan være å løse opp salt, rust, kalk osv. Mellom de aktive væskene er det ofte piller som er viskøse og som hjelper til å holde væskene adskilt. Et rensetog kan ledes og følges av pigger, men det er ikke alltid nødvendig.", "2018-06-22T15:43:25Z", 148214, 1, "Rensetog", "2018-09-04T08:44:53Z" },
                    { 180, "", "Rensetog; en rad av små volum med væsker (kalles piller) som har ulike oppgaver innen rensing. Oppgavene kan være å løse opp salt, rust, kalk osv. Mellom de aktive væskene er det ofte piller som er viskøse og som hjelper til å holde væskene adskilt. Et rensetog kan ledes og følges av pigger, men det er ikke alltid nødvendig.", "2018-06-22T15:43:25Z", 148214, 1, "Rensetog", "2018-09-04T08:44:53Z" },
                    { 179, "", "HEC (hydroksyetylcellulose) er en polymer som blir brukt som et viskositetsøkende middel i saltløsninger som for eksempel kompletteringsvæsker og drill-in-væsker. HEC gir pseudoplastisk reologi, men utvikler egentlig ingen gelstyrke.", "2018-06-22T15:36:20Z", 151883, 1, "HEC ", "2018-09-04T08:43:44Z" },
                    { 178, "", "HEC (hydroksyetylcellulose) er en polymer som blir brukt som et viskositetsøkende middel i saltløsninger som for eksempel kompletteringsvæsker og drill-in-væsker. HEC gir pseudoplastisk reologi, men utvikler egentlig ingen gelstyrke.", "2018-06-22T15:36:20Z", 151883, 1, "HEC ", "2018-09-04T08:43:44Z" },
                    { 167, "", "Kompatibel betyr at noe kan virke sammen, er forenlig, passer til.", "2018-06-22T15:35:20Z", 153315, 1, "Kompatibel", "2018-09-04T08:43:30Z" },
                    { 166, "", "Kompatibel betyr at noe kan virke sammen, er forenlig, passer til.", "2018-06-22T15:35:20Z", 153315, 1, "Kompatibel", "2018-09-04T08:43:30Z" },
                    { 165, "", "MRU er en serie bevegelsessensorer som måler rullebevegelser, topp og bunn i bølgebevegelse, rotasjon rundt senterakse og vertikalbevegelse i forhold til et Nonepunkt. MRU sender signaler til et reaktivt system, vanligvis hiv-kompenserings- eller dynamisk posisjoneringssystem, som utløser motvirkende bevegelser.", "2018-06-22T15:32:08Z", 156620, 1, "Motion Reference Unit-MRU", "2018-08-17T14:22:07Z" },
                    { 164, "", "MRU er en serie bevegelsessensorer som måler rullebevegelser, topp og bunn i bølgebevegelse, rotasjon rundt senterakse og vertikalbevegelse i forhold til et Nonepunkt. MRU sender signaler til et reaktivt system, vanligvis hiv-kompenserings- eller dynamisk posisjoneringssystem, som utløser motvirkende bevegelser.", "2018-06-22T15:32:08Z", 156620, 1, "Motion Reference Unit-MRU", "2018-08-17T14:22:07Z" },
                    { 161, "", "ID = inner diameter = indre diameter", "2018-06-22T15:30:00Z", 137720, 1, "ID", "2018-08-17T14:21:42Z" },
                    { 160, "", "ID = inner diameter = indre diameter", "2018-06-22T15:30:00Z", 137720, 1, "ID", "2018-08-17T14:21:42Z" },
                    { 159, "", "OD = outer diameter = utvendig diameter", "2018-06-22T15:30:01Z", 137719, 1, "OD", "2018-08-17T14:21:43Z" },
                    { 158, "", "OD = outer diameter = utvendig diameter", "2018-06-22T15:30:01Z", 137719, 1, "OD", "2018-08-17T14:21:43Z" },
                    { 157, "", "middelavstanden er et resultat av havets gjennomsnittshøyde fra havbunnen, målt i tidsrommet mellom høy- og lavvann. På engelsk MSL: Mean Sea Level.", "2018-06-22T15:29:59Z", 141018, 1, "middelavstand", "2018-08-17T14:21:38Z" },
                    { 183, "", "Å holde vinkel i en brønn betyr at man fortsetter boringen i den retningen (vinkelen) man har, uten å droppe eller bygge vinkel.", "2018-06-22T15:34:12Z", 149580, 1, "Holde vinkel", "2018-09-04T08:43:31Z" },
                    { 66, "", "Genutgave, alternativ utgave av et gen. Alle individer har to allel for hvert gen. Det ene allelet er nedarvet fra far og det andre fra mor. Eksempel: Det finnes allel for blå og brun øyenfarge. Det brune dominerer over det blå, så dersom du har blå øyne kan du være sikker på at du har to allel med kode for blå øyne.", "2018-05-27T23:41:29Z", 9104, 1, "Allel", "2018-06-11T09:17:58Z" },
                    { 63, "", "Friksjon er gnidingsmotstand.", "2018-05-04T20:57:01Z", 89223, 1, "Friksjon", "2018-08-20T08:35:03Z" },
                    { 62, "", "Friksjon er gnidningsmotstand.", "2018-05-04T20:57:01Z", 89223, 1, "Friksjon", "2018-08-20T08:35:03Z" },
                    { 18, "Sigurd Alnæs", "Å fjerne feil fra dataprogrammer ved å analysere den overordnede prosessen for å løse et problem.", "2018-05-04T14:09:59Z", 48037, 1, "Debug", "2018-05-04T15:00:03Z" },
                    { 17, "Sigurd Alnæs", "Å fjerne feil frå dataprogram ved å analysere den overordna prosessen for å løyse eit problem.", "2018-05-04T14:09:59Z", 48037, 1, "Debug", "2018-05-04T15:00:03Z" },
                    { 14, "Sigurd Alnæs", "Et programmeringsspråk som for eksempel BASIC, COBOL, Logo, Java, C++, C# eller PHP. Alle kodelinjer i språket oversettes av datamaskinen til maskinspråk. Høynivåspråk er lettere å forstå enn maskinspråk, fordi det ligner mer på vårt eget talespråk enn maskinspråk gjør.", "2018-05-04T14:09:59Z", 48072, 1, "Høynivåspråk", "2018-05-04T15:00:02Z" },
                    { 13, "Sigurd Alnæs", "Eit programmeringsspråk som til dømes BASIC, COBOL, Logo, Java, C++, C# eller PHP. Alle kodelinjer i språket blir omsette av datamaskina til maskinspråk. Høgnivåspråk er lettare å forstå enn maskinspråk, fordi det liknar meir på vårt eige talespråk enn maskinspråk gjer.", "2018-05-04T14:09:59Z", 48072, 1, "Høgnivåspråk", "2018-05-04T15:00:02Z" },
                    { 20, "Sigurd Alnæs", "En strategi for problemløsing som starter med primitivene. Strategien kan være målrettet, slik at primitiver settes sammen til en helhet med et bestemt mål i sikte. Strategien kan også brukes på en mer tilfeldig måte, uten et klart mål i sikte. Målet kan formes etter hvert som du løser flere av primitivene.", "2018-05-04T14:59:12Z", 48020, 1, "Bygg opp-strategi", "2018-05-04T15:00:04Z" },
                    { 19, "Sigurd Alnæs", "Ein strategi for problemløysing som startar med primitivane. Strategien kan vere målretta, slik at primitivar blir sette saman til ein heilskap med eit bestemt mål i sikte. Strategien kan også brukast på ein meir tilfeldig måte, utan eit klart mål i sikte. Målet kan formast etter kvart som du løyser fleire av primitivane.", "2018-05-04T14:59:12Z", 48020, 1, "Bygg opp-strategi", "2018-05-04T15:00:04Z" },
                    { 119, "", "Trontaledebatten er en debatt om den årlige trontalen. Trontalen leses opp av Kongen ved Stortingets høytidelige åpning og inneholder regjeringens programerklæring for kommende år.", "2018-06-22T15:02:29Z", 11288, 1, "Trontaledebatten", "2018-08-20T10:16:46Z" },
                    { 118, "", "Trontaledebatten er ein debatt om den årlege trontalen. Trontalen blir lesen opp av Kongen ved den høgtidelege opninga av Stortinget og inneheld regjeringas programerklæring for året som kjem.", "2018-06-22T15:02:29Z", 11288, 1, "Trontaledebatten", "2018-08-20T10:16:46Z" },
                    { 151, "Inga Berntsen Rudi", "ILO står for International Labour Organization – den internasjonale arbeiderorganisasjonen. Den er en av organisasjonene i FN-systemet.", "2018-06-22T15:14:49Z", 50202, 1, "ILO", "2018-08-20T09:58:40Z" },
                    { 150, "Inga Berntsen Rudi", "ILO står for International Labour Organization – den internasjonale arbeidarorganisasjonen. Det er ein av organisasjonane i FN-systemet.", "2018-06-22T15:14:49Z", 50202, 1, "ILO", "2018-08-20T09:58:40Z" },
                    { 140, "Gro-Anita Mortensen", "I et representativt demokrati velger innbyggerne representanter som styrer på vegne av dem. Denne styreformen kalles også indirekte demokrati.", "2018-06-22T15:03:51Z", 6869, 1, "representativt/indirekte demokrati", "2018-08-20T10:17:00Z" },
                    { 139, "Gro-Anita Mortensen", "I eit representativt demokrati vel innbyggjarane representantar som styrer på vegner av dei. Denne styreforma blir også kalla indirekte demokrati.", "2018-06-22T15:03:51Z", 6869, 1, "representativt/indirekte demokrati", "2018-08-20T10:17:00Z" },
                    { 60, "amendor", "Å integrere er å innlemme som del av eller å innpasse i eit heile.", "2018-06-18T08:31:11Z", 92353, 1, "Integrere", "2018-06-22T16:50:24Z" },
                    { 59, "amendor", "Friksjon er gnidingsmotstand.", "2018-06-18T08:31:16Z", 92354, 1, "Friksjon", "2018-06-22T16:50:27Z" },
                    { 3, "Sigurd Alnæs", "Ein feil eller ei misforståing. Ein bug i eit dataprogram kan komme av ein feil i planen for å lage programmet. Det kan òg vere ein feil eller ei misforståing i prosedyren som blir programmert.", "2018-05-04T14:10:00Z", 48019, 1, "Bug", "2018-05-04T15:00:03Z" },
                    { 64, "Eidnes Trond", "Revisor er ein person som kontrollerer rekneskapen på vegner av styresmaktene.", "2018-05-27T22:40:54Z", 92832, 1, "Revisor", "2018-09-04T08:44:48Z" },
                    { 42, "amendor", "Hierarki: en rangordning der de som er øverst, har mer ansvar og myndighet enn de lenger nede i hierarkiet", "2018-05-04T20:42:35Z", 95159, 1, "Hierarki", "2018-09-04T06:19:54Z" },
                    { 41, "amendor", "Hierarki: ei rangordning der dei som står øvst, har meir ansvar og styringsrett enn dei lenger ned i hierarkiet", "2018-05-04T20:42:35Z", 95159, 1, "Hierarki", "2018-09-04T06:19:54Z" },
                    { 44, "amendor", "Kvalifikasjon: en utdanning eller opplæring som gjør deg egnet til å utføre en bestemt oppgave.", "2018-05-04T20:42:36Z", 95160, 1, "Kvalifikasjon", "2018-09-04T06:19:56Z" },
                    { 43, "amendor", "Kvalifikasjon: ei utdanning eller opplæring som gjer deg skikka til å utføre ei bestemt oppgåve", "2018-05-04T20:42:36Z", 95160, 1, "Kvalifikasjon", "2018-09-04T06:19:56Z" },
                    { 65, "Ragna Tørdal", "Cliffhanger: fortellermessig grep i film, stammer fra stumfilmtidens seriefilmer. Disse ble vist på kino avsnitt for avsnitt, og for å lokke publikum til neste avsnitt kunne man avslutte med en scene hvor hovedpersonen var i en farlig situasjon uten utveier, f.eks. presset av overtallige skurker, kastet i bjørnegården, plassert bundet på en jernbanelinje – eller etterlatt hengende fra en fjellhylle, derav navnet. Neste avsnitt måtte da innledes med heltens mirakuløse redning. Slike spenningsskapende grep har også vært benyttet i fjernsynsserier, og begrepet er dessuten blitt tatt i bruk i litteraturen. I Store norske leksikon. Hentet fra: http://snl.no/cliffhanger", "2018-05-04T21:19:38Z", 100722, 1, "Cliffhanger", "2018-05-27T21:10:40Z" },
                    { 109, "amendor", "jordbruk, skogbruk, fiske, fangst og utvinning", "2018-06-22T15:06:53Z", 111917, 1, "Primærnæringene", "2018-08-17T19:20:24Z" },
                    { 108, "amendor", "jordbruk, skogbruk, fiske, fangst og utvinning", "2018-06-22T15:06:53Z", 111917, 1, "Primærnæringane", "2018-08-17T19:20:24Z" },
                    { 223, "Stine Frivåg", "75’ = 75 fot = 2286 cm = 22,9 m", "2018-06-22T15:30:00Z", 137721, 1, "75'", "2018-08-17T14:21:42Z" },
                    { 222, "Stine Frivåg", "75’ = 75 fot = 2286 cm = 22,9 m", "2018-06-22T15:30:00Z", 137721, 1, "75'", "2018-08-17T14:21:42Z" },
                    { 93, "Stine Frivåg", "Korrosjon; tæring på materialer ved kjemiske eller elektrokjemiske reaksjoner med omgivelsene. Begrepet brukes særlig i forbindelse med metaller og legeringer.", "2018-06-22T15:43:15Z", 148146, 1, "Korrosjon", "2018-09-04T08:44:18Z" },
                    { 92, "Stine Frivåg", "Korrosjon; tæring på materialer ved kjemiske eller elektrokjemiske reaksjoner med omgivelsene. Begrepet brukes særlig i forbindelse med metaller og legeringer.", "2018-06-22T15:43:15Z", 148146, 1, "Korrosjon", "2018-09-04T08:44:18Z" },
                    { 209, "Sissel Paaske", "EX-beskyttelse; Elektrisk utstyr som er sikret slik at det ikke bidrar til antenning av brennbare eller eksplosive materialer på grunn av gnistdannelse. Ex-beskyttelsen kan være innpakning/isolasjon eller plassering av utstyret i overtrykkskammer slik at det ytre miljø ikke når inn til det elektriske utstyret.", "2018-06-22T15:46:09Z", 148723, 1, "EX-beskyttelse", "2018-09-04T08:43:50Z" },
                    { 208, "Sissel Paaske", "EX-beskyttelse; Elektrisk utstyr som er sikret slik at det ikke bidrar til antenning av brennbare eller eksplosive materialer på grunn av gnistdannelse. Ex-beskyttelsen kan være innpakning/isolasjon eller plassering av utstyret i overtrykkskammer slik at det ytre miljø ikke når inn til det elektriske utstyret.", "2018-06-22T15:46:09Z", 148723, 1, "EX-beskyttelse", "2018-09-04T08:43:50Z" },
                    { 381, "Sissel Paaske", "Setback (engelsk); det området som er reservert til plassering av borerør som er skrudd sammen i stands. Setback er på boredekk i et konvensjonelt boretårn og lavere plassert på ramrigg.", "2018-06-22T15:46:39Z", 149254, 1, "Setback", "2018-09-04T08:43:51Z" },
                    { 377, "amendor", "Revisor er en person som kontrollerer regnskapet på vegne av myndighetene.", "2018-05-04T21:04:59Z", 92403, 1, "Revisor ", "2018-09-04T08:44:45Z" },
                    { 227, "", "Gelstyrke er væskens evne til å stivne når den stå i ro", "2018-06-22T15:36:19Z", 142350, 1, "gelstyrke", "2018-09-04T08:43:41Z" },
                    { 4, "Sigurd Alnæs", "En feil eller en misforståelse. En bug i et dataprogram kan skyldes en feil i planen for å lage programmet. Det kan også være en feil eller misforståelse i prosedyren som programmeres.", "2018-05-04T14:10:00Z", 48019, 1, "Bug", "2018-05-04T15:00:03Z" },
                    { 2, "Sigurd Alnæs", "Hver datamaskin er laget for å ”forstå”. Det betyr at datamaskinen må være i stand til å utføre et begrenset antall handlinger og operasjoner. Slike operasjoner, eller primitiver, kalles maskinspråk. Ulike merker og modeller har forskjellig maskinspråk.", "2018-05-04T14:10:00Z", 48094, 1, "Maskinspråk", "2018-05-04T15:00:04Z" },
                    { 61, "", "Friksjon er gnidningsmotstand.", "2018-05-04T20:57:01Z", 89223, 1, "Friksjon", "2018-08-20T08:35:03Z" },
                    { 58, "", "veltilpassa", "2018-05-04T20:13:25Z", 172496, 1, "angepasst", "2018-09-04T06:24:39Z" },
                    { 57, "", "veltilpassa", "2018-05-04T20:13:25Z", 172496, 1, "angepasst", "2018-09-04T06:24:39Z" },
                    { 56, "", "ikkje / ikke nødvendigvis", "2018-05-04T20:13:30Z", 172510, 1, "nicht unbedingt", "2018-09-04T06:24:37Z" },
                    { 55, "", "ikke / ikkje nødvendigvis", "2018-05-04T20:13:30Z", 172510, 1, "nicht unbedingt", "2018-09-04T06:24:37Z" },
                    { 54, "", "fødde / født mellom 1985 og 2000", "2018-05-04T20:13:30Z", 172512, 1, "von 1985 bis 2000 geborenen", "2018-09-04T06:24:35Z" },
                    { 53, "", "født / fødde mellom 1985 og 2000", "2018-05-04T20:13:30Z", 172512, 1, "von 1985 bis 2000 geborenen", "2018-09-04T06:24:35Z" },
                    { 52, "", "når smartphonen sviktar / svikter", "2018-05-04T20:13:29Z", 172513, 1, "wenn das Smartphone ausfällt", "2018-09-04T06:24:34Z" },
                    { 51, "", "når smartphonen svikter / sviktar", "2018-05-04T20:13:29Z", 172513, 1, "wenn das Smartphone ausfällt", "2018-09-04T06:24:34Z" },
                    { 50, "", "at bedrifter \"søker jobb\" hos unge medarbeidarar / medarbeidere", "2018-05-04T20:13:29Z", 172515, 1, "dass sich Firmen bei jungen Mitarbeitern bewerben", "2018-09-04T06:24:32Z" },
                    { 49, "", "at bedrifter \"søker jobb\" hos unge medarbeidere / medarbeidarar", "2018-05-04T20:13:29Z", 172515, 1, "dass sich Firmen bei jungen Mitarbeitern bewerben", "2018-09-04T06:24:32Z" },
                    { 48, "", "strenge rangordningar / rangordninger", "2018-05-04T20:13:28Z", 172517, 1, "sturen Hierarchien", "2018-09-04T06:24:30Z" },
                    { 47, "", "strenge rangordninger / rangordningar", "2018-05-04T20:13:28Z", 172517, 1, "sturen Hierarchien", "2018-09-04T06:24:30Z" },
                    { 46, "", "heilt øvst / helt øverst på lista", "2018-05-04T20:13:27Z", 172521, 1, "ganz oben auf der Rangordnung", "2018-09-04T06:24:28Z" },
                    { 1, "Sigurd Alnæs", "Kvar datamaskin er laga for å ”forstå”. Det betyr at datamaskina må vere i stand til å utføre ei avgrensa mengd handlingar og operasjonar. Slike operasjonar, eller primitivar, kallar vi maskinspråk. Ulike merke og modellar har forskjellig maskinspråk.", "2018-05-04T14:10:00Z", 48094, 1, "Maskinspråk", "2018-05-04T15:00:04Z" },
                    { 45, "", "helt øverst / heilt øvst på lista", "2018-05-04T20:13:27Z", 172521, 1, "ganz oben auf der Rangordnung", "2018-09-04T06:24:28Z" },
                    { 39, "", "positiv holdning / haldning til deling", "2018-05-04T20:13:27Z", 172520, 1, "Sharing-Mentalität", "2018-09-04T06:24:29Z" },
                    { 38, "", "meir likeverdig enn tidlegare / mer likeverdig enn tidligere", "2018-05-04T20:13:30Z", 172499, 1, "partnerschaftlicher als früher", "2018-09-04T06:24:36Z" },
                    { 37, "", "mer likeverdig enn tidligere / meir likeverdig enn tidlegare", "2018-05-04T20:13:30Z", 172499, 1, "partnerschaftlicher als früher", "2018-09-04T06:24:36Z" },
                    { 34, "", "Til generasjon Z reknar forskarane / regner forskerne", "2018-05-04T20:13:29Z", 172514, 1, "Zur Generation Z zählen die Forscher ", "2018-09-04T06:24:33Z" },
                    { 33, "", "Til generasjon Z regner forskerne / reknar forskarane", "2018-05-04T20:13:29Z", 172514, 1, "Zur Generation Z zählen die Forscher ", "2018-09-04T06:24:33Z" },
                    { 32, "", "kombinere familie og yrke", "2018-05-04T20:13:28Z", 172519, 1, "Familie und Beruf miteinander verbinden", "2018-09-04T06:24:31Z" },
                    { 31, "", "kombinere familie og yrke", "2018-05-04T20:13:28Z", 172519, 1, "Familie und Beruf miteinander verbinden", "2018-09-04T06:24:31Z" },
                    { 30, "", "Varsling er å gå vidare med kritikkverdige forhold til nokon som kan gjere noko med det. Kritikkverdige forhold er brot på lover og reglar, brot på interne reglar eller brot på etiske normer.", "2018-05-27T22:37:00Z", 187383, 1, "Varsling", "2018-09-04T06:20:57Z" },
                    { 29, "", "Varsling er å gå videre med kritikkverdige forhold til noen som kan gjøre noe med det. Kritikkverdige forhold er brudd på lover og regler, brudd på interne regler eller brudd på etiske normer.", "2018-05-27T22:37:00Z", 187383, 1, "Varsling", "2018-09-04T06:20:57Z" },
                    { 24, "", "Ein strategi for å bryte ned problem i mindre problem. Målet er å finne alle primitivane og arbeide med dei. Sjå Primitiv. Når alle primitivane er løyste og løysingane er smelta saman på ein føremålstenleg måte, er det opphavlege overordna problemet løyst.", "2018-05-04T14:59:12Z", 48018, 1, "Bryt ned-strategi", "2018-05-04T15:00:04Z" },
                    { 23, "", "En strategi for å bryte ned problemer i mindre problemer. Målet er å finne alle primitivene og arbeide med disse. Se Primitiv. Når alle primitivene er løst og løsningene er smeltet sammen på en hensiktsmessig måte, er det opprinnelige overordnede problemet løst.", "2018-05-04T14:59:12Z", 48018, 1, "Bryt ned-strategi", "2018-05-04T15:00:04Z" },
                    { 143, "", "Ad-hoc aksjon er en aksjonsform som er tidsavgrenset og gjelder bare en sak.", "2018-06-22T15:03:16Z", 11325, 1, "Ad-hoc aksjon", "2018-08-20T10:11:28Z" },
                    { 81, "Inga Berntsen Rudi", "FN-pakten er den avtalen som etablerte organisasjonen De forente nasjoner (FN).", "2018-05-09T15:44:53Z", 60708, 1, "FN-pakten", "2018-09-04T06:47:08Z" },
                    { 80, "Inga Berntsen Rudi", "FN-pakta er den avtalen som etablerte organisasjonen Dei sameinte nasjonane (FN).", "2018-05-09T15:44:53Z", 60708, 1, "FN-pakta", "2018-09-04T06:47:08Z" },
                    { 40, "", "positiv haldning / holdning til deling", "2018-05-04T20:13:27Z", 172520, 1, "Sharing-Mentalität", "2018-09-04T06:24:29Z" },
                    { 380, "Sissel Paaske", "Setback (engelsk); det området som er reservert til plassering av borerør som er skrudd sammen i stands. Setback er på boredekk i et konvensjonelt boretårn og lavere plassert på ramrigg.", "2018-06-22T15:46:39Z", 149254, 1, "Setback", "2018-09-04T08:43:51Z" },
                    { 228, "", "Fluid (engelsk) brukes som en fellesbetegnelse for væske-, gass- og kondensatfase. Vanlig å bruke for reservoar som har flere faser eller gass som kondenserer på grunn av trykkfall.", "2018-06-22T15:36:24Z", 150090, 1, "Fluid", "2018-09-04T08:43:55Z" },
                    { 236, "", "Additiv: tilsetningsstoff.", "2018-06-22T15:36:17Z", 151879, 1, "Additiv", "2018-09-04T08:43:31Z" },
                    { 456, "", "V-døren er navnet på åpningen i boretårnet fra boredekk til rørdekk. Åpningen er formet som en opp-ned V (Λ) slik at lange rørseksjoner kan trekkes inn på boredekk ute å støte borti tårnets åpning.", "2018-06-22T15:30:45Z", 160720, 1, "V-døren", "2018-08-17T14:18:48Z" },
                    { 455, "", "V-døren er navnet på åpningen i boretårnet fra boredekk til rørdekk. Åpningen er formet som en opp ned V (Λ) slik at lange rørseksjoner kan trekkes inn på boredekk ute å støte borti tårnets åpning.", "2018-06-22T15:30:45Z", 160720, 1, "V-døren", "2018-08-17T14:18:48Z" },
                    { 454, "", "IADC- International Association of Drilling Contractors. En interesseorganisasjon som jobber for å oppnå sikkerhet og effektiv drift i oljerelatert virksomhet. Organisasjonen er særlig kjent for sin rolle innen HMS og brønnkontroll i bore- og brønnoperasjoner.", "2018-06-22T15:30:58Z", 160280, 1, "IADC", "2018-08-17T14:18:36Z" },
                    { 453, "", "IADC- International Association of Drilling Contractors. En interesseorganisasjon som jobber for å oppnå sikkerhet og effektiv drift i oljerelatert virksomhet. Organisasjonen er særlig kjent for sin rolle innen HMS og brønnkontroll i bore- og brønnoperasjoner.", "2018-06-22T15:30:58Z", 160280, 1, "IADC", "2018-08-17T14:18:36Z" },
                    { 452, "", "Kick, på norsk «brønnspark», er en innstrømning av formasjonsvæsker eller gass i brønnen som bores. Årsaken til kick er at trykket innvendig i brønnen er lavere enn trykket i formasjonen det bores i.", "2018-06-22T15:29:57Z", 141019, 1, "Kick", "2018-09-04T08:44:05Z" },
                    { 451, "", "Kick, på norsk «brønnspark», er en innstrømning av formasjonsvæsker eller gass i brønnen som bores. Årsaken til kick er at trykket innvendig i brønnen er lavere enn trykket i formasjonen det bores i.", "2018-06-22T15:29:57Z", 141019, 1, "Kick", "2018-09-04T08:44:05Z" },
                    { 436, "", "Åpning i skipsskrog eller riggskrog som gir tilgang til sjøen under boretårnet. Veggene i moonpool er isolert mot vanninntrengning.", "2018-06-22T15:30:02Z", 137718, 1, "moonpool", "2018-08-17T14:21:43Z" },
                    { 435, "", "Åpning i skipsskrog eller riggskrog som gir tilgang til sjøen under boretårnet. Veggene i moonpool er isolert mot vanninntrengning.", "2018-06-22T15:30:02Z", 137718, 1, "moonpool", "2018-08-17T14:21:43Z" },
                    { 432, "", "Flapper valve (engelsk); klaff ventil. Hengslet klaff som holdes av en lett stålfjær og lukkes mot et sete (ring). Klaffen holder tett med trykk på klaffsiden mot setet. Klaffen åpnes ved strømning eller trykk fra setesiden mot stålfjæren.", "2018-06-22T15:34:15Z", 149591, 1, "Flapper valve", "2018-09-04T08:43:27Z" },
                    { 431, "", "Flapper valve (engelsk); klaffventil. Hengslet klaff som holdes av en lett stålfjær og lukkes mot et sete (ring). Klaffen holder tett med trykk på klaffsiden mot setet. Klaffen åpnes ved strømning eller trykk fra setesiden mot stålfjæren.", "2018-06-22T15:34:15Z", 149591, 1, "Flapper valve", "2018-09-04T08:43:27Z" },
                    { 430, "", "En akselerator er et verktøy som brukes sammen med jar (slagverktøy) i BHA for å gi ekstra slagkraft til jaren. Akseleratoren er fleksibel i lengderetningen og bidrar med ekstra strekk i borestrengen når det trekkes for å jare. Akseleratoren overfører strekket til jaren som bevegelsesenergi, slik at jaren kan slå fullt slag på BHA.", "2018-06-22T15:34:33Z", 149832, 1, "Akselerator", "2018-09-04T08:43:28Z" },
                    { 429, "", "En akselerator er et verktøy som brukes sammen med jar (slagverktøy) i BHA for å gi ekstra slagkraft til jaren. Akseleratoren er fleksibel i lengderetningen og bidrar med ekstra strekk i borestrengen når det trekkes for å jare. Akseleratoren overfører strekket til jaren som bevegelsesenergi, slik at jaren kan slå fullt slag på BHA.", "2018-06-22T15:34:33Z", 149832, 1, "Akselerator", "2018-09-04T08:43:28Z" },
                    { 428, "", "Å integrere er å innlemme som del av eller å innpasse i eit heile.", "2018-05-04T20:56:58Z", 89124, 1, "Integrere", "2018-08-20T08:35:27Z" },
                    { 427, "", "Å integrere betyr å innlemme som del av eller å innpasse i et hele.", "2018-05-04T20:56:58Z", 89124, 1, "Integrere ", "2018-08-20T08:35:27Z" },
                    { 426, "", "Å integrere betyr å innlemme som del av eller å innpasse i et hele.", "2018-05-04T20:56:58Z", 89124, 1, "Integrere ", "2018-08-20T08:35:27Z" },
                    { 393, "", "Ein prognose kan til dømes vere ei oversikt over korleis ei bedrift trur at økonomien deira vil sjå ut dei neste månadene, det vil seie kor store inntektene og kostnadene vil bli.", "2018-05-27T22:39:49Z", 187631, 1, "Prognose", "2018-09-04T06:21:02Z" },
                    { 392, "", "En prognose kan for eksempel være en oversikt over hvordan en bedrift tror at økonomien dens vil se ut de neste månedene, det vil si hvor store inntektene og kostnadene vil bli.", "2018-05-27T22:39:49Z", 187631, 1, "Prognose", "2018-09-04T06:21:02Z" },
                    { 391, "", "Statisk: er i ro, stillestående, i likevekt.", "2018-06-22T15:36:19Z", 151877, 1, "Statisk", "2018-09-04T08:43:39Z" },
                    { 390, "", "Statisk: er i ro, stillestående, i likevekt.", "2018-06-22T15:36:19Z", 151877, 1, "Statisk", "2018-09-04T08:43:39Z" },
                    { 383, "", "Proaktiv vil si at en tenker fremover og er forberedt på det som skjer i fremtiden.", "2018-06-22T15:46:28Z", 148833, 1, "Proaktiv", "2018-09-04T08:43:56Z" },
                    { 382, "", "Proaktiv vil si at en tenker fremover og er forberedt på det som skjer i fremtiden.", "2018-06-22T15:46:28Z", 148833, 1, "Proaktiv", "2018-09-04T08:43:56Z" },
                    { 379, "", "Ridebelte er en sele som er designet på en slik måte at en person kan være i en sittende posisjon når en jobber i høyden.", "2018-06-22T15:46:28Z", 148834, 1, "Ridebelte", "2018-09-04T08:43:54Z" },
                    { 378, "", "Ridebelte er en sele som er utformet på en slik måte at en person kan være i sittende posisjon når han/hun jobber i høyden.", "2018-06-22T15:46:28Z", 148834, 1, "Ridebelte", "2018-09-04T08:43:54Z" },
                    { 376, "", "Ringrommet (annulus på engelsk) er området mellom to rør som står inni hverandre. I borefasen er området mellom borerørenes utside og brønnens innside omtalt som ringrommet. Når brønnen er ferdig komplettert kalles ringrommet mellom produksjonsrør og nærmeste foringsrør A-annulus, neste ringrom mellom to foringsrør B-annulus og så videre.", "2018-06-22T15:33:27Z", 162509, 1, "Ringrom", "2018-09-04T08:44:14Z" },
                    { 375, "", "Ringrommet (annulus på engelsk) er området mellom to rør som står inni hverandre. I borefasen er området mellom borerørenes utside og brønnens innside omtalt som ringrommet. Når brønnen er ferdig komplettert, kalles ringrommet mellom produksjonsrør og nærmeste foringsrør A-annulus, neste ringrom mellom to foringsrør B-annulus og så videre.", "2018-06-22T15:33:27Z", 162509, 1, "Ringrom", "2018-09-04T08:44:14Z" },
                    { 370, "", "LWD: Logging While Drilling. Verktøy i BHA som kan logge formasjonsegenskaper som densitet, porøsitet, trykk osv. mens man borer. Sparer masse tid i kontrast til Wireline logging som kjøres etter at borestrengen er trukket ut.", "2018-06-22T15:34:30Z", 140798, 1, "LWD", "2018-09-04T08:43:35Z" },
                    { 369, "", "LWD: Logging While Drilling. Verktøy i BHA som kan logge formasjonsegenskaper som densitet, porøsitet, trykk osv. mens man borer. Sparer masse tid i kontrast til Wireline logging som kjøres etter at borestrengen er trukket ut.", "2018-06-22T15:34:30Z", 140798, 1, "LWD", "2018-09-04T08:43:35Z" },
                    { 366, "", "Meirverdiavgift er ei generell forbruksavgift på verdien som blir lagd til varer eller tenester i kvart handels- eller produksjonsledd. (Wikipedia)", "2018-05-27T22:40:09Z", 187646, 1, "Meirverdiavgift", "2018-09-04T08:45:36Z" },
                    { 365, "", "Merverdiavgift er en generell forbruksavgift på verdien som blir lagt til varer eller tjenester i hvert handels- eller produksjonsledd. (Wikipedia)", "2018-05-27T22:40:09Z", 187646, 1, "Merverdiavgift", "2018-09-04T08:45:36Z" },
                    { 457, "", "The eagle (engelsk) er en rørkrane som er montert i boretårnets framside. Kranen kan strekke seg framover (ut fra tårnet) og hente rør fra catwalken. Kranen vipper røret til vertikal posisjon inne i tårnet. Eagle brukes der catwalken ikke når fram til boredekk.", "2018-06-22T15:30:49Z", 161699, 1, "Eagle ", "2018-09-04T08:43:57Z" },
                    { 458, "", "The eagle (engelsk) er en rørkrane som er montert i boretårnets framside. Kranen kan strekke seg framover (ut fra tårnet) og hente rør fra catwalken. Kranen vipper røret til vertikal posisjon inne i tårnet. Eagle brukes der catwalken ikke når fram til boredekk.", "2018-06-22T15:30:49Z", 161699, 1, "Eagle ", "2018-09-04T08:43:57Z" },
                    { 459, "", "Pseudoplastisk betyr at viskositeten er relativt høy i stillestående form, men minker når væsken utsettes for krefter som for eksempel bevegelseskraften fra sirkulasjonspumpene.", "2018-06-22T15:39:54Z", 142346, 1, "pseudoplastisk", "2018-09-04T08:43:46Z" },
                    { 460, "", "Pseudoplastisk betyr at viskositeten er relativt høy i stillestående form, men minker når væsken utsettes for krefter som f.eks bevegelseskraften som kommer fra sirkulasjonspumpene.", "2018-06-22T15:39:54Z", 142346, 1, "pseudoplastisk", "2018-09-04T08:43:46Z" },
                    { 508, "", "Strømningsregime; beskriver fordeling og plassering av gass/væske/fast stoff som oppstår når ulike kombinasjoner av gass/væske/fast stoff strømmer sammen i en retning.", "2018-06-22T15:39:03Z", 157456, 1, "Strømningsregime", "2018-09-04T08:43:36Z" },
                    { 507, "", "Strømningsregime; beskriver fordeling og plassering av gass/væske/fast stoff som oppstår når ulike kombinasjoner av gass/væske/fast stoff strømmer sammen i en retning.", "2018-06-22T15:39:03Z", 157456, 1, "Strømningsregime", "2018-09-04T08:43:36Z" },
                    { 504, "", "Polymerer, syntetiske eller naturlige forbindelser som består av kjedeformede molekyler. Disse er bygd opp av repeterende strukturelle enheter (monomerenheter, merer) dannet av mindre molekyler (monomerer).", "2018-06-22T15:35:51Z", 148150, 1, "Polymer", "2018-09-04T08:44:09Z" },
                    { 503, "", "Polymerer; syntetiske eller naturlige forbindelser som består av kjedeformede molekyler. Disse er bygd opp av repeterende strukturelle enheter (monomerenheter, merer) dannet av mindre molekyler (monomerer).", "2018-06-22T15:35:51Z", 148150, 1, "Polymer", "2018-09-04T08:44:09Z" },
                    { 502, "", "Reaktiv formasjon er en formasjonstype som reagerer lett med væske eller salt i væsken og sveller/ekspanderer. Slik reaksjon forårsaker ofte boreproblemer og bør unngås ved valg av riktig sammensetning i borevæsken.", "2018-06-22T15:36:04Z", 153353, 1, "Reaktiv formasjon", "2018-09-04T08:43:35Z" },
                    { 501, "", "Reaktiv formasjon er en formasjonstype som reagerer lett med væske eller salt i væsken og sveller/ekspanderer. Slik reaksjon forårsaker ofte boreproblemer og bør unngås ved valg av riktig sammensetning i borevæsken.", "2018-06-22T15:36:04Z", 153353, 1, "Reaktiv formasjon", "2018-09-04T08:43:35Z" },
                    { 494, "", "Å drifte et rør betyr å kontrollere at den indre diameteren på røret tilfredsstiller kravene. Til det bruker man en drift. Dette er en stang som har nøyaktig og kontrollert ytre diameter. Driften skyves helt gjennom røret som skal kontrolleres. OD drift er på samme måte, men da brukes en utvendig rørdrift som har godkjent toleranse innvendig.", "2018-06-22T15:30:51Z", 161679, 1, "Drifte", "2018-09-04T08:44:03Z" },
                    { 493, "", "Å drifte et rør betyr å kontrollere at den indre diameteren på røret tilfredsstiller kravene. Til det bruker man en drift. Dette er en stang som har nøyaktig og kontrollert ytre diameter. Driften skyves helt gjennom røret som skal kontrolleres. OD drift er på samme måte, men da brukes en utvendig rørdrift som har godkjent toleranse innvendig.", "2018-06-22T15:30:51Z", 161679, 1, "Drifte", "2018-09-04T08:44:03Z" },
                    { 492, "", "Trippe kommer av det engelske uttrykket \"trip\" - reise. Å trippe strengen i brønnen betyr at man trekker strengen ut eller kjører den inn i brønnen. En \"roundtrip\" betyr at strengen både trekkes ut og kjøres inn igjen med kun et kortere opphold imellom.", "2018-06-22T15:34:43Z", 148139, 1, "Trippe", "2018-09-04T08:44:16Z" },
                    { 491, "", "Trippe kommer av det engelske uttrykket \"trip\" - reise. Å trippe strengen i brønnen betyr at man trekker strengen ut eller kjører den inn i brønnen. En \"roundtrip\" betyr at strengen både trekkes ut og kjøres inn igjen med kun et kortere opphold imellom.", "2018-06-22T15:34:43Z", 148139, 1, "Trippe", "2018-09-04T08:44:16Z" },
                    { 490, "", "OD (Outer Diameter). Diameteren måles på tvers i enden av røret, inkludert rørgodset.", "2018-06-22T15:33:53Z", 145679, 1, "OD", "2018-09-04T08:43:45Z" },
                    { 489, "", "OD (Outer Diameter). Diameteren måles på tvers i enden av røret, inkludert rørgodset.", "2018-06-22T15:33:53Z", 145679, 1, "OD", "2018-09-04T08:43:45Z" },
                    { 488, "", "Flerfasestrømning, transport av gass, væske og eventuelt faste stoffer i et felles rør. Strømmen fra en petroleumsbrønn som produserer både gass og olje, er et eksempel på flerfasestrømning. (SNL)", "2018-06-22T15:42:23Z", 145920, 1, "Flerfasestrømning", "2018-09-04T08:44:20Z" },
                    { 487, "", "Flerfasestrømning, transport av gass, væske og eventuelt faste stoffer i et felles rør. Strømmen fra en petroleumsbrønn som produserer både gass og olje, er et eksempel på flerfasestrømning. (SNL)", "2018-06-22T15:42:23Z", 145920, 1, "Flerfasestrømning", "2018-09-04T08:44:20Z" },
                    { 364, "", "Friskluftmaske: Maske som dekker nese og munn og som har tilført pusteluft.", "2018-06-22T15:46:15Z", 148661, 1, "Friskluftmaske", "2018-09-04T08:43:51Z" },
                    { 486, "", "BHA: Bottom Hole Assembly. Utstyr som skrus sammen og brukes nederst i bore- eller servicestrengen. Utstyret har spesielle oppgaver som f.eks. boring, logging, måling, perforering osv.", "2018-06-22T15:34:11Z", 140795, 1, "BHA", "2018-09-04T08:43:52Z" },
                    { 482, "", "Grense, området mellom to grenseverdier (f.eks høy og lav) er innenfor marginen.", "2018-06-22T15:36:45Z", 148137, 1, "Margin", "2018-09-04T08:44:03Z" },
                    { 481, "", "Grense, området mellom to grenseverdier (f.eks høy og lav) er innenfor marginen.", "2018-06-22T15:36:45Z", 148137, 1, "Margin", "2018-09-04T08:44:03Z" },
                    { 480, "", "Killmud betyr drepeslam. Det brukes når brønnen er i underbalanse i forhold til formasjonstrykket. Killmud veies opp til høyere densitet enn boreslammet og holdes klart om bord i tilfelle det blir behov for det. Killmud sirkuleres inn i brønnen for å gjenopprette balanse mot formasjonstrykket.", "2018-06-22T15:31:05Z", 149356, 1, "Killmud", "2018-08-17T14:19:55Z" },
                    { 479, "", "Killmud betyr drepeslam. Det brukes når brønnen er i underbalanse i forhold til formasjonstrykket. Killmud veies opp til høyere densitet enn boreslammet og holdes klart om bord i tilfelle det blir behov for det. Killmud sirkuleres inn i brønnen for å gjenopprette balanse mot formasjonstrykket.", "2018-06-22T15:31:05Z", 149356, 1, "Killmud", "2018-08-17T14:19:55Z" },
                    { 476, "", "Links (engelsk). Lenker (to) som brukes som forlengere for å henge elevator eller tilsvarende under top drive eller i kroken under løpeblokken. Et annet ord for links på englsk er bails, som er omskrevet til «beiler» på norsk. Links er utformet som en stålstang med løkker (øye) i hver ende. Links leveres med ulike lengder og løftebegrensninger etter bestilling.", "2018-06-22T15:30:47Z", 160712, 1, "Links", "2018-08-17T14:18:52Z" },
                    { 475, "", "Links (engelsk). To lenker som brukes som forlengere for å henge elevator eller tilsvarende under top drive eller i kroken under løpeblokken. Et annet ord for links på englsk er bails, som er omskrevet til «beiler» på norsk. Linksene er utformet som en stålstang med løkker (øye) i hver ende. De leveres med ulike lengder og løftebegrensninger etter bestilling.", "2018-06-22T15:30:47Z", 160712, 1, "Links", "2018-08-17T14:18:52Z" },
                    { 474, "", "Pipedeck er et dekkområde utenfor boredekk der det oppbevares alle typer borerør og annet utstyr som skal brukes i forbindelse med bore- og brønnoperasjoner.", "2018-06-22T15:46:33Z", 148637, 1, "Pipedeck ", "2018-09-04T08:43:54Z" },
                    { 473, "", "Pipedeck er et dekkområde utenfor boredekk der det oppbevares alle typer borerør og annet utstyr som skal brukes i forbindelse med bore- og brønnoperasjoner.", "2018-06-22T15:46:33Z", 148637, 1, "Pipedeck ", "2018-09-04T08:43:54Z" },
                    { 472, "", "Stand (engelsk) er to eller flere borerør som er skrudd sammen. Det er vanlig med to lange eller tre middels lange rør. Et stand plasseres i fingerbordet mellom bruk. Innkjøring og uttrekking av borerørene er mer effektiv når kun hver andre eller hver tredje gjengeforbindelse brukes.", "2018-06-22T15:30:46Z", 160716, 1, "Stand", "2018-09-04T08:43:33Z" },
                    { 471, "", "Stand (engelsk) er to eller flere borerør som er skrudd sammen. Det er vanlig med to lange eller tre middels lange rør. Et stand plasseres i fingerbordet mellom bruk. Innkjøring og uttrekking av borerørene er mer effektivt når kun hver andre eller hver tredje gjengeforbindelse brukes.", "2018-06-22T15:30:46Z", 160716, 1, "Stand", "2018-09-04T08:43:33Z" },
                    { 468, "", "Skin er engelsk og beskriver formasjonsskade som er påført i nær-brønn området på grunn av bore- eller kompletteringsvæske eller mekanisk skade fra bore- eller kompletteringsutstyr. Skin er redusert permeabilitet.", "2018-06-22T15:35:23Z", 153513, 1, "Skin - formasjonsskade", "2018-09-04T08:43:39Z" },
                    { 467, "", "Skin er engelsk og beskriver formasjonsskade som er påført i nær-brønn området på grunn av bore- eller kompletteringsvæske eller mekanisk skade fra bore- eller kompletteringsutstyr. Skin er redusert permeabilitet.", "2018-06-22T15:35:23Z", 153513, 1, "Skin - formasjonsskade", "2018-09-04T08:43:39Z" },
                    { 462, "", "SJA - sikker jobb analyse; dokument og prosess som brukes for å identifisere faremomenter i deler av, eller hele, arbeidsoppdraget. SJA kan medføre endring i AT eller AO før arbeidet kan startes.", "2018-06-22T15:46:16Z", 148745, 1, "SJA - sikker jobb analyse", "2018-09-04T08:43:56Z" },
                    { 461, "", "SJA – sikker jobb analyse; dokument og prosess som brukes for å identifisere faremomenter i deler av, eller hele, arbeidsoppdraget. SJA kan medføre endring i AT eller AO før arbeidet kan startes.", "2018-06-22T15:46:16Z", 148745, 1, "SJA - sikker jobb analyse", "2018-09-04T08:43:56Z" },
                    { 485, "", "BHA: Bottom Hole Assembly. Utstyr som skrus sammen og brukes nederst i bore- eller servicestrengen. Utstyret har spesielle oppgaver som f.eks. boring, logging, måling, perforering osv.", "2018-06-22T15:34:11Z", 140795, 1, "BHA", "2018-09-04T08:43:52Z" },
                    { 363, "", "Friskluftmaske: Maske som dekker nese og munn og som har tilført pusteluft.", "2018-06-22T15:46:15Z", 148661, 1, "Friskluftmaske", "2018-09-04T08:43:51Z" },
                    { 362, "", "Åndedrettsvern består av en maske som skal dekke munn og nese, og brukes med filter eller trykkluftflasker for å beskytte luftveiene og lungene mot uønsket gass eller partikler.", "2018-06-22T15:46:10Z", 148676, 1, "Åndedrettsvern", "2018-09-04T08:43:55Z" },
                    { 361, "", "Åndedrettsvern består av en maske som skal dekke munn og nese, og brukes med filter eller trykkluftflasker for å beskytte luftveiene og lungene mot uønsket gass eller partikler.", "2018-06-22T15:46:10Z", 148676, 1, "Åndedrettsvern", "2018-09-04T08:43:55Z" },
                    { 288, "", "Topdrive er selve boreinnretningen som vandrer opp og ned og roterer i en borerigg.", "2018-06-22T15:46:04Z", 148602, 1, "Topdrive", "2018-09-04T08:43:56Z" },
                    { 287, "", "Topdrive er selve boreinnretningen som vandrer opp og ned og roterer i en borerigg.", "2018-06-22T15:46:04Z", 148602, 1, "Topdrive", "2018-09-04T08:43:56Z" },
                    { 286, "", "Rate er en forenkling av uttrykket strømningsrate som oppgis i volum per tidsenhet (f.eks. liter/minutt).", "2018-06-22T15:42:11Z", 150245, 1, "Rate", "2018-09-04T08:43:54Z" },
                    { 285, "", "Rate er en forenkling av uttrykket strømningsrate som oppgis i volum per tidsenhet (f.eks. liter/minutt).", "2018-06-22T15:42:11Z", 150245, 1, "Rate", "2018-09-04T08:43:54Z" },
                    { 284, "", "Manifold er et rørsystem som leder væske eller gass inn fra flere grener til et sentralt punkt (manifolden) og ut til flere grener. I en manifold er det vanligvis et system av ventiler som gjør at man kan åpne og stenge til- og fra- rørene etter behov.", "2018-06-22T15:39:28Z", 150088, 1, "Manifold ", "2018-09-04T08:43:54Z" },
                    { 283, "", "Manifold er et rørsystem som leder væske eller gass inn fra flere grener til et sentralt punkt (manifolden), og derfra og ut til flere grener. I en manifold er det vanligvis et system av ventiler som gjør at man kan åpne og stenge til- og fra-rørene etter behov.", "2018-06-22T15:39:28Z", 150088, 1, "Manifold ", "2018-09-04T08:43:54Z" },
                    { 280, "", "IBOP - Internal Blow Out Preventer, er en sikringsventil som er montert i øverste del av borestrengen i Topdrive. Den skal hindre utblåsning gjennom borestrengen på overflaten. Den er automatisk og stenger dersom det oppstår trykk fra undersiden i borestrengen. Den kan også stenges via styringspanelet i Drillers Cabin. Det finnes også en egen type IBOP som kan monteres i borestrengen og føres inn i brønnen.", "2018-06-22T15:30:42Z", 158998, 1, "IBOP ", "2018-09-04T08:43:53Z" },
                    { 279, "", "IBOP - Internal Blow Out Preventer, er en sikringsventil som er montert i øverste del av borestrengen i Topdrive. Den skal hindre utblåsning gjennom borestrengen på overflaten. Den er automatisk og stenger dersom det oppstår trykk fra undersiden i borestrengen. Den kan også stenges via styringspanelet i Drillers Cabin. Det finnes også en egen type IBOP som kan monteres i borestrengen og føres inn i brønnen.", "2018-06-22T15:30:42Z", 158998, 1, "IBOP", "2018-09-04T08:43:53Z" },
                    { 276, "", "TVD; engelsk True Vertical Depth. Vertikal høyde/dybde. En brønn måles vertikalt fra RKB til TVD.", "2018-06-22T15:39:03Z", 157471, 1, "TVD", "2018-09-04T08:43:34Z" },
                    { 275, "", "TVD; engelsk True Vertical Depth. Vertikal høyde/dybde. En brønn måles vertikalt fra RKB til TVD.", "2018-06-22T15:39:03Z", 157471, 1, "TVD", "2018-09-04T08:43:34Z" },
                    { 272, "", "Surfaktant; (fra amerikansk: surface active agent, surfactant) er en kjemisk forbindelse som reduserer overflatespenningen i en væske slik at den lettere kan blandes med andre væsker. Såpe i vaskevann oppfører seg som en surfaktant slik at vannet kan løsne fett.", "2018-06-22T15:43:34Z", 148219, 1, "Surfaktant", "2018-09-04T08:44:33Z" },
                    { 271, "", "Surfaktant; (fra amerikansk: surface active agent, surfactant) er en kjemisk forbindelse som reduserer overflatespenningen i en væske slik at den lettere kan blandes med andre væsker. Såpe i vaskevann oppfører seg som en surfaktant slik at vannet kan løsne fett.", "2018-06-22T15:43:34Z", 148219, 1, "Surfaktant", "2018-09-04T08:44:33Z" },
                    { 270, "", "Nominelt filter fjerner 90% av partiklene som er større enn den gitte filtreringsstørrelsen.", "2018-06-22T15:39:52Z", 142353, 1, "nominelt", "2018-09-04T08:43:33Z" },
                    { 269, "", "Et nominelt filter fjerner 90 % av partiklene som er større enn den gitte filtreringsstørrelsen.", "2018-06-22T15:39:52Z", 142353, 1, "nominelt", "2018-09-04T08:43:33Z" },
                    { 289, "", "Korrosjonsinhibitor; tilsetningsstoff (vanligvis kjemikalier) som reduserer eller forsinker korrosjonsskade på utstyr. Tilsetningsstoffet kan danne en beskyttende film på overflaten av utstyret, eller danne kjemisk binding med skadelige stoffer i væsken.", "2018-06-22T15:43:25Z", 148193, 1, "Korrosjonsinhibitor", "2018-09-04T08:44:55Z" },
                    { 268, "", "Scale (engelsk) er kalsiumkarbonat fra formasjonsvann som følger med olje og gass fra reservoaret. På grunn av trykk- og temperaturfall fra reservoaret skilles mineraler ut fra væsken. Scale fester seg på produksjonsrørets innside. Problemet som oppstår er at rørets indre diameter blir mindre, og det påvirker produksjonen.", "2018-06-22T15:39:28Z", 150091, 1, "Scale", "2018-09-04T08:43:52Z" },
                    { 258, "", "Absolutt filter fjerner 99.98% av partiklene som er større enn den oppgitte filtreringsstørrelsen (> µ Rating)", "2018-06-22T15:39:52Z", 142352, 1, "absolutt", "2018-09-04T08:43:35Z" },
                    { 257, "", "Et absolutt filter fjerner 99,98 % av partiklene som er større enn den oppgitte filtreringsstørrelsen (> µ Rating).", "2018-06-22T15:39:52Z", 142352, 1, "absolutt", "2018-09-04T08:43:35Z" },
                    { 256, "", "Ei forskrift er ei rettsleg bindande regulering som må ha heimel i gyldig lov. Forskrifta må halde seg innanfor lovheimelen, og må ikkje vere i strid med andre lover", "2018-05-27T22:44:21Z", 188149, 1, "forskrift", "2018-09-04T08:45:05Z" },
                    { 255, "", "En forskrift er en rettslig bindende regulering som må ha hjemmel i gyldig lov. Forskriften må holde seg innenfor lovhjemmelen, og må ikke være i strid med andre lover.", "2018-05-27T22:44:21Z", 188149, 1, "forskrift", "2018-09-04T08:45:05Z" },
                    { 254, "", "Idémyldring er ein teknikk der fleire personar i eit møte kastar fram flest mogleg idear om eit tema. Alle idear blir helste velkomne utan kritikk. Først seinare går vi kritisk gjennom dei ideane som er komne fram.", "2018-05-04T20:57:48Z", 91118, 1, "Idémyldringsteknikkar", "2018-09-04T06:40:16Z" },
                    { 253, "", "Idémyldring er en teknikk der flere personer i et møte kaster fram så mange ideer som overhodet mulig om et tema. Alle ideer mottas uten kritikk. Først seinere tar vi en kritisk gjennomgang av ideene som ble fremmet.", "2018-05-04T20:57:48Z", 91118, 1, "Idémyldringsteknikker", "2018-09-04T06:40:16Z" },
                    { 252, "", "Idémyldring er ein teknikk der fleire personar i eit møte kastar fram flest mogleg idear om eit tema. Alle idear blir helste velkomne utan kritikk. Først seinare går vi kritisk gjennom dei ideane som er komne fram.", "2018-05-04T20:57:48Z", 91118, 1, "Idémyldring", "2018-09-04T06:40:16Z" },
                    { 245, "", "Koalescerplater har en overflate som samler små dråper som tiltrekkes hverandre og danner større dråper. Når dråpene blir større faller de ned i væskefasen. Dråpenes startstørrelse kan være i væske- eller dampform.", "2018-06-22T15:39:25Z", 150195, 1, "Koalescerplater", "2018-09-04T08:43:42Z" },
                    { 244, "", "Koalescerplater har en overflate som samler små dråper som tiltrekkes hverandre og danner større dråper. Når dråpene blir større, faller de ned i væskefasen. Dråpenes startstørrelse kan være i væske- eller dampform.", "2018-06-22T15:39:25Z", 150195, 1, "Koalescerplater", "2018-09-04T08:43:42Z" },
                    { 241, "", "Pigg (engelsk: pig) er en plugg som skyves gjennom rør ved hjelp av væske som pumpes bak piggen. Differensialtrykket forskyver piggen og væsken/gassen foran denne. Piggen sendes inn i og tas ut av rørledningen i spesielle stasjoner som er koblet til rørledningen. Piggens oppgave kan være å rense røret, skrape innsiden, kalibrere (måle) innvendig diameter, osv.", "2018-06-22T15:43:24Z", 146117, 1, "Pigg", "2018-09-04T08:44:39Z" },
                    { 240, "", "Pigg (engelsk: pig) er en plugg som skyves gjennom rør ved hjelp av væske som pumpes bak piggen. Differensialtrykket forskyver piggen og væsken/gassen foran denne. Piggen sendes inn i og tas ut av rørledningen i spesielle stasjoner som er koblet til rørledningen. Piggens oppgave kan være å rense røret, skrape innsiden, kalibrere (måle) innvendig diameter, osv.", "2018-06-22T15:43:24Z", 146117, 1, "Pigg", "2018-09-04T08:44:39Z" },
                    { 239, "", "Ein kravspesifikasjon er dei krava som blir stilte til eit produkt. Når ein ber om eit anbod, er det vanleg å stille visse krav til produktet. Gjeld det til dømes mat til ein polekspedisjon, stiller ein krav om haldbarheit og næringsinnhald.", "2018-05-27T22:24:27Z", 186758, 1, "Kravspesifikasjon", "2018-09-04T08:44:47Z" },
                    { 238, "", "En kravspesifikasjon er de kravene som stilles til et produkt. Når man ber om et anbud, er det vanlig å stille visse krav til produktet. Er det for eksempel mat til en polekspedisjon, stilles det krav om holdbarhet og næringsinnhold.", "2018-05-27T22:24:27Z", 186758, 1, "Kravspesifikasjon", "2018-09-04T08:44:47Z" },
                    { 237, "", "Additiv: tilsetningsstoff.", "2018-06-22T15:36:17Z", 151879, 1, "Additiv", "2018-09-04T08:43:31Z" },
                    { 267, "", "Scale (engelsk) er kalsiumkarbonat fra formasjonsvann som følger med olje og gass fra reservoaret. På grunn av trykk- og temperaturfall fra reservoaret skilles mineraler ut fra væsken. Scale fester seg på produksjonsrørets innside. Problemet som oppstår er at rørets indre diameter blir mindre, og det påvirker produksjonen.", "2018-06-22T15:39:28Z", 150091, 1, "Scale", "2018-09-04T08:43:52Z" },
                    { 229, "", "Fluid (engelsk) brukes som en fellesbetegnelse for væske-, gass- og kondensatfase. Vanlig å bruke for reservoar som har flere faser eller gass som kondenserer på grunn av trykkfall.", "2018-06-22T15:36:24Z", 150090, 1, "Fluid", "2018-09-04T08:43:55Z" },
                    { 290, "", "Korrosjonsinhibitor; tilsetningsstoff (vanligvis kjemikalier) som reduserer eller forsinker korrosjonsskade på utstyr. Tilsetningsstoffet kan danne en beskyttende film på overflaten av utstyret, eller danne kjemisk binding med skadelige stoffer i væsken.", "2018-06-22T15:43:25Z", 148193, 1, "Korrosjonsinhibitor", "2018-09-04T08:44:55Z" },
                    { 296, "", "Safety er sikkerhetslederen om bord på en plattform. Han er ansvarlig for at alt innen HMS er tilfredsstillende.", "2018-06-22T15:45:59Z", 148806, 1, "Safety", "2018-08-17T14:10:38Z" },
                    { 360, "", "Tenntemperatur forteller noe om hvilken temperatur en trenger for å skape antennelse på et material.", "2018-06-22T15:46:11Z", 148673, 1, "Tenntemperatur", "2018-09-04T08:43:59Z" },
                    { 359, "", "Tenntemperatur forteller noe om hvilken temperatur en trenger for å skape antennelse på et material.", "2018-06-22T15:46:11Z", 148673, 1, "Tenntemperatur", "2018-09-04T08:43:59Z" },
                    { 358, "", "Manrider er en personellvinsj hvor en kan kjøre en person i ridebelte opp i den høyden hvor det er arbeid som skal utføres.", "2018-06-22T15:46:27Z", 148837, 1, "Manrider", "2018-09-04T08:43:51Z" },
                    { 357, "", "Manrider er en personellvinsj hvor en kan kjøre en person i ridebelte opp i den høyden hvor det er arbeid som skal utføres.", "2018-06-22T15:46:27Z", 148837, 1, "Manrider", "2018-09-04T08:43:51Z" },
                    { 356, "", "Tennkilde er det utstyret en bruker til antennelse. Om en tenner på et stearinlys med en fyrstikk, er fyrstikken tennkilde.", "2018-06-22T15:46:11Z", 148672, 1, "Tennkilde", "2018-09-04T08:44:04Z" },
                    { 355, "", "Tennkilde er det utstyret en bruker til antennelse. Om en tenner på et stearinlys med en fyrstikk, er fyrstikken tennkilde.", "2018-06-22T15:46:11Z", 148672, 1, "Tennkilde", "2018-09-04T08:44:04Z" },
                    { 354, "", "Katodisk beskyttelse: Ved kontakt mellom forskjellige metaller i en elektrolytisk blanding (sjøvann), betegnes det metallet som er mest edelt som katode (beskyttet), det andre metallet er anode (offer).", "2018-06-22T15:43:14Z", 148149, 1, "Katodisk beskyttelse", "2018-09-04T08:44:14Z" },
                    { 353, "", "Katodisk beskyttelse: Ved kontakt mellom forskjellige metaller i en elektrolytisk blanding (sjøvann), betegnes det metallet som er mest edelt som katode (beskyttet), det andre metallet er anode (offer).", "2018-06-22T15:43:14Z", 148149, 1, "Katodisk beskyttelse", "2018-09-04T08:44:14Z" },
                    { 350, "", "Alkaner (tidl. parafiner), organiske forbindelser som bare består av karbon og hydrogen (hydrokarboner). Generell formel for alkaner er CnH2n+2. Noen av de mest kjente alkanene er metan CH4; etan C2H6; propan C3H8; butan C4H10; pentan C5H12 og heksan C6H14.", "2018-06-22T15:43:36Z", 146358, 1, "Alkaner", "2018-09-04T08:44:41Z" },
                    { 349, "", "Alkaner (tidl. parafiner), organiske forbindelser som bare består av karbon og hydrogen (hydrokarboner). Generell formel for alkaner er CnH2n+2. Noen av de mest kjente alkanene er metan CH4; etan C2H6; propan C3H8; butan C4H10; pentan C5H12 og heksan C6H14.", "2018-06-22T15:43:36Z", 146358, 1, "Alkaner", "2018-09-04T08:44:41Z" },
                    { 340, "", "BOP; Blow Out Preventor, på norsk \"utblåsningssikring\", monteres på brønnen når man skal gjennomføre bore- og brønnaktiviteter. Har flere ulike ventiler som kan stenge brønnen mot det ytre miljø (se detaljer i eget emne).", "2018-06-22T15:30:02Z", 141021, 1, "BOP", "2018-09-04T08:43:59Z" },
                    { 339, "", "BOP; Blow Out Preventor, på norsk \"utblåsningssikring\", monteres på brønnen når man skal gjennomføre bore- og brønnaktiviteter. Har flere ulike ventiler som kan stenge brønnen mot det ytre miljø (se detaljer i eget emne).", "2018-06-22T15:30:02Z", 141021, 1, "BOP", "2018-09-04T08:43:59Z" },
                    { 338, "", "Verneombud er en arbeidstaker som er valgt av sine kolleger og skal ivareta arbeidstakernes interesser i saker som angår arbeidsmiljøet. Verneombudet trer inn i saken dersom ikke arbeidstakeren selv får til en løsning. Verneombudet skal melde fra til Safety om utilfredsstillende forhold.", "2018-06-22T15:45:58Z", 148807, 1, "Verneombud", "2018-08-17T14:10:38Z" },
                    { 337, "", "Verneombud er en arbeidstaker som er valgt av sine kolleger og skal ivareta arbeidstakernes interesser i saker som angår arbeidsmiljøet. Verneombudet trer inn i saken dersom ikke arbeidstakeren selv får til en løsning. Verneombudet skal melde fra til Safety om utilfredsstillende forhold.", "2018-06-22T15:45:58Z", 148807, 1, "Verneombud", "2018-08-17T14:10:38Z" },
                    { 295, "", "Safety er sikkerhetslederen om bord på en plattform. Han er ansvarlig for at alt innen HMS er tilfredsstillende.", "2018-06-22T15:45:59Z", 148806, 1, "Safety", "2018-08-17T14:10:38Z" },
                    { 336, "", "Hydrokarboner (HC) er organisk-kjemiske forbindelser som kun består av hydrogen (H) og karbon (C). De kan være av flere typer alt etter antall hydrogen og karbon atomer, og hvordan de kjemiske bindinger i molekylene varierer.", "2018-06-22T15:46:09Z", 148678, 1, "Hydrokarboner (HC)", "2018-09-04T08:43:54Z" },
                    { 334, "", "Beskrivelse av en situasjon der en gjenstand er så tung at den ikke vil flyte opp fra bunnen i en væske", "2018-06-22T15:43:13Z", 148157, 1, "Negativ oppdrift", "2018-09-04T08:44:13Z" },
                    { 333, "", "Beskrivelse av en situasjon der en gjenstand er så tung at den ikke vil flyte opp fra bunnen i en væske", "2018-06-22T15:43:13Z", 148157, 1, "Negativ oppdrift", "2018-09-04T08:44:13Z" },
                    { 328, "", "Hydrater er isdannelse som oppstår når lette hydrokarbonforbindelser som f.eks. metangass sammen med vann kommer i et miljø med høyt trykk og lav temperatur. Hydrater opptrer som is-slush i oljeproduksjon og som is-linser i gassrør. Hydratene kan redusere produksjonen eller plugge den helt. En hydratplugg er vanskelig å løse opp, og det tilsettes derfor MEG i produksjonsløpet for å hindre hydratdannelse.", "2018-06-22T15:39:30Z", 146127, 1, "Hydrat", "2018-09-04T08:44:49Z" },
                    { 327, "", "Hydrater er isdannelse som oppstår når lette hydrokarbonforbindelser som f.eks. metangass sammen med vann kommer i et miljø med høyt trykk og lav temperatur. Hydrater opptrer som is-slush i oljeproduksjon og som is-linser i gassrør. Hydratene kan redusere produksjonen eller plugge den helt. En hydratplugg er vanskelig å løse opp, og det tilsettes derfor MEG i produksjonsløpet for å hindre hydratdannelse.", "2018-06-22T15:39:30Z", 146127, 1, "Hydrat", "2018-09-04T08:44:49Z" },
                    { 320, "", "FBE- Fusion Bonded Epoxy, (flytende plastmasse/kunstig harpiks) Masse/pulver som sprayes på en forvarmet overflate. Kan legges i flere lag for ekstra beskyttelse mot det ytre miljø.", "2018-06-22T15:43:14Z", 146248, 1, "FBE", "2018-09-04T08:44:16Z" },
                    { 319, "", "FBE- Fusion Bonded Epoxy, (flytende plastmasse/kunstig harpiks) Masse/pulver som sprayes på en forvarmet overflate. Kan legges i flere lag for ekstra beskyttelse mot det ytre miljø.", "2018-06-22T15:43:14Z", 146248, 1, "FBE", "2018-09-04T08:44:16Z" },
                    { 314, "", "Inhibere betyr å hemme eller hindre, vanligvis å hemme/hindre en kjemisk reaksjon. Ordet brukes ofte i betydningen \"å tilsette\" - for å hindre...", "2018-06-22T15:43:22Z", 146136, 1, "Inhibere", "2018-09-04T08:44:38Z" },
                    { 313, "", "Inhibere betyr å hemme eller hindre, vanligvis å hemme/hindre en kjemisk reaksjon. Ordet brukes ofte i betydningen \"å tilsette\" - for å hindre...", "2018-06-22T15:43:22Z", 146136, 1, "Inhibere", "2018-09-04T08:44:38Z" },
                    { 308, "", "Nedstrøms viser til et område etter kilden (startpunkt), i samme retning som strømmen.", "2018-06-22T15:42:08Z", 151152, 1, "Nedstrøms ", "2018-09-04T08:43:41Z" },
                    { 307, "", "Nedstrøms viser til et område etter kilden (startpunkt), i samme retning som strømmen.", "2018-06-22T15:42:08Z", 151152, 1, "Nedstrøms ", "2018-09-04T08:43:41Z" },
                    { 306, "", "MD; engelsk Measured Depth. Målt lengde/dybde. Brønnens lengde fra RKB til bunnen i hullet.", "2018-06-22T15:37:50Z", 157472, 1, "MD", "2018-09-04T08:43:47Z" },
                    { 305, "", "MD; engelsk Measured Depth. Målt lengde/dybde. Brønnens lengde fra RKB til bunnen i hullet.", "2018-06-22T15:37:50Z", 157472, 1, "MD", "2018-09-04T08:43:47Z" },
                    { 304, "", "Koalesens er en prosess der to eller flere dråper eller partikler slår seg sammen ved kontakt til å danne en enkel dråpe.", "2018-06-22T15:39:26Z", 149945, 1, "Koalesens", "2018-09-04T08:43:46Z" },
                    { 303, "", "Koalesens er en prosess der to eller flere dråper eller partikler slår seg sammen ved kontakt til å danne en enkel dråpe.", "2018-06-22T15:39:26Z", 149945, 1, "Koalesens", "2018-09-04T08:43:46Z" },
                    { 335, "", "Hydrokarboner (HC) er organisk-kjemiske forbindelser som kun består av hydrogen (H) og karbon (C). De kan være av flere typer alt etter antall hydrogen og karbon atomer, og hvordan de kjemiske bindinger i molekylene varierer.", "2018-06-22T15:46:09Z", 148678, 1, "Hydrokarbonder (HC)", "2018-09-04T08:43:54Z" },
                    { 509, "", "SIWHP, engelsk; Shut in wellhead pressure. Trykket som dannes ved brønnhodet når brønnen er stengt (ikke produserer). Trykket ved brønnhodet er resultatet av reservoartrykk minus hydrostatisk trykk i produksjonsrøret.", "2018-06-22T15:39:00Z", 156207, 1, "SIWHP", "2018-09-04T08:43:44Z" },
                    { 510, "", "SIWHP, engelsk; Shut in wellhead pressure. Trykket som dannes ved brønnhodet når brønnen er stengt (ikke produserer). Trykket ved brønnhodet er resultatet av reservoartrykk minus hydrostatisk trykk i produksjonsrøret.", "2018-06-22T15:39:00Z", 156207, 1, "SIWHP", "2018-09-04T08:43:44Z" },
                    { 450, "Sissel Paaske", "Wolframkarbid (WC) er et svært hardt metallglinsende stoff som brukes i stedet for diamanter på slipeverktøy og borekroner. Det er stabilt opp til 2800 °C, nesten like hardt som diamant, og fremstilles ved at man lar wolfram reagere med karbon ved høy temperatur.", "2018-06-22T15:34:18Z", 149587, 1, "wolframkarbid", "2018-09-04T08:43:38Z" },
                    { 311, "Sissel Paaske", "DHSV er forkortet fra Down Hole Safety Valve. Det er en ventil som monteres i øvre del av brønnen i produksjonsrøret. Ventilen holdes åpen av trykk gjennom en kontrollinje. Den er «fail safe close», som betyr at den stenger dersom trykket i kontrollinjen faller under et minimumsnivå. Ventilen er primærbarrieren i en produserende brønn.", "2018-06-22T15:37:42Z", 178527, 1, "DHSV", "2018-09-04T08:43:46Z" },
                    { 219, "Sissel Paaske", "artikulert plattform; en plattform, f.eks. for lasting til havs, som er festet til et forankringspunkt på havbunnen via et kardangledd, slik at plattformen kan gi etter for strøm og vind uten å ta skade (SNL).", "2018-06-22T15:43:44Z", 145913, 1, "artikulert", "2018-09-04T08:43:55Z" },
                    { 218, "Sissel Paaske", "artikulert plattform; en plattform, f.eks. for lasting til havs, som er festet til et forankringspunkt på havbunnen via et kardangledd, slik at plattformen kan gi etter for strøm og vind uten å ta skade (SNL).", "2018-06-22T15:43:44Z", 145913, 1, "artikulert", "2018-09-04T08:43:55Z" },
                    { 132, "", "Hovudavtalen (ofte kalla tariffavtalens del 1) er ein avtale mellom arbeidsgivarorganisasjonar og arbeidstakarorganisasjonar. Han inneheld generelle avtalepunkt om forhandlings- og samarbeidstilhøve, men seier ikkje noko om til dømes løn. Hovudavtalen kan til dømes handle om dei tilsette sin rett til informasjon, medråderett og innsyn, og sikre retten til å ha tillitsvalde som opptrer på vegner av arbeidstakarane. Han sikrar også tillitsvalde mot usakleg oppseiing og trekkjer opp kva for spelereglar som gjeld på arbeidsplassen for informasjon, samarbeid og konfliktløysing. Hovudavtalen gjeld normalt for fire år av gangen. Hovudavtalen i arbeidslivet er styrande for reguleringa av andre avtalar. Den første hovudavtalen i Noreg blei inngått i 1935 mellom LO og N.A.F. (seinare NHO). Kjelde: Wikipedia", "2018-05-09T15:21:18Z", 4228, 1, "Hovudavtalen", "2018-09-04T08:52:05Z" },
                    { 131, "", "Hovedavtalen (ofte kalt tariffavtalens del 1) er en avtale mellom arbeidsgiverorganisasjoner og arbeidstakerorganisasjoner. Den inneholder generelle bestemmelser om forhandlings- og samarbeidsforhold, men sier ikke noe om for eksempel lønn. Hovedavtalen kan for eksempel handle om de ansattes rett til informasjon, medbestemmelse og innsyn, og sikre retten til å ha tillitsvalgte som opptrer på arbeidstakernes vegne. Den sikrer også tillitsvalgte mot usaklig oppsigelse og trekker opp hvilke spilleregler som gjelder på arbeidsplassen for informasjon, samarbeid og konfliktløsning. Hovedavtalen gjelder normalt for fire år av gangen. Hovedavtalen i arbeidslivet er styrende for reguleringen av andre avtaler. Den første hovedavtalen i Norge ble inngått i 1935 mellom LO og N.A.F. (senere NHO). Kilde: Wikipedia", "2018-05-09T15:21:18Z", 4228, 1, "Hovedavtalen", "2018-09-04T08:52:05Z" },
                    { 348, "Inga Berntsen Rudi", "Assimilering tyder \"å gjere lik\". Assimilering blir gjerne forklart som ein politikk som ein stat eller ei regjering fører overfor ein språkleg og kulturell minoritet for å gjere han mest mogleg lik fleirtalet i befolkninga. I Noreg blei denne politikken ført overfor samane. Vi refererer også ofte til det som ein fornorskingsprosess.", "2018-05-04T21:29:02Z", 9710, 1, "Assimilering", "2018-09-04T08:50:57Z" },
                    { 347, "Inga Berntsen Rudi", "Assimilering betyr \"å gjøre lik\". Assimilering beskrives gjerne som en politikk som en stat eller regjering fører overfor en språklig og kulturell minoritet for å gjøre den mest mulig lik flertallet i befolkningen. I Norge ble denne politikken ført overfor samene. Vi refererer også ofte til det som en fornorskningsprosess.", "2018-05-04T21:29:02Z", 9710, 1, "Assimilering", "2018-09-04T08:50:57Z" },
                    { 464, "Inga Berntsen Rudi", "Å ratifisere ein avtale vil seie å godkjenne han, eller å gjere han gyldig. Om eit land ratifiserer ein avtale, tyder det at dei godkjenner alle sider ved han og bind seg til å følgje avtalen i eitt og alt.", "2018-06-22T14:59:33Z", 4483, 1, "Ratifisert", "2018-08-20T09:59:32Z" },
                    { 463, "Inga Berntsen Rudi", "Å ratifisere en avtale betyr å godkjenne den, eller å den gjøre gyldig. Hvis et land ratifiserer en avtale, betyr det at de godkjenner alle sider ved den og forplikter seg til å følge avtalen i ett og alt.", "2018-06-22T14:59:33Z", 4483, 1, "Ratifisert", "2018-08-20T09:59:32Z" },
                    { 466, "Inga Berntsen Rudi", "Ein konvensjon er ein avtale som også kan gå under namn som traktat eller pakt. Ofte er konvensjonar internasjonale. Ein internasjonal konvensjon er ein avtale mellom statar. Dei statane som skriv under, bind seg til å respektere avtalen. Når ein stat har skrive under på ein slik konvensjon, seier vi at staten har ratifisert konvensjonen. Da er konvensjonen folkerettsleg bindande for den staten.", "2018-06-22T14:59:34Z", 3515, 1, "Konvensjon", "2018-08-20T09:59:33Z" },
                    { 465, "Inga Berntsen Rudi", "En konvensjon er en avtale som også kan gå under navn som traktat eller pakt. Ofte er konvensjoner internasjonale. En internasjonal konvensjon er en avtale mellom stater hvor de statene som underskriver, forplikter seg til å respektere avtalen. Når en stat har skrevet under på en slik konvensjon, sier vi at staten har ratifisert konvensjonen. Da er konvensjonen folkerettslig bindende for den staten.", "2018-06-22T14:59:34Z", 3515, 1, "Konvensjon", "2018-08-20T09:59:33Z" },
                    { 417, "", "Sivil ulydnad er ei politisk aksjonsform som bryt lova, eller som er brot på andre offentlege føresegner. Lovbrota må vere ikkjevaldelege og avgrensa til ei bestemd sak.", "2018-06-22T15:03:03Z", 11301, 1, "sivil ulydnad", "2018-08-20T10:11:28Z" },
                    { 416, "", "Sivil ulydighet er en politisk aksjonsform som bryter loven, eller som er brudd på andre offentlige bestemmelser. Lovbruddene må være ikkevoldelige og avgrenset til en bestemt sak.", "2018-06-22T15:03:03Z", 11301, 1, "sivil ulydighet", "2018-08-20T10:11:28Z" },
                    { 312, "Sissel Paaske", "DHSV er forkortet fra Down Hole Safety Valve. Det er en ventil som monteres i øvre del av brønnen i produksjonsrøret. Ventilen holdes åpen av trykk gjennom en kontrollinje. Den er «fail safe close», som betyr at den stenger dersom trykket i kontrollinjen faller under et minimumsnivå. Ventilen er primærbarrieren i en produserende brønn.", "2018-06-22T15:37:42Z", 178527, 1, "DHSV", "2018-09-04T08:43:46Z" },
                    { 405, "", "Representativt demokrati er ei demokratisk styreform der dei som skal ta politiske avgjerder, er valde av folket. Representativt demokrati kallast ofte også for indirekte demokrati.", "2018-06-22T15:03:25Z", 11212, 1, "representativt demokrati", "2018-08-20T10:19:17Z" },
                    { 524, "", "Direkte demokrati tyder at folket gjennom val kan ta stilling til konkrete saker. Folkerøystingar er døme på direkte demokrati.", "2018-06-22T15:03:50Z", 11268, 1, "direkte demokrati", "2018-08-20T10:17:00Z" },
                    { 523, "", "Direkte demokrati betyr at folket gjennom valg kan ta stilling til konkrete saker. Folkeavstemninger er eksempler på direkte demokrati.", "2018-06-22T15:03:50Z", 11268, 1, "direkte demokrati", "2018-08-20T10:17:00Z" },
                    { 235, "", "Når ei regjering stiller kabinettspørsmål, tyder det at ho trugar med å gå av dersom forslaget det gjeld, ikkje blir vedteke i Stortinget.", "2018-05-09T15:17:33Z", 11257, 1, "kabinettspørsmål", "2018-09-04T08:51:48Z" },
                    { 234, "", "Når en regjering stiller kabinettspørsmål, betyr det at den truer med å gå av dersom forslaget det gjelder, ikke blir vedtatt i Stortinget.", "2018-05-09T15:17:33Z", 11257, 1, "kabinettspørsmål", "2018-09-04T08:51:48Z" },
                    { 374, "Isak Nordeng Jensen", "Ein avtale som Noreg, Island og Liechtenstein har inngått med EU for å få tollfridom for ei rekkje varer som vi ønskjer å importere eller eksportere til land innanfor EU. Landbruksprodukt og fisk er ikkje med i EØS-avtalen.", "2018-05-27T23:05:11Z", 167207, 1, "EØS-avtalen", "2018-08-20T10:26:19Z" },
                    { 373, "Isak Nordeng Jensen", "En avtale som Norge, Island og Liechtenstein har inngått med EU for å få tollfrihet for en rekke varer som vi ønsker å importere eller eksportere til land innenfor EU. Landbruksprodukter og fisk inngår ikke i EØS-avtalen.", "2018-05-27T23:05:11Z", 167207, 1, "EØS-avtalen", "2018-08-20T10:26:19Z" },
                    { 124, "Inga Berntsen Rudi", "At noko er legitimt, tyder at det er rettmessig – noko som blir godteke som lovleg eller sjølvsagt.", "2018-06-22T15:08:51Z", 9091, 1, "legitimt", "2018-08-20T10:28:45Z" },
                    { 123, "Inga Berntsen Rudi", "At noe er legitimt, betyr at det er rettmessig – noe som godtas som lovlig eller selvfølgelig.", "2018-06-22T15:08:51Z", 9091, 1, "legitimt", "2018-08-20T10:28:45Z" },
                    { 415, "Inga Berntsen Rudi", "Folkerett er rettsreglar som er bindande i forholdet mellom statar. Ein reknar også med at einskildpersonar (individ) og internasjonale organisasjonar kan vere bundne av folkeretten.", "2018-06-22T15:08:51Z", 5356, 1, "folkeretten", "2018-08-20T10:28:44Z" },
                    { 414, "Inga Berntsen Rudi", "Folkerett er rettsregler som er bindende i forholdet mellom stater. Man regner også med at enkeltpersoner (individer) og internasjonale organisasjoner kan være bundet av folkeretten.", "2018-06-22T15:08:51Z", 5356, 1, "folkeretten", "2018-08-20T10:28:44Z" },
                    { 243, "Inga Berntsen Rudi", "Ei norm er ein regel eller eit prinsipp som tillèt eller nektar ei handling eller ein handlemåte. Det er ei felles oppfatting av kva som er godteke eller ikkje i eit samfunn. Vi kan seie at ei norm er ei rettesnor for korleis vi skal oppføre oss. Normer kan vere både formelle, nedskrivne lover og reglar og uformelle og uskrivne. Til dømes har vi normer for bordskikk som ikkje er skrivne ned.", "2018-06-22T15:08:50Z", 5352, 1, "normer", "2018-08-20T10:28:43Z" },
                    { 242, "Inga Berntsen Rudi", "En norm er en regel eller et prinsipp som forbyr eller tillater en handling eller handlemåte. Det er en felles oppfattelse av hva som er godtatt eller ikke i et samfunn. Vi kan si at en norm er en rettesnor for hvordan vi skal oppføre oss. Normer kan være både formelle, nedskrevne lover og regler og uformelle og uskrevne. For eksempel har vi normer for bordskikk som ikke er skrevet ned.", "2018-06-22T15:08:50Z", 5352, 1, "normer", "2018-08-20T10:28:43Z" },
                    { 342, "Inga Berntsen Rudi", "Ein resolusjon er eit vedtak eller ei fråsegn som ei forsamling har gjort i fellesskap, og som alle medlemmene av forsamlinga stiller seg bak. Til dømes vedtek FN mange resolusjonar, særleg i Generalforsamlinga og i Tryggingsrådet. Døme på FN-resolusjonar er resolusjon 55/56 frå 2000 som etablerte ein prosess som skulle sikre at diamantar blir kjøpte frå konfliktfrie område, og resolusjon 61/255 frå 2007 som fordømte all form for fornekting av holocaust.", "2018-05-09T15:44:53Z", 61087, 1, "Resolusjon", "2018-09-04T06:47:06Z" },
                    { 404, "", "Representativt demokrati er en demokratisk styreform der de som skal ta politiske beslutninger, er valgt av folket. Representativt demokrati kalles ofte også for indirekte demokrati.", "2018-06-22T15:03:25Z", 11212, 1, "representativt demokrati", "2018-08-20T10:19:17Z" },
                    { 341, "Inga Berntsen Rudi", "En resolusjon er et vedtak eller en uttalelse som en forsamling har gjort i fellesskap, og som alle medlemmene av forsamlingen stiller seg bak. For eksempel vedtar FN mange resolusjoner, særlig i Generalforsamlingen og i Sikkerhetsrådet. Eksempler på FN-resolusjoner er resolusjon 55/56 fra 2000 som etablerte en prosess som skulle sikre at diamanter blir kjøpt fra konfliktfrie områder, og resolusjon 61/255 fra 2007 som fordømte enhver fornektelse av holocaust.", "2018-05-09T15:44:53Z", 61087, 1, "Resolusjon", "2018-09-04T06:47:06Z" },
                    { 162, "Sissel Paaske", "P/A: Plug and Abandon. Når BOP eller ventiltre skal fjernes fra brønnen (etter borefase eller produksjonsfase), må brønnen sikres med to plugger: en dyp og en grunn. I noen tilfeller er det en midlertidig plugging (temporary abandonment), andre ganger er det en permanent plugging.", "2018-06-22T15:37:43Z", 177669, 1, "P/A", "2018-09-04T08:43:46Z" },
                    { 273, "Sissel Paaske", "Å perforere en brønn vil si at det skytes flere hull i røret som skiller brønnen fra reservoaret. Perforering utføres ved hjelp av mange små eksplosiver som aktiviseres når de er kjørt inn i brønnen til riktig sted.", "2018-06-22T15:44:54Z", 177921, 1, "Perforere en brønn", "2018-09-04T08:43:52Z" },
                    { 9, "Johannes Leiknes Nag", "Brukergrensesnitt er måten maskinen og programmet kommuniserer med brukeren på. Brukergrensesnittet består av menyer og ikoner, hurtigtaster, så vel som input-enheter som tastatur og mus.", "2018-05-04T14:09:27Z", 173846, 1, "Brukergrensesnitt/UI", "2018-05-27T15:36:18Z" },
                    { 6, "Johannes Leiknes Nag", "Brukaroppleving er korleis det er å bevege seg i og bruke funksjonane i eit grensesnitt.", "2018-05-04T14:09:28Z", 173847, 1, "Brukaroppleving/UX", "2018-05-27T15:36:18Z" },
                    { 5, "Johannes Leiknes Nag", "Brukeropplevelse av hvordan det er å bevege seg i og bruke funksjonene i et grensesnitt.", "2018-05-04T14:09:28Z", 173847, 1, "Brukeropplevelse/UX", "2018-05-27T15:36:18Z" },
                    { 175, "Sissel Paaske", "Dispersjon betyr «en finfordelt spredning». Dispergeringsmidler gjør at uløselige, finknuste partikler kan spres og sveve jevnt fordelt i en væske.", "2018-06-22T15:38:14Z", 177523, 1, "Dispergeringsmiddel", "2018-09-04T08:43:58Z" },
                    { 70, "Sissel Paaske", "Å droppe vinkel i en brønn betyr å redusere vinkelen ned mot 0° (vertikal).", "2018-06-22T15:34:11Z", 149579, 1, "Droppe vinkel", "2018-09-04T08:43:33Z" },
                    { 448, "Sissel Paaske", "HPHT; high pressure high temperature. Brønner der poretrykket er over 690 bar og temperaturen er høyere enn 150 °C. Noen brønner kan være enten HP eller HT.", "2018-06-22T15:38:19Z", 177663, 1, "HPHT", "2018-09-04T08:43:41Z" },
                    { 447, "Sissel Paaske", "HPHT; high pressure high temperature. Brønner der poretrykket er over 690 bar og temperaturen er høyere enn 150 °C. Noen brønner kan være enten HP eller HT.", "2018-06-22T15:38:19Z", 177663, 1, "HPHT", "2018-09-04T08:43:41Z" },
                    { 117, "Sissel Paaske", "FIT; Formation Integrity Test. En trykktest som tester om formasjonen tåler et tilført trykk uten å lekke. FIT skal ikke teste ved hvilket trykk formasjonen sprekker.", "2018-06-22T15:37:57Z", 177664, 1, "FIT", "2018-09-04T08:44:13Z" },
                    { 116, "Sissel Paaske", "FIT; Formation Integrity Test. En trykktest som tester om formasjonen tåler et tilført trykk uten å lekke. FIT skal ikke teste ved hvilket trykk formasjonen sprekker.", "2018-06-22T15:37:57Z", 177664, 1, "FIT", "2018-09-04T08:44:13Z" },
                    { 113, "Sissel Paaske", "LOT; Leak Off Test. Trykktest av formasjonsstyrken. Trykket økes til formasjonen begynner å lekke. Trykket som oppnås er grenseverdien for belastning mot formasjonen og skal ikke overskrides i videre operasjon i brønnen.", "2018-06-22T15:38:17Z", 177667, 1, "LOT", "2018-09-04T08:43:31Z" },
                    { 112, "Sissel Paaske", "LOT; Leak Off Test. Trykktest av formasjonsstyrken. Trykket økes til formasjonen begynner å lekke. Trykket som oppnås er grenseverdien for belastning mot formasjonen og skal ikke overskrides i videre operasjon i brønnen.", "2018-06-22T15:38:17Z", 177667, 1, "LOT", "2018-09-04T08:43:31Z" },
                    { 498, "Sissel Paaske", "Kick off point (KOP) er det dypet i brønnen der vinkelen skal økes eller reduseres fra den retningen brønnen har. En brønn kan ha mange KOP, ett for hver retningsendring.", "2018-06-22T15:37:54Z", 177789, 1, "Kick off point (KOP)", "2018-09-04T08:44:01Z" },
                    { 497, "Sissel Paaske", "Kick off point (KOP) er det dypet i brønnen der vinkelen skal økes eller reduseres fra den retningen brønnen har. En brønn kan ha mange KOP, ett for hver retningsendring.", "2018-06-22T15:37:54Z", 177789, 1, "Kick off point (KOP)", "2018-09-04T08:44:01Z" },
                    { 163, "Sissel Paaske", "P/A: Plug and Abandon. Når BOP eller ventiltre skal fjernes fra brønnen (etter borefase eller produksjonsfase), må brønnen sikres med to plugger: en dyp og en grunn. I noen tilfeller er det en midlertidig plugging (temporary abandonment), andre ganger er det en permanent plugging.", "2018-06-22T15:37:43Z", 177669, 1, "P/A", "2018-09-04T08:43:46Z" },
                    { 411, "Sissel Paaske", "Riser er det engelske ordet for stigerør. Riser er en midlertidig rørforlengelse av brønnen fra brønnhodet til overflaten (rigg). Det finnes ulike typer riser: drilling riser med stor dimensjon, work-over riser med noe mindre dimensjon, og production riser som er en permanent forlengelse av brønnen.", "2018-06-22T15:37:52Z", 177831, 1, "Riser (stigerør)", "2018-09-04T08:43:55Z" },
                    { 399, "Sissel Paaske", "Roller cone bit, også kjent som rock bit, er en borekrone med tre kjegler som ruller mot formasjonen og knuser den til mindre biter. På norsk kalles den ofte rulleborekrone.", "2018-06-22T15:37:56Z", 177837, 1, "Roller cone bit", "2018-09-04T08:44:06Z" },
                    { 398, "Sissel Paaske", "Roller cone bit, også kjent som rock bit, er en borekrone med tre kjegler som ruller mot formasjonen og knuser den til mindre biter. På norsk kalles den ofte rulleborekrone.", "2018-06-22T15:37:56Z", 177837, 1, "Roller cone bit", "2018-09-04T08:44:06Z" },
                    { 421, "Sissel Paaske", "PDC-bit er engelsk forkortelse for Polycrystalline Diamond Compact. Det er en borekrone med kunstige diamanter som kutter og maler formasjonen. Den har ingen roterende deler.", "2018-06-22T15:37:48Z", 177850, 1, "PDC-bit", "2018-09-04T08:43:36Z" },
                    { 420, "Sissel Paaske", "PDC-bit er engelsk forkortelse for Polycrystalline Diamond Compact. Det er en borekrone med kunstige diamanter som kutter og maler formasjonen. Den har ingen roterende deler.", "2018-06-22T15:37:48Z", 177850, 1, "PDC-bit", "2018-09-04T08:43:36Z" },
                    { 372, "Sissel Paaske", "Pin og box er engelske uttrykk for utvendige og innvendige gjenger. Andre uttrykk er male og female: hann- og hunngjenger.", "2018-06-22T15:37:45Z", 177900, 1, "Pin og box-gjenger", "2018-09-04T08:43:30Z" },
                    { 371, "Sissel Paaske", "Pin og box er engelske uttrykk for utvendige og innvendige gjenger. Andre uttrykk er male og female: hann- og hunngjenger.", "2018-06-22T15:37:45Z", 177900, 1, "Pin og box-gjenger", "2018-09-04T08:43:30Z" },
                    { 425, "Sissel Paaske", "Svivel er en rørkobling som er delt i to med pakning i overgangen. Svivelen gjør at den ene siden av koblingen kan rotere uten at den andre enden følger med.", "2018-06-22T15:44:59Z", 177923, 1, "Svivel", "2018-09-04T08:43:56Z" },
                    { 424, "Sissel Paaske", "Svivel er en rørkobling som er delt i to med pakning i overgangen. Svivelen gjør at den ene siden av koblingen kan rotere uten at den andre enden følger med.", "2018-06-22T15:44:59Z", 177923, 1, "Svivel", "2018-09-04T08:43:56Z" },
                    { 199, "Sissel Paaske", "Fiskenakken er utformingen i den øvre delen av hver komponent. Den skal være utformet slik at det er mulig å ta tak i komponenten med et fiskevertøy og hente komponenten ut av brønnen.", "2018-06-22T15:44:46Z", 178002, 1, "Fiskenakke", "2018-09-04T08:44:04Z" },
                    { 198, "Sissel Paaske", "Fiskenakken er utformingen i den øvre delen av hver komponent. Den skal være utformet slik at det er mulig å ta tak i komponenten med et fiskevertøy og hente komponenten ut av brønnen.", "2018-06-22T15:44:46Z", 178002, 1, "Fiskenakke", "2018-09-04T08:44:04Z" },
                    { 407, "Sissel Paaske", "Assembly er engelsk og betyr montering. Ordet brukes om komponenter som monteres sammen i en lengre enhet for å brukes til boring eller brønnaktiviteter. Et assembly dokumenteres på en liste med tekst og tegning som viser hvor hver komponent er, og de ytre og indre målene.", "2018-06-22T15:41:06Z", 178004, 1, "Assembly", "2018-09-04T08:44:06Z" },
                    { 406, "Sissel Paaske", "Assembly er engelsk og betyr montering. Ordet brukes om komponenter som monteres sammen i en lengre enhet for å brukes til boring eller brønnaktiviteter. Et assembly dokumenteres på en liste med tekst og tegning som viser hvor hver komponent er, og de ytre og indre målene.", "2018-06-22T15:41:06Z", 178004, 1, "Assembly", "2018-09-04T08:44:06Z" },
                    { 274, "Sissel Paaske", "Å perforere en brønn vil si at det skytes flere hull i røret som skiller brønnen fra reservoaret. Perforering utføres ved hjelp av mange små eksplosiver som aktiviseres når de er kjørt inn i brønnen til riktig sted.", "2018-06-22T15:44:54Z", 177921, 1, "Perforere en brønn", "2018-09-04T08:43:52Z" },
                    { 410, "Sissel Paaske", "Riser er det engelske ordet for stigerør. Riser er en midlertidig rørforlengelse av brønnen fra brønnhodet til overflaten (rigg). Det finnes ulike typer riser: drilling riser med stor dimensjon, work-over riser med noe mindre dimensjon, og production riser som er en permanent forlengelse av brønnen.", "2018-06-22T15:37:52Z", 177831, 1, "Riser (stigerør)", "2018-09-04T08:43:55Z" },
                    { 115, "Inga Berntsen Rudi", "Sedvane (eller seder/skikkar) er måtar vi opptrer på som er svært vanlege, men som ikkje er fastsette i skriftlege reglar. Det er altså uskrivne reglar som er oppstått i samfunnet over tid, og som folk har retta seg etter og til dømes ser på som vanleg skikk og bruk. Sedvanerett er når ein sedvane er så innarbeidd at han til dømes kan brukast i ein dom i ei rettssak sjølv om han ikkje er skriven ned i nokon lovtekst.", "2018-06-22T15:14:48Z", 50414, 1, "sedvanerett", "2018-08-20T09:58:39Z" },
                    { 114, "Inga Berntsen Rudi", "Sedvane (eller seder/skikker) er måter vi opptrer på som er svært vanlige, men som ikke er bestemt i skriftlige regler. Det er altså uskrevne regler som er oppstått i samfunnet over tid, og som folk har rettet seg etter og for eksempel ser på som vanlig skikk og bruk. Sedvanerett er når en sedvane er så innarbeidet at den for eksempel kan brukes i en dom i en rettssak selv om den ikke er skrevet ned i noen lovtekst.", "2018-06-22T15:14:48Z", 50414, 1, "sedvanerett", "2018-08-20T09:58:39Z" },
                    { 147, "Inga Berntsen Rudi", "Å ratifisere er når eit land godkjenner ein avtale, til dømes ein konvensjon. Når ein avtale er ratifisert, er han bindande. Dei landa som har ratifisert ein avtale, har altså forplikta seg til å følgje han.", "2018-06-22T15:14:47Z", 50204, 1, "ratifiserte", "2018-08-20T09:58:38Z" },
                    { 217, "", "Spørjetime er eit møte på Stortinget der stortingsrepresentantane kan stille spørsmål til statsrådane. Spørjetimen blir normalt halden kvar onsdag. I den munnlege spørjetimen svarer statsrådane spontant på spørsmål dei ikkje har fått høyre på førehand. Til vanleg møter to til tre statsrådar til den munnlege spørjetimen. I den ordinære spørjetimen svarer statsrådane på spørsmål som er blitt leverte inn av representantane seinast fredagen veka før, og som statsrådane dermed har førebudd seg på.", "2018-06-22T15:02:27Z", 11284, 1, "Spørjetime", "2018-08-20T10:16:45Z" },
                    { 216, "", "Spørretime er et møte på Stortinget der stortingsrepresentantene kan stille spørsmål til statsrådene. Spørretimen holdes normalt hver onsdag. I den muntlige spørretimen svarer statsrådene spontant på spørsmål de ikke har fått høre på forhånd. Vanligvis møter to til tre statsråder til den muntlige spørretimen. I den ordinære spørretimen besvares spørsmål som er blitt innlevert av representantene senest fredagen uken før, og som statsrådene dermed har forberedt seg på.", "2018-06-22T15:02:27Z", 11284, 1, "Spørretime", "2018-08-20T10:16:45Z" },
                    { 101, "", "Nesten alle saker som skal takast opp på Stortinget, blir først handsama i ein fagkomité. Fagkomiteane har ulike arbeidsområde. Alle stortingsrepresentantane sit i ein fagkomité.", "2018-06-22T15:02:29Z", 11270, 1, "Fagkomité", "2018-08-20T10:16:46Z" },
                    { 100, "", "Nesten alle saker som tas opp på Stortinget, behandles først i en fagkomité. Fagkomiteene har ulike arbeidsområder. Alle stortingsrepresentantene sitter i en fagkomité.", "2018-06-22T15:02:29Z", 11270, 1, "Fagkomité", "2018-08-20T10:16:46Z" },
                    { 526, "Liv Dagrunn Andreassen", "Pinned er engelsk og betyr at det er skrudd inn skruer som er sentrale for virkemåten. Noen skruer skal holde to deler sammen, andre skruer skal kunne deles i to med skyv- eller drakraft.", "2018-06-22T15:41:13Z", 181780, 1, "Pinned", "2018-09-04T08:43:42Z" },
                    { 525, "Liv Dagrunn Andreassen", "Pinned er engelsk og betyr at det er skrudd inn skruer som er sentrale for virkemåten. Noen skruer skal holde to deler sammen, andre skruer skal kunne deles i to med skyv- eller drakraft.", "2018-06-22T15:41:13Z", 181780, 1, "Pinned", "2018-09-04T08:43:42Z" },
                    { 500, "Sissel Paaske", "Permeabiliteten til et porøst materiale (f.eks. reservoarbergart) er et mål for gjennomstrømmeligheten i materialet. Det vil si evnen til å transportere væske eller gass fra et område til et annet område i materialet. Det er kanaler som forbinder porene i materialet. Permeabilitet måles i darcy.", "2018-06-22T15:35:22Z", 153312, 1, "Permeabilitet ", "2018-09-04T08:44:13Z" },
                    { 499, "Sissel Paaske", "Permeabiliteten til et porøst materiale (f.eks. reservoarbergart) er et mål for gjennomstrømmeligheten i materialet. Det vil si evnen til å transportere væske eller gass fra et område til et annet område i materialet. Det er kanaler som forbinder porene i materialet. Permeabilitet måles i darcy.", "2018-06-22T15:35:22Z", 153312, 1, "Permeabilitet ", "2018-09-04T08:44:13Z" },
                    { 145, "Liv Dagrunn Andreassen", "Nødavstenging av brønner deles i to nivå: NAS 2 stenger brønnene ved DHSV. NAS 1 stenger hovedgenerator og starter nødstrøm. I tillegg isoleres alt som kan bidra til eksplosjon. Nødavstenging initieres automatisk ved feil i kritiske komponenter og kan også utløses ved manuell trykknapp.", "2018-06-22T15:41:42Z", 181907, 1, "NAS (nødavstengning)", "2018-09-04T08:43:39Z" },
                    { 144, "Liv Dagrunn Andreassen", "Nødavstenging av brønner deles i to nivå: NAS 2 stenger brønnene ved DHSV. NAS 1 stenger hovedgenerator og starter nødstrøm. I tillegg isoleres alt som kan bidra til eksplosjon. Nødavstenging initieres automatisk ved feil i kritiske komponenter og kan også utløses ved manuell trykknapp.", "2018-06-22T15:41:42Z", 181907, 1, "NAS (nødavstengning)", "2018-09-04T08:43:39Z" },
                    { 195, "Sissel Paaske", "Fra engelsk heave. Hiv er den vertikale bevegelsen som skapes av bølger på et flytende objekt. Størrelsen på hiv oppgis som avstand fra bølgetopp til bølgedal.", "2018-06-22T15:32:09Z", 155890, 1, "Hiv", "2018-08-17T14:22:08Z" },
                    { 194, "Sissel Paaske", "Fra engelsk heave. Hiv er den vertikale bevegelsen som skapes av bølger mot et flytende objekt. Størrelsen på hiv oppgis som avstand fra bølgetopp til bølgedal.", "2018-06-22T15:32:09Z", 155890, 1, "Hiv", "2018-08-17T14:22:08Z" },
                    { 332, "Sissel Paaske", "API - American Petroleum Institute. API er mest kjent for arbeidet med utforming og regulering av standarder til den amerikanske olje- og gassindustrien, på samme måte som NORSOK fungerer for norsk sokkel. API standard er internasjonalt akseptert og refereres til blant annet i norske standarder. API tilbyr også godkjenning (sertifisering) og opplæring.", "2018-06-22T15:33:49Z", 160648, 1, "API", "2018-09-04T08:43:51Z" },
                    { 483, "Inga Berntsen Rudi", "En stortingssesjon er den tida stortinget sitter sammen, eller er samlet. Stortingssesjonen starter som regel i oktober og avsluttes i slutten av juni. Stortinget er altså ikke samlet på sommeren.", "2018-06-22T15:02:28Z", 51216, 1, "Stortingssesjon", "2018-08-20T10:16:45Z" },
                    { 331, "Sissel Paaske", "API - American Petroleum Institute. API er mest kjent for arbeidet med utforming og regulering av standarder til den amerikanske olje- og gassindustrien, på samme måte som NORSOK fungerer for norsk sokkel. API standard er internasjonalt akseptert og refereres til blant annet i norske standarder. API tilbyr også godkjenning (sertifisering) og opplæring.", "2018-06-22T15:33:49Z", 160648, 1, "API", "2018-09-04T08:43:51Z" },
                    { 259, "Sissel Paaske", "Kokepunktstrykk (bubble point pressure) er trykket ved en gitt temperatur som gjør at væsken (oljen) slipper ut gass fra væskeformen. Gass kan frigjøres ved at trykk/temperatur økes (vann til vanndamp) eller reduseres (uttak av olje fra reservoar). Et eksempel på norsk sokkel: ... kokepunktet for oljen målt til 6 bar under reservoartrykket ved reservoartemperatur. Reservoartrykket var 408 bar.", "2018-06-22T15:38:40Z", 153769, 1, "Kokepunktstrykk", "2018-09-04T08:43:32Z" },
                    { 512, "Sissel Paaske", "Gass- og vann-gjennombrudd beskriver situasjonen som oppstår når oljeproduksjonen går over til en ny fase med vann eller gass som følger oljen opp til overflaten. Vanngjennombrudd er et problem fordi vannet er forurenset og må behandles før det kan dumpes. Gassgjennombrudd er et problem fordi trykket i reservoaret faller dramatisk når gassen strømmer fritt ut i brønnen, noe som gjør at oljereserven blir liggende igjen i oljefellen.", "2018-06-22T15:38:46Z", 154126, 1, "Gjennombrudd", "2018-09-04T08:43:36Z" },
                    { 511, "Sissel Paaske", "Gass- og vann-gjennombrudd beskriver situasjonen som oppstår når oljeproduksjonen går over til en ny fase med vann eller gass som følger oljen opp til overflaten. Vanngjennombrudd er et problem fordi vannet er forurenset og må behandles før det kan dumpes. Gassgjennombrudd er et problem fordi trykket i reservoaret faller dramatisk når gassen strømmer fritt ut i brønnen, noe som gjør at oljereserven blir liggende igjen i oljefellen.", "2018-06-22T15:38:46Z", 154126, 1, "Gjennombrudd", "2018-09-04T08:43:36Z" },
                    { 173, "Sissel Paaske", "Nærbrønnområdet er den delen av formasjonen/bergarten som grenser til brønnen som bores.", "2018-06-22T15:35:22Z", 153313, 1, "Nærbrønnområdet ", "2018-09-04T08:43:40Z" },
                    { 172, "Sissel Paaske", "Nærbrønnområdet er den delen av formasjonen/bergarten som grenser til brønnen som bores.", "2018-06-22T15:35:22Z", 153313, 1, "Nærbrønnområdet ", "2018-09-04T08:43:40Z" },
                    { 233, "Sissel Paaske", "Agitere: å bevege, røre, uroe. Beskriver omrøring i større væskevolum som f.eks. i industrielle tankstørrelser. Agitator er en motordrevet visp.", "2018-06-22T15:36:21Z", 151862, 1, "Agitere", "2018-09-04T08:43:49Z" },
                    { 232, "Sissel Paaske", "Agitere: å bevege, røre, uroe. Beskriver omrøring i større væskevolum som f.eks. i industrielle tankstørrelser. Agitator er en motordrevet visp.", "2018-06-22T15:36:21Z", 151862, 1, "Agitere", "2018-09-04T08:43:49Z" },
                    { 446, "Yttervik Reinholdtsen Lisbeth", "En emulsjonsbryter er et stoff som kan hjelpe emulgerte stoffer å separeres fra hverandre. En emulsjon er en miks av to eller flere væsker som ikke kan blandes på vanlig måte. En normal blanding er for eksempel vann og saft, som begge er vannbaserte og blandes fullstendig sammen. Olje og vann derimot vil bestå av dråpefase i væskefase, enten som vanndråper i olje eller som oljedråper i vann.", "2018-06-22T15:35:58Z", 149947, 1, "Emulsjonsbryter", "2018-09-04T08:43:44Z" },
                    { 445, "Yttervik Reinholdtsen Lisbeth", "En emulsjonsbryter er et stoff som kan hjelpe emulgerte stoffer å separeres fra hverandre. En emulsjon er en miks av to eller flere væsker som ikke kan blandes på vanlig måte. En normal blanding er for eksempel vann og saft, som begge er vannbaserte og blandes fullstendig sammen. Olje og vann derimot vil bestå av dråpefase i væskefase, enten som vanndråper i olje eller som oljedråper i vann.", "2018-06-22T15:35:58Z", 149947, 1, "Emulsjonsbryter", "2018-09-04T08:43:44Z" },
                    { 171, "Sissel Paaske", "Produksjon ved hjelp av trykkavlasting vil si at trykket i reservoaret er drivkraften til produksjonen. Ettehvert som reservoaret tømmes, vil trykket falle og trykket ved brønnhodet synker. I senfasen vi produksjonen kreve trykkstøtte fra f.eks. injeksjon i feltet eller med pumper i brønnen.", "2018-06-22T15:42:11Z", 150238, 1, "Trykkavlasting ", "2018-09-04T08:43:56Z" },
                    { 170, "Sissel Paaske", "Produksjon ved hjelp av trykkavlasting vil si at trykket i reservoaret er drivkraften til produksjonen. Etterhvert som reservoaret tømmes, vil trykket falle og trykket ved brønnhodet synker. I senfasen vil produksjonen kreve trykkstøtte fra f.eks. injeksjon i feltet eller med pumper i brønnen.", "2018-06-22T15:42:11Z", 150238, 1, "Trykkavlasting ", "2018-09-04T08:43:56Z" },
                    { 205, "Sissel Paaske", "Transponder: fra engelsk transmitter 'sender' og respond 'svare'. Trådløs innretning som når den mottar et visst signal, automatisk sender ut et eget signal, brukes ved navigering via satellitt.", "2018-06-22T15:32:04Z", 155897, 1, "Transponder", "2018-08-17T14:22:14Z" },
                    { 204, "Sissel Paaske", "Transponder: fra engelsk transmitter 'sender' og respond 'svare'. Trådløs innretning som når den mottar et visst signal, automatisk sender ut et eget signal. Brukes ved navigering via satellitt.", "2018-06-22T15:32:04Z", 155897, 1, "Transponder", "2018-08-17T14:22:14Z" },
                    { 260, "Sissel Paaske", "Kokepunktstrykk (bubble point pressure) er trykket ved en gitt temperatur som gjør at væsken (oljen) slipper ut gass fra væskeformen. Gass kan frigjøres ved at trykk/temperatur økes (vann til vanndamp) eller reduseres (uttak av olje fra reservoar). Et eksempel på norsk sokkel: ... kokepunktet for oljen målt til 6 bar under reservoartrykket ved reservoartemperatur. Reservoartrykket var 408 bar.", "2018-06-22T15:38:40Z", 153769, 1, "Kokepunktstrykk", "2018-09-04T08:43:32Z" },
                    { 484, "Inga Berntsen Rudi", "Ein stortingssesjon er den tida stortinget sit saman, eller er samla. Stortingssesjonen startar som regel i oktober og blir avslutta i slutten av juni. Stortinget er altså ikkje samla på sommaren.", "2018-06-22T15:02:28Z", 51216, 1, "Stortingssesjon", "2018-08-20T10:16:45Z" },
                    { 517, "", "En forskrift er en detaljbestemmelse til en lov vedtatt av Stortinget. Når Stortinget vedtar loven, overlates det ofte til regjeringen å utarbeide de utfyllende detaljene. Slike detaljbestemmelser kan endres uten at loven må opp til ny behandling i Stortinget.", "2018-06-22T15:02:31Z", 11273, 1, "Forskrift", "2018-08-20T10:16:47Z" },
                    { 518, "", "Ei forskrift er ei detaljert presisering til ei lov vedteken av Stortinget. Når Stortinget vedtek lova, blir det ofte overlate til regjeringa å utarbeide dei utfyllande detaljane. Forskriftene kan endrast utan at lova må opp til ny handsaming i Stortinget.", "2018-06-22T15:02:31Z", 11273, 1, "Forskrift", "2018-08-20T10:16:47Z" },
                    { 146, "Inga Berntsen Rudi", "Å ratifisere er når et land godkjenner en avtale, for eksempel en konvensjon. Når en avtale er ratifisert, er den bindende. De landene som har ratifisert en avtale, har altså forpliktet seg til å følge den.", "2018-06-22T15:14:47Z", 50204, 1, "ratifiserte", "2018-08-20T09:58:38Z" },
                    { 324, "Inga Berntsen Rudi", "Eit valmanntal er eit oversyn over dei personane som har rett til å røyste ved eit særskilt val. Til dømes har kommune- og fylkestingsval, stortingsval og sametingsval kvar sine valmanntal.", "2018-06-22T15:14:46Z", 50418, 1, "valmanntal", "2018-08-20T09:58:36Z" },
                    { 323, "Inga Berntsen Rudi", "Et valgmanntall er en oversikt over de personene som har rett til å stemme ved et bestemt valg. For eksempel har kommune- og fylkestingsvalg, stortingsvalg og sametingsvalg hver sine valgmanntall.", "2018-06-22T15:14:46Z", 50418, 1, "valgmanntall", "2018-08-20T09:58:36Z" },
                    { 282, "Inga Berntsen Rudi", "Det er vanleg at forslag frå ulike organisasjonar og instansar, mellom andre regjeringa, blir sende ut på høyring. Det tyder at ein vil ha skriftlege reaksjonar på forslaget. Dei som forslaga blir sende ut på høyring til, blir kalla høyringsinstansar. Om til dømes regjeringa fremjar eit forslag som gjeld idrett, vil sannsynlegvis Idrettsforbundet vere ein av høyringsinstansane. Handlar forslaget om noko som vil få verknad for dei samiske områda, er Sametinget ein høyringsinstans.", "2018-06-22T15:14:45Z", 50415, 1, "høyringsinstans", "2018-08-20T09:58:36Z" },
                    { 281, "Inga Berntsen Rudi", "Det er vanlig at forslag fra forskjellige organisasjoner og instanser, blant annet regjeringen, blir sendt ut på høring. Det betyr at man vil ha skriftlige reaksjoner på forslaget. De som forslagene blir sendt ut på høring til, kalles høringsinstanser. Hvis for eksempel regjeringen fremmer et forslag som gjelder idrett, vil sannsynligvis Idrettsforbundet være en av høringsinstansene. Handler forslaget om noe som vil berøre de samiske områdene, er Sametinget en høringsinstans.", "2018-06-22T15:14:45Z", 50415, 1, "høringsinstans", "2018-08-20T09:58:36Z" },
                    { 397, "Inga Berntsen Rudi", "Det å konsultere vil seie å søkje råd hos ein fagkyndig – ein som er ekspert på eit særskilt fagområde. Når konsultasjonar går føre seg mellom to partar, til dømes Sametinget og norske styresmakter, vender dei seg til kvarandre for å spørje om råd og hjelp.", "2018-06-22T15:14:45Z", 50416, 1, "konsultasjon", "2018-08-20T09:58:35Z" },
                    { 396, "Inga Berntsen Rudi", "Det å konsultere betyr å søke råd hos en fagkyndig – en som er ekspert på et spesielt fagområde. Når det foregår konsultasjoner mellom to parter, for eksempel Sametinget og norske myndigheter, henvender de seg til hverandre for å spørre om råd og hjelp.", "2018-06-22T15:14:45Z", 50416, 1, "konsultasjon", "2018-08-20T09:58:35Z" },
                    { 385, "Inga Berntsen Rudi", "Når ein person, ein organisasjon eller eit utval får eit mandat, vil det seie at dei får eit særskilt oppdrag og fullmakt til å utføre det. Dei kan til dømes få i oppdrag å greie ut om noko (finne ut av noko) eller styre eit område. Eit mandat kan også vere eit verv.", "2018-06-22T15:04:28Z", 50417, 1, "mandat", "2018-08-20T10:18:57Z" },
                    { 384, "Inga Berntsen Rudi", "Når en person, en organisasjon eller et utvalg får et mandat, betyr det at de får et bestemt oppdrag og fullmakt til å utføre det. De kan for eksempel få i oppdrag å utrede noe (finne ut av noe) eller styre et område. Et mandat kan også være et verv.", "2018-06-22T15:04:28Z", 50417, 1, "mandat", "2018-08-20T10:18:57Z" },
                    { 344, "", "Utjevningsmandat er plasser i Stortinget som tildeles de partiene som i oppgjøret etter valget får få mandater i forhold til stemmetall. Det er 19 utjevningsmandater, ett for hvert fylke.", "2018-06-22T15:04:28Z", 11220, 1, "Utjevningsmandat", "2018-08-20T10:18:56Z" },
                    { 343, "", "Utjevningsmandat er plasser i Stortinget som tildeles de partiene som i oppgjøret etter valget får få mandater i forhold til stemmetall. Det er 19 utjevningsmandater, ett for hvert fylke.", "2018-06-22T15:04:28Z", 11220, 1, "Utjevningsmandat", "2018-08-20T10:18:56Z" },
                    { 87, "Gro-Anita Mortensen", "Ideologi er eit tankesystem som gir uttrykk for eit bestemt heilskapleg syn på samfunnet. Ideologiane søkjer å gi svar på spørsmål om kvifor samfunnet er blitt som det er, korleis det bør vere, kva for generelle mål politikken bør ha, osb.", "2018-05-04T15:54:07Z", 6699, 1, "ideologi", "2018-08-17T16:49:10Z" },
                    { 86, "Gro-Anita Mortensen", "Ideologi er et tankesystem som gir uttrykk for et bestemt helhetlig syn på samfunnet. Ideologiene søker å gi svar på spørsmål om hvorfor samfunnet er blitt som det er, hvordan det bør være, hvilke generelle mål politikken bør ha, osv.", "2018-05-04T15:54:07Z", 6699, 1, "ideologi", "2018-08-17T16:49:10Z" },
                    { 193, "", "Sosialisme er ein politisk ideologi (tankesett) som avviser privat eigedomsrett og meiner at samfunnet skal eige produksjonsmidla. Han tek avstand frå kapitalistisk maktkonsentrasjon hos eit fåtal. Målet er i staden ein statleg planøkonomi som gagnar behova til alle samfunnsmedlemene.", "2018-05-04T15:54:07Z", 11346, 1, "sosialisme", "2018-08-17T16:49:09Z" },
                    { 192, "", "Sosialisme er en politisk ideologi (tankesett) som avviser privat eiendomsrett og hevder at produksjonsmidlene skal eies av samfunnet. Den tar avstand fra en kapitalistisk maktkonsentrasjon hos et fåtall, og har i stedet som mål en statlig planøkonomi som tilgodeser alle samfunnsmedlemmenes behov.", "2018-05-04T15:54:07Z", 11346, 1, "sosialisme", "2018-08-17T16:49:09Z" },
                    { 22, "", "Liberalisme er ein politisk ideologi (tankesett) som krev politisk, religiøs og økonomisk fridom for den einskilde utan statleg innblanding.", "2018-05-04T15:54:06Z", 11345, 1, "liberalisme", "2018-08-17T16:49:06Z" },
                    { 21, "", "Liberalisme er en politisk ideologi (tankesett) som krever politisk, religiøs og økonomisk frihet for den enkelte uten statlig innblanding.", "2018-05-04T15:54:06Z", 11345, 1, "liberalisme", "2018-08-17T16:49:06Z" },
                    { 26, "", "Pragmatisme er ei haldning som inneber at ein rettar seg etter dei tilhøva som er.", "2018-05-04T15:54:05Z", 11333, 1, "pragmatisme", "2018-08-17T16:49:02Z" },
                    { 25, "", "Pragmatisme er en holdning som innebærer at en retter seg etter de forhold som er.", "2018-05-04T15:54:05Z", 11333, 1, "pragmatisme", "2018-08-17T16:49:02Z" },
                    { 434, "", "Sosialliberalisme er ein politisk ideologi (tankesett) som vil gjennomføre sosiale reformer innanfor ramma av det privatkapitalistiske systemet. I teorien er individet eit sjølvstendig vesen og samstundes sosialt avhengig. Staten bør derfor til ein viss grad regulere samfunnstilhøva, men berre slik at det blir sosialt forsvarleg med individuell utfalding.", "2018-05-04T15:54:04Z", 11347, 1, "sosialliberalisme", "2018-08-17T16:49:01Z" },
                    { 433, "", "Sosialliberalisme er en politisk ideologi (tankesett) som vil gjennomføre sosiale reformer innenfor rammen av det privatkapitalistiske systemet. I teorien er individet et selvstendig vesen og samtidig sosialt avhengig. Staten bør derfor til en viss grad regulere samfunnsforholdene, men bare slik at det blir sosialt forsvarlig med individuell utfoldelse.", "2018-05-04T15:54:04Z", 11347, 1, "sosialliberalisme", "2018-08-17T16:49:01Z" },
                    { 36, "", "Ein rettsstat er ein stat der domstolane er uavhengige av dei politiske styresmaktene, og der ingen skal kunne setjast i fengsel eller straffast utan å ha fått prøvd saka si for ein domstol.", "2018-05-04T15:54:03Z", 11213, 1, "rettsstat", "2018-08-17T16:48:58Z" },
                    { 35, "", "En rettsstat er en stat hvor domstolene er uavhengige av de politiske myndighetene, og hvor ingen skal kunne settes i fengsel eller straffes uten å ha fått prøvd saken sin for en domstol.", "2018-05-04T15:54:03Z", 11213, 1, "rettsstat", "2018-08-17T16:48:58Z" },
                    { 346, "", "Ei partigruppe er ei gruppe sett saman av alle representantane frå same politiske parti på Stortinget. Alle stortingsrepresentantane høyrer til i ei partigruppe i Stortinget.", "2018-06-22T15:02:30Z", 11280, 1, "Partigruppe", "2018-08-20T10:16:47Z" },
                    { 345, "", "Ei partigruppe er en gruppe bestående av alle representantene fra samme politiske parti på Stortinget. Alle stortingsrepresentantene tilhører en partigruppe i Stortinget.", "2018-06-22T15:02:30Z", 11280, 1, "Partigruppe", "2018-08-20T10:16:47Z" },
                    { 142, "", "Fullmaktslov er ei lov som Stortinget overlèt (delegerer) til regjeringa og forvaltinga å utforme nærmare detaljerte reglar og forskrifter til innanfor området for lova.", "2018-06-22T15:02:31Z", 11267, 1, "Fullmaktslov", "2018-08-20T10:16:48Z" },
                    { 141, "", "Fullmaktslov er en lov der Stortinget overlater (delegerer) til regjeringen og forvaltningen å utforme nærmere detaljerte regler og forskrifter innenfor lovens område.", "2018-06-22T15:02:31Z", 11267, 1, "Fullmaktslov", "2018-08-20T10:16:48Z" },
                    { 514, "", "Statsbudsjettet er eit budsjett over inntektene og utgiftene til staten. Det blir vedteke i Stortinget i slutten av kvar haustsesjon. Forslaget til statsbudsjett blir fremja av regjeringa og får alltid \"Proposisjon til Stortinget nr. 1\" (Prop. 1 S.) i namnet sitt.", "2018-06-22T15:02:27Z", 11286, 1, "Statsbudsjett", "2018-08-20T10:16:44Z" },
                    { 513, "", "Statsbudsjettet er et budsjett over statens inntekter og utgifter. Det vedtas i Stortinget i slutten av hver høstsesjon. Forslaget til statsbudsjett fremmes av regjeringen og får alltid \"Proposisjon til Stortinget nr. 1\" (Prop. 1 S.) i navnet sitt.", "2018-06-22T15:02:27Z", 11286, 1, "Statsbudsjett", "2018-08-20T10:16:44Z" },
                    { 10, "Johannes Leiknes Nag", "Brukargrensesnitt er måten maskinen og programmet kommuniserer med brukaren på. Brukargrensesnittet består av menyar og ikon, hurtigtastar, så vel som input-einingar som tastatur og mus.", "2018-05-04T14:09:27Z", 173846, 1, "Brukargrensesnitt/UI", "2018-05-27T15:36:18Z" },
                    { 72, "Johannes Leiknes Nag", "Personas er liksompersoner definert ut fra ulik alder, kjønn og interesser, som brukes for å undersøke hvordan ulike brukere opplever navigasjonen på et nettsted. Personas brukes i planlegging av nettsteder og app-er.", "2018-05-04T14:09:25Z", 173858, 1, "Personas", "2018-05-27T15:36:16Z" },
                    { 174, "Sissel Paaske", "Dispersjon betyr «en finfordelt spredning». Dispergeringsmidler gjør at uløselige, finknuste partikler kan spres og sveve jevnt fordelt i en væske.", "2018-06-22T15:38:14Z", 177523, 1, "Dispergeringsmiddel", "2018-09-04T08:43:58Z" },
                    { 11, "Johannes Leiknes Nag", "En brukersti er en forestilling om hvordan en typisk person vil komme til å bruke et nettsted, lete og finne fram. Brukerstier brukes i planlegging av nettsteder og app-er.", "2018-05-04T14:09:26Z", 173857, 1, "Brukersti", "2018-05-27T15:36:17Z" },
                    { 506, "Sissel Paaske", "Fra engelsk location. Lokasjon er stedet der installasjonen skal ligge over en brønn, eller starte brønnboring. Lokasjon har nøyaktige satellittkoordinater som brukes for å plassere en fast installasjon korrekt på feltet, for å plassere en flytende enhet før ankring, eller som referansepunkter når den skal holdes på plass med DP.", "2018-06-22T15:29:48Z", 155896, 1, "Lokasjon", "2018-08-17T14:22:13Z" },
                    { 505, "Sissel Paaske", "Fra engelsk location. Lokasjon er det stedet der installasjonen skal ligge over en brønn eller starte brønnboring. Lokasjonen har nøyaktige satellittkoordinater som brukes for å plassere en fast installasjon korrekt på feltet, for å plassere en flytende enhet før ankring, eller som referansepunkter når enheten skal holdes på plass med DP.", "2018-06-22T15:29:48Z", 155896, 1, "Lokasjon", "2018-08-17T14:22:13Z" },
                    { 134, "Inga Berntsen Rudi", "Den fruktbare halvmånen viser til eit halvbogeforma område i Midtausten der tidleg jordbruk og sivilisasjon utvikla seg, og viktige nyvinngar som skrift og hjulet kom til. Omgrepet blei skapt som The Fertile Crescent av den amerikanske arkeologen James Henry Breasted tidleg på 1900-talet. Området følgjer elvane Jordan, Eufrat og Tigris frå Levanten ved Middelhavet i vest til Mesopotamia og Persiabukta i aust. Det er avgrensa av det anatoliske høglandet i nord og Den syriske ørkenen i sør. I dag ligg statane Irak, Syria, Jordan, Libanon, Israel, Dei palestinske sjølvstyresmaktene og delar av Tyrkia og Iran i området. Ein kan også rekna Nildalen og Egypt med til området, ettersom også dette var fruktsamt og folkesett i oldtida, men jordbruk blei ikkje utvikla her. (Kjelde: Wikipedia)", "2018-05-09T14:47:38Z", 159382, 1, "Den fruktbare halvmåne", "2018-09-04T06:27:30Z" },
                    { 133, "Inga Berntsen Rudi", "Den fruktbare halvmåne viser til et halvmåneformet område i Midtøsten der tidlig jordbruk og sivilisasjoner utviklet seg, og viktige oppfinnelser som skrift og hjulet kom. Begrepet ble skapt som The Fertile Crescent av den amerikanske arkeologen James Henry Breasted tidlige på 1900-tallet. Området følger elvene Jordan, Eufrat og Tigris fra Levanten ved Middelhavet i vest til Mesopotamia og Persiabukta i øst. Det er avgrenset av det anatoliske høylandet i nord og den syriske ørkenen i sør. I dag ligger statene Irak, Syria, Jordan, Libanon, Israel, De palestinske selvstyreområene og deler av Tyrkia og Iran i området. Man kan også regne Nildalen og Egypt med til området, ettersom også dette var frukbart og folkerikt i oldtida, men jordbruk ble ikke utviklet her. (Kilde: Wikipedia)", "2018-05-09T14:47:38Z", 159382, 1, "Den fruktbare halvmåne", "2018-09-04T06:27:30Z" },
                    { 522, "Yttervik Reinholdtsen Lisbeth", "Brønnslisse: En plattform eller havbunnsramme har et begrenset antall åpninger som det kan kobles brønner opp mot. Disse åpningene er på brønnhodedekket og kalles \"slots\". På norsk brukes uttrykket slisser.", "2018-06-22T15:40:44Z", 164645, 1, "Brønnslisse", "2018-09-04T08:43:37Z" },
                    { 521, "Yttervik Reinholdtsen Lisbeth", "Brønnslisse: En plattform eller havbunnsramme har et begrenset antall åpninger som det kan kobles brønner opp mot. Disse åpningene er på brønnhodedekket og kalles \"slots\". På norsk brukes uttrykket slisser.", "2018-06-22T15:40:44Z", 164645, 1, "Brønnslisse", "2018-09-04T08:43:37Z" },
                    { 326, "Yttervik Reinholdtsen Lisbeth", "Sealbore diverter. En sealbore er et rørstykke som har en innvendig finpolert overflate. Den brukes som tetningsflate mot utvendige tetninger på rør som stikkes inn i sealboren. En sealbore diverter er skråkuttet i toppen og fungerer som en guide som skråner mot et annet løp i brønnen.", "2018-06-22T15:40:50Z", 164686, 1, "Sealbore diverter", "2018-09-04T08:43:44Z" },
                    { 325, "Yttervik Reinholdtsen Lisbeth", "Sealbore diverter. En sealbore er et rørstykke som har en innvendig finpolert overflate. Den brukes som tetningsflate mot utvendige tetninger på rør som stikkes inn i sealboren. En sealbore diverter er skråkuttet i toppen og fungerer som en guide som skråner mot et annet løp i brønnen.", "2018-06-22T15:40:50Z", 164686, 1, "Sealbore diverter", "2018-09-04T08:43:44Z" },
                    { 185, "Yttervik Reinholdtsen Lisbeth", "Svellpakning (swell packer) er et rør med utvendig gummi-element som reagerer med væske (olje eller vann) og sveller i størrelse til det tetter mot den utvendige grensen (brønnen).", "2018-06-22T15:40:49Z", 164688, 1, "Svellpakning", "2018-09-04T08:43:41Z" },
                    { 184, "Yttervik Reinholdtsen Lisbeth", "Svellpakning (swell packer) er et rør med utvendig gummi-element som reagerer med væske (olje eller vann) og sveller i størrelse til det tetter mot den utvendige grensen (brønnen).", "2018-06-22T15:40:49Z", 164688, 1, "Svellpakning", "2018-09-04T08:43:41Z" },
                    { 177, "Yttervik Reinholdtsen Lisbeth", "ICD (Inflow Control Device). En strupe-mekanisme som brukes for å redusere (regulere) innstrømningen i brønnen på et avgrenset område. Brukes ofte for å forsinke vanngjennombrudd i hælen på lange horisontale brønner. ICD kommer i ulike utgaver fra flere leverandører.", "2018-06-22T15:40:49Z", 164692, 1, "ICD (Inflow control device)", "2018-09-04T08:43:36Z" },
                    { 176, "Yttervik Reinholdtsen Lisbeth", "ICD (Inflow Control Device). En strupe-mekanisme som brukes for å redusere (regulere) innstrømningen i brønnen på et avgrenset område. Brukes ofte for å forsinke vanngjennombrudd i hælen på lange horisontale brønner. ICD kommer i ulike utgaver fra flere leverandører.", "2018-06-22T15:40:49Z", 164692, 1, "ICD (Inflow control device)", "2018-09-04T08:43:36Z" },
                    { 352, "Yttervik Reinholdtsen Lisbeth", null, "2018-06-22T15:45:33Z", 166414, 1, "Operatør", "2018-09-04T08:43:53Z" },
                    { 422, "Sissel Paaske", "Kompensere betyr å oppveie, utjevne, erstatte. Når man kompenserer for noe, retter man opp en forandring eller unøyaktighet, eller skaper en balanse. Borestrengskompensering er å lage en bevegelse som virker motsatt av de vertikale bølgebevegelsene, slik at borestrengen blir stående i ro i forhold til borehullet (brønnen).", "2018-06-22T15:32:09Z", 155856, 1, "Kompensering", "2018-08-17T14:22:08Z" },
                    { 351, "Yttervik Reinholdtsen Lisbeth", "Operatør er et fellesord som beskriver selskapet som er tildelt ansvaret for feltet eller blokken. I Norge er det alltid et oljeselskap (Statoil, ConocoPhillips, Talisman osv.) som er operatørselskapet.", "2018-06-22T15:45:33Z", 166414, 1, "Operatør", "2018-09-04T08:43:53Z" },
                    { 412, "Sissel Paaske", "Redundancy: overflødighet. Å inkludere en ekstra komponent som kan erstatte tapet av en annen uten at drift eller sikkerhet påvirkes. Offshore installeres en ekstra pumpe, et ekstra sikringspanel, et ekstra styringspanel eller annet. Disse har som oppgave å være tilgjengelige (og klar for bruk) om den komponenten som vanligvis er i bruk, feiler.", "2018-06-22T15:45:28Z", 166509, 1, "Redundancy – overflødighet", "2018-09-04T08:43:53Z" },
                    { 409, "Emily Sørensen", "Opplysningar om respondentane, som blir brukte i tillegg til informasjonen frå hovudspørsmåla når ein utfører undersøkingar. Kjønn, alder, bustad og yrke er døme på bakgrunnsvariablar.", "2018-06-22T14:57:01Z", 167152, 1, "Bakgrunnsvariabel", "2018-08-17T17:44:22Z" },
                    { 408, "Emily Sørensen", "Opplysninger om respondentene, som brukes i tillegg til informasjonen fra hovedspørsmålene når man utfører undersøkelser. Kjønn, alder, bosted og yrke er eksempler på bakgrunnsvariabler.", "2018-06-22T14:57:01Z", 167152, 1, "Bakgrunnsvariabel", "2018-08-17T17:44:22Z" },
                    { 103, "Emily Sørensen", "Utvikling av samfunnet som ikkje går ut over framtidige generasjonar sin tilgang på ressursane.", "2018-06-22T15:06:25Z", 167194, 1, "Berekraftig utvikling", "2018-08-17T19:12:48Z" },
                    { 102, "Emily Sørensen", "Utvikling av samfunnet som ikke går på bekostning av framtidige generasjoners tilgang på ressursene.", "2018-06-22T15:06:25Z", 167194, 1, "Bærekraftig utvikling", "2018-08-17T19:12:48Z" },
                    { 126, "Isak Nordeng Jensen", "Det å generalisere, det vil seie å lage allmenne reglar basert på samanlikning av enkelttilfelle. I samfunnsfag er det viktig å studere mange enkelttilfelle for å kunne generalisere.", "2018-06-22T14:57:00Z", 167214, 1, "Generalisering", "2018-08-17T17:44:21Z" },
                    { 125, "Isak Nordeng Jensen", "Å generalisere, det vil si å lage allmenne regler basert på sammenlikning av enkelttilfeller. I samfunnsfag er det viktig å studere mange enkelttilfeller for å kunne generalisere.", "2018-06-22T14:57:00Z", 167214, 1, "Generalisering", "2018-08-17T17:44:21Z" },
                    { 395, "Emily Sørensen", "Ei meining eller oppfatning som vi har gjort oss opp trass i manglande eller avgrensa kunnskap om temaet vi meiner noko om.", "2018-06-22T14:57:46Z", 167254, 1, "Fordom", "2018-08-17T16:09:52Z" },
                    { 394, "Emily Sørensen", "En mening eller oppfatning som vi har gjort oss opp på tross av manglende eller begrenset kunnskap om temaet vi mener noe om.", "2018-06-22T14:57:46Z", 167254, 1, "Fordom", "2018-08-17T16:09:52Z" },
                    { 73, "Johannes Leiknes Nag", "Personas er liksompersonar definerte ut frå ulik alder, kjønn og interesser, som blir brukte for å undersøkje korleis ulike brukarar opplever navigasjonen på ein nettstad. Personas blir brukt i planlegging av nettstader og app-ar.", "2018-05-04T14:09:25Z", 173858, 1, "Personas", "2018-05-27T15:36:16Z" },
                    { 263, "Emily Sørensen", "Forslag i en nasjonalforsamling om at en minister eller hele regjeringen ikke lenger har nasjonalforsamlingens tillit. Hvis forslaget får flertall i nasjonalforsamlingen, må ministeren eller den sittende regjeringen gå av.", "2018-06-22T15:04:14Z", 167284, 1, "Mistillitsforslag", "2018-08-20T10:15:09Z" },
                    { 387, "Emily Sørensen", "Å behandle somme menneske dårlegare enn andre på bakgrunn av kulturen, etnisiteten eller religionen deira, og ikkje på bakgrunn av handlingane deira.", "2018-06-22T14:57:45Z", 167309, 1, "Rasisme", "2018-08-17T16:09:48Z" },
                    { 386, "Emily Sørensen", "Å behandle noen mennesker dårligere enn andre på bakgrunn av deres kultur, etnisitet eller religion, og ikke på bakgrunn av deres handlinger.", "2018-06-22T14:57:45Z", 167309, 1, "Rasisme", "2018-08-17T16:09:48Z" },
                    { 413, "Sissel Paaske", "Redundancy: overflødighet. Å inkludere en ekstra komponent som kan erstatte tapet av en annen uten at drift eller sikkerhet påvirkes. Offshore installeres en ekstra pumpe, et ekstra sikringspanel, et ekstra styringspanel og så videre. Disse har som oppgave enn å være tilgjengelig (og klar for bruk) om den komponenten som vanligvis er i bruk, feiler.", "2018-06-22T15:45:28Z", 166509, 1, "Redundancy - overflødighet", "2018-09-04T08:43:53Z" },
                    { 294, "Emily Sørensen", "Sosiale prosessar som fører til at individet tileignar seg og tek opp i seg uskrivne og skrivne normer og reglar i samfunnet Primærsosialisering: sosialisering i heimen og privatsfæren Sekundærsosialisering: sosialisering i det offentlege rommet, til dømes på skulen eller på fotballaget.", "2018-06-22T14:57:47Z", 167349, 1, "Sosialisering", "2018-08-17T16:09:52Z" },
                    { 423, "Sissel Paaske", "Kompensere betyr å oppveie, utjevne, erstatte. Når man kompenserer for noe retter man opp en forandring eller unøyaktighet, eller skaper en balanse. Borestrengskompensering er å lage en bevegelse som virker motsatt av de vertikale bølgebevegelsene, slik at borestrengen blir stående i ro i forhold til borehullet (brønnen).", "2018-06-22T15:32:09Z", 155856, 1, "Kompensering", "2018-08-17T14:22:08Z" },
                    { 419, "Sissel Paaske", "Thrustere er en spesiell propell som er innfelt i skroget på den flytende enheten, ofte i siden foran og bak i fartøyet. Kalles ofte sidepropell. Brukes både til posisjonering og framdrift.", "2018-06-22T15:32:04Z", 155892, 1, "Thruster", "2018-08-17T14:22:14Z" },
                    { 449, "Sissel Paaske", "Wolframkarbid (WC) er et svært hardt metallglinsende stoff som brukes i stedet for diamanter på slipeverktøy og borekroner. Det er stabilt opp til 2800 °C, nesten like hardt som diamant, og fremstilles ved at man lar wolfram reagere med karbon ved høy temperatur.", "2018-06-22T15:34:18Z", 149587, 1, "wolframkarbid", "2018-09-04T08:43:38Z" },
                    { 262, "Sissel Paaske", "Konus er en geometrisk form bestående av en sylinder med en bred og en smal ende. Eksempel på kon-form kan være melkeglass, vaskebøtte, lampeskjerm osv. Konisiteten er et forholdstall mellom den brede enden og den smale enden.", "2018-06-22T15:34:17Z", 149589, 1, "Konus", "2018-09-04T08:43:36Z" },
                    { 261, "Sissel Paaske", "Konus er en geometrisk form bestående av en sylinder med en bred og en smal ende. Eksempel på kon-form kan være melkeglass, vaskebøtte, lampeskjerm osv. Konisiteten er et forholdstall mellom den brede enden og den smale enden.", "2018-06-22T15:34:17Z", 149589, 1, "Konus", "2018-09-04T08:43:36Z" },
                    { 169, "Sissel Paaske", "Kunstig diamant kalles ofte industriell diamant. Den lages ved høyt trykk og varme av rent karbon. Diamanten som skapes er ikke av smykkekvalitet eller -størrelse men har tilnærmet den naturlige diamantens hardhet og fungerer derfor utmerket som kutteverktøy.", "2018-06-22T15:34:16Z", 149590, 1, "Kunstig diamant", "2018-09-04T08:43:31Z" },
                    { 168, "Sissel Paaske", "Kunstig diamant kalles ofte industriell diamant. Den lages ved høyt trykk og varme av rent karbon. Diamanten som skapes er ikke av smykkekvalitet eller -størrelse, men har tilnærmet den naturlige diamantens hardhet og fungerer derfor utmerket som kutteverktøy.", "2018-06-22T15:34:16Z", 149590, 1, "Kunstig diamant", "2018-09-04T08:43:31Z" },
                    { 440, "Sissel Paaske", "Brønnhodetrykk er trykket som den produserte væsken/gassen har når den har kommet opp til brønnhodet i toppen av brønnen. På engelsk: wellhead pressure. Det opprinnelige trykket i reservoaret reduseres opp til brønnhodet på grunn av friksjon og hydrostatisk mottrykk i produksjonsrøret.", "2018-06-22T15:38:59Z", 150242, 1, "Brønnhodetrykk", "2018-09-04T08:43:58Z" },
                    { 439, "Sissel Paaske", "Brønnhodetrykk er trykket som den produserte væsken/gassen har når den er kommet opp til brønnhodet i toppen av brønnen. På engelsk: wellhead pressure. Det opprinnelige trykket i reservoaret reduseres opp til brønnhodet på grunn av friksjon og hydrostatisk mottrykk i produksjonsrøret.", "2018-06-22T15:38:59Z", 150242, 1, "Brønnhodetrykk", "2018-09-04T08:43:58Z" },
                    { 310, "Sissel Paaske", "Flottør er en lufttett kolbe som flyter på væske. Den er hengslet til en ventil som åpner/lukker når flottøren kommer til et forhåndsbestemt nivå.", "2018-06-22T15:41:59Z", 150232, 1, "Flottør ", "2018-09-04T08:43:42Z" },
                    { 309, "Sissel Paaske", "Flottør er en lufttett kolbe som flyter på væske. Den er hengslet til en ventil som åpner/lukker når flottøren kommer til et forhåndsbestemt nivå.", "2018-06-22T15:41:59Z", 150232, 1, "Flottør ", "2018-09-04T08:43:42Z" },
                    { 438, "Sissel Paaske", "Driller / borer: Boreren er utførende og ansvarlig for aktivitetene i bore- og brønnoperasjonen. Sitter i driller-bua og styrer boreutstyret.", "2018-06-22T15:46:03Z", 148684, 1, "Driller", "2018-09-04T08:43:52Z" },
                    { 437, "Sissel Paaske", "Driller / borer: Boreren er utførende og ansvarlig for aktivitetene i bore- og brønnoperasjonen. Sitter i driller-bua og styrer boreutstyret.", "2018-06-22T15:46:03Z", 148684, 1, "Driller", "2018-09-04T08:43:52Z" },
                    { 478, "Sissel Paaske", "Barriere; skal hindre eller redusere risiko for feil, fare eller ulykke. Det finnes tekniske, operasjonelle og organisatoriske barrierer. Eksempel fra hverdagen: et rekkverk på en trapp er en teknisk barriere mot fall sideveis ut av trappen, dersom brukere av trappen holder i rekkverket kan det også forhindre et fall i trappen.", "2018-06-22T15:41:39Z", 148778, 1, "Barriere", "2018-09-04T08:43:52Z" },
                    { 477, "Sissel Paaske", "Barriere; skal hindre eller redusere risiko for feil, fare eller ulykke. Det finnes tekniske, operasjonelle og organisatoriske barrierer. Eksempel fra hverdagen: et rekkverk på en trapp er en teknisk barriere mot fall sideveis ut av trappen, dersom brukere av trappen holder i rekkverket kan det også forhindre et fall i trappen.", "2018-06-22T15:41:39Z", 148778, 1, "Barriere", "2018-09-04T08:43:52Z" },
                    { 418, "Sissel Paaske", "Thrustere er spesielle propeller som er innfelt i skroget på den flytende enheten, ofte i siden foran og bak på fartøyet. Kalles ofte sidepropell. Brukes både til posisjonering og framdrift.", "2018-06-22T15:32:04Z", 155892, 1, "Thruster", "2018-08-17T14:22:14Z" },
                    { 322, "Yttervik Reinholdtsen Lisbeth", "Dobbel sikring vil si at utstyr er sikret med to uavhengige sikringer.", "2018-06-22T15:46:02Z", 148607, 1, "Dobbel sikring", "2018-09-04T08:43:55Z" },
                    { 316, "Yttervik Reinholdtsen Lisbeth", "En brannvakt skal være tilstede på arbeidsstedet og kontrollere for eventuelle branntilløp. Brannvakten har opplæring i sine oppgaver og skal være merket med vest eller lignende. Brannvakten skal være kjent med SJA.", "2018-06-22T15:46:10Z", 148674, 1, "Brannvakt", "2018-09-04T08:43:57Z" },
                    { 315, "Yttervik Reinholdtsen Lisbeth", "En brannvakt skal være tilstede på arbeidsstedet og kontrollere for eventuelle branntilløp. Brannvakten har opplæring i sine oppgaver og skal være merket med vest eller lignende. Brannvakten skal være kjent med SJA.", "2018-06-22T15:46:10Z", 148674, 1, "Brannvakt", "2018-09-04T08:43:57Z" },
                    { 318, "Yttervik Reinholdtsen Lisbeth", "Entringsvakt: Passer på personen(e) som har entret et risiko-område eller tank. Skal ha kontinuerlig kontakt med de som overvåkes.", "2018-06-22T15:46:15Z", 148658, 1, "Entringsvakt", "2018-09-04T08:43:53Z" },
                    { 317, "Yttervik Reinholdtsen Lisbeth", "Entringsvakt: Passer på personen(e) som har entret et risiko-område eller tank. Skal ha kontinuerlig kontakt med de som overvåkes.", "2018-06-22T15:46:15Z", 148658, 1, "Entringsvakt", "2018-09-04T08:43:53Z" },
                    { 191, "Sissel Paaske", "Filtrat er filtrert væske, der partikler og forurensninger blir holdt tilbake på et filter, mens væsken (filtratet) går gjennom filteret. Filtrat i forbindelse med borevæske er væsken som klarer å trenge inn i formasjonens porer, partiklene stopper på overflaten av formasjonen og danner filterkake.", "2018-06-22T15:35:52Z", 151693, 1, "Filtrat", "2018-09-04T08:43:37Z" },
                    { 190, "Sissel Paaske", "Filtrat er filtrert væske, der partikler og forurensninger blir holdt tilbake på et filter, mens væsken (filtratet) går gjennom filteret. Filtrat i forbindelse med borevæske er væsken som klarer å trenge inn i formasjonens porer, mens partiklene stopper på overflaten av formasjonen og danner filterkake.", "2018-06-22T15:35:52Z", 151693, 1, "Filtrat", "2018-09-04T08:43:37Z" },
                    { 389, "Sissel Paaske", "Filterkake dannes på overflaten av et filter når partikler fra en væske stoppes, mens væsken passerer gjennom filteret. Når filterkaken er tett, vil den hindre væske fra å strømme gjennom filteret. Filterkake i brønnen hindrer tap av borevæske inn i formasjonen.", "2018-06-22T15:35:53Z", 151694, 1, "Filterkake", "2018-09-04T08:43:34Z" },
                    { 388, "Sissel Paaske", "Filterkake dannes på overflaten av et filter når partikler fra en væske stoppes, mens væsken passerer gjennom filteret. Når filterkaken er tett, vil den hindre væske fra å strømme gjennom filteret. Filterkake i brønnen hindrer tap av borevæske inn i formasjonen.", "2018-06-22T15:35:53Z", 151694, 1, "Filterkake", "2018-09-04T08:43:34Z" },
                    { 292, "Sissel Paaske", "Flokkulering beskriver dannelse av en større masse (flokk). Brukes for å beskrive hvordan avlange leirepartikler (f.eks. i bentonittslam) binder seg til hverandre med kortside mot langside, eller langside mot langside. Konsekvensen av slik samling er økt viskositet og økt filtertap.", "2018-06-22T15:36:02Z", 153372, 1, "Flokkulering", "2018-09-04T08:43:57Z" },
                    { 291, "Sissel Paaske", "Flokkulering beskriver dannelse av en større masse (flokk). Brukes for å beskrive hvordan avlange leirepartikler (f.eks. i bentonittslam) binder seg til hverandre med kortside mot langside, eller langside mot langside. Konsekvensen av slik samling er økt viskositet og økt filtertap.", "2018-06-22T15:36:02Z", 153372, 1, "Flokkulering", "2018-09-04T08:43:57Z" },
                    { 99, "Inga Berntsen Rudi", "Prognosar eller utviklingsgang i framtida. Korleis ekspertar meiner utviklinga vil gå, til dømes innan innvandring, befolkningsvekst og økonomi.", "2018-06-22T15:07:07Z", 83591, 1, "Framskrivingar", "2018-08-17T17:14:56Z" },
                    { 98, "Inga Berntsen Rudi", "Prognoser eller utviklingsforløp i framtiden. Hvordan eksperter mener utviklingen vil gå, f.eks innen innvandring, befolkningsvekst, økonomi o.l.", "2018-06-22T15:07:07Z", 83591, 1, "Framskrivinger", "2018-08-17T17:14:56Z" },
                    { 120, "Inga Berntsen Rudi", "Etruskarane er eit folk vi veit relativt lite om. På øya Lemnos i Egeerhavet er det funne ei innskrift frå 600-talet f.Kr., på eit språk som liknar etruskisk. Nokre forskarar tolkar det som at dei hadde innvandra frå aust. Andre meiner Etruskarane var eit urfolk i Toscana. Elles har det berre blitt funne få og korte tekstar på etruskisk, der vi veit tydinga av om lag 100 ord. Det er noko av grunnen til at vi veit så lite om dei. Etruskarane hadde ein blomstringstid då Roma vart grunnlagt, men vart gradvis svekka etter kvart som den nye naboen vaks. Omtrent ved overgangen til romersk keisartid, var heile den etruskiske befolkninga latinisert.", "2018-05-09T14:49:13Z", 156327, 1, "Etruskarane", "2018-09-04T06:47:26Z" },
                    { 321, "Yttervik Reinholdtsen Lisbeth", "Dobbel sikring vil si at utstyr er sikret med to uavhengige sikringer.", "2018-06-22T15:46:02Z", 148607, 1, "Dobbel sikring", "2018-09-04T08:43:55Z" },
                    { 293, "Emily Sørensen", "Sosiale prosesser som fører til at individet tilegner seg og tar opp i seg uskrevne og skrevne normer og regler i samfunnet Primærsosialisering: sosialisering i hjemmet og privatsfæren Sekundærsosialisering: sosialisering i det offentlige rommet, for eksempel på skolen eller på fotballaget.", "2018-06-22T14:57:47Z", 167349, 1, "Sosialisering", "2018-08-17T16:09:52Z" },
                    { 264, "Emily Sørensen", "Forslag i ei nasjonalforsamling om at ein minister eller heile regjeringa ikkje lenger har tillit i nasjonalforsamlinga. Dersom forslaget får fleirtal i nasjonalforsamlinga, må ministeren eller den sitjande regjeringa gå av.", "2018-06-22T15:04:14Z", 167284, 1, "Mistillitsforslag", "2018-08-20T10:15:09Z" },
                    { 297, "Emily Sørensen", "Forskjellsbehandling som får negative konsekvenser for den eller dem det gjelder Direkte diskriminering: når en person blir behandlet dårligere enn en annen på grunn av kjønn, etnisk bakgrunn, seksuell orientering, funksjonsevne osv. Indirekte diskriminering: når en tilsynelatende nøytral praksis fører til at en person behandles dårligere enn en annen på grunn av kjønn, etnisk bakgrunn, seksuell orientering, funksjonsevne osv.", "2018-06-22T14:57:46Z", 167387, 1, "Diskriminering", "2018-08-17T16:09:49Z" },
                    { 246, "Sissel Paaske", "Choke line og kill line i BOP er linjer (rør) som går inn i BOP fra overflaten. Linjene brukes til å sirkulere væske inn og ut fra ringrommet når en ventil i BOP er stengt over koblingspunktet til choke line og kill line. Choke line brukes til utsirkulering, og kill line til innsirkulering av væske.", "2018-06-22T15:37:30Z", 174238, 1, "Choke line og kill line på BOP", "2018-09-04T08:43:58Z" },
                    { 278, "Sissel Paaske", "Sikkerhetsmargin er et tillegg over eller under et mål som gjør at man har noe spillerom før grensen er nådd.", "2018-06-22T15:37:25Z", 174241, 1, "Sikkerhetsmargin ", "2018-09-04T08:43:47Z" },
                    { 277, "Sissel Paaske", "Sikkerhetsmargin er et tillegg over eller under et mål som gjør at man har noe spillerom før grensen er nådd.", "2018-06-22T15:37:25Z", 174241, 1, "Sikkerhetsmargin ", "2018-09-04T08:43:47Z" },
                    { 298, "Emily Sørensen", "Forskjellsbehandling som får negative konsekvensar for den eller dei det gjeld Direkte diskriminering: når ein person blir behandla dårlegare enn ein annan på grunn av kjønn, etnisk bakgrunn, seksuell orientering, funksjonsevne osv. Indirekte diskriminering: når ein tilsynelatande nøytral praksis fører til at ein person blir behandla dårlegare enn ein annan på grunn av kjønn, etnisk bakgrunn, seksuell orientering, funksjonsevne osv.", "2018-06-22T14:57:46Z", 167387, 1, "Diskriminering", "2018-08-17T16:09:49Z" },
                    { 212, "Sissel Paaske", "Primærbarrieren i en brønn er den hindringen som ligger nærmest kilden (reservoaret). I forbindelse med bore- og brønnaktivitet er primærbarrieren væsken som står i brønnen. Når brønnen produserer, er det kompletteringen med sikringsventilen (DHSV) i brønnen som er primærbarrieren.", "2018-06-22T15:37:31Z", 174263, 1, "Primærbarriere", "2018-09-04T08:44:03Z" },
                    { 28, "Sigurd Alnæs", "Et problem du kan løse enkelt, raskt og nøyaktig. En ”byggestein” som du kan bruke når du skal løse mer komplekse problemer. Du deler opp hovedproblemet i mindre primitiver og løser dem enkelt. Et eksempel på en primitiv er gangetabellen. Har du lært den, slipper du å tenke på hvordan du løser 8 x 7. Du vet med en gang at det er 56. Se også", "2018-05-04T14:59:12Z", 48108, 1, "Primitiv", "2018-05-04T15:00:05Z" },
                    { 27, "Sigurd Alnæs", "Eit problem du kan løyse enkelt, raskt og nøyaktig. Ein ”byggjestein” som du kan bruke når du skal løyse meir komplekse problem. Du deler opp hovudproblemet i mindre primitivar, og løyser dei enkelt. Eit døme på ein primitiv er gongetabellen. Har du lært han, slepp du å tenkje på korleis du løyser 8 x 7. Du veit med ein gong at det er 56. Sjå òg", "2018-05-04T14:59:12Z", 48108, 1, "Primitiv", "2018-05-04T15:00:05Z" },
                    { 231, "Kristin Bøhle", "Vannmolekyler er polare. Det vil si at de har en ladningsforskyvning, men ingen netto ladning. Vannmolekyler har en positiv og negativ side (pol) fordi oksygen og hydrogen trekker ulikt på de felles elektronparene.", "2018-06-22T15:36:00Z", 134394, 1, "Polare vannmolekyler", "2018-09-04T08:43:33Z" },
                    { 230, "Kristin Bøhle", "Vassmolekyl er polare. Det vil seie at dei har ei ladningsforskyving, men ingen netto ladning. Vassmolekyl har ei positiv og ei negativ side (pol), fordi oksygen og hydrogen trekkjer ulikt på dei felles elektronpara.", "2018-06-22T15:36:00Z", 134394, 1, "Polare vassmolekyl", "2018-09-04T08:43:33Z" },
                    { 266, "Sissel Paaske", "Forvitring kommer fra det tyske ordet «Wetter» som betyr vær. På engelsk omtales forvitring som \"weathering\". Forvitring er altså nedbryting av bergarter på grunn av vær: vann, vind og temperatur.", "2018-06-22T15:28:45Z", 175244, 1, "Forvitring", "2018-08-17T14:12:47Z" },
                    { 265, "Sissel Paaske", "Forvitring kommer fra det tyske ordet «Wetter» som betyr vær. På engelsk omtales forvitring som \"weathering\". Forvitring er altså nedbryting av bergarter på grunn av vær: vann, vind og temperatur.", "2018-06-22T15:28:45Z", 175244, 1, "Forvitring", "2018-08-17T14:12:47Z" },
                    { 77, "Emily Sørensen", "Avtale mellom ei fagforeining og ein arbeidsgivar om arbeids- og lønnsvilkår. Ein tariffavtale gjeld for ein bestemt tidsperiode og er ulik frå bransje til bransje.", "2018-05-27T16:37:10Z", 167361, 1, "Tariffavtale", "2018-09-04T08:50:56Z" },
                    { 76, "Emily Sørensen", "Avtale mellom en fagforening og en arbeidsgiver om arbeids- og lønnsvilkår. En tariffavtale gjelder for en bestemt tidsperiode og er forskjellig fra bransje til bransje.", "2018-05-27T16:37:10Z", 167361, 1, "Tariffavtale", "2018-09-04T08:50:56Z" },
                    { 247, "Sissel Paaske", "Choke line og kill line i BOP er linjer (rør) som går inn i BOP fra overflaten. Linjene brukes til å sirkulere væske inn og ut fra ringrommet når en ventil i BOP er stengt over koblingspunktet til choke line og kill line. Choke line brukes til utsirkulering, og kill line til innsirkulering av væske.", "2018-06-22T15:37:30Z", 174238, 1, "Choke line og kill line på BOP", "2018-09-04T08:43:58Z" },
                    { 251, "Sissel Paaske", "Casing er engelsk og betyr fôringsrør. Rørene skrus sammen og brukes til å sikre borehullet. Casingen går helt opp i brønnen. For hver nye seksjon som bores ut, installeres en mindre casing innvendig i den forrige. Casing sementeres i nederste del. Casing skilles fra andre rør på størrelsen, mindre rør kalles tubing på engelsk.", "2018-06-22T15:37:45Z", 175426, 1, "Casing", "2018-09-04T08:44:14Z" },
                    { 91, "Sissel Paaske", "Delta dannes av elveavsetninger (elvedelta, elveos). I området der elven ender i stillestående vann eller hav, avsettes sedimenter som danner kanaler og endringer i retningene utløpet tar. Typiske former er vifteform og fuglefot.", "2018-06-22T15:28:47Z", 175462, 1, "Delta", "2018-08-17T14:15:27Z" },
                    { 90, "Sissel Paaske", "Delta dannes av elveavsetninger (elvedelta, elveos). I området der elven ender i stillestående vann eller hav, avsettes sedimenter som danner kanaler og endringer i retningene utløpet tar. Typiske former er vifteform og fuglefot.", "2018-06-22T15:28:47Z", 175462, 1, "Delta", "2018-08-17T14:15:27Z" },
                    { 187, "Sissel Paaske", "Overlagring beskriver hvordan lag på lag med avsetninger og sedimentære bergarter ligger over en bergart i dypet.", "2018-06-22T15:28:58Z", 175464, 1, "Overlagring", "2018-08-17T14:15:16Z" },
                    { 186, "Sissel Paaske", "Overlagring beskriver hvordan lag på lag med avsetninger og sedimentære bergarter ligger over en bergart i dypet.", "2018-06-22T15:28:58Z", 175464, 1, "Overlagring", "2018-08-17T14:15:16Z" },
                    { 221, "Sissel Paaske", "CBL er en forkortelse for Cement Bond Log. Loggen viser toppen av sementen, om det er hull i sementen eller mangler sement i noen områder. Loggen utføres på kabel og bruker lydsignaler (acoustic sonic log) som loggemedium.", "2018-06-22T15:37:49Z", 176572, 1, "CBL", "2018-09-04T08:43:39Z" },
                    { 220, "Sissel Paaske", "CBL er en forkortelse for Cement Bond Log. Loggen viser toppen av sementen, om det er hull i sementen eller mangler sement i noen områder. Loggen utføres på kabel og bruker lydsignaler (acoustic sonic log) som loggemedium.", "2018-06-22T15:37:49Z", 176572, 1, "CBL", "2018-09-04T08:43:39Z" },
                    { 300, "Sissel Paaske", "MWD er forkortelse for Measurement While Drilling. Det er et verktøy som brukes i bunnen av borestrengen (i BHA) til å registrere retningen på brønnbanen. Retningen registreres både vertikalt og horisontalt. Informasjonen om retningen sendes til overflaten gjennom pulser i boreslammet. På overflaten ser retningsboreren brønnbanen på en skjerm.", "2018-06-22T15:35:27Z", 176573, 1, "MWD", "2018-09-04T08:43:36Z" },
                    { 299, "Sissel Paaske", "MWD er forkortelse for Measurement While Drilling. Det er et verktøy som brukes i bunnen av borestrengen (i BHA) til å registrere retningen på brønnbanen. Retningen registreres både vertikalt og horisontalt. Informasjonen om retningen sendes til overflaten gjennom pulser i boreslammet. På overflaten ser retningsboreren brønnbanen på en skjerm.", "2018-06-22T15:35:27Z", 176573, 1, "MWD", "2018-09-04T08:43:36Z" },
                    { 8, "Johannes Leiknes Nag", "Universell utforming er å forme omgjevnadene slik at vi tek omsyn til variasjonen i funksjonsevne hos innbyggjarane, inkludert personar med nedsett funksjonsevne.", "2018-05-04T14:09:27Z", 173854, 1, "Universell utforming/UU", "2018-05-27T15:36:18Z" },
                    { 7, "Johannes Leiknes Nag", "Universell utforming er å forme omgivelsene slik at vi tar hensyn til variasjonen i funksjonsevne hos innbyggerne, inkludert personer med nedsatt funksjonsevne.", "2018-05-04T14:09:27Z", 173854, 1, "Universell utforming/UU", "2018-05-27T15:36:18Z" },
                    { 16, "Johannes Leiknes Nag", "App, forkorting for «applikasjon», er ei programvareløysing laga for å køyre på smarttelefonar og nettbrett; nokre appar, kalla web apps, køyrer på nettet.", "2018-05-04T14:09:27Z", 173856, 1, "App", "2018-05-27T15:36:17Z" },
                    { 15, "Johannes Leiknes Nag", "App, forkortelse for «applikasjon», er en programvareløsning laget for å kjøre på smarttelefoner og nettbrett; noen apper, kalt web apps, kjører på nettet.", "2018-05-04T14:09:27Z", 173856, 1, "App", "2018-05-27T15:36:17Z" },
                    { 12, "Johannes Leiknes Nag", "Ein brukarsti er ei førestilling om korleis ein typisk person vil komme til å bruke ein nettstad, leite og finne fram. Brukarstiar blir brukte i planlegging av nettstader og app-ar.", "2018-05-04T14:09:26Z", 173857, 1, "Brukarsti", "2018-05-27T15:36:17Z" },
                    { 250, "Sissel Paaske", "Casing er engelsk og betyr fôringsrør. Rørene skrus sammen og brukes til å sikre borehullet. Casingen går helt opp i brønnen. For hver nye seksjon som bores ut, installeres en mindre casing innvendig i den forrige. Casing sementeres i nederste del. Casing skilles fra andre rør på størrelsen, mindre rør kalles tubing på engelsk.", "2018-06-22T15:37:45Z", 175426, 1, "Casing", "2018-09-04T08:44:14Z" },
                    { 400, "Emily Sørensen", "En pengestøtte som blir gitt til foreldre med barn mellom ett og to år som ikke går i barnehage. Støtten kan tidligst bli gitt fra måneden etter at barnet har fylt ett år, og kan maksimalt gis til og med måneden før barnet fyller to år, dvs. maksimalt 11 måneder.", "2018-06-22T15:06:20Z", 167266, 1, "Kontantstøtte", "2018-08-17T19:10:43Z" },
                    { 213, "Sissel Paaske", "Primærbarrieren i en brønn er den hindringen som ligger nærmest kilden (reservoaret). I forbindelse med bore- og brønnaktivitet er primærbarrieren væsken som står i brønnen. Når brønnen produserer, er det kompletteringen med sikringsventilen (DHSV) i brønnen som er primærbarrieren.", "2018-06-22T15:37:31Z", 174263, 1, "Primærbarriere", "2018-09-04T08:44:03Z" },
                    { 96, "Isak Nordeng Jensen", "Mødre kan få engangsstønad ved fødsel og adopsjon hvis de ikke har rett til foreldrepenger. Hvis en far er alene om omsorgen, kan også han ha rett til engangsstønad.", "2018-06-22T15:06:21Z", 167189, 1, "Engangsstønad", "2018-08-17T19:10:46Z" },
                    { 442, "Sissel Paaske", "Norsk olje og gass er en interesse- og arbeidsgiverorganisasjon for oljeselskaper og leverandørbedrifter knyttet til utforsking og produksjon av olje og gass på norsk kontinentalsokkel. Norsk olje og gass er en landsforening i NHO, Næringslivets Hovedorganisasjon.", "2018-06-22T15:45:35Z", 168316, 1, "Norsk olje og gass", "2018-09-04T08:43:53Z" },
                    { 441, "Sissel Paaske", "Norsk olje og gass er en interesse- og arbeidsgiverorganisasjon for oljeselskaper og leverandørbedrifter knyttet til utforsking og produksjon av olje og gass på norsk kontinentalsokkel. Norsk olje og gass er en landsforening i NHO, Næringslivets Hovedorganisasjon.", "2018-06-22T15:45:35Z", 168316, 1, "Norsk olje og gass", "2018-09-04T08:43:53Z" },
                    { 79, "Sissel Paaske", "ppm; parts per million. Måleenhet som vanligvis brukes for konsentrasjon av et stoff i et annet, der små mengder er påviselige og muligens viktige.", "2018-06-22T15:42:09Z", 150257, 1, "ppm", "2018-09-04T08:43:50Z" },
                    { 78, "Sissel Paaske", "ppm; parts per million. Måleenhet som vanligvis brukes for konsentrasjon av et stoff i et annet, der små mengder er påviselige og muligens viktige.", "2018-06-22T15:42:09Z", 150257, 1, "ppm", "2018-09-04T08:43:50Z" },
                    { 330, "Sissel Paaske", "Pallebord er et bord som kan beveges vertikalt opp og ned. Det brukes til å løfte paller med kjemikalier for mixing av borevæske.", "2018-06-22T15:32:16Z", 168492, 1, "Pallebord", "2018-08-17T14:22:27Z" },
                    { 329, "Sissel Paaske", "Pallebord er et bord som kan beveges vertikalt opp og ned. Det brukes til å løfte paller med kjemikalier for mixing av borevæske.", "2018-06-22T15:32:16Z", 168492, 1, "Pallebord", "2018-08-17T14:22:27Z" },
                    { 368, "Sissel Paaske", "En godt konsolidert bergart har en sterk forbindelse eller binding av mineraler mellom sedimentene i bergarten. Bindingene i løse bergarter og avleiringer oppstår ved hjelp av trykkpåvirkning, sammenpressing, omkrystallisering og sementering av sedimentene med nydannede mineraler. Dersom bergarten er løs og faller fra hverandre ved lett belastning, er den dårlig konsolidert.", "2018-06-22T15:29:01Z", 171174, 1, "Konsolidert bergart", "2018-09-04T08:43:58Z" },
                    { 367, "Sissel Paaske", "En godt konsolidert bergart har en sterk forbindelse eller binding av mineraler mellom sedimentene i bergarten. Bindingene i løse bergarter og avleiringer oppstår ved hjelp av trykkpåvirkning, sammenpressing, omkrystallisering og sementering av sedimentene med nydannede mineraler. Dersom bergarten er løs og faller fra hverandre ved lett belastning, er den dårlig konsolidert.", "2018-06-22T15:29:01Z", 171174, 1, "Konsolidert bergart", "2018-09-04T08:43:58Z" },
                    { 401, "Emily Sørensen", "Ei pengestøtte som blir gitt til foreldre med barn mellom eitt og to år som ikkje går i barnehage. Støtta kan tidlegast bli gitt frå månaden etter at barnet har fylt eitt år, og kan maksimalt bli utbetalt til og med månaden før barnet fyller to år, dvs. maksimalt 11 månader.", "2018-06-22T15:06:20Z", 167266, 1, "Kontantstøtte", "2018-08-17T19:10:43Z" },
                    { 515, "Liv Dagrunn Andreassen", "Den indre kraften i bergarten som må til for å holde massen av bergartene som ligger over. Dypereliggende formasjoner er sterkere enn grunne bergarter på grunn av herdeprosessen som pågår over millioner av år. Når vi drenerer væske ut av porene i bergarten påvirker det den indre styrken slik at bergarten svekkes.", "2018-06-22T15:35:31Z", 172158, 1, "Formasjonsstyrke", "2018-09-04T08:43:30Z" },
                    { 302, "Sissel Paaske", "Solenoidventil er en magnetisk spoleventil som opereres med elektrisk spenning. Når det tilføres spenning, endres den magnetiske retningen i spolen slik at ventilens posisjon endres. Når spenningen fjernes, er det en fjær som bringer ventilen til motsatt posisjon.", "2018-06-22T15:42:34Z", 172662, 1, "Solenoidventil ", "2018-09-04T08:43:41Z" },
                    { 301, "Sissel Paaske", "Solenoidventil er en magnetisk spoleventil som opereres med elektrisk spenning. Når det tilføres spenning, endres den magnetiske retningen i spolen slik at ventilens posisjon endres. Når spenningen fjernes, er det en fjær som bringer ventilen til motsatt posisjon.", "2018-06-22T15:42:34Z", 172662, 1, "Solenoidventil ", "2018-09-04T08:43:41Z" },
                    { 496, "Sissel Paaske", "Boreparameter er et samlebegrep for verdier som er viktige å overvåke under boring. De vanligste vi overvåker, er framdriften, rate of penetration (ROP), vekten på borekronen, weight on bit (WOB), og friksjonen mot rotasjon på borekronen, torque. Endringer i boreparametrene som ikke er forårsaket av endringer fra borerens kontrollpanel, kan bety at man borer inn i høytrykksone eller får kick inn i brønnen.", "2018-06-22T15:34:48Z", 172685, 1, "Boreparameter ", "2018-09-04T08:43:41Z" },
                    { 495, "Sissel Paaske", "Boreparameter er et samlebegrep for verdier som er viktige å overvåke under boring. De vanligste vi overvåker, er framdriften, rate of penetration (ROP), vekten på borekronen, weight on bit (WOB), og friksjonen mot rotasjon på borekronen, torque. Endringer i boreparametrene som ikke er forårsaket av endringer fra borerens kontrollpanel, kan bety at man borer inn i høytrykksone eller får kick inn i brønnen.", "2018-06-22T15:34:48Z", 172685, 1, "Boreparameter ", "2018-09-04T08:43:41Z" },
                    { 516, "Liv Dagrunn Andreassen", "Den indre kraften i bergarten som må til for å holde massen av bergartene som ligger over. Dypereliggende formasjoner er sterkere enn grunne bergarter på grunn av herdeprosessen som pågår over millioner av år. Når vi drenerer væske ut av porene i bergarten påvirker det den indre styrken slik at bergarten svekkes.", "2018-06-22T15:35:31Z", 172158, 1, "Formasjonsstyrke", "2018-09-04T08:43:30Z" },
                    { 402, "Sissel Paaske", "Pilothull kommer fra det engelske verbet to pilot; å lede. Pilothull er boring av et hull i to steg, først med liten diameter, deretter med den større diameteren. Et pilothull bores i områder med ukjente forhold. Dersom det er gass vil konsekvensene av en utstrømning være betydelig mindre, enn med stort hull. Det er også lettere å gjenvinne kontrollen med å pumpe væske med høy hastighet i et lite hull, fordi det skaper friksjon som virker mot utstrømningen.", "2018-06-22T15:34:47Z", 172679, 1, "Pilothull ", "2018-09-04T08:43:39Z" },
                    { 403, "Sissel Paaske", "Pilothull kommer fra det engelske verbet to pilot; å lede. Pilothull er boring av et hull i to steg, først med liten diameter, deretter med den større diameteren. Et pilothull bores i områder med ukjente forhold. Dersom det er gass, vil konsekvensene av en utstrømning være betydelig mindre enn med stort hull. Det er også lettere å gjenvinne kontrollen med å pumpe væske med høy hastighet i et lite hull, fordi det skaper friksjon som virker mot utstrømningen.", "2018-06-22T15:34:47Z", 172679, 1, "Pilothull ", "2018-09-04T08:43:39Z" },
                    { 469, "Liv Dagrunn Andreassen", "Geologiske lag er lagene som dannes gjennom millioner av år av ulike typer sedimenter som er avsatt på havbunnen. Sedimentene er da blitt omdannet til forskjellige bergarter som ligger lag på lag. Skillet mellom disse ulike bergartene er grensene som påvises i seismiske undersøkelser. Dypet og vinkelen til disse grensene er endret fra opprinnelig posisjon på grunn av blant annet foldinger, forkastninger og saltdiapirer.", "2018-06-22T15:29:38Z", 173987, 1, "Geologiske lag", "2018-08-17T14:17:19Z" },
                    { 470, "Liv Dagrunn Andreassen", "Geologiske lag er lagene som dannes gjennom millioner av år av ulike typer sedimenter som er avsatt på havbunnen. Sedimentene er da blitt omdannet til forskjellige bergarter som ligger lag på lag. Skillet mellom disse ulike bergartene er grensene som påvises i seismiske undersøkelser. Dypet og vinkelen til disse grensene er endret fra opprinnelig posisjon på grunn av blant annet foldinger, forkastninger og saltdiapirer.", "2018-06-22T15:29:38Z", 173987, 1, "Geologiske lag", "2018-08-17T14:17:19Z" },
                    { 248, "Liv Dagrunn Andreassen", "Fjernstyrt undervannsfarkost (ROV, fra engelsk Remotely Operated Vehicle) er en robot som blir fjernstyrt fra kontrollrom på skip eller plattform. ROV brukes til kartlegging av havbunn, inspeksjon, vedlikehold og reparasjon av havbunnsinstallasjoner og lignende. Den kan operere ned til ca. 3000 meter og i helt spesielle tilfeller ned til 7000–8000 meter. Fjernstyrte undervannsfarkoster utfører i dag mange oppgaver som før krevde dykkere. Operatøren som flyr en ROV, kalles pilot.", "2018-06-22T15:37:55Z", 173533, 1, "ROV", "2018-09-04T08:44:04Z" },
                    { 249, "Liv Dagrunn Andreassen", "Fjernstyrt undervannsfarkost (ROV, fra engelsk Remotely Operated Vehicle) er en robot som blir fjernstyrt fra kontrollrom på skip eller plattform. ROV brukes til kartlegging av havbunn, inspeksjon, vedlikehold og reparasjon av havbunnsinstallasjoner og lignende. Den kan operere ned til ca. 3000 meter og i helt spesielle tilfeller ned til 7000–8000 meter. Fjernstyrte undervannsfarkoster utfører i dag mange oppgaver som før krevde dykkere. Operatøren som flyr en ROV, kalles pilot.", "2018-06-22T15:37:55Z", 173533, 1, "ROV", "2018-09-04T08:44:04Z" },
                    { 214, "Liv Dagrunn Andreassen", "Av de greske ordene lithos; stein og logi; lære). Beskrivelse og klassifikasjon av bergarter, særlig sedimentære bergarter som sandstein, kalkstein og leirskifer.", "2018-06-22T15:35:40Z", 173531, 1, "Litologi", "2018-09-04T08:43:44Z" },
                    { 97, "Isak Nordeng Jensen", "Mødrer kan få eingongsstønad ved fødsel og adopsjon dersom dei ikkje har rett til foreldrepengar. Dersom ein far er åleine om omsorga, kan også han ha rett til eingongsstønad.", "2018-06-22T15:06:21Z", 167189, 1, "Eingongsstønad", "2018-08-17T19:10:46Z" },
                    { 443, "Sissel Paaske", "GOC, gas-oil contact, viser til dybden i et reservoar der bunnen av gassen møter toppen av oljen.", "2018-07-06T14:42:41Z", 172924, 1, "GOC – gas-oil contact", "2018-09-04T08:43:28Z" },
                    { 444, "Sissel Paaske", "GOC, gas-oil contact, viser til dybden i et reservoar der bunnen av gassen møter toppen av oljen.", "2018-07-06T14:42:41Z", 172924, 1, "GOC – gas-oil contact", "2018-09-04T08:43:28Z" },
                    { 519, "Sissel Paaske", "OWC, oil-water contact, viser til dybden i et reservoar der bunnen av oljen møter toppen av formasjonsvannet. OWC flytter seg oppover eller mot brønnen når reservoaret dreneres for olje.", "2018-07-06T14:42:42Z", 172923, 1, "OWC – oil-water contact", "2018-09-04T08:43:31Z" },
                    { 520, "Sissel Paaske", "OWC, oil-water contact, viser til dybden i et reservoar der bunnen av oljen møter toppen av formasjonsvannet. OWC flytter seg oppover eller mot brønnen når reservoaret dreneres for olje.", "2018-07-06T14:42:42Z", 172923, 1, "OWC – oil-water contact", "2018-09-04T08:43:31Z" },
                    { 110, "Sissel Paaske", "Kryssproduksjon er når en brønn har høyere trykk enn en annen, slik at produsert væske går ned i lavtrykkbrønnen i stedet for videre inn i produksjonsrøret. Kryssproduksjonen skjer i møtepunktet mellom brønnene (manifolden) før videre transport til produksjonsrøret. For å hindre kryssproduksjon kan man strupe produksjonen fra høytrykksbrønnen foran manifolden.", "2018-06-22T15:42:26Z", 172660, 1, "Kryssproduksjon ", "2018-09-04T08:43:42Z" },
                    { 111, "Sissel Paaske", "Kryssproduksjon er når en brønn har høyere trykk enn en annen, slik at produsert væske går ned i lavtrykkbrønnen i stedet for videre inn i produksjonsrøret. Kryssproduksjonen skjer i møtepunktet mellom brønnene (manifolden) før videre transport til produksjonsrøret. For å hindre kryssproduksjon kan man strupe produksjonen fra høytrykksbrønnen foran manifolden.", "2018-06-22T15:42:26Z", 172660, 1, "Kryssproduksjon ", "2018-09-04T08:43:42Z" },
                    { 215, "Liv Dagrunn Andreassen", "Av de greske ordene lithos; stein og logi; lære). Beskrivelse og klassifikasjon av bergarter, særlig sedimentære bergarter som sandstein, kalkstein og leirskifer.", "2018-06-22T15:35:40Z", 173531, 1, "Litologi", "2018-09-04T08:43:44Z" }
                });

            migrationBuilder.InsertData(
                table: "Metadata",
                columns: new[] { "Id", "CategoryId", "Code", "Description" },
                values: new object[,]
                {
                    { 1, 2, "nn", "Nynorsk" },
                    { 2, 2, "nb", "Bokmål" },
                    { 3, 2, "Språknøytral", "Språknøytral" },
                    { 5, 3, "Brønnteknikk", "" },
                    { 6, 3, "Samfunnsfag", "" },
                    { 10, 3, "Historie Vg2 og Vg3", "" },
                    { 8, 3, "Biologi 1", "" },
                    { 9, 3, "Digital kompetanse", "" },
                    { 11, 3, "Transport og logistikk Vg2", "" },
                    { 12, 3, "Medie- og informasjonskunnskap 1 og 2", "" },
                    { 13, 3, "Service og samferdsel Vg1", "" },
                    { 7, 3, "Medieuttrykk og mediesamfunnet", "" },
                    { 4, 1, "Begrep", "" }
                });

            migrationBuilder.InsertData(
                table: "ConceptMetas",
                columns: new[] { "ConceptId", "MetadataId", "Id" },
                values: new object[,]
                {
                    { 204, 4, 1 },
                    { 386, 2, 551 },
                    { 387, 4, 552 },
                    { 387, 6, 553 },
                    { 387, 1, 554 },
                    { 263, 4, 555 },
                    { 263, 6, 556 },
                    { 263, 2, 557 },
                    { 264, 4, 558 },
                    { 264, 6, 559 },
                    { 264, 1, 560 },
                    { 386, 6, 550 },
                    { 394, 4, 561 },
                    { 394, 2, 563 },
                    { 395, 4, 564 },
                    { 395, 6, 565 },
                    { 395, 1, 566 },
                    { 125, 4, 567 },
                    { 125, 2, 568 },
                    { 126, 4, 569 },
                    { 126, 1, 570 },
                    { 102, 4, 571 },
                    { 102, 6, 572 },
                    { 394, 6, 562 },
                    { 102, 2, 573 },
                    { 386, 4, 549 },
                    { 294, 6, 547 },
                    { 78, 4, 525 },
                    { 78, 5, 526 },
                    { 78, 2, 527 },
                    { 79, 4, 528 },
                    { 79, 5, 529 },
                    { 79, 1, 530 },
                    { 441, 4, 531 },
                    { 441, 5, 532 },
                    { 441, 2, 533 },
                    { 442, 4, 534 },
                    { 294, 1, 548 },
                    { 442, 5, 535 },
                    { 297, 4, 537 },
                    { 297, 6, 538 },
                    { 297, 2, 539 },
                    { 298, 4, 540 },
                    { 298, 6, 541 },
                    { 298, 1, 542 },
                    { 293, 4, 543 },
                    { 293, 6, 544 },
                    { 293, 2, 545 },
                    { 294, 4, 546 },
                    { 442, 1, 536 },
                    { 330, 1, 524 },
                    { 103, 4, 574 },
                    { 103, 1, 576 },
                    { 184, 2, 603 },
                    { 185, 4, 604 },
                    { 185, 5, 605 },
                    { 185, 1, 606 },
                    { 325, 4, 607 },
                    { 325, 5, 608 },
                    { 325, 2, 609 },
                    { 326, 4, 610 },
                    { 326, 5, 611 },
                    { 326, 1, 612 },
                    { 184, 5, 602 },
                    { 521, 4, 613 },
                    { 521, 2, 615 },
                    { 522, 4, 616 },
                    { 522, 5, 617 },
                    { 522, 1, 618 },
                    { 133, 4, 619 },
                    { 133, 10, 620 },
                    { 133, 2, 621 },
                    { 134, 4, 622 },
                    { 134, 10, 623 },
                    { 134, 1, 624 },
                    { 521, 5, 614 },
                    { 103, 6, 575 },
                    { 184, 4, 601 },
                    { 177, 5, 599 },
                    { 408, 4, 577 },
                    { 408, 6, 578 },
                    { 408, 2, 579 },
                    { 409, 4, 580 },
                    { 409, 6, 581 },
                    { 409, 1, 582 },
                    { 412, 4, 583 },
                    { 412, 5, 584 },
                    { 412, 2, 585 },
                    { 413, 4, 586 },
                    { 177, 1, 600 },
                    { 413, 5, 587 },
                    { 351, 4, 589 },
                    { 351, 5, 590 },
                    { 351, 2, 591 },
                    { 352, 4, 592 },
                    { 352, 5, 593 },
                    { 352, 1, 594 },
                    { 176, 4, 595 },
                    { 176, 5, 596 },
                    { 176, 2, 597 },
                    { 177, 4, 598 },
                    { 413, 1, 588 },
                    { 330, 5, 523 },
                    { 330, 4, 522 },
                    { 329, 2, 521 },
                    { 401, 1, 446 },
                    { 96, 4, 447 },
                    { 96, 6, 448 },
                    { 96, 2, 449 },
                    { 97, 4, 450 },
                    { 97, 6, 451 },
                    { 97, 1, 452 },
                    { 469, 4, 453 },
                    { 469, 5, 454 },
                    { 469, 2, 455 },
                    { 401, 6, 445 },
                    { 470, 4, 456 },
                    { 470, 1, 458 },
                    { 248, 4, 459 },
                    { 248, 5, 460 },
                    { 248, 2, 461 },
                    { 249, 4, 462 },
                    { 249, 5, 463 },
                    { 249, 1, 464 },
                    { 214, 4, 465 },
                    { 214, 5, 466 },
                    { 214, 2, 467 },
                    { 470, 5, 457 },
                    { 215, 4, 468 },
                    { 401, 4, 444 },
                    { 400, 6, 442 },
                    { 28, 4, 420 },
                    { 28, 9, 421 },
                    { 28, 2, 422 },
                    { 212, 4, 423 },
                    { 212, 5, 424 },
                    { 212, 2, 425 },
                    { 213, 4, 426 },
                    { 213, 5, 427 },
                    { 213, 1, 428 },
                    { 277, 4, 429 },
                    { 400, 2, 443 },
                    { 277, 5, 430 },
                    { 278, 4, 432 },
                    { 278, 5, 433 },
                    { 278, 1, 434 },
                    { 246, 4, 435 },
                    { 246, 5, 436 },
                    { 246, 2, 437 },
                    { 247, 4, 438 },
                    { 247, 5, 439 },
                    { 247, 1, 440 },
                    { 400, 4, 441 },
                    { 277, 2, 431 },
                    { 215, 5, 469 },
                    { 215, 1, 470 },
                    { 443, 4, 471 },
                    { 496, 5, 499 },
                    { 496, 1, 500 },
                    { 301, 4, 501 },
                    { 301, 5, 502 },
                    { 301, 2, 503 },
                    { 302, 4, 504 },
                    { 302, 5, 505 },
                    { 302, 1, 506 },
                    { 515, 4, 507 },
                    { 515, 5, 508 },
                    { 496, 4, 498 },
                    { 515, 2, 509 },
                    { 516, 5, 511 },
                    { 516, 1, 512 },
                    { 367, 4, 513 },
                    { 367, 5, 514 },
                    { 367, 2, 515 },
                    { 368, 4, 516 },
                    { 368, 5, 517 },
                    { 368, 1, 518 },
                    { 329, 4, 519 },
                    { 329, 5, 520 },
                    { 516, 4, 510 },
                    { 495, 2, 497 },
                    { 495, 5, 496 },
                    { 495, 4, 495 },
                    { 443, 5, 472 },
                    { 443, 2, 473 },
                    { 444, 4, 474 },
                    { 444, 5, 475 },
                    { 444, 1, 476 },
                    { 519, 4, 477 },
                    { 519, 5, 478 },
                    { 519, 2, 479 },
                    { 520, 4, 480 },
                    { 520, 5, 481 },
                    { 520, 1, 482 },
                    { 110, 4, 483 },
                    { 110, 5, 484 },
                    { 110, 2, 485 },
                    { 111, 4, 486 },
                    { 111, 5, 487 },
                    { 111, 1, 488 },
                    { 402, 4, 489 },
                    { 402, 5, 490 },
                    { 402, 2, 491 },
                    { 403, 4, 492 },
                    { 403, 5, 493 },
                    { 403, 1, 494 },
                    { 505, 4, 625 },
                    { 27, 1, 419 },
                    { 505, 5, 626 },
                    { 506, 4, 628 },
                    { 108, 4, 760 },
                    { 108, 11, 761 },
                    { 108, 1, 762 },
                    { 109, 4, 763 },
                    { 109, 11, 764 },
                    { 109, 2, 765 },
                    { 65, 4, 766 },
                    { 65, 12, 767 },
                    { 43, 4, 768 },
                    { 43, 1, 769 },
                    { 223, 2, 759 },
                    { 44, 4, 770 },
                    { 41, 4, 772 },
                    { 41, 13, 773 },
                    { 41, 1, 774 },
                    { 42, 4, 775 },
                    { 42, 13, 776 },
                    { 42, 2, 777 },
                    { 377, 4, 778 },
                    { 377, 13, 779 },
                    { 64, 4, 780 },
                    { 59, 4, 781 },
                    { 44, 2, 771 },
                    { 59, 13, 782 },
                    { 223, 5, 758 },
                    { 222, 1, 756 },
                    { 71, 5, 734 },
                    { 71, 1, 735 },
                    { 380, 4, 736 },
                    { 380, 5, 737 },
                    { 380, 2, 738 },
                    { 381, 4, 739 },
                    { 381, 5, 740 },
                    { 381, 1, 741 },
                    { 208, 4, 742 },
                    { 208, 5, 743 },
                    { 223, 4, 757 },
                    { 208, 2, 744 },
                    { 209, 5, 746 },
                    { 209, 1, 747 },
                    { 92, 4, 748 },
                    { 92, 5, 749 },
                    { 92, 2, 750 },
                    { 93, 4, 751 },
                    { 93, 5, 752 },
                    { 93, 1, 753 },
                    { 222, 4, 754 },
                    { 222, 5, 755 },
                    { 209, 4, 745 },
                    { 71, 4, 733 },
                    { 60, 4, 783 },
                    { 139, 4, 785 },
                    { 14, 2, 812 },
                    { 17, 4, 813 },
                    { 17, 9, 814 },
                    { 17, 1, 815 },
                    { 18, 4, 816 },
                    { 18, 9, 817 },
                    { 18, 2, 818 },
                    { 3, 4, 819 },
                    { 3, 9, 820 },
                    { 3, 1, 821 },
                    { 14, 9, 811 },
                    { 4, 4, 822 },
                    { 4, 2, 824 },
                    { 1, 4, 825 },
                    { 1, 9, 826 },
                    { 1, 1, 827 },
                    { 2, 4, 828 },
                    { 2, 9, 829 },
                    { 2, 2, 830 },
                    { 80, 4, 831 },
                    { 80, 1, 832 },
                    { 81, 4, 833 },
                    { 4, 9, 823 },
                    { 60, 13, 784 },
                    { 14, 4, 810 },
                    { 13, 9, 808 },
                    { 139, 6, 786 },
                    { 139, 1, 787 },
                    { 140, 4, 788 },
                    { 140, 6, 789 },
                    { 140, 2, 790 },
                    { 150, 4, 791 },
                    { 150, 6, 792 },
                    { 150, 1, 793 },
                    { 151, 4, 794 },
                    { 151, 6, 795 },
                    { 13, 1, 809 },
                    { 151, 2, 796 },
                    { 118, 1, 798 },
                    { 119, 4, 799 },
                    { 119, 2, 800 },
                    { 19, 4, 801 },
                    { 19, 9, 802 },
                    { 19, 1, 803 },
                    { 20, 4, 804 },
                    { 20, 9, 805 },
                    { 20, 2, 806 },
                    { 13, 4, 807 },
                    { 118, 4, 797 },
                    { 70, 2, 732 },
                    { 70, 5, 731 },
                    { 70, 4, 730 },
                    { 292, 4, 655 },
                    { 292, 5, 656 },
                    { 292, 1, 657 },
                    { 388, 4, 658 },
                    { 388, 5, 659 },
                    { 388, 2, 660 },
                    { 389, 4, 661 },
                    { 389, 5, 662 },
                    { 389, 1, 663 },
                    { 190, 4, 664 },
                    { 291, 2, 654 },
                    { 190, 5, 665 },
                    { 191, 4, 667 },
                    { 191, 5, 668 },
                    { 191, 1, 669 },
                    { 317, 4, 670 },
                    { 317, 5, 671 },
                    { 317, 2, 672 },
                    { 318, 4, 673 },
                    { 318, 5, 674 },
                    { 318, 1, 675 },
                    { 315, 4, 676 },
                    { 190, 2, 666 },
                    { 315, 5, 677 },
                    { 291, 5, 653 },
                    { 99, 1, 651 },
                    { 506, 5, 629 },
                    { 506, 1, 630 },
                    { 422, 4, 631 },
                    { 422, 5, 632 },
                    { 422, 2, 633 },
                    { 423, 4, 634 },
                    { 423, 5, 635 },
                    { 423, 1, 636 },
                    { 418, 4, 637 },
                    { 418, 5, 638 },
                    { 291, 4, 652 },
                    { 418, 2, 639 },
                    { 419, 5, 641 },
                    { 419, 1, 642 },
                    { 120, 4, 643 },
                    { 120, 10, 644 },
                    { 120, 1, 645 },
                    { 98, 4, 646 },
                    { 98, 6, 647 },
                    { 98, 2, 648 },
                    { 99, 4, 649 },
                    { 99, 6, 650 },
                    { 419, 4, 640 },
                    { 315, 2, 678 },
                    { 316, 4, 679 },
                    { 316, 5, 680 },
                    { 439, 2, 708 },
                    { 440, 4, 709 },
                    { 440, 5, 710 },
                    { 440, 1, 711 },
                    { 168, 4, 712 },
                    { 168, 5, 713 },
                    { 168, 2, 714 },
                    { 169, 4, 715 },
                    { 169, 5, 716 },
                    { 169, 1, 717 },
                    { 439, 5, 707 },
                    { 261, 4, 718 },
                    { 261, 2, 720 },
                    { 262, 4, 721 },
                    { 262, 5, 722 },
                    { 262, 1, 723 },
                    { 449, 4, 724 },
                    { 449, 5, 725 },
                    { 449, 2, 726 },
                    { 450, 4, 727 },
                    { 450, 5, 728 },
                    { 450, 1, 729 },
                    { 261, 5, 719 },
                    { 439, 4, 706 },
                    { 310, 1, 705 },
                    { 310, 5, 704 },
                    { 316, 1, 681 },
                    { 321, 4, 682 },
                    { 321, 5, 683 },
                    { 321, 2, 684 },
                    { 322, 4, 685 },
                    { 322, 5, 686 },
                    { 322, 1, 687 },
                    { 477, 4, 688 },
                    { 477, 5, 689 },
                    { 477, 2, 690 },
                    { 478, 4, 691 },
                    { 478, 5, 692 },
                    { 478, 1, 693 },
                    { 437, 4, 694 },
                    { 437, 5, 695 },
                    { 437, 2, 696 },
                    { 438, 4, 697 },
                    { 438, 5, 698 },
                    { 438, 1, 699 },
                    { 309, 4, 700 },
                    { 309, 5, 701 },
                    { 309, 2, 702 },
                    { 310, 4, 703 },
                    { 505, 2, 627 },
                    { 81, 2, 834 },
                    { 27, 9, 418 },
                    { 231, 2, 416 },
                    { 343, 4, 133 },
                    { 343, 2, 134 },
                    { 344, 4, 135 },
                    { 344, 1, 136 },
                    { 384, 4, 137 },
                    { 384, 6, 138 },
                    { 384, 2, 139 },
                    { 385, 4, 140 },
                    { 385, 6, 141 },
                    { 385, 1, 142 },
                    { 87, 1, 132 },
                    { 396, 4, 143 },
                    { 396, 2, 145 },
                    { 397, 4, 146 },
                    { 397, 6, 147 },
                    { 397, 1, 148 },
                    { 281, 4, 149 },
                    { 281, 6, 150 },
                    { 281, 2, 151 },
                    { 282, 4, 152 },
                    { 282, 6, 153 },
                    { 282, 1, 154 },
                    { 396, 6, 144 },
                    { 323, 4, 155 },
                    { 87, 6, 131 },
                    { 86, 2, 129 },
                    { 434, 6, 107 },
                    { 434, 1, 108 },
                    { 25, 4, 109 },
                    { 25, 6, 110 },
                    { 25, 2, 111 },
                    { 26, 4, 112 },
                    { 26, 6, 113 },
                    { 26, 1, 114 },
                    { 21, 4, 115 },
                    { 21, 6, 116 },
                    { 87, 4, 130 },
                    { 21, 2, 117 },
                    { 22, 6, 119 },
                    { 22, 1, 120 },
                    { 192, 4, 121 },
                    { 192, 6, 122 },
                    { 192, 2, 123 },
                    { 193, 4, 124 },
                    { 193, 6, 125 },
                    { 193, 1, 126 },
                    { 86, 4, 127 },
                    { 86, 6, 128 },
                    { 22, 4, 118 },
                    { 434, 4, 106 },
                    { 323, 6, 156 },
                    { 324, 4, 158 },
                    { 414, 2, 185 },
                    { 415, 4, 186 },
                    { 415, 6, 187 },
                    { 415, 1, 188 },
                    { 123, 4, 189 },
                    { 123, 6, 190 },
                    { 123, 2, 191 },
                    { 124, 4, 192 },
                    { 124, 6, 193 },
                    { 124, 1, 194 },
                    { 414, 6, 184 },
                    { 373, 4, 195 },
                    { 374, 4, 197 },
                    { 374, 1, 198 },
                    { 234, 4, 199 },
                    { 234, 2, 200 },
                    { 235, 4, 201 },
                    { 235, 1, 202 },
                    { 523, 4, 203 },
                    { 523, 2, 204 },
                    { 524, 4, 205 },
                    { 524, 1, 206 },
                    { 373, 2, 196 },
                    { 323, 2, 157 },
                    { 414, 4, 183 },
                    { 243, 6, 181 },
                    { 324, 6, 159 },
                    { 324, 1, 160 },
                    { 146, 4, 161 },
                    { 146, 6, 162 },
                    { 146, 2, 163 },
                    { 147, 4, 164 },
                    { 147, 6, 165 },
                    { 147, 1, 166 },
                    { 114, 4, 167 },
                    { 114, 6, 168 },
                    { 243, 1, 182 },
                    { 114, 2, 169 },
                    { 115, 6, 171 },
                    { 115, 1, 172 },
                    { 341, 4, 173 },
                    { 341, 2, 174 },
                    { 342, 4, 175 },
                    { 342, 1, 176 },
                    { 242, 4, 177 },
                    { 242, 6, 178 },
                    { 242, 2, 179 },
                    { 243, 4, 180 },
                    { 115, 4, 170 },
                    { 433, 2, 105 },
                    { 433, 6, 104 },
                    { 433, 4, 103 },
                    { 173, 4, 28 },
                    { 173, 5, 29 },
                    { 173, 1, 30 },
                    { 511, 4, 31 },
                    { 511, 5, 32 },
                    { 511, 2, 33 },
                    { 512, 4, 34 },
                    { 512, 5, 35 },
                    { 512, 1, 36 },
                    { 259, 4, 37 },
                    { 172, 2, 27 },
                    { 259, 5, 38 },
                    { 260, 4, 40 },
                    { 260, 5, 41 },
                    { 260, 1, 42 },
                    { 331, 4, 43 },
                    { 331, 5, 44 },
                    { 331, 2, 45 },
                    { 332, 4, 46 },
                    { 332, 5, 47 },
                    { 332, 1, 48 },
                    { 194, 4, 49 },
                    { 259, 2, 39 },
                    { 194, 5, 50 },
                    { 172, 5, 26 },
                    { 233, 1, 24 },
                    { 204, 5, 2 },
                    { 204, 2, 3 },
                    { 205, 4, 4 },
                    { 205, 5, 5 },
                    { 205, 1, 6 },
                    { 170, 4, 7 },
                    { 170, 5, 8 },
                    { 170, 2, 9 },
                    { 171, 4, 10 },
                    { 171, 5, 11 },
                    { 172, 4, 25 },
                    { 171, 1, 12 },
                    { 445, 5, 14 },
                    { 445, 2, 15 },
                    { 446, 4, 16 },
                    { 446, 5, 17 },
                    { 446, 1, 18 },
                    { 232, 4, 19 },
                    { 232, 5, 20 },
                    { 232, 2, 21 },
                    { 233, 4, 22 },
                    { 233, 5, 23 },
                    { 445, 4, 13 },
                    { 194, 2, 51 },
                    { 195, 4, 52 },
                    { 195, 5, 53 },
                    { 484, 6, 81 },
                    { 484, 1, 82 },
                    { 517, 4, 83 },
                    { 517, 2, 84 },
                    { 518, 4, 85 },
                    { 518, 1, 86 },
                    { 513, 4, 87 },
                    { 513, 2, 88 },
                    { 514, 4, 89 },
                    { 514, 1, 90 },
                    { 484, 4, 80 },
                    { 141, 4, 91 },
                    { 142, 4, 93 },
                    { 142, 1, 94 },
                    { 345, 4, 95 },
                    { 345, 2, 96 },
                    { 346, 4, 97 },
                    { 346, 1, 98 },
                    { 35, 4, 99 },
                    { 35, 2, 100 },
                    { 36, 4, 101 },
                    { 36, 1, 102 },
                    { 141, 2, 92 },
                    { 483, 2, 79 },
                    { 483, 6, 78 },
                    { 483, 4, 77 },
                    { 195, 1, 54 },
                    { 144, 4, 55 },
                    { 144, 2, 56 },
                    { 145, 4, 57 },
                    { 145, 1, 58 },
                    { 499, 4, 59 },
                    { 499, 5, 60 },
                    { 499, 2, 61 },
                    { 500, 4, 62 },
                    { 500, 5, 63 },
                    { 500, 1, 64 },
                    { 525, 4, 65 },
                    { 525, 2, 66 },
                    { 526, 4, 67 },
                    { 526, 1, 68 },
                    { 100, 4, 69 },
                    { 100, 2, 70 },
                    { 101, 4, 71 },
                    { 101, 1, 72 },
                    { 216, 4, 73 },
                    { 216, 2, 74 },
                    { 217, 4, 75 },
                    { 217, 1, 76 },
                    { 404, 4, 207 },
                    { 27, 4, 417 },
                    { 404, 2, 208 },
                    { 405, 1, 210 },
                    { 10, 4, 342 },
                    { 10, 7, 343 },
                    { 10, 1, 344 },
                    { 72, 4, 345 },
                    { 72, 7, 346 },
                    { 72, 2, 347 },
                    { 73, 4, 348 },
                    { 73, 7, 349 },
                    { 73, 1, 350 },
                    { 11, 4, 351 },
                    { 9, 2, 341 },
                    { 11, 7, 352 },
                    { 12, 4, 354 },
                    { 12, 7, 355 },
                    { 12, 1, 356 },
                    { 15, 4, 357 },
                    { 15, 7, 358 },
                    { 15, 2, 359 },
                    { 16, 4, 360 },
                    { 16, 7, 361 },
                    { 16, 1, 362 },
                    { 7, 4, 363 },
                    { 11, 2, 353 },
                    { 7, 7, 364 },
                    { 9, 7, 340 },
                    { 6, 1, 338 },
                    { 113, 1, 316 },
                    { 116, 4, 317 },
                    { 116, 5, 318 },
                    { 116, 2, 319 },
                    { 117, 4, 320 },
                    { 117, 5, 321 },
                    { 117, 1, 322 },
                    { 447, 4, 323 },
                    { 447, 5, 324 },
                    { 447, 2, 325 },
                    { 9, 4, 339 },
                    { 448, 4, 326 },
                    { 448, 1, 328 },
                    { 174, 4, 329 },
                    { 174, 5, 330 },
                    { 174, 2, 331 },
                    { 175, 4, 332 },
                    { 175, 5, 333 },
                    { 175, 1, 334 },
                    { 5, 4, 335 },
                    { 5, 2, 336 },
                    { 6, 4, 337 },
                    { 448, 5, 327 },
                    { 113, 5, 315 },
                    { 7, 2, 365 },
                    { 8, 7, 367 },
                    { 250, 5, 394 },
                    { 250, 2, 395 },
                    { 251, 4, 396 },
                    { 251, 5, 397 },
                    { 251, 1, 398 },
                    { 76, 4, 399 },
                    { 76, 6, 400 },
                    { 76, 2, 401 },
                    { 77, 4, 402 },
                    { 77, 6, 403 },
                    { 250, 4, 393 },
                    { 77, 1, 404 },
                    { 265, 5, 406 },
                    { 265, 2, 407 },
                    { 266, 4, 408 },
                    { 266, 5, 409 },
                    { 266, 1, 410 },
                    { 230, 4, 411 },
                    { 230, 8, 412 },
                    { 230, 1, 413 },
                    { 231, 4, 414 },
                    { 231, 8, 415 },
                    { 265, 4, 405 },
                    { 8, 4, 366 },
                    { 91, 1, 392 },
                    { 91, 4, 390 },
                    { 8, 1, 368 },
                    { 299, 4, 369 },
                    { 299, 5, 370 },
                    { 299, 2, 371 },
                    { 300, 4, 372 },
                    { 300, 5, 373 },
                    { 300, 1, 374 },
                    { 220, 4, 375 },
                    { 220, 5, 376 },
                    { 220, 2, 377 },
                    { 91, 5, 391 },
                    { 221, 4, 378 },
                    { 221, 1, 380 },
                    { 186, 4, 381 },
                    { 186, 5, 382 },
                    { 186, 2, 383 },
                    { 187, 4, 384 },
                    { 187, 5, 385 },
                    { 187, 1, 386 },
                    { 90, 4, 387 },
                    { 90, 5, 388 },
                    { 90, 2, 389 },
                    { 221, 5, 379 },
                    { 113, 4, 314 },
                    { 112, 2, 313 },
                    { 112, 5, 312 },
                    { 132, 4, 237 },
                    { 132, 1, 238 },
                    { 218, 4, 239 },
                    { 218, 5, 240 },
                    { 218, 2, 241 },
                    { 219, 4, 242 },
                    { 219, 5, 243 },
                    { 219, 1, 244 },
                    { 311, 4, 245 },
                    { 311, 5, 246 },
                    { 131, 2, 236 },
                    { 311, 2, 247 },
                    { 312, 5, 249 },
                    { 312, 1, 250 },
                    { 162, 4, 251 },
                    { 162, 5, 252 },
                    { 162, 2, 253 },
                    { 163, 4, 254 },
                    { 163, 5, 255 },
                    { 163, 1, 256 },
                    { 273, 4, 257 },
                    { 273, 5, 258 },
                    { 312, 4, 248 },
                    { 273, 2, 259 },
                    { 131, 4, 235 },
                    { 348, 6, 233 },
                    { 416, 4, 211 },
                    { 416, 6, 212 },
                    { 416, 2, 213 },
                    { 417, 4, 214 },
                    { 417, 6, 215 },
                    { 417, 1, 216 },
                    { 465, 4, 217 },
                    { 465, 6, 218 },
                    { 465, 2, 219 },
                    { 466, 4, 220 },
                    { 348, 1, 234 },
                    { 466, 6, 221 },
                    { 463, 4, 223 },
                    { 463, 6, 224 },
                    { 463, 2, 225 },
                    { 464, 4, 226 },
                    { 464, 6, 227 },
                    { 464, 1, 228 },
                    { 347, 4, 229 },
                    { 347, 6, 230 },
                    { 347, 2, 231 },
                    { 348, 4, 232 },
                    { 466, 1, 222 },
                    { 274, 4, 260 },
                    { 274, 5, 261 },
                    { 274, 1, 262 },
                    { 421, 4, 290 },
                    { 421, 5, 291 },
                    { 421, 1, 292 },
                    { 398, 4, 293 },
                    { 398, 5, 294 },
                    { 398, 2, 295 },
                    { 399, 4, 296 },
                    { 399, 5, 297 },
                    { 399, 1, 298 },
                    { 410, 4, 299 },
                    { 420, 2, 289 },
                    { 410, 5, 300 },
                    { 411, 4, 302 },
                    { 411, 5, 303 },
                    { 411, 1, 304 },
                    { 497, 4, 305 },
                    { 497, 5, 306 },
                    { 497, 2, 307 },
                    { 498, 4, 308 },
                    { 498, 5, 309 },
                    { 498, 1, 310 },
                    { 112, 4, 311 },
                    { 410, 2, 301 },
                    { 420, 5, 288 },
                    { 420, 4, 287 },
                    { 372, 1, 286 },
                    { 406, 4, 263 },
                    { 406, 5, 264 },
                    { 406, 2, 265 },
                    { 407, 4, 266 },
                    { 407, 5, 267 },
                    { 407, 1, 268 },
                    { 198, 4, 269 },
                    { 198, 5, 270 },
                    { 198, 2, 271 },
                    { 199, 4, 272 },
                    { 199, 5, 273 },
                    { 199, 1, 274 },
                    { 424, 4, 275 },
                    { 424, 5, 276 },
                    { 424, 2, 277 },
                    { 425, 4, 278 },
                    { 425, 5, 279 },
                    { 425, 1, 280 },
                    { 371, 4, 281 },
                    { 371, 5, 282 },
                    { 371, 2, 283 },
                    { 372, 4, 284 },
                    { 372, 5, 285 },
                    { 405, 4, 209 },
                    { 143, 4, 835 }
                });
        }
    }
}
