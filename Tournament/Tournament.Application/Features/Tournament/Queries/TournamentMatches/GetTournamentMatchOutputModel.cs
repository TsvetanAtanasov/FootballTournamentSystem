namespace FootballTournamentSystem.Tournament.Application.Features.Tournament.Queries.TournamentMatches
{
    public class GetTournamentMatchOutputModel
    {
        public GetTournamentMatchOutputModel(
            int id,
            string homeTeamName,
            string homeTeamLogo,
            string awayTeamName,
            string awayTeamLogo)
        {
            this.Id = id;
            this.HomeTeamName = homeTeamName;
            this.HomeTeamLogo = homeTeamLogo;
            this.AwayTeamName = awayTeamName;
            this.AwayTeamLogo = awayTeamLogo;
        }

        public int Id { get; private set; }

        public string HomeTeamName { get; private set; } = default!;

        public string HomeTeamLogo { get; private set; } = default!;

        public string AwayTeamName { get; private set; } = default!;

        public string AwayTeamLogo { get; private set; } = default!;
    }
}
