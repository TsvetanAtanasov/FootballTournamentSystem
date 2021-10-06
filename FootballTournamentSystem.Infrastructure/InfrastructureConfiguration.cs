namespace FootballTournamentSystem.Infrastructure
{
    using Application.Contracts;
    using Core.Infrastructure.Events;
    using FootballTournamentSystem.Application.Features.Person.Coach;
    using FootballTournamentSystem.Application.Features.Person.Player;
    using FootballTournamentSystem.Application.Features.Person.President;
    using FootballTournamentSystem.Application.Features.Person.Referee;
    using FootballTournamentSystem.Application.Features.Statistics.MatchStatistics;
    using FootballTournamentSystem.Application.Features.Statistics.PlayerStatistics;
    using FootballTournamentSystem.Application.Features.Statistics.TournamentStatistics;
    using FootballTournamentSystem.Application.Features.Tournament.Match;
    using FootballTournamentSystem.Application.Features.Tournament.Team;
    using FootballTournamentSystem.Application.Features.Tournament.Tournament;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.Person.Coach;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.Person.Player;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.Person.President;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.Person.Referee;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.Statistics.MatchStatistics;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.Statistics.PlayerStatistics;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.Statistics.TournamentStatistics;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.Tournament.Match;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.Tournament.Team;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.Tournament.Tournament;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Persistence;

    public static class InfrastructureConfiguration
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
            => services
                .AddDbContext<FootballTournamentDbContext>(options => options
                    .UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection"),
                        b => b.MigrationsAssembly(typeof(FootballTournamentDbContext).Assembly.FullName)))
                .AddTransient<IEventDispatcher, EventDispatcher>()
                .AddTransient<ITournamentRepository, TournamentRepository>()
                .AddTransient<ITeamRepository, TeamRepository>()
                .AddTransient<IMatchRepository, MatchRepository>()
                .AddTransient<IMatchStatisticsRepository, MatchStatisticsRepository>()
                .AddTransient<IPlayerStatisticsRepository, PlayerStatisticsRepository>()
                .AddTransient<ITournamentStatisticsRepository, TournamentStatisticsRepository>()
                .AddTransient<ICoachRepository, CoachRepository>()
                .AddTransient<IPlayerRepository, PlayerRepository>()
                .AddTransient<IPresidentRepository, PresidentRepository>()
                .AddTransient<IRefereeRepository, RefereeRepository>()
                .AddTransient(typeof(IRepository<>), typeof(FootballTournamentDataRepository<>));
    }
}
