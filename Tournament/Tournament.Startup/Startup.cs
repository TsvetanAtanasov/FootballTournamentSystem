namespace FootballTournamentSystem.Startup
{
    using Core.Application.Configuration;
    using Core.Domain;
    using Core.Infrastructure;
    using Core.Web;
    using FootballTournamentSystem.Infrastructure;
    using FootballTournamentSystem.Tournament.Application.Features.Match.Commands.Create;
    using FootballTournamentSystem.Tournament.Domain.Factories.Tournament;
    using FootballTournamentSystem.Tournament.Infrastructure.Persistance;
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
                .AddDomain<ITournamentFactory>()
                .AddApplication<CreateMatchCommand>(this.Configuration)
                .AddWebService<TournamentDbContext>(this.Configuration)
                .AddTournamentInfrastructure(this.Configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app
             .UseWebService(env)
             .Initialize();
        }
    }
}
