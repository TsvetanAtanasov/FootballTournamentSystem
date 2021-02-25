namespace FootballTournamentSystem.Domain.Factories.TournamentContext.Team
{
    using FootballTournamentSystem.Domain.Models.PersonContext.Coach;
    using FootballTournamentSystem.Domain.Models.PersonContext.President;
    using Models.TournamentContext.Team;

    public interface ITeamFactory : IFactory<Team>
    {
        ITeamFactory WithName(string name);

        ITeamFactory WithLogoUrl(string logoUrl);

        ITeamFactory WithYearFounded(int yearFounded);

        ITeamFactory WithPresident(string firstName, string lastName, string imageUrl);

        ITeamFactory WithPresident(President president);

        ITeamFactory WithCoach(string firstName, string lastName, string imageUrl);

        ITeamFactory WithCoach(Coach coach);

        ITeamFactory WithCountry(string country);

        ITeamFactory WithStadium(string stadium);

        ITeamFactory WithGroupPoints(int groupPoints);
    }
}
