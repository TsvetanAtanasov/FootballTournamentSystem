namespace FootballTournamentSystem.Startup
{
    using Core.Application.Configuration;
    using Core.Domain;
    using Core.Infrastructure;
    using Core.Web;
    using FootballTournamentSystem.Infrastructure;
    using FootballTournamentSystem.Statistics.Application.Features.TournamentStatistics.Commands.Create;
    using FootballTournamentSystem.Statistics.Domain.Factories.TournamentStatistics;
    using FootballTournamentSystem.Statistics.Infrastructure.Persistance;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddDomain<ITournamentStatisticsFactory>()
                .AddApplication<CreateTournamentStatisticsCommand>(this.Configuration)
                .AddWebService<StatisticsDbContext>(this.Configuration)
                .AddStatisticsInfrastructure(this.Configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app
             .UseWebService(env)
             .Initialize();
        }
    }
}
