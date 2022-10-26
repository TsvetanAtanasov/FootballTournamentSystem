namespace FootballTournamentSystem.Person.Infrastructure.Configurations.Referee
{
    using FootballTournamentSystem.Person.Domain.Models.Referee;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class RefereeConfiguration : IEntityTypeConfiguration<Referee>
    {
        public void Configure(EntityTypeBuilder<Referee> builder)
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
