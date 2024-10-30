using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Front_To_Back_Project.Migrations
{
    /// <inheritdoc />
    public partial class addmigratonPricingPlanAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PricingPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Users = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Space = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sources = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Support = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalFeature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingPlans", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PricingPlans");
        }
    }
}
