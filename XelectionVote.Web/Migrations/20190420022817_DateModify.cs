using Microsoft.EntityFrameworkCore.Migrations;

namespace XelectionVote.Web.Migrations
{
    public partial class DateModify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VoteId",
                table: "Votes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Votes_VoteId",
                table: "Votes",
                column: "VoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Votes_VoteId",
                table: "Votes",
                column: "VoteId",
                principalTable: "Votes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Votes_VoteId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_VoteId",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "VoteId",
                table: "Votes");
        }
    }
}
