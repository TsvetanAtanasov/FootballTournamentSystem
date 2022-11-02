namespace FootballTournamentSystem.Person.Infrastructure.Configurations.Player
{
    using FootballTournamentSystem.Person.Domain.Models.Player;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Guid)
                .IsRequired();

            builder
                .Property(p => p.Height)
                .IsRequired();

            builder
                .Property(p => p.Weight)
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
