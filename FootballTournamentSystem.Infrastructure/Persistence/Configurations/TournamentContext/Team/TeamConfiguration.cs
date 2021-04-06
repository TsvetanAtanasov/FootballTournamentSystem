namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.TournamentContext.Team
{

    using Domain.Models.TournamentContext.Team;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using static Domain.Models.ModelConstants.Common;

    internal class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder
                .Property(t => t.LogoUrl)
                .IsRequired()
                .HasMaxLength(MaxUrlLength);

            builder
                .Property(t => t.YearFounded)
                .IsRequired();

            builder
                .Property(t => t.Country)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder
                .Property(t => t.Stadium)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder
                .Property(t => t.GroupPoints)
                .IsRequired();

            builder
                .HasOne(t => t.PresidentId)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(pr => pr.Matches)
                .WithOne()
                .Metadata
                .PrincipalToDependent
                .SetField("matches");
        }
    }
}
