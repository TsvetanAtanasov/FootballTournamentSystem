namespace FootballTournamentSystem.Infrastructure.Persistence.DbContextInterfaces
{
    using Domain.Models.PersonContext.Referee;
    using Domain.Models.PersonContext.President;
    using Domain.Models.PersonContext.Player;
    using Domain.Models.PersonContext.Coach;
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
