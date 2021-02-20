namespace FootballTournamentSystem.Domain.Factories.TournamentContext.Team
{
    using FootballTournamentSystem.Domain.Models.PersonContext.President;
    using Models.TournamentContext.Team;

    public interface ITeamFactory : IFactory<Team>
    {
        ITeamFactory WithName(string name);

        ITeamFactory WithLogoUrl(string logoUrl);

        ITeamFactory WithYearFounded(int yearFounded);

        ITeamFactory WithPresident(President president);

        ITeamFactory WithCoach(string coach);

        ITeamFactory WithLeague(string league);

        ITeamFactory WithStadium(string stadium);

        ITeamFactory WithGroupPoints(int groupPoints);
    }
}
