namespace FootballTournamentSystem.Application.Features.TournamentContext.Match.Commands.AddRefereeToMatch
{
    public class AddRefereeToMatchOutputModel
    {
        public AddRefereeToMatchOutputModel(int refereeId)
        {
            this.RefereeId = refereeId;
        }

        public int RefereeId { get; }
    }
}
