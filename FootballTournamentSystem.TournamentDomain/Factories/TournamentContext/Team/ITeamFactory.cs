namespace FootballTournamentSystem.Domain.Factories.TournamentContext.Team
{
    using Models.TournamentContext.Team;

    public interface ITeamFactory : IFactory<Team>
    {
        ITeamFactory WithName(string name);

        ITeamFactory WithLogoUrl(string logoUrl);

        ITeamFactory WithYearFounded(int yearFounded);

        ITeamFactory WithPresident(string president);

        ITeamFactory WithCoach(string coach);

        ITeamFactory WithLeague(string league);

        ITeamFactory WithStadium(string stadium);
    }
}
