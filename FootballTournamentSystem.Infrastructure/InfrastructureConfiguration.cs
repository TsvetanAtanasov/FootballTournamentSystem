namespace FootballTournamentSystem.Infrastructure
{
    using Application.Contracts;
    using Common.Infrastructure.Events;
    using FootballTournamentSystem.Application.Features.Person.Coach;
    using FootballTournamentSystem.Application.Features.Person.Player;
    using FootballTournamentSystem.Application.Features.Person.President;
    using FootballTournamentSystem.Application.Features.Person.Referee;
    using FootballTournamentSystem.Application.Features.StatisticsContext.MatchStatistics;
    using FootballTournamentSystem.Application.Features.StatisticsContext.PlayerStatistics;
    using FootballTournamentSystem.Application.Features.StatisticsContext.TournamentStatistics;
    using FootballTournamentSystem.Application.Features.TournamentContext.Match;
    using FootballTournamentSystem.Application.Features.TournamentContext.Team;
    using FootballTournamentSystem.Application.Features.TournamentContext.Tournament;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.Person.Coach;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.Person.Player;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.Person.President;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.Person.Referee;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.StatisticsContext.MatchStatistics;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.StatisticsContext.PlayerStatistics;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.StatisticsContext.TournamentStatistics;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.TournamentContext.Match;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.TournamentContext.Team;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories.TournamentContext.Tournament;
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
