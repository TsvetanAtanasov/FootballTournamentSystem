namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.TournamentContext.Match
{
    using Domain.Models.TournamentContext.Match;
    using Domain.Models.StatisticsContext.PlayerStatistics;
    using Domain.Models.StatisticsContext.MatchStatistics;
    using Domain.Models.Person.Referee;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder
                .HasKey(t => t.Id);

            // think of better solution for teams connection here
            builder
                .HasMany(g => g.Teams)
                .WithOne()
                .Metadata
                .PrincipalToDependent
                .SetField("teams");

            builder
                .HasOne<PlayerStatistics>()
                .WithMany()
                .HasForeignKey(t => t.PlayerStatisticsId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne<MatchStatistics>()
                .WithMany()
                .HasForeignKey(t => t.MatchStatisticsId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne<Referee>()
                .WithMany()
                .HasForeignKey(t => t.RefereeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
