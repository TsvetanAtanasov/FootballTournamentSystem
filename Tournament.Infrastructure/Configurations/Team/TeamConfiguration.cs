namespace FootballTournamentSystem.Tournament.Infrastructure.Configurations.Team
{
    using FootballTournamentSystem.Tournament.Domain.Models.Team;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Core.Domain.Models;

    internal class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(ModelConstants.Common.MaxNameLength);

            builder
                .Property(t => t.LogoUrl)
                .IsRequired()
                .HasMaxLength(ModelConstants.Common.MaxUrlLength);

            builder
                .Property(t => t.YearFounded)
                .IsRequired();

            builder
                .Property(t => t.Country)
                .IsRequired()
                .HasMaxLength(ModelConstants.Common.MaxNameLength);

            builder
                .Property(t => t.Stadium)
                .IsRequired()
                .HasMaxLength(ModelConstants.Common.MaxNameLength);

            builder
                .Property(t => t.GroupPoints)
                .IsRequired();
        }
    }
}
