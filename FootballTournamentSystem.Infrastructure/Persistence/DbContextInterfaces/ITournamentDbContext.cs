namespace FootballTournamentSystem.Infrastructure.Persistence.DbContextInterfaces
{
    using Domain.Models.TournamentContext.Tournament;
    using Domain.Models.TournamentContext.Match;
    using Microsoft.EntityFrameworkCore;
    using Domain.Models.TournamentContext.Team;

    internal interface ITournamentDbContext
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
