namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.TournamentContext.Tournament
{
    using Domain.Models.TournamentContext.Tournament;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class RoundOf16Configuration : IEntityTypeConfiguration<RoundOf16>
    {
        public void Configure(EntityTypeBuilder<RoundOf16> builder)
        {
            builder
                .HasKey(d => d.Id);

            builder
                .HasMany(pr => pr.Matches)
                .WithOne()
                .Metadata
                .PrincipalToDependent
                .SetField("matches");
        }
    }
}
