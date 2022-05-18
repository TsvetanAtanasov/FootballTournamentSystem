namespace Core.Application.Configuration
{
    using System.Reflection;
    using AutoMapper;
    using MediatR;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class ApplicationConfiguration
    {
        public static IServiceCollection AddApplication<TAssemblyType>(
            this IServiceCollection services,
            IConfiguration configuration)
            => services
                .Configure<ApplicationSettings>(
                    configuration.GetSection(nameof(ApplicationSettings)),
                    options => options.BindNonPublicProperties = true)
                .AddAutoMapper(typeof(TAssemblyType).Assembly)
                .AddMediatR(typeof(TAssemblyType).Assembly);
    }
}
