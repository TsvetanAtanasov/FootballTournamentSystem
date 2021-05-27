namespace FootballTournamentSystem.Application.Features.TournamentContext.Match.Commands.Create
{
    public class CreateMatchOutputModel
    {
        public CreateMatchOutputModel(int matchId)
        {
            this.MatchId = matchId;
        }

        public int MatchId { get; }
    }
}
