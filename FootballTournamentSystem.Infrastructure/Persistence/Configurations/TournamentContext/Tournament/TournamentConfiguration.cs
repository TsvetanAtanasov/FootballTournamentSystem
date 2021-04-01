namespace FootballTournamentSystem.Infrastructure.Persistence.Configurations.TournamentContext.Tournament
{
    using Domain.Models.TournamentContext.Tournament;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using static Domain.Models.ModelConstants.Common;

    internal class TournamentConfiguration : IEntityTypeConfiguration<Tournament>
    {
        public void Configure(EntityTypeBuilder<Tournament> builder)
        {
            builder
                .HasKey(d => d.Id);

            builder
                .Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder
                .Property(d => d.TournamentType)
                .IsRequired();

            builder
                .Property(d => d.NumberOfTeams)
                .IsRequired();

            builder
                .Property(d => d.ImageUrl)
                .IsRequired();

            builder
                .HasOne(c => c.RoundOf16)
                .WithMany()
                .HasForeignKey("RoundOf16Id")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.QuarterFinals)
                .WithMany()
                .HasForeignKey("QuarterFinalsId")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.SemiFinals)
                .WithMany()
                .HasForeignKey("SemiFinalsId")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.Final)
                .WithMany()
                .HasForeignKey("FinalId")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.RoundOf16)
                .WithMany()
                .HasForeignKey("RoundOf16Id")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(pr => pr.Groups)
                .WithOne()
                .Metadata
                .PrincipalToDependent
                .SetField("groups");

            builder
                .HasMany(pr => pr.Matches)
                .WithOne()
                .Metadata
                .PrincipalToDependent
                .SetField("matches");
        }
    }
}
