namespace FootballTournamentSystem.Tournament.Infrastructure.Configurations.Team
{
    using FootballTournamentSystem.Tournament.Domain.Models.Team;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Core.Domain.Models;

    internal class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(ModelConstants.Common.MaxNameLength);

            builder
                .Property(t => t.LogoUrl)
                .IsRequired()
                .HasMaxLength(ModelConstants.Common.MaxUrlLength);

            builder
                .Property(t => t.YearFounded)
                .IsRequired();

            builder
                .Property(t => t.Country)
                .IsRequired()
                .HasMaxLength(ModelConstants.Common.MaxNameLength);

            builder
                .Property(t => t.Stadium)
                .IsRequired()
                .HasMaxLength(ModelConstants.Common.MaxNameLength);

            builder
                .Property(t => t.GroupPoints)
                .IsRequired();

            //TODO: check how to make the connection with entities from other microservices

            //builder
            //    .HasOne<President>()
            //    .WithMany()
            //    .HasForeignKey(t => t.PresidentId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder
            //    .HasOne<Coach>()
            //    .WithMany()
            //    .HasForeignKey(t => t.CoachId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder
            //    .HasMany<Player>()
            //    .WithOne()
            //    .Metadata
            //    .PrincipalToDependent
            //    .SetField("playerIds");
        }
    }
}
