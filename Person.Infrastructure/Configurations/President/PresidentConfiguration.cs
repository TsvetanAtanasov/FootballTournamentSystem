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
        }
    }
}
