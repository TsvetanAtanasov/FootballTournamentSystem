namespace FootballTournamentSystem.Domain.Factories.TournamentContext.Team
{
    using FootballTournamentSystem.Domain.Models.Person.Coach;
    using FootballTournamentSystem.Domain.Models.Person.President;
    using global::Common.Domain;
    using Models.TournamentContext.Team;

    public interface ITeamFactory : IFactory<Team>
    {
        ITeamFactory WithName(string name);

        ITeamFactory WithLogoUrl(string logoUrl);

        ITeamFactory WithYearFounded(int yearFounded);

        ITeamFactory WithCountry(string country);

        ITeamFactory WithStadium(string stadium);

        ITeamFactory WithGroupPoints(int groupPoints);
    }
}
