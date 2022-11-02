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
                .HasKey(r => r.Id);

            builder
                .Property(r => r.Guid)
                .IsRequired();

            builder
                .Property(r => r.FirstName)
                .IsRequired();

            builder
                .Property(r => r.LastName)
                .IsRequired();

            builder
                .Property(r => r.ImageUrl)
                .IsRequired();
        }
    }
}
