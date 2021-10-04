using System;

namespace FootballTournamentSystem.Application.Features.Tournament.Match.Commands.AddRefereeToMatch
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
