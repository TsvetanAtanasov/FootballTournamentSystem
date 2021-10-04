namespace FootballTournamentSystem.Infrastructure.Persistence.DbContextInterfaces
{
    using Domain.Models.Tournament.Tournament;
    using Domain.Models.Tournament.Match;
    using Microsoft.EntityFrameworkCore;
    using Domain.Models.Tournament.Team;
    using Common.Infrastructure.Persistence;

    internal interface ITournamentDbContext : IDbContext
    {
        DbSet<Tournament> Tournaments { get; }

        DbSet<SemiFinals> SemiFinals { get; }

        DbSet<RoundOf16> RoundOf16s { get; }

        DbSet<QuarterFinals> QuarterFinals { get; }

        DbSet<Group> Groups { get; }

        DbSet<Final> Finals { get; }

        DbSet<Match> Matches { get; }

        DbSet<Team> Teams { get; }
    }
}
