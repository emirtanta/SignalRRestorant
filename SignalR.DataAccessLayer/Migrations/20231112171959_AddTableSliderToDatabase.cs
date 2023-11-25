using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    public partial class AddTableSliderToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    SliderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Title2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Title3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description1 = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Description3 = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.SliderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
