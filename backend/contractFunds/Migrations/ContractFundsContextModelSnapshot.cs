﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using contractFunds.Model;

#nullable disable

namespace contractFunds.Migrations
{
    [DbContext(typeof(ContractFundsContext))]
    partial class ContractFundsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BackerProject", b =>
                {
                    b.Property<long>("FavouriteProjectsId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProjectBackersId")
                        .HasColumnType("bigint");

                    b.HasKey("FavouriteProjectsId", "ProjectBackersId");

                    b.HasIndex("ProjectBackersId");

                    b.ToTable("BackerProject");
                });

            modelBuilder.Entity("contractFunds.Model.Entities.Backer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("BirthDateForBacker")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EmailAddressForBacker")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstNameForBacker")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordForBacker")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("SolanaAddressForRefund")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SurNameForBacker")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserNameForBacker")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Backers");
                });

            modelBuilder.Entity("contractFunds.Model.Entities.Creator", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("BirthDateForCreator")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EmailAddressForCreator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstNameForCreator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordForCreator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("SolanaAddressForReceiveMoney")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SurNameForCreator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserNameForCreator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Creators");
                });

            modelBuilder.Entity("contractFunds.Model.Entities.Donation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<double>("DonatedAmountOfMoney")
                        .HasColumnType("double precision");

                    b.Property<long>("DonatedProjectId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DonationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("DonatorId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DonatedProjectId");

                    b.HasIndex("DonatorId");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("contractFunds.Model.Entities.Milestone", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("MilestoneCreationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("MilestoneDeadline")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MilestoneDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MilestoneTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("MoneyToUnlock")
                        .HasColumnType("double precision");

                    b.Property<long>("ProjectOfMilestoneId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProjectOfMilestoneId");

                    b.ToTable("Milestones");
                });

            modelBuilder.Entity("contractFunds.Model.Entities.Project", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Category")
                        .HasColumnType("integer");

                    b.Property<double>("GatheredMoney")
                        .HasColumnType("double precision");

                    b.Property<string>("Photos")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ProjectCreationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("ProjectCreatorId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ProjectDeadline")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ProjectDescriptionLong")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProjectDescriptionShort")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProjectLocation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("RequestedAmountOfMoney")
                        .HasColumnType("double precision");

                    b.Property<string>("TeamDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Videos")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProjectCreatorId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("contractFunds.Model.Entities.Voting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("EndOfVoting")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("MilestoneToVoteId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProjectToVoteId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartOfVoting")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("TrustVote")
                        .HasColumnType("integer");

                    b.Property<int>("TrustlessVote")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MilestoneToVoteId");

                    b.HasIndex("ProjectToVoteId");

                    b.ToTable("Votings");
                });

            modelBuilder.Entity("BackerProject", b =>
                {
                    b.HasOne("contractFunds.Model.Entities.Project", null)
                        .WithMany()
                        .HasForeignKey("FavouriteProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("contractFunds.Model.Entities.Backer", null)
                        .WithMany()
                        .HasForeignKey("ProjectBackersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("contractFunds.Model.Entities.Donation", b =>
                {
                    b.HasOne("contractFunds.Model.Entities.Project", "DonatedProject")
                        .WithMany("Donations")
                        .HasForeignKey("DonatedProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("contractFunds.Model.Entities.Backer", "Donator")
                        .WithMany("Donations")
                        .HasForeignKey("DonatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DonatedProject");

                    b.Navigation("Donator");
                });

            modelBuilder.Entity("contractFunds.Model.Entities.Milestone", b =>
                {
                    b.HasOne("contractFunds.Model.Entities.Project", "ProjectOfMilestone")
                        .WithMany("Milestones")
                        .HasForeignKey("ProjectOfMilestoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectOfMilestone");
                });

            modelBuilder.Entity("contractFunds.Model.Entities.Project", b =>
                {
                    b.HasOne("contractFunds.Model.Entities.Creator", "ProjectCreator")
                        .WithMany("Projects")
                        .HasForeignKey("ProjectCreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectCreator");
                });

            modelBuilder.Entity("contractFunds.Model.Entities.Voting", b =>
                {
                    b.HasOne("contractFunds.Model.Entities.Milestone", "MilestoneToVote")
                        .WithMany()
                        .HasForeignKey("MilestoneToVoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("contractFunds.Model.Entities.Project", "ProjectToVote")
                        .WithMany()
                        .HasForeignKey("ProjectToVoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MilestoneToVote");

                    b.Navigation("ProjectToVote");
                });

            modelBuilder.Entity("contractFunds.Model.Entities.Backer", b =>
                {
                    b.Navigation("Donations");
                });

            modelBuilder.Entity("contractFunds.Model.Entities.Creator", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("contractFunds.Model.Entities.Project", b =>
                {
                    b.Navigation("Donations");

                    b.Navigation("Milestones");
                });
#pragma warning restore 612, 618
        }
    }
}