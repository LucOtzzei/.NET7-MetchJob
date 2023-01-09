using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Otzzei.MetchJob.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class VacanciesFilledInJobOpportunity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "JobOpportunities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "VacanciesFilled",
                table: "JobOpportunities",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "JobOpportunities");

            migrationBuilder.DropColumn(
                name: "VacanciesFilled",
                table: "JobOpportunities");
        }
    }
}
