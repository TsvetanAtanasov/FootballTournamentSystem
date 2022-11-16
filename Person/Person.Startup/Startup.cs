namespace FootballTournamentSystem.Startup
{
    using Core.Application.Configuration;
    using Core.Domain;
    using Core.Infrastructure;
    using Core.Web;
    using FootballTournamentSystem.Infrastructure;
    using FootballTournamentSystem.Person.Application.Features.Coach.Commands.Create;
    using FootballTournamentSystem.Person.Domain.Factories.Coach;
    using FootballTournamentSystem.Person.Infrastructure.Persistance;
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
                .AddDomain<ICoachFactory>()
                .AddApplication<CreateCoachCommand>(this.Configuration)
                .AddWebService<PersonDbContext>(this.Configuration)
                .AddPersonInfrastructure(this.Configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app
             .UseWebService(env)
             .Initialize();
        }
    }
}
