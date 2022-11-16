namespace FootballTournamentSystem.Tournament.Infrastructure.Persistance
{
    using System.Reflection;
    using Microsoft.EntityFrameworkCore;
    using Core.Infrastructure.Data;
    using FootballTournamentSystem.Tournament.Infrastructure;
    using FootballTournamentSystem.Tournament.Domain.Models.Tournament;
    using FootballTournamentSystem.Tournament.Domain.Models.Match;
    using FootballTournamentSystem.Tournament.Domain.Models.Team;


    public class TournamentDbContext : MessageDbContext,
        ITournamentDbContext
    {
        public TournamentDbContext(DbContextOptions<TournamentDbContext> options)
            : base(options)
        {
        }

        public DbSet<Tournament> Tournaments { get; set; } = default!;

        public DbSet<SemiFinals> SemiFinals { get; set; } = default!;

        public DbSet<RoundOf16> RoundOf16s { get; set; } = default!;

        public DbSet<QuarterFinals> QuarterFinals { get; set; } = default!;

        public DbSet<Group> Groups { get; set; } = default!;

        public DbSet<Final> Finals { get; set; } = default!;

        public DbSet<Match> Matches { get; set; } = default!;

        public DbSet<Team> Teams { get; set; } = default!;

        protected override Assembly ConfigurationsAssembly => Assembly.GetExecutingAssembly();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
