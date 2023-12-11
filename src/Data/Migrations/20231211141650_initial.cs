using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeerPositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeerPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMediaAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlatformName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMediaAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employeers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employeers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employeers_EmployeerPositions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "EmployeerPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSocialMedia",
                columns: table => new
                {
                    EmployeerId = table.Column<int>(type: "int", nullable: false),
                    SocialMediaId = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSocialMedia", x => new { x.EmployeerId, x.SocialMediaId });
                    table.ForeignKey(
                        name: "FK_EmployeeSocialMedia_Employeers_EmployeerId",
                        column: x => x.EmployeerId,
                        principalTable: "Employeers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeSocialMedia_SocialMediaAccounts_SocialMediaId",
                        column: x => x.SocialMediaId,
                        principalTable: "SocialMediaAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employeers_PositionId",
                table: "Employeers",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSocialMedia_SocialMediaId",
                table: "EmployeeSocialMedia",
                column: "SocialMediaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeSocialMedia");

            migrationBuilder.DropTable(
                name: "Employeers");

            migrationBuilder.DropTable(
                name: "SocialMediaAccounts");

            migrationBuilder.DropTable(
                name: "EmployeerPositions");
        }
    }
}
