namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.PersonContext.Coach
{
    using Domain.Models.PersonContext.Coach;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class CoachConfiguration : IEntityTypeConfiguration<Coach>
    {
        public void Configure(EntityTypeBuilder<Coach> builder)
        {
            builder
                .HasKey(t => t.Id);
        }
    }
}
