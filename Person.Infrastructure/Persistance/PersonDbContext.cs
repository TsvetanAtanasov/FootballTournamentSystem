namespace FootballTournamentSystem.Person.Infrastructure.Persistance
{
    using System.Reflection;
    using Microsoft.EntityFrameworkCore;
    using FootballTournamentSystem.Person.Domain.Models.Coach;
    using FootballTournamentSystem.Person.Domain.Models.Player;
    using FootballTournamentSystem.Person.Domain.Models.President;
    using FootballTournamentSystem.Person.Domain.Models.Referee;

    public class PersonDbContext : DbContext,
        IPersonDbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options)
            : base(options)
        {
        }

        public DbSet<Referee> Referees { get; set; } = default!;

        public DbSet<President> Presidents { get; set; } = default!;

        public DbSet<Player> Players { get; set; } = default!;

        public DbSet<Coach> Coaches { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}