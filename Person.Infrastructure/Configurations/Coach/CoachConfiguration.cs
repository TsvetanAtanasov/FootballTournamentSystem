namespace FootballTournamentSystem.Person.Infrastructure.Configurations.Coach
{
    using FootballTournamentSystem.Person.Domain.Models.Coach;
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
