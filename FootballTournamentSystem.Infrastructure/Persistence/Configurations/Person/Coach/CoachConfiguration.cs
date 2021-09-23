namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.Person.Coach
{
    using Domain.Models.Person.Coach;
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
