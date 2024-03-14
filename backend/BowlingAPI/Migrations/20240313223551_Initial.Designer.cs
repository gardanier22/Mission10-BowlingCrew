﻿// <auto-generated />
using System;
using BowlingAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BowlingAPI.Migrations
{
    [DbContext(typeof(BowlingLeagueContext))]
    [Migration("20240313223551_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("BowlingAPI.Data.Bowler", b =>
                {
                    b.Property<int>("BowlerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("BowlerID");

                    b.Property<string>("BowlerAddress")
                        .HasColumnType("nvarchar (50)");

                    b.Property<string>("BowlerCity")
                        .HasColumnType("nvarchar (50)");

                    b.Property<string>("BowlerFirstName")
                        .HasColumnType("nvarchar (50)");

                    b.Property<string>("BowlerLastName")
                        .HasColumnType("nvarchar (50)");

                    b.Property<string>("BowlerMiddleInit")
                        .HasColumnType("nvarchar (1)");

                    b.Property<string>("BowlerPhoneNumber")
                        .HasColumnType("nvarchar (14)");

                    b.Property<string>("BowlerState")
                        .HasColumnType("nvarchar (2)");

                    b.Property<string>("BowlerZip")
                        .HasColumnType("nvarchar (10)");

                    b.Property<int?>("TeamId")
                        .HasColumnType("INT")
                        .HasColumnName("TeamID");

                    b.HasKey("BowlerId");

                    b.HasIndex(new[] { "BowlerLastName" }, "BowlerLastName");

                    b.HasIndex(new[] { "TeamId" }, "BowlersTeamID");

                    b.ToTable("Bowlers");
                });

            modelBuilder.Entity("BowlingAPI.Data.BowlerScore", b =>
                {
                    b.Property<int>("MatchId")
                        .HasColumnType("INT")
                        .HasColumnName("MatchID");

                    b.Property<short>("GameNumber")
                        .HasColumnType("smallint");

                    b.Property<int>("BowlerId")
                        .HasColumnType("INT")
                        .HasColumnName("BowlerID");

                    b.Property<short?>("HandiCapScore")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)0);

                    b.Property<short?>("RawScore")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)0);

                    b.Property<bool>("WonGame")
                        .HasColumnType("bit");

                    b.HasKey("MatchId", "GameNumber", "BowlerId");

                    b.HasIndex(new[] { "BowlerId" }, "BowlerID");

                    b.HasIndex(new[] { "MatchId", "GameNumber" }, "MatchGamesBowlerScores");

                    b.ToTable("Bowler_Scores", (string)null);
                });

            modelBuilder.Entity("BowlingAPI.Data.MatchGame", b =>
                {
                    b.Property<int>("MatchId")
                        .HasColumnType("INT")
                        .HasColumnName("MatchID");

                    b.Property<short>("GameNumber")
                        .HasColumnType("smallint");

                    b.Property<int?>("WinningTeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasDefaultValue(0)
                        .HasColumnName("WinningTeamID");

                    b.HasKey("MatchId", "GameNumber");

                    b.HasIndex(new[] { "WinningTeamId" }, "Team1ID");

                    b.HasIndex(new[] { "MatchId" }, "TourneyMatchesMatchGames");

                    b.ToTable("Match_Games", (string)null);
                });

            modelBuilder.Entity("BowlingAPI.Data.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("TeamID");

                    b.Property<int?>("CaptainId")
                        .HasColumnType("INT")
                        .HasColumnName("CaptainID");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar (50)");

                    b.HasKey("TeamId");

                    b.HasIndex(new[] { "TeamId" }, "TeamID")
                        .IsUnique();

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("BowlingAPI.Data.Tournament", b =>
                {
                    b.Property<int>("TourneyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("TourneyID");

                    b.Property<DateOnly?>("TourneyDate")
                        .HasColumnType("date");

                    b.Property<string>("TourneyLocation")
                        .HasColumnType("nvarchar (50)");

                    b.HasKey("TourneyId");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("BowlingAPI.Data.TourneyMatch", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("MatchID");

                    b.Property<int?>("EvenLaneTeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasDefaultValue(0)
                        .HasColumnName("EvenLaneTeamID");

                    b.Property<string>("Lanes")
                        .HasColumnType("nvarchar (5)");

                    b.Property<int?>("OddLaneTeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasDefaultValue(0)
                        .HasColumnName("OddLaneTeamID");

                    b.Property<int?>("TourneyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasDefaultValue(0)
                        .HasColumnName("TourneyID");

                    b.HasKey("MatchId");

                    b.HasIndex(new[] { "OddLaneTeamId" }, "TourneyMatchesOdd");

                    b.HasIndex(new[] { "TourneyId" }, "TourneyMatchesTourneyID");

                    b.HasIndex(new[] { "EvenLaneTeamId" }, "Tourney_MatchesEven");

                    b.ToTable("Tourney_Matches", (string)null);
                });

            modelBuilder.Entity("BowlingAPI.Data.ZtblBowlerRating", b =>
                {
                    b.Property<string>("BowlerRating")
                        .HasColumnType("nvarchar (15)");

                    b.Property<short?>("BowlerHighAvg")
                        .HasColumnType("smallint");

                    b.Property<short?>("BowlerLowAvg")
                        .HasColumnType("smallint");

                    b.HasKey("BowlerRating");

                    b.ToTable("ztblBowlerRatings", (string)null);
                });

            modelBuilder.Entity("BowlingAPI.Data.ZtblSkipLabel", b =>
                {
                    b.Property<int>("LabelCount")
                        .HasColumnType("INT");

                    b.HasKey("LabelCount");

                    b.ToTable("ztblSkipLabels", (string)null);
                });

            modelBuilder.Entity("BowlingAPI.Data.ZtblWeek", b =>
                {
                    b.Property<DateOnly>("WeekStart")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("WeekEnd")
                        .HasColumnType("date");

                    b.HasKey("WeekStart");

                    b.ToTable("ztblWeeks", (string)null);
                });

            modelBuilder.Entity("BowlingAPI.Data.Bowler", b =>
                {
                    b.HasOne("BowlingAPI.Data.Team", "Team")
                        .WithMany("Bowlers")
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("BowlingAPI.Data.BowlerScore", b =>
                {
                    b.HasOne("BowlingAPI.Data.Bowler", "Bowler")
                        .WithMany("BowlerScores")
                        .HasForeignKey("BowlerId")
                        .IsRequired();

                    b.Navigation("Bowler");
                });

            modelBuilder.Entity("BowlingAPI.Data.MatchGame", b =>
                {
                    b.HasOne("BowlingAPI.Data.TourneyMatch", "Match")
                        .WithMany("MatchGames")
                        .HasForeignKey("MatchId")
                        .IsRequired();

                    b.Navigation("Match");
                });

            modelBuilder.Entity("BowlingAPI.Data.TourneyMatch", b =>
                {
                    b.HasOne("BowlingAPI.Data.Team", "EvenLaneTeam")
                        .WithMany("TourneyMatchEvenLaneTeams")
                        .HasForeignKey("EvenLaneTeamId");

                    b.HasOne("BowlingAPI.Data.Team", "OddLaneTeam")
                        .WithMany("TourneyMatchOddLaneTeams")
                        .HasForeignKey("OddLaneTeamId");

                    b.HasOne("BowlingAPI.Data.Tournament", "Tourney")
                        .WithMany("TourneyMatches")
                        .HasForeignKey("TourneyId");

                    b.Navigation("EvenLaneTeam");

                    b.Navigation("OddLaneTeam");

                    b.Navigation("Tourney");
                });

            modelBuilder.Entity("BowlingAPI.Data.Bowler", b =>
                {
                    b.Navigation("BowlerScores");
                });

            modelBuilder.Entity("BowlingAPI.Data.Team", b =>
                {
                    b.Navigation("Bowlers");

                    b.Navigation("TourneyMatchEvenLaneTeams");

                    b.Navigation("TourneyMatchOddLaneTeams");
                });

            modelBuilder.Entity("BowlingAPI.Data.Tournament", b =>
                {
                    b.Navigation("TourneyMatches");
                });

            modelBuilder.Entity("BowlingAPI.Data.TourneyMatch", b =>
                {
                    b.Navigation("MatchGames");
                });
#pragma warning restore 612, 618
        }
    }
}