using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniProject_LinkedIn.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ObjectTypes",
                columns: table => new
                {
                    ObjectType_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjectType_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedByDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedByDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectTypes", x => x.ObjectType_Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInformation",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    User_Profile_photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Background_photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Headline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Current_position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Education = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Industry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Contact_Info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedByDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedByDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInformation", x => x.User_ID);
                    table.ForeignKey(
                        name: "FK_UserInformation_UserInformation_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserInformation_UserInformation_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "View1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_View1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Objects",
                columns: table => new
                {
                    Object_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Object_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjectType_Id = table.Column<int>(type: "int", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedByDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedByDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objects", x => x.Object_Id);
                    table.ForeignKey(
                        name: "FK_Objects_ObjectTypes_ObjectType_Id",
                        column: x => x.ObjectType_Id,
                        principalTable: "ObjectTypes",
                        principalColumn: "ObjectType_Id");
                });

            migrationBuilder.CreateTable(
                name: "ParentObjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Parent_Id = table.Column<int>(type: "int", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedByDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedByDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentObjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParentObjects_ObjectTypes_Parent_Id",
                        column: x => x.Parent_Id,
                        principalTable: "ObjectTypes",
                        principalColumn: "ObjectType_Id");
                });

            migrationBuilder.CreateTable(
                name: "LicansesCertificate",
                columns: table => new
                {
                    LC_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LC_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_ID = table.Column<int>(type: "int", nullable: true),
                    LC_Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LC_Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedByDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedByDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicansesCertificate", x => x.LC_Id);
                    table.ForeignKey(
                        name: "FK_LicansesCertificate_UserInformation_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LicansesCertificate_UserInformation_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LicansesCertificate_UserInformation_User_ID",
                        column: x => x.User_ID,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Project_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(type: "int", nullable: true),
                    Project_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedByDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedByDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Project_Id);
                    table.ForeignKey(
                        name: "FK_Project_UserInformation_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_UserInformation_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_UserInformation_User_Id",
                        column: x => x.User_Id,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Skill_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Skill_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Id = table.Column<int>(type: "int", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedByDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedByDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Skill_Id);
                    table.ForeignKey(
                        name: "FK_Skill_UserInformation_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skill_UserInformation_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skill_UserInformation_User_Id",
                        column: x => x.User_Id,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User_Post",
                columns: table => new
                {
                    Post_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(type: "int", nullable: true),
                    Photo_Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedByDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedByDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Post", x => x.Post_Id);
                    table.ForeignKey(
                        name: "FK_User_Post_UserInformation_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Post_UserInformation_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Post_UserInformation_User_Id",
                        column: x => x.User_Id,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserConnections",
                columns: table => new
                {
                    UserConnection_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_ID = table.Column<int>(type: "int", nullable: true),
                    ConnectedUser_ID = table.Column<int>(type: "int", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedByDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedByDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserConnections", x => x.UserConnection_Id);
                    table.ForeignKey(
                        name: "FK_UserConnections_UserInformation_ConnectedUser_ID",
                        column: x => x.ConnectedUser_ID,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserConnections_UserInformation_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserConnections_UserInformation_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserConnections_UserInformation_User_ID",
                        column: x => x.User_ID,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Location_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City_Id = table.Column<int>(type: "int", nullable: true),
                    State_Id = table.Column<int>(type: "int", nullable: true),
                    country_Id = table.Column<int>(type: "int", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedByDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedByDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Location_Id);
                    table.ForeignKey(
                        name: "FK_Location_Objects_City_Id",
                        column: x => x.City_Id,
                        principalTable: "Objects",
                        principalColumn: "Object_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Location_Objects_State_Id",
                        column: x => x.State_Id,
                        principalTable: "Objects",
                        principalColumn: "Object_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Location_Objects_country_Id",
                        column: x => x.country_Id,
                        principalTable: "Objects",
                        principalColumn: "Object_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostComments",
                columns: table => new
                {
                    PostComment_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Post_Id = table.Column<int>(type: "int", nullable: true),
                    User_Id = table.Column<int>(type: "int", nullable: true),
                    Comment_Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedByDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedByDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComments", x => x.PostComment_Id);
                    table.ForeignKey(
                        name: "FK_PostComments_UserInformation_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostComments_UserInformation_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostComments_UserInformation_User_Id",
                        column: x => x.User_Id,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostComments_User_Post_Post_Id",
                        column: x => x.Post_Id,
                        principalTable: "User_Post",
                        principalColumn: "Post_Id");
                });

            migrationBuilder.CreateTable(
                name: "PostLikes",
                columns: table => new
                {
                    PostLike_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(type: "int", nullable: true),
                    Post_Id = table.Column<int>(type: "int", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedByDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedByDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostLikes", x => x.PostLike_Id);
                    table.ForeignKey(
                        name: "FK_PostLikes_UserInformation_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostLikes_UserInformation_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostLikes_UserInformation_User_Id",
                        column: x => x.User_Id,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostLikes_User_Post_Post_Id",
                        column: x => x.Post_Id,
                        principalTable: "User_Post",
                        principalColumn: "Post_Id");
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Company_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location_Id = table.Column<int>(type: "int", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedByDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedByDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Company_Id);
                    table.ForeignKey(
                        name: "FK_Company_Location_Location_Id",
                        column: x => x.Location_Id,
                        principalTable: "Location",
                        principalColumn: "Location_Id");
                });

            migrationBuilder.CreateTable(
                name: "CommentLikes",
                columns: table => new
                {
                    CommentLike_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostComment_Id = table.Column<int>(type: "int", nullable: true),
                    User_ID = table.Column<int>(type: "int", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedByDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedByDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentLikes", x => x.CommentLike_Id);
                    table.ForeignKey(
                        name: "FK_CommentLikes_PostComments_PostComment_Id",
                        column: x => x.PostComment_Id,
                        principalTable: "PostComments",
                        principalColumn: "PostComment_Id");
                    table.ForeignKey(
                        name: "FK_CommentLikes_UserInformation_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentLikes_UserInformation_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentLikes_UserInformation_User_ID",
                        column: x => x.User_ID,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    Exp_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company_Id = table.Column<int>(type: "int", nullable: true),
                    Employment_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedByDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedByDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience", x => x.Exp_Id);
                    table.ForeignKey(
                        name: "FK_Experience_Company_Company_Id",
                        column: x => x.Company_Id,
                        principalTable: "Company",
                        principalColumn: "Company_Id");
                    table.ForeignKey(
                        name: "FK_Experience_UserInformation_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Experience_UserInformation_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Experience_UserInformation_User_Id",
                        column: x => x.User_Id,
                        principalTable: "UserInformation",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_CreatedById",
                table: "CommentLikes",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_ModifiedById",
                table: "CommentLikes",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_PostComment_Id",
                table: "CommentLikes",
                column: "PostComment_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_User_ID",
                table: "CommentLikes",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Company_Location_Id",
                table: "Company",
                column: "Location_Id",
                unique: true,
                filter: "[Location_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_Company_Id",
                table: "Experience",
                column: "Company_Id",
                unique: true,
                filter: "[Company_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_CreatedById",
                table: "Experience",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_ModifiedById",
                table: "Experience",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_User_Id",
                table: "Experience",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_LicansesCertificate_CreatedById",
                table: "LicansesCertificate",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LicansesCertificate_ModifiedById",
                table: "LicansesCertificate",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_LicansesCertificate_User_ID",
                table: "LicansesCertificate",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Location_City_Id",
                table: "Location",
                column: "City_Id",
                unique: true,
                filter: "[City_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Location_country_Id",
                table: "Location",
                column: "country_Id",
                unique: true,
                filter: "[country_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Location_State_Id",
                table: "Location",
                column: "State_Id",
                unique: true,
                filter: "[State_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Objects_ObjectType_Id",
                table: "Objects",
                column: "ObjectType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ParentObjects_Parent_Id",
                table: "ParentObjects",
                column: "Parent_Id",
                unique: true,
                filter: "[Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_CreatedById",
                table: "PostComments",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_ModifiedById",
                table: "PostComments",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_Post_Id",
                table: "PostComments",
                column: "Post_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_User_Id",
                table: "PostComments",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PostLikes_CreatedById",
                table: "PostLikes",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PostLikes_ModifiedById",
                table: "PostLikes",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PostLikes_Post_Id",
                table: "PostLikes",
                column: "Post_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PostLikes_User_Id",
                table: "PostLikes",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Project_CreatedById",
                table: "Project",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ModifiedById",
                table: "Project",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Project_User_Id",
                table: "Project",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_CreatedById",
                table: "Skill",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_ModifiedById",
                table: "Skill",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_User_Id",
                table: "Skill",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Post_CreatedById",
                table: "User_Post",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_User_Post_ModifiedById",
                table: "User_Post",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_User_Post_User_Id",
                table: "User_Post",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserConnections_ConnectedUser_ID",
                table: "UserConnections",
                column: "ConnectedUser_ID");

            migrationBuilder.CreateIndex(
                name: "IX_UserConnections_CreatedById",
                table: "UserConnections",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserConnections_ModifiedById",
                table: "UserConnections",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserConnections_User_ID",
                table: "UserConnections",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_UserInformation_CreatedById",
                table: "UserInformation",
                column: "CreatedById",
                unique: true,
                filter: "[CreatedById] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserInformation_ModifiedById",
                table: "UserInformation",
                column: "ModifiedById",
                unique: true,
                filter: "[ModifiedById] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentLikes");

            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropTable(
                name: "LicansesCertificate");

            migrationBuilder.DropTable(
                name: "ParentObjects");

            migrationBuilder.DropTable(
                name: "PostLikes");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "UserConnections");

            migrationBuilder.DropTable(
                name: "View1");

            migrationBuilder.DropTable(
                name: "PostComments");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "User_Post");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "UserInformation");

            migrationBuilder.DropTable(
                name: "Objects");

            migrationBuilder.DropTable(
                name: "ObjectTypes");
        }
    }
}
