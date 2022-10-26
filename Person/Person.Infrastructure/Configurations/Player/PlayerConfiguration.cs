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
                .HasKey(t => t.Id);

            builder
                .Property(t => t.Height)
                .IsRequired();

            builder
                .Property(t => t.Weight)
                .IsRequired();

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
