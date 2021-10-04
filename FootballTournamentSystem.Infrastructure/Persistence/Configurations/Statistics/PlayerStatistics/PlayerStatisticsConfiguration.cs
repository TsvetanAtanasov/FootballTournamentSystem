namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.Statistics.PlayerStatistics
{
    using Domain.Models.Statistics.PlayerStatistics;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class PlayerStatisticsConfiguration : IEntityTypeConfiguration<PlayerStatistics>
    {
        public void Configure(EntityTypeBuilder<PlayerStatistics> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.GoalsScored)
                .IsRequired();

            builder
                .Property(t => t.MinutesPlayed)
                .IsRequired();

            builder
                .Property(t => t.Assists)
                .IsRequired();
        }
    }
}
