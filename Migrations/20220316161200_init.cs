using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GetShitDoneBackend.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectItemInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembersId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembersUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectItemInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskItemInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assignees = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItemInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsProjectManager = table.Column<bool>(type: "bit", nullable: false),
                    IsSpecialist = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectItemInfo");

            migrationBuilder.DropTable(
                name: "TaskItemInfo");

            migrationBuilder.DropTable(
                name: "UserInfo");
        }
    }
}
