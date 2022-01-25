namespace FootballTournamentSystem.Infrastructure
{
    using System;
    using Core.Application.Contracts;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using FootballTournamentSystem.Statistics.Infrastructure.Persistance;
    using FootballTournamentSystem.Statistics.Application.Features.MatchStatistics;
    using FootballTournamentSystem.Statistics.Infrastructure.Repositories.MatchStatistics;
    using FootballTournamentSystem.Statistics.Application.Features.PlayerStatistics;
    using FootballTournamentSystem.Statistics.Infrastructure.Repositories.PlayerStatistics;
    using FootballTournamentSystem.Statistics.Application.Features.TournamentStatistics;
    using FootballTournamentSystem.Statistics.Infrastructure.Repositories.TournamentStatistics;
    using FootballTournamentSystem.Statistics.Infrastructure.Repositories;

    public static class InfrastructureConfiguration
    {
        public static IServiceCollection AddStatisticsInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
            => services
                .AddDbContext<StatisticsDbContext>(options => options
                    .UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection"),
                        sqlOptions => sqlOptions
                            .EnableRetryOnFailure(
                                maxRetryCount: 10,
                                maxRetryDelay: TimeSpan.FromSeconds(30),
                                errorNumbersToAdd: null)
                        /*b => b.MigrationsAssembly(typeof(StatisticsDbContext).Assembly.FullName)*/))
                .AddTransient<IMatchStatisticsRepository, MatchStatisticsRepository>()
                .AddTransient<IPlayerStatisticsRepository, PlayerStatisticsRepository>()
                .AddTransient<ITournamentStatisticsRepository, TournamentStatisticsRepository>()
                .AddTransient(typeof(IRepository<>), typeof(FootballTournamentDataRepository<>));
    }
}
