namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.PersonContext.Referee
{
    using Domain.Models.PersonContext.Referee;
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
