﻿namespace FootballTournamentSystem.Domain.Models.Person.Coach
{
    using Common.Domain.Events;

    public class Coach : Person
    {
        internal Coach(string firstName, string lastName, string imageUrl, int teamId)
            : base(firstName, lastName, imageUrl)
        {
            this.TeamId = teamId;

            this.RaiseEvent(new CoachCreatedEvent(this.Id, this.TeamId));
        }

        private Coach() 
            : base()
        {

        }

        public int TeamId { get; }
    }
}
