﻿namespace FootballTournamentSystem.Application.Features.TournamentContext.Tournament.Commands.TournamentGroups.AddGroupToTournament
{
    public class AddGroupToTournamentOutputModel
    {
        public AddGroupToTournamentOutputModel(int groupId)
        {
            this.GrouptId = groupId;
        }

        public int GrouptId { get; }
    }
}