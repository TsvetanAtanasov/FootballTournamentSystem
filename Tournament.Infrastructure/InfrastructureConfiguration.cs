namespace FootballTournamentSystem.Infrastructure
{
    using Core.Application.Contracts;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using FootballTournamentSystem.Tournament.Infrastructure.Persistance;
    using FootballTournamentSystem.Application.Features.Tournament.Tournament;
    using FootballTournamentSystem.Tournament.Infrastructure.Repositories.Tournament;
    using FootballTournamentSystem.Tournament.Application.Features.Team;
    using FootballTournamentSystem.Tournament.Infrastructure.Repositories.Team;
    using FootballTournamentSystem.Tournament.Application.Features.Match;
    using FootballTournamentSystem.Tournament.Infrastructure.Repositories.Match;
    using FootballTournamentSystem.Tournament.Infrastructure.Repositories;
    using MassTransit;
    using FootballTournamentSystem.Tournament.Application.Features.Team.Messages;
    using Core.Infrastructure;
    using System;

    public static class InfrastructureConfiguration
    {
        public static IServiceCollection AddTournamentInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
            => services
                .AddDbContext<TournamentDbContext>(options => options
                    .UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection"),
                        b => b.MigrationsAssembly(typeof(TournamentDbContext).Assembly.FullName)))
                .AddTransient<ITournamentRepository, TournamentRepository>()
                .AddTransient<ITeamRepository, TeamRepository>()
                .AddTransient<IMatchRepository, MatchRepository>()
                .AddTransient(typeof(IRepository<>), typeof(FootballTournamentDataRepository<>))
                .AddMessaging(consumers: new Type[] { typeof(CoachCreatedConsumer), typeof(PlayerCreatedConsumer), typeof(PresidentCreatedConsumer) });
    }
}
