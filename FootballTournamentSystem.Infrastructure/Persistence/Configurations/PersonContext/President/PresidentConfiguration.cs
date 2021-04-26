namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.PersonContext.President
{
    using Domain.Models.PersonContext.President;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class PresidentConfiguration : IEntityTypeConfiguration<President>
    {
        public void Configure(EntityTypeBuilder<President> builder)
        {
            builder
                .HasKey(t => t.Id);
        }
    }
}
