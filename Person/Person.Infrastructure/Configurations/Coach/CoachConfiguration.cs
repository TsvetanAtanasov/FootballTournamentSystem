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
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Guid)
                .IsRequired();

            builder
                .Property(c => c.FirstName)
                .IsRequired();

            builder
                .Property(c => c.LastName)
                .IsRequired();

            builder
                .Property(c => c.ImageUrl)
                .IsRequired();
        }
    }
}
