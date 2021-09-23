namespace FootballTournamentSystem.Infrastructure.Persistence.DbContextInterfaces
{
    using Domain.Models.Person.Referee;
    using Domain.Models.Person.President;
    using Domain.Models.Person.Player;
    using Domain.Models.Person.Coach;
    using Microsoft.EntityFrameworkCore;
    using Common.Infrastructure.Persistence;

    internal interface IPersonDbContext : IDbContext
    {
        DbSet<Referee> Referees { get; }

        DbSet<President> Presidents { get; }

        DbSet<Player> Players { get; }

        DbSet<Coach> Coaches { get; }
    }
}
