using System;

namespace FootballTournamentSystem.Tournament.Application.Features.Match.Commands.AddRefereeToMatch
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
