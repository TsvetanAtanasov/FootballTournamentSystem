namespace FootballTournamentSystem.Identity
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Core.Infrastructure;
    using FootballTournamentSystem.Identity.Data;
    using FootballTournamentSystem.Identity.Infrastructure;
    using FootballTournamentSystem.Identity.Services;
    using Core.Web;

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
            services.AddWebService<IdentityDbContext>(this.Configuration)
                .AddUserStorage()
                .AddTransient<IIdentityService, IdentityService>()
                .AddTransient<ITokenGeneratorService, TokenGeneratorService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app
             .UseWebService(env)
             .Initialize();
        }
    }
}
