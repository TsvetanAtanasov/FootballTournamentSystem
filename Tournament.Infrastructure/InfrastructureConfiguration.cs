﻿namespace FootballTournamentSystem.Infrastructure
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
                .AddMassTransit(mt =>
                            {
                                mt.AddConsumer<CoachCreatedConsumer>();
                                mt.AddConsumer<PlayerCreatedConsumer>();
                                mt.AddConsumer<PresidentCreatedConsumer>();

                                mt.AddBus(bus => Bus.Factory.CreateUsingRabbitMq(rmq =>
                                {
                                    rmq.Host("rabbitmq://localhost");

                                    rmq.ReceiveEndpoint(nameof(CoachCreatedConsumer), endpoint =>
                                    {
                                        endpoint.ConfigureConsumer<CoachCreatedConsumer>(bus);
                                    });

                                    rmq.ReceiveEndpoint(nameof(PlayerCreatedConsumer), endpoint =>
                                    {
                                        endpoint.ConfigureConsumer<PlayerCreatedConsumer>(bus);
                                    });


                                    rmq.ReceiveEndpoint(nameof(PresidentCreatedConsumer), endpoint =>
                                    {
                                        endpoint.ConfigureConsumer<PresidentCreatedConsumer>(bus);
                                    });
                                }));
                            })
                .AddMassTransitHostedService();
    }
}
