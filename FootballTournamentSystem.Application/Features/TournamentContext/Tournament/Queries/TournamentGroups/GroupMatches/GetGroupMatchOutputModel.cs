namespace FootballTournamentSystem.Application.Features.TournamentContext.Tournament.Queries.TournamentGroups.GroupMatches
{
    public class GetGroupMatchOutputModel
    {
        public int Id { get; private set; }

        public string HomeTeamName { get; private set; } = default!;

        public string HomeTeamLogo { get; private set; } = default!;

        public string AwayTeamName { get; private set; } = default!;

        public string AwayTeamLogo { get; private set; } = default!;
    }
}
