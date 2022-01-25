namespace FootballTournamentSystem.Infrastructure
{
    using System;
    using Core.Application.Contracts;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using FootballTournamentSystem.Person.Infrastructure.Persistance;
    using FootballTournamentSystem.Person.Infrastructure.Repositories;
    using FootballTournamentSystem.Person.Application.Features.Coach;
    using FootballTournamentSystem.Person.Infrastructure.Repositories.Coach;
    using FootballTournamentSystem.Person.Application.Features.Player;
    using FootballTournamentSystem.Person.Infrastructure.Repositories.Player;
    using FootballTournamentSystem.Person.Application.Features.President;
    using FootballTournamentSystem.Person.Infrastructure.Repositories.Referee;
    using FootballTournamentSystem.Person.Infrastructure.Repositories.President;
    using Core.Infrastructure;

    public static class InfrastructureConfiguration
    {
        public static IServiceCollection AddStatisticsInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
            => services
                .AddDbContext<PersonDbContext>(options => options
                    .UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection"),
                        sqlOptions => sqlOptions
                            .EnableRetryOnFailure(
                                maxRetryCount: 10,
                                maxRetryDelay: TimeSpan.FromSeconds(30),
                                errorNumbersToAdd: null)
                        /*b => b.MigrationsAssembly(typeof(PersonDbContext).Assembly.FullName)*/))
                .AddTransient<ICoachRepository, CoachRepository>()
                .AddTransient<IPlayerRepository, PlayerRepository>()
                .AddTransient<IPresidentRepository, PresidentRepository>()
                .AddTransient<IRefereeRepository, RefereeRepository>()
                .AddTransient(typeof(IRepository<>), typeof(FootballTournamentDataRepository<>))
                .AddMessaging();
    }
}
