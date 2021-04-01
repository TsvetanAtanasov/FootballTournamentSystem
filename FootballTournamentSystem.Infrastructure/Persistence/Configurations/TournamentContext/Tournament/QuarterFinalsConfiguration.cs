namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.TournamentContext.Tournament
{
    using Domain.Models.TournamentContext.Tournament;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class QuarterFinalsConfiguration : IEntityTypeConfiguration<QuarterFinals>
    {
        public void Configure(EntityTypeBuilder<QuarterFinals> builder)
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
