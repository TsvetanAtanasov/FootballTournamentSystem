namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.TournamentContext.Tournament
{
    using Domain.Models.TournamentContext.Tournament;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class FinalConfiguration : IEntityTypeConfiguration<Final>
    {
        public void Configure(EntityTypeBuilder<Final> builder)
        {
            builder
                .HasKey(d => d.Id);

            builder
                .HasOne(c => c.Match)
                .WithMany()
                .HasForeignKey("MatchId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
