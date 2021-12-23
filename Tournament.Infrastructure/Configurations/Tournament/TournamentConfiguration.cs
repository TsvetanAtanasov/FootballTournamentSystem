namespace FootballTournamentSystem.Tournament.Infrastructure.Configurations.Tournament
{
    using FootballTournamentSystem.Tournament.Domain.Models.Tournament;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Core.Domain.Models;

    internal class TournamentConfiguration : IEntityTypeConfiguration<Tournament>
    {
        public void Configure(EntityTypeBuilder<Tournament> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(ModelConstants.Common.MaxNameLength);

            builder
                .Property(t => t.NumberOfTeams)
                .IsRequired();

            builder
                .Property(t => t.ImageUrl)
                .IsRequired();

            builder
                .HasOne(t => t.RoundOf16)
                .WithMany()
                .HasForeignKey("RoundOf16Id")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(t => t.QuarterFinals)
                .WithMany()
                .HasForeignKey("QuarterFinalsId")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(t => t.SemiFinals)
                .WithMany()
                .HasForeignKey("SemiFinalsId")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(t => t.Final)
                .WithMany()
                .HasForeignKey("FinalId")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(t => t.RoundOf16)
                .WithMany()
                .HasForeignKey("RoundOf16Id")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(t => t.Groups)
                .WithOne()
                .Metadata
                .PrincipalToDependent
                .SetField("groups");

            builder
                .HasMany(t => t.Matches)
                .WithOne()
                .Metadata
                .PrincipalToDependent
                .SetField("matches");

            //TODO: check how to do tournament statistics relation
        }
    }
}
