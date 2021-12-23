namespace FootballTournamentSystem.Tournament.Infrastructure.Tournament
{
    using FootballTournamentSystem.Tournament.Domain.Models.Tournament;
    using FootballTournamentSystem.Tournament.Domain.Models.Match;
    using Microsoft.EntityFrameworkCore;
    using FootballTournamentSystem.Tournament.Domain.Models.Team;
    using Core.Infrastructure.Persistence;

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
