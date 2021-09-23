namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.Person.Referee
{
    using Domain.Models.Person.Referee;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class RefereeConfiguration : IEntityTypeConfiguration<Referee>
    {
        public void Configure(EntityTypeBuilder<Referee> builder)
        {
            builder
                .HasKey(t => t.Id);
        }
    }
}
