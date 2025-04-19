using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHousingAccomodation.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LandLordInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandLordInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginAttempts = table.Column<int>(type: "int", nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastPasswordChangeDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniversityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentInformation_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyMonthlyRent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsAvailable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TitleDeedsOrBillUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyIsApprovedByAdmin = table.Column<bool>(type: "bit", nullable: false),
                    PropertyAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyLatitudeCoordinates = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PropertLongitudeCoordinates = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PropertyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LandLordInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyInformation_LandLordInformation_LandLordInformationId",
                        column: x => x.LandLordInformationId,
                        principalTable: "LandLordInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyInformation_StudentInformation_StudentInformationId",
                        column: x => x.StudentInformationId,
                        principalTable: "StudentInformation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudentInterests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Interest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentInterests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentInterests_StudentInformation_StudentInformationId",
                        column: x => x.StudentInformationId,
                        principalTable: "StudentInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyAmentiesInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmentiesName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyAmentiesInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyAmentiesInformation_PropertyInformation_PropertyInformationId",
                        column: x => x.PropertyInformationId,
                        principalTable: "PropertyInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyRatings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PropertyInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyRatings_PropertyInformation_PropertyInformationId",
                        column: x => x.PropertyInformationId,
                        principalTable: "PropertyInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyRatings_StudentInformation_StudentInformationId",
                        column: x => x.StudentInformationId,
                        principalTable: "StudentInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomMonthlyRent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsAvailable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProperyInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StudentInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomInformation_PropertyInformation_PropertyInformationId",
                        column: x => x.PropertyInformationId,
                        principalTable: "PropertyInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RoomInformation_StudentInformation_StudentInformationId",
                        column: x => x.StudentInformationId,
                        principalTable: "StudentInformation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PropertyImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageResolution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomInformationGuidId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoomInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyImages_PropertyInformation_PropertyInformationId",
                        column: x => x.PropertyInformationId,
                        principalTable: "PropertyInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PropertyImages_RoomInformation_RoomInformationId",
                        column: x => x.RoomInformationId,
                        principalTable: "RoomInformation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyAmentiesInformation_PropertyInformationId",
                table: "PropertyAmentiesInformation",
                column: "PropertyInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyImages_PropertyInformationId",
                table: "PropertyImages",
                column: "PropertyInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyImages_RoomInformationId",
                table: "PropertyImages",
                column: "RoomInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyInformation_LandLordInformationId",
                table: "PropertyInformation",
                column: "LandLordInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyInformation_StudentInformationId",
                table: "PropertyInformation",
                column: "StudentInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyRatings_PropertyInformationId",
                table: "PropertyRatings",
                column: "PropertyInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyRatings_StudentInformationId",
                table: "PropertyRatings",
                column: "StudentInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomInformation_PropertyInformationId",
                table: "RoomInformation",
                column: "PropertyInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomInformation_StudentInformationId",
                table: "RoomInformation",
                column: "StudentInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInformation_UserId",
                table: "StudentInformation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInterests_StudentInformationId",
                table: "StudentInterests",
                column: "StudentInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_userId",
                table: "UserRoles",
                column: "userId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyAmentiesInformation");

            migrationBuilder.DropTable(
                name: "PropertyImages");

            migrationBuilder.DropTable(
                name: "PropertyRatings");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "StudentInterests");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "RoomInformation");

            migrationBuilder.DropTable(
                name: "PropertyInformation");

            migrationBuilder.DropTable(
                name: "LandLordInformation");

            migrationBuilder.DropTable(
                name: "StudentInformation");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
