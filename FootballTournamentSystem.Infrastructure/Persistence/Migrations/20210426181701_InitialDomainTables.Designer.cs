﻿// <auto-generated />
using System;
using FootballTournamentSystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FootballTournamentSystem.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(FootballTournamentDbContext))]
    [Migration("20210426181701_InitialDomainTables")]
    partial class InitialDomainTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.PersonContext.Coach.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Coaches");
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.PersonContext.Player.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<int>("PlayerStatisticsId")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PlayerStatisticsId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.PersonContext.President.President", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Presidents");
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.PersonContext.Referee.Referee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Referees");
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.StatisticsContext.MatchStatistics.MatchStatistics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AwayTeamGoals")
                        .HasColumnType("int");

                    b.Property<int>("HomeTeamGoals")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MatchStatistics");
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.StatisticsContext.PlayerStatistics.PlayerStatistics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Assists")
                        .HasColumnType("int");

                    b.Property<int>("GoalsScored")
                        .HasColumnType("int");

                    b.Property<int>("MinutesPlayed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PlayerStatistics");
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.StatisticsContext.TournamentStatistics.TournamentStatistics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GoalScorerId")
                        .HasColumnType("int");

                    b.Property<int>("GoalsScored")
                        .HasColumnType("int");

                    b.Property<int>("WinnerTeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TournamentStatistics");
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.TournamentContext.Match.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("MatchStatisticsId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerStatisticsId")
                        .HasColumnType("int");

                    b.Property<int?>("QuarterFinalsId")
                        .HasColumnType("int");

                    b.Property<int>("RefereeId")
                        .HasColumnType("int");

                    b.Property<int?>("RoundOf16Id")
                        .HasColumnType("int");

                    b.Property<int?>("SemiFinalsId")
                        .HasColumnType("int");

                    b.Property<int?>("TournamentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("MatchStatisticsId");

                    b.HasIndex("PlayerStatisticsId");

                    b.HasIndex("QuarterFinalsId");

                    b.HasIndex("RefereeId");

                    b.HasIndex("RoundOf16Id");

                    b.HasIndex("SemiFinalsId");

                    b.HasIndex("TournamentId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.TournamentContext.Team.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CoachId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("GroupPoints")
                        .HasColumnType("int");

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(2048)")
                        .HasMaxLength(2048);

                    b.Property<int?>("MatchId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("PresidentId")
                        .HasColumnType("int");

                    b.Property<string>("Stadium")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("YearFounded")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoachId");

                    b.HasIndex("GroupId");

                    b.HasIndex("MatchId");

                    b.HasIndex("PresidentId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.Final", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.ToTable("Finals");
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int?>("TournamentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TournamentId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.QuarterFinals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("QuarterFinals");
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.RoundOf16", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("RoundOf16s");
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.SemiFinals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("SemiFinals");
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FinalId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("NumberOfTeams")
                        .HasColumnType("int");

                    b.Property<int?>("QuarterFinalsId")
                        .HasColumnType("int");

                    b.Property<int?>("RoundOf16Id")
                        .HasColumnType("int");

                    b.Property<int?>("SemiFinalsId")
                        .HasColumnType("int");

                    b.Property<int>("TournamentStatisticsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FinalId");

                    b.HasIndex("QuarterFinalsId");

                    b.HasIndex("RoundOf16Id");

                    b.HasIndex("SemiFinalsId");

                    b.HasIndex("TournamentStatisticsId");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.PersonContext.Player.Player", b =>
                {
                    b.HasOne("FootballTournamentSystem.Domain.Models.StatisticsContext.PlayerStatistics.PlayerStatistics", null)
                        .WithMany()
                        .HasForeignKey("PlayerStatisticsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.TournamentContext.Match.Match", b =>
                {
                    b.HasOne("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.Group", null)
                        .WithMany("Matches")
                        .HasForeignKey("GroupId");

                    b.HasOne("FootballTournamentSystem.Domain.Models.StatisticsContext.MatchStatistics.MatchStatistics", null)
                        .WithMany()
                        .HasForeignKey("MatchStatisticsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FootballTournamentSystem.Domain.Models.StatisticsContext.PlayerStatistics.PlayerStatistics", null)
                        .WithMany()
                        .HasForeignKey("PlayerStatisticsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.QuarterFinals", null)
                        .WithMany("Matches")
                        .HasForeignKey("QuarterFinalsId");

                    b.HasOne("FootballTournamentSystem.Domain.Models.PersonContext.Referee.Referee", null)
                        .WithMany()
                        .HasForeignKey("RefereeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.RoundOf16", null)
                        .WithMany("Matches")
                        .HasForeignKey("RoundOf16Id");

                    b.HasOne("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.SemiFinals", null)
                        .WithMany("Matches")
                        .HasForeignKey("SemiFinalsId");

                    b.HasOne("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.Tournament", null)
                        .WithMany("Matches")
                        .HasForeignKey("TournamentId");
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.TournamentContext.Team.Team", b =>
                {
                    b.HasOne("FootballTournamentSystem.Domain.Models.PersonContext.Coach.Coach", null)
                        .WithMany()
                        .HasForeignKey("CoachId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.Group", null)
                        .WithMany("Teams")
                        .HasForeignKey("GroupId");

                    b.HasOne("FootballTournamentSystem.Domain.Models.TournamentContext.Match.Match", null)
                        .WithMany("Teams")
                        .HasForeignKey("MatchId");

                    b.HasOne("FootballTournamentSystem.Domain.Models.PersonContext.President.President", null)
                        .WithMany()
                        .HasForeignKey("PresidentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.Final", b =>
                {
                    b.HasOne("FootballTournamentSystem.Domain.Models.TournamentContext.Match.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.Group", b =>
                {
                    b.HasOne("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.Tournament", null)
                        .WithMany("Groups")
                        .HasForeignKey("TournamentId");
                });

            modelBuilder.Entity("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.Tournament", b =>
                {
                    b.HasOne("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.Final", "Final")
                        .WithMany()
                        .HasForeignKey("FinalId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.QuarterFinals", "QuarterFinals")
                        .WithMany()
                        .HasForeignKey("QuarterFinalsId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.RoundOf16", "RoundOf16")
                        .WithMany()
                        .HasForeignKey("RoundOf16Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FootballTournamentSystem.Domain.Models.TournamentContext.Tournament.SemiFinals", "SemiFinals")
                        .WithMany()
                        .HasForeignKey("SemiFinalsId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FootballTournamentSystem.Domain.Models.StatisticsContext.TournamentStatistics.TournamentStatistics", null)
                        .WithMany()
                        .HasForeignKey("TournamentStatisticsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}