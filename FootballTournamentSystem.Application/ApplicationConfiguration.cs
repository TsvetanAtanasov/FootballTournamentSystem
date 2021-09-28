namespace FootballTournamentSystem.Application
{
    using System.Reflection;
    using Common.Application.Configuration;
    using MediatR;
    using AutoMapper;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Configuration;

    public static class ApplicationConfiguration
    {
        public static IServiceCollection AddApplication(
            this IServiceCollection services,
            IConfiguration configuration)
            => services
                .Configure<ApplicationSettings>(
                    configuration.GetSection(nameof(ApplicationSettings)),
                    options => options.BindNonPublicProperties = true)
                .AddAutoMapper(Assembly.GetExecutingAssembly())
                .AddMediatR(Assembly.GetExecutingAssembly());
    }
}
