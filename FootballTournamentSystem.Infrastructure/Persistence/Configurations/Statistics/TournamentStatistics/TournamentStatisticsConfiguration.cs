namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.Statistics.TournamentStatistics
{
    using Domain.Models.Statistics.TournamentStatistics;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class TournamentStatisticsConfiguration : IEntityTypeConfiguration<TournamentStatistics>
    {
        public void Configure(EntityTypeBuilder<TournamentStatistics> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.GoalsScored)
                .IsRequired();
        }
    }
}
