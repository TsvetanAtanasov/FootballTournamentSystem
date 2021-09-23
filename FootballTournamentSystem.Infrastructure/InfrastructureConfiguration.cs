namespace FootballTournamentSystem.Infrastructure
{
    using Application.Contracts;
    using Common.Infrastructure.Events;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories;
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
                .AddTransient(typeof(IRepository<>), typeof(FootballTournamentDataRepository<>));
    }
}
