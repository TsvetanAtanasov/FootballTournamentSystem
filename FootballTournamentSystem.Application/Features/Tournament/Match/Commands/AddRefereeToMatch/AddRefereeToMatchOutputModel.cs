using System;

namespace FootballTournamentSystem.Application.Features.TournamentContext.Match.Commands.AddRefereeToMatch
{
    public class AddRefereeToMatchOutputModel
    {
        public AddRefereeToMatchOutputModel(Guid refereeId)
        {
            this.RefereeId = refereeId;
        }

        public Guid RefereeId { get; }
    }
}
