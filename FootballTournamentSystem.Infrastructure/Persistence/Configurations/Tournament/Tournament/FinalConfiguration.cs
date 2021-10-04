namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.Tournament.Tournament
{
    using Domain.Models.Tournament.Tournament;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class FinalConfiguration : IEntityTypeConfiguration<Final>
    {
        public void Configure(EntityTypeBuilder<Final> builder)
        {
            builder
                .HasKey(f => f.Id);

            builder
                .HasOne(f => f.Match)
                .WithMany()
                .HasForeignKey("MatchId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
