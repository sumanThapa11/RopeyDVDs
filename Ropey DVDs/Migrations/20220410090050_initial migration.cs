using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ropey_DVDs.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ActorSurname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ActorFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorNumber);
                });

            migrationBuilder.CreateTable(
                name: "DVDCategories",
                columns: table => new
                {
                    CategoryNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeRestricted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DVDCategories", x => x.CategoryNumber);
                });

            migrationBuilder.CreateTable(
                name: "LoanTypes",
                columns: table => new
                {
                    LoanNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoanName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoanDuration = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanTypes", x => x.LoanNumber);
                });

            migrationBuilder.CreateTable(
                name: "MembershipCategories",
                columns: table => new
                {
                    MembershipCategoryNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MembershipCategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MembershipCategoryTotalLoans = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipCategories", x => x.MembershipCategoryNumber);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    ProducerNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProducerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.ProducerNumber);
                });

            migrationBuilder.CreateTable(
                name: "Studios",
                columns: table => new
                {
                    StudioNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudioName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studios", x => x.StudioNumber);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MembershipCategoryNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MembershipCategoryNumber1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MemberLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MemberFirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MemberAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MemberDateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberNumber);
                    table.ForeignKey(
                        name: "FK_Members_MembershipCategories_MembershipCategoryNumber1",
                        column: x => x.MembershipCategoryNumber1,
                        principalTable: "MembershipCategories",
                        principalColumn: "MembershipCategoryNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DVDTitles",
                columns: table => new
                {
                    DVDNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DVDCategoryCategoryNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StudioNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudioNumber1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProducerNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProducerNumber1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    DateReleased = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StandardCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PenaltyCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DVDTitles", x => x.DVDNumber);
                    table.ForeignKey(
                        name: "FK_DVDTitles_DVDCategories_DVDCategoryCategoryNumber",
                        column: x => x.DVDCategoryCategoryNumber,
                        principalTable: "DVDCategories",
                        principalColumn: "CategoryNumber");
                    table.ForeignKey(
                        name: "FK_DVDTitles_Producers_ProducerNumber1",
                        column: x => x.ProducerNumber1,
                        principalTable: "Producers",
                        principalColumn: "ProducerNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DVDTitles_Studios_StudioNumber1",
                        column: x => x.StudioNumber1,
                        principalTable: "Studios",
                        principalColumn: "StudioNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CastMembers",
                columns: table => new
                {
                    DVDNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ActorNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DVDTitleDVDNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ActorNumber1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastMembers", x => new { x.DVDNumber, x.ActorNumber });
                    table.ForeignKey(
                        name: "FK_CastMembers_Actors_ActorNumber1",
                        column: x => x.ActorNumber1,
                        principalTable: "Actors",
                        principalColumn: "ActorNumber");
                    table.ForeignKey(
                        name: "FK_CastMembers_DVDTitles_DVDTitleDVDNumber",
                        column: x => x.DVDTitleDVDNumber,
                        principalTable: "DVDTitles",
                        principalColumn: "DVDNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DVDCopies",
                columns: table => new
                {
                    CopyNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DVDNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DVDTitleDVDNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DatePurchased = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DVDCopies", x => x.CopyNumber);
                    table.ForeignKey(
                        name: "FK_DVDCopies_DVDTitles_DVDTitleDVDNumber",
                        column: x => x.DVDTitleDVDNumber,
                        principalTable: "DVDTitles",
                        principalColumn: "DVDNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    LoanNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoanTypeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoanTypeLoanNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CopyNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DVDCopyCopyNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MemberNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberNumber1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateReturned = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.LoanNumber);
                    table.ForeignKey(
                        name: "FK_Loans_DVDCopies_DVDCopyCopyNumber",
                        column: x => x.DVDCopyCopyNumber,
                        principalTable: "DVDCopies",
                        principalColumn: "CopyNumber");
                    table.ForeignKey(
                        name: "FK_Loans_LoanTypes_LoanTypeLoanNumber",
                        column: x => x.LoanTypeLoanNumber,
                        principalTable: "LoanTypes",
                        principalColumn: "LoanNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_Members_MemberNumber1",
                        column: x => x.MemberNumber1,
                        principalTable: "Members",
                        principalColumn: "MemberNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CastMembers_ActorNumber1",
                table: "CastMembers",
                column: "ActorNumber1");

            migrationBuilder.CreateIndex(
                name: "IX_CastMembers_DVDTitleDVDNumber",
                table: "CastMembers",
                column: "DVDTitleDVDNumber");

            migrationBuilder.CreateIndex(
                name: "IX_DVDCopies_DVDTitleDVDNumber",
                table: "DVDCopies",
                column: "DVDTitleDVDNumber");

            migrationBuilder.CreateIndex(
                name: "IX_DVDTitles_DVDCategoryCategoryNumber",
                table: "DVDTitles",
                column: "DVDCategoryCategoryNumber");

            migrationBuilder.CreateIndex(
                name: "IX_DVDTitles_ProducerNumber1",
                table: "DVDTitles",
                column: "ProducerNumber1");

            migrationBuilder.CreateIndex(
                name: "IX_DVDTitles_StudioNumber1",
                table: "DVDTitles",
                column: "StudioNumber1");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_DVDCopyCopyNumber",
                table: "Loans",
                column: "DVDCopyCopyNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LoanTypeLoanNumber",
                table: "Loans",
                column: "LoanTypeLoanNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_MemberNumber1",
                table: "Loans",
                column: "MemberNumber1");

            migrationBuilder.CreateIndex(
                name: "IX_Members_MembershipCategoryNumber1",
                table: "Members",
                column: "MembershipCategoryNumber1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CastMembers");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "DVDCopies");

            migrationBuilder.DropTable(
                name: "LoanTypes");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "DVDTitles");

            migrationBuilder.DropTable(
                name: "MembershipCategories");

            migrationBuilder.DropTable(
                name: "DVDCategories");

            migrationBuilder.DropTable(
                name: "Producers");

            migrationBuilder.DropTable(
                name: "Studios");
        }
    }
}
