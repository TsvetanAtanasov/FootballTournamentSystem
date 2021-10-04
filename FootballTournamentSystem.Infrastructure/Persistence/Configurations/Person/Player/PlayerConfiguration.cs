namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.Person.Player
{
    using Domain.Models.Person.Player;
    using Domain.Models.Statistics.PlayerStatistics;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.Height)
                .IsRequired();

            builder
                .Property(t => t.Weight)
                .IsRequired();

            builder
                .HasOne<PlayerStatistics>()
                .WithMany()
                .HasForeignKey(t => t.PlayerStatisticsId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
