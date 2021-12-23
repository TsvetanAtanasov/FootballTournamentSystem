namespace FootballTournamentSystem.Tournament.Infrastructure.Configurations.Tournament
{
    using Core.Domain.Models;
    using FootballTournamentSystem.Tournament.Domain.Models.Tournament;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder
                .HasKey(g => g.Id);

            builder
                .Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(ModelConstants.Common.MaxNameLength);

            builder
                .HasMany(g => g.Teams)
                .WithOne()
                .Metadata
                .PrincipalToDependent
                .SetField("teams");

            builder
                .HasMany(g => g.Matches)
                .WithOne()
                .Metadata
                .PrincipalToDependent
                .SetField("matches");
        }
    }
}
