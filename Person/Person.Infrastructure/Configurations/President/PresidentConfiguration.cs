namespace FootballTournamentSystem.Person.Infrastructure.Configurations.President
{
    using FootballTournamentSystem.Person.Domain.Models.President;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class PresidentConfiguration : IEntityTypeConfiguration<President>
    {
        public void Configure(EntityTypeBuilder<President> builder)
        {
            builder
                .HasKey(t => t.Id);

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
