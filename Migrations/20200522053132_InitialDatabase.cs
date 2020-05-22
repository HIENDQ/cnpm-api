using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace timtro.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    PermissionId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PermissionName = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.PermissionId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AdminPermission",
                columns: table => new
                {
                    AdminPermissionId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AdminId = table.Column<int>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false),
                    license = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminPermission", x => x.AdminPermissionId);
                    table.ForeignKey(
                        name: "FK_AdminPermission_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "AdminId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminPermission_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "PermissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermissionDetail",
                columns: table => new
                {
                    PermissionDetailId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PermissionId = table.Column<int>(nullable: false),
                    ActionName = table.Column<string>(nullable: true),
                    CheckAction = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionDetail", x => x.PermissionDetailId);
                    table.ForeignKey(
                        name: "FK_PermissionDetail_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "PermissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    NewsId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    Area = table.Column<float>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NewsId);
                    table.ForeignKey(
                        name: "FK_News_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CommentDetail = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    NewsId = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comment_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "NewsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminPermission_AdminId",
                table: "AdminPermission",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminPermission_PermissionId",
                table: "AdminPermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_NewsId",
                table: "Comment",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserId",
                table: "Comment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_News_UserId",
                table: "News",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionDetail_PermissionId",
                table: "PermissionDetail",
                column: "PermissionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminPermission");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "PermissionDetail");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
