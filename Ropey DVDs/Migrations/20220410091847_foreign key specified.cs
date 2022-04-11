using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ropey_DVDs.Migrations
{
    public partial class foreignkeyspecified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CastMembers_Actors_ActorNumber1",
                table: "CastMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_CastMembers_DVDTitles_DVDTitleDVDNumber",
                table: "CastMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_DVDCopies_DVDTitles_DVDTitleDVDNumber",
                table: "DVDCopies");

            migrationBuilder.DropForeignKey(
                name: "FK_DVDTitles_DVDCategories_DVDCategoryCategoryNumber",
                table: "DVDTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_DVDTitles_Producers_ProducerNumber1",
                table: "DVDTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_DVDTitles_Studios_StudioNumber1",
                table: "DVDTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_DVDCopies_DVDCopyCopyNumber",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_LoanTypes_LoanTypeLoanNumber",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Members_MemberNumber1",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_MembershipCategories_MembershipCategoryNumber1",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_MembershipCategoryNumber1",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Loans_DVDCopyCopyNumber",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_Loans_LoanTypeLoanNumber",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_Loans_MemberNumber1",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_DVDTitles_DVDCategoryCategoryNumber",
                table: "DVDTitles");

            migrationBuilder.DropIndex(
                name: "IX_DVDTitles_ProducerNumber1",
                table: "DVDTitles");

            migrationBuilder.DropIndex(
                name: "IX_DVDTitles_StudioNumber1",
                table: "DVDTitles");

            migrationBuilder.DropIndex(
                name: "IX_DVDCopies_DVDTitleDVDNumber",
                table: "DVDCopies");

            migrationBuilder.DropIndex(
                name: "IX_CastMembers_ActorNumber1",
                table: "CastMembers");

            migrationBuilder.DropIndex(
                name: "IX_CastMembers_DVDTitleDVDNumber",
                table: "CastMembers");

            migrationBuilder.DropColumn(
                name: "MembershipCategoryNumber1",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "DVDCopyCopyNumber",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "LoanTypeLoanNumber",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "MemberNumber1",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "DVDCategoryCategoryNumber",
                table: "DVDTitles");

            migrationBuilder.DropColumn(
                name: "ProducerNumber1",
                table: "DVDTitles");

            migrationBuilder.DropColumn(
                name: "StudioNumber1",
                table: "DVDTitles");

            migrationBuilder.DropColumn(
                name: "DVDTitleDVDNumber",
                table: "DVDCopies");

            migrationBuilder.DropColumn(
                name: "ActorNumber1",
                table: "CastMembers");

            migrationBuilder.DropColumn(
                name: "DVDTitleDVDNumber",
                table: "CastMembers");

            migrationBuilder.AlterColumn<string>(
                name: "MembershipCategoryNumber",
                table: "Members",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MemberNumber",
                table: "Loans",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LoanTypeNumber",
                table: "Loans",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CopyNumber",
                table: "Loans",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StudioNumber",
                table: "DVDTitles",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardCharge",
                table: "DVDTitles",
                type: "decimal(9,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "ProducerNumber",
                table: "DVDTitles",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PenaltyCharge",
                table: "DVDTitles",
                type: "decimal(9,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryNumber",
                table: "DVDTitles",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DVDNumber",
                table: "DVDCopies",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Members_MembershipCategoryNumber",
                table: "Members",
                column: "MembershipCategoryNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_CopyNumber",
                table: "Loans",
                column: "CopyNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LoanTypeNumber",
                table: "Loans",
                column: "LoanTypeNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_MemberNumber",
                table: "Loans",
                column: "MemberNumber");

            migrationBuilder.CreateIndex(
                name: "IX_DVDTitles_CategoryNumber",
                table: "DVDTitles",
                column: "CategoryNumber");

            migrationBuilder.CreateIndex(
                name: "IX_DVDTitles_ProducerNumber",
                table: "DVDTitles",
                column: "ProducerNumber");

            migrationBuilder.CreateIndex(
                name: "IX_DVDTitles_StudioNumber",
                table: "DVDTitles",
                column: "StudioNumber");

            migrationBuilder.CreateIndex(
                name: "IX_DVDCopies_DVDNumber",
                table: "DVDCopies",
                column: "DVDNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CastMembers_ActorNumber",
                table: "CastMembers",
                column: "ActorNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_CastMembers_Actors_ActorNumber",
                table: "CastMembers",
                column: "ActorNumber",
                principalTable: "Actors",
                principalColumn: "ActorNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CastMembers_DVDTitles_DVDNumber",
                table: "CastMembers",
                column: "DVDNumber",
                principalTable: "DVDTitles",
                principalColumn: "DVDNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DVDCopies_DVDTitles_DVDNumber",
                table: "DVDCopies",
                column: "DVDNumber",
                principalTable: "DVDTitles",
                principalColumn: "DVDNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DVDTitles_DVDCategories_CategoryNumber",
                table: "DVDTitles",
                column: "CategoryNumber",
                principalTable: "DVDCategories",
                principalColumn: "CategoryNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DVDTitles_Producers_ProducerNumber",
                table: "DVDTitles",
                column: "ProducerNumber",
                principalTable: "Producers",
                principalColumn: "ProducerNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DVDTitles_Studios_StudioNumber",
                table: "DVDTitles",
                column: "StudioNumber",
                principalTable: "Studios",
                principalColumn: "StudioNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_DVDCopies_CopyNumber",
                table: "Loans",
                column: "CopyNumber",
                principalTable: "DVDCopies",
                principalColumn: "CopyNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_LoanTypes_LoanTypeNumber",
                table: "Loans",
                column: "LoanTypeNumber",
                principalTable: "LoanTypes",
                principalColumn: "LoanNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Members_MemberNumber",
                table: "Loans",
                column: "MemberNumber",
                principalTable: "Members",
                principalColumn: "MemberNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_MembershipCategories_MembershipCategoryNumber",
                table: "Members",
                column: "MembershipCategoryNumber",
                principalTable: "MembershipCategories",
                principalColumn: "MembershipCategoryNumber",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CastMembers_Actors_ActorNumber",
                table: "CastMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_CastMembers_DVDTitles_DVDNumber",
                table: "CastMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_DVDCopies_DVDTitles_DVDNumber",
                table: "DVDCopies");

            migrationBuilder.DropForeignKey(
                name: "FK_DVDTitles_DVDCategories_CategoryNumber",
                table: "DVDTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_DVDTitles_Producers_ProducerNumber",
                table: "DVDTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_DVDTitles_Studios_StudioNumber",
                table: "DVDTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_DVDCopies_CopyNumber",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_LoanTypes_LoanTypeNumber",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Members_MemberNumber",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_MembershipCategories_MembershipCategoryNumber",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_MembershipCategoryNumber",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Loans_CopyNumber",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_Loans_LoanTypeNumber",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_Loans_MemberNumber",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_DVDTitles_CategoryNumber",
                table: "DVDTitles");

            migrationBuilder.DropIndex(
                name: "IX_DVDTitles_ProducerNumber",
                table: "DVDTitles");

            migrationBuilder.DropIndex(
                name: "IX_DVDTitles_StudioNumber",
                table: "DVDTitles");

            migrationBuilder.DropIndex(
                name: "IX_DVDCopies_DVDNumber",
                table: "DVDCopies");

            migrationBuilder.DropIndex(
                name: "IX_CastMembers_ActorNumber",
                table: "CastMembers");

            migrationBuilder.AlterColumn<string>(
                name: "MembershipCategoryNumber",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "MembershipCategoryNumber1",
                table: "Members",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "MemberNumber",
                table: "Loans",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoanTypeNumber",
                table: "Loans",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "CopyNumber",
                table: "Loans",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "DVDCopyCopyNumber",
                table: "Loans",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoanTypeLoanNumber",
                table: "Loans",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MemberNumber1",
                table: "Loans",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "StudioNumber",
                table: "DVDTitles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<decimal>(
                name: "StandardCharge",
                table: "DVDTitles",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,2)");

            migrationBuilder.AlterColumn<string>(
                name: "ProducerNumber",
                table: "DVDTitles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PenaltyCharge",
                table: "DVDTitles",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,2)");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryNumber",
                table: "DVDTitles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "DVDCategoryCategoryNumber",
                table: "DVDTitles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProducerNumber1",
                table: "DVDTitles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudioNumber1",
                table: "DVDTitles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "DVDNumber",
                table: "DVDCopies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "DVDTitleDVDNumber",
                table: "DVDCopies",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ActorNumber1",
                table: "CastMembers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DVDTitleDVDNumber",
                table: "CastMembers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Members_MembershipCategoryNumber1",
                table: "Members",
                column: "MembershipCategoryNumber1");

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
                name: "IX_DVDCopies_DVDTitleDVDNumber",
                table: "DVDCopies",
                column: "DVDTitleDVDNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CastMembers_ActorNumber1",
                table: "CastMembers",
                column: "ActorNumber1");

            migrationBuilder.CreateIndex(
                name: "IX_CastMembers_DVDTitleDVDNumber",
                table: "CastMembers",
                column: "DVDTitleDVDNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_CastMembers_Actors_ActorNumber1",
                table: "CastMembers",
                column: "ActorNumber1",
                principalTable: "Actors",
                principalColumn: "ActorNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_CastMembers_DVDTitles_DVDTitleDVDNumber",
                table: "CastMembers",
                column: "DVDTitleDVDNumber",
                principalTable: "DVDTitles",
                principalColumn: "DVDNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DVDCopies_DVDTitles_DVDTitleDVDNumber",
                table: "DVDCopies",
                column: "DVDTitleDVDNumber",
                principalTable: "DVDTitles",
                principalColumn: "DVDNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DVDTitles_DVDCategories_DVDCategoryCategoryNumber",
                table: "DVDTitles",
                column: "DVDCategoryCategoryNumber",
                principalTable: "DVDCategories",
                principalColumn: "CategoryNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_DVDTitles_Producers_ProducerNumber1",
                table: "DVDTitles",
                column: "ProducerNumber1",
                principalTable: "Producers",
                principalColumn: "ProducerNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DVDTitles_Studios_StudioNumber1",
                table: "DVDTitles",
                column: "StudioNumber1",
                principalTable: "Studios",
                principalColumn: "StudioNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_DVDCopies_DVDCopyCopyNumber",
                table: "Loans",
                column: "DVDCopyCopyNumber",
                principalTable: "DVDCopies",
                principalColumn: "CopyNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_LoanTypes_LoanTypeLoanNumber",
                table: "Loans",
                column: "LoanTypeLoanNumber",
                principalTable: "LoanTypes",
                principalColumn: "LoanNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Members_MemberNumber1",
                table: "Loans",
                column: "MemberNumber1",
                principalTable: "Members",
                principalColumn: "MemberNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_MembershipCategories_MembershipCategoryNumber1",
                table: "Members",
                column: "MembershipCategoryNumber1",
                principalTable: "MembershipCategories",
                principalColumn: "MembershipCategoryNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
