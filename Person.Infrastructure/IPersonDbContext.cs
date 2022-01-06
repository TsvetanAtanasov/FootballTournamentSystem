namespace FootballTournamentSystem.Person.Infrastructure
{
    using Microsoft.EntityFrameworkCore;
    using Core.Infrastructure.Persistence;
    using FootballTournamentSystem.Person.Domain.Models.Referee;
    using FootballTournamentSystem.Person.Domain.Models.President;
    using FootballTournamentSystem.Person.Domain.Models.Player;
    using FootballTournamentSystem.Person.Domain.Models.Coach;

    internal interface IPersonDbContext : IDbContext
    {
        DbSet<Referee> Referees { get; }

        DbSet<President> Presidents { get; }

        DbSet<Player> Players { get; }

        DbSet<Coach> Coaches { get; }
    }
}
