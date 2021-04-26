namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.StatisticsContext.TournamentStatistics
{
    using Domain.Models.StatisticsContext.TournamentStatistics;
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
