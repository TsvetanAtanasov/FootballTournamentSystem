namespace FootballTournamentSystem.Tournament.Infrastructure.Configurations.Match
{
    using FootballTournamentSystem.Tournament.Domain.Models.Match;
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

            //builder
            //    .HasOne<PlayerStatistics>()
            //    .WithMany()
            //    .HasForeignKey(t => t.PlayerStatisticsId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder
            //    .HasOne<MatchStatistics>()
            //    .WithMany()
            //    .HasForeignKey(t => t.MatchStatisticsId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder
            //    .HasOne<Referee>()
            //    .WithMany()
            //    .HasForeignKey(t => t.RefereeId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
