using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class createInstituteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Institute",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Locale = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Lat = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Long = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institute", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Institute");
        }
    }
}
