namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.Tournament.Tournament
{
    using Domain.Models.Tournament.Tournament;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class RoundOf16Configuration : IEntityTypeConfiguration<RoundOf16>
    {
        public void Configure(EntityTypeBuilder<RoundOf16> builder)
        {
            builder
                .HasKey(r => r.Id);

            builder
                .HasMany(r => r.Matches)
                .WithOne()
                .Metadata
                .PrincipalToDependent
                .SetField("matches");
        }
    }
}
