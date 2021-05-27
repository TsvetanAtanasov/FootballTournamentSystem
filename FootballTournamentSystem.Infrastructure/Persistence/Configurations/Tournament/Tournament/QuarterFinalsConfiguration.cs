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
                .HasKey(qf => qf.Id);

            builder
                .HasMany(qf => qf.Matches)
                .WithOne()
                .Metadata
                .PrincipalToDependent
                .SetField("matches");
        }
    }
}
