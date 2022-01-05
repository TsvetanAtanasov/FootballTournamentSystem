namespace FootballTournamentSystem.Statistics.Infrastructure.Configurations.MatchStatistics
{
    using FootballTournamentSystem.Statistics.Domain.Models.MatchStatistics;
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
