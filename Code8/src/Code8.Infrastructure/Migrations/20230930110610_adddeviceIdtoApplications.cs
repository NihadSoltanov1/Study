using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Code8.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class adddeviceIdtoApplications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeviceId",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeviceId",
                table: "Applicants");
        }
    }
}
