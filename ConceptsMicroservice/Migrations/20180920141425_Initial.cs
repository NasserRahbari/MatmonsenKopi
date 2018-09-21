using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ConceptsMicroservice.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConceptsItems",
                columns: table => new
                {
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ExternalId = table.Column<long>(nullable: false),
                    Created = table.Column<string>(nullable: true),
                    Updated = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    SupportedLanguages = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConceptsItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConceptsItems");
        }
    }
}
