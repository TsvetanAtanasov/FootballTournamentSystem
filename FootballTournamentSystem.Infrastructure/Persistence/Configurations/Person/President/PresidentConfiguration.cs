namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.Person.President
{
    using Domain.Models.Person.President;
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
