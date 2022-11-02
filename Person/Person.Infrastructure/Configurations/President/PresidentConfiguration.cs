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
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Guid)
                .IsRequired();

            builder
                .Property(p => p.FirstName)
                .IsRequired();

            builder
                .Property(p => p.LastName)
                .IsRequired();

            builder
                .Property(p => p.ImageUrl)
                .IsRequired();
        }
    }
}
