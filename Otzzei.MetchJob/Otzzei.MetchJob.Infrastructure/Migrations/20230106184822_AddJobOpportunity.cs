using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Otzzei.MetchJob.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddJobOpportunity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobOpportunities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ManagerJobId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalaryCurrency = table.Column<int>(type: "int", nullable: false),
                    MinimumWageAtWork = table.Column<double>(type: "float", nullable: false),
                    MaximumWageAtWork = table.Column<double>(type: "float", nullable: false),
                    JobsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobActivities = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobOpportunities", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobOpportunities");
        }
    }
}
