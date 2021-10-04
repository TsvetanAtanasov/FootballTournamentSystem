namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.Tournament.Tournament
{
    using Domain.Models.Tournament.Tournament;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class SemiFinalsConfiguration : IEntityTypeConfiguration<SemiFinals>
    {
        public void Configure(EntityTypeBuilder<SemiFinals> builder)
        {
            builder
                .HasKey(sf => sf.Id);

            builder
                .HasMany(sf => sf.Matches)
                .WithOne()
                .Metadata
                .PrincipalToDependent
                .SetField("matches");
        }
    }
}
