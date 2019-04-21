using Microsoft.EntityFrameworkCore.Migrations;

namespace XelectionVote.Web.Migrations
{
    public partial class ChangesError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Candidates",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_EventId",
                table: "Candidates",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Events_EventId",
                table: "Candidates",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Events_EventId",
                table: "Candidates");

            migrationBuilder.DropIndex(
                name: "IX_Candidates_EventId",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Candidates");

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
    }
}
