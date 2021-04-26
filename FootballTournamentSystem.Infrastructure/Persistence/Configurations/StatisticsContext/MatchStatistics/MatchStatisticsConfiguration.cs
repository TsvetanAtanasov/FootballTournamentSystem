namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.StatisticsContext.MatchStatistics
{
    using Domain.Models.StatisticsContext.MatchStatistics;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class MatchStatisticsConfiguration : IEntityTypeConfiguration<MatchStatistics>
    {
        public void Configure(EntityTypeBuilder<MatchStatistics> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.HomeTeamGoals)
                .IsRequired();

            builder
                .Property(t => t.AwayTeamGoals)
                .IsRequired();
        }
    }
}
