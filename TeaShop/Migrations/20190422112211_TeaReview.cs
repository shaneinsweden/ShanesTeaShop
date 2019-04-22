using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeaShop.Migrations
{
    public partial class TeaReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeaReviews",
                columns: table => new
                {
                    TeaReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeaId = table.Column<int>(nullable: false),
                    ReviewedBy = table.Column<string>(nullable: true),
                    ReviewedOn = table.Column<DateTime>(nullable: false),
                    ReviewTitle = table.Column<string>(nullable: true),
                    ReviewText = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeaReviews", x => x.TeaReviewId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeaReviews");
        }
    }
}
