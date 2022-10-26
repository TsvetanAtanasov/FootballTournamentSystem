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

            builder
                .Property(t => t.Id)
                .ValueGeneratedNever();

            builder
                .Property(t => t.FirstName)
                .IsRequired();

            builder
                .Property(t => t.LastName)
                .IsRequired();

            builder
                .Property(t => t.ImageUrl)
                .IsRequired();
        }
    }
}
