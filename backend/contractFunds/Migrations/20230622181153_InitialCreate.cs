using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace contractFunds.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Backers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SurNameForBacker = table.Column<string>(type: "text", nullable: false),
                    FirstNameForBacker = table.Column<string>(type: "text", nullable: false),
                    UserNameForBacker = table.Column<string>(type: "text", nullable: false),
                    BirthDateForBacker = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EmailAddressForBacker = table.Column<string>(type: "text", nullable: false),
                    PasswordForBacker = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    SolanaAddressForRefund = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Creators",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SurNameForCreator = table.Column<string>(type: "text", nullable: false),
                    FirstNameForCreator = table.Column<string>(type: "text", nullable: false),
                    UserNameForCreator = table.Column<string>(type: "text", nullable: false),
                    BirthDateForCreator = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EmailAddressForCreator = table.Column<string>(type: "text", nullable: false),
                    PasswordForCreator = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    SolanaAddressForReceiveMoney = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProjectName = table.Column<string>(type: "text", nullable: false),
                    ProjectDescriptionShort = table.Column<string>(type: "text", nullable: false),
                    ProjectDescriptionLong = table.Column<string>(type: "text", nullable: false),
                    TeamDescription = table.Column<string>(type: "text", nullable: false),
                    ProjectLocation = table.Column<string>(type: "text", nullable: false),
                    Photos = table.Column<string>(type: "text", nullable: false),
                    Videos = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<int>(type: "integer", nullable: false),
                    RequestedAmountOfMoney = table.Column<double>(type: "double precision", nullable: false),
                    GatheredMoney = table.Column<double>(type: "double precision", nullable: false),
                    ProjectCreationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProjectDeadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProjectCreatorId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Creators_ProjectCreatorId",
                        column: x => x.ProjectCreatorId,
                        principalTable: "Creators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BackerProject",
                columns: table => new
                {
                    FavouriteProjectsId = table.Column<long>(type: "bigint", nullable: false),
                    ProjectBackersId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackerProject", x => new { x.FavouriteProjectsId, x.ProjectBackersId });
                    table.ForeignKey(
                        name: "FK_BackerProject_Backers_ProjectBackersId",
                        column: x => x.ProjectBackersId,
                        principalTable: "Backers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackerProject_Projects_FavouriteProjectsId",
                        column: x => x.FavouriteProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DonatorId = table.Column<long>(type: "bigint", nullable: false),
                    DonatedAmountOfMoney = table.Column<double>(type: "double precision", nullable: false),
                    DonationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DonatedProjectId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donations_Backers_DonatorId",
                        column: x => x.DonatorId,
                        principalTable: "Backers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donations_Projects_DonatedProjectId",
                        column: x => x.DonatedProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Milestones",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MilestoneTitle = table.Column<string>(type: "text", nullable: false),
                    MilestoneDescription = table.Column<string>(type: "text", nullable: false),
                    MilestoneCreationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MilestoneDeadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProjectOfMilestoneId = table.Column<long>(type: "bigint", nullable: false),
                    MoneyToUnlock = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Milestones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Milestones_Projects_ProjectOfMilestoneId",
                        column: x => x.ProjectOfMilestoneId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Votings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProjectToVoteId = table.Column<long>(type: "bigint", nullable: false),
                    StartOfVoting = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndOfVoting = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MilestoneToVoteId = table.Column<long>(type: "bigint", nullable: false),
                    TrustVote = table.Column<int>(type: "integer", nullable: false),
                    TrustlessVote = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Votings_Milestones_MilestoneToVoteId",
                        column: x => x.MilestoneToVoteId,
                        principalTable: "Milestones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Votings_Projects_ProjectToVoteId",
                        column: x => x.ProjectToVoteId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BackerProject_ProjectBackersId",
                table: "BackerProject",
                column: "ProjectBackersId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_DonatedProjectId",
                table: "Donations",
                column: "DonatedProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_DonatorId",
                table: "Donations",
                column: "DonatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Milestones_ProjectOfMilestoneId",
                table: "Milestones",
                column: "ProjectOfMilestoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectCreatorId",
                table: "Projects",
                column: "ProjectCreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Votings_MilestoneToVoteId",
                table: "Votings",
                column: "MilestoneToVoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Votings_ProjectToVoteId",
                table: "Votings",
                column: "ProjectToVoteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackerProject");

            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "Votings");

            migrationBuilder.DropTable(
                name: "Backers");

            migrationBuilder.DropTable(
                name: "Milestones");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Creators");
        }
    }
}
