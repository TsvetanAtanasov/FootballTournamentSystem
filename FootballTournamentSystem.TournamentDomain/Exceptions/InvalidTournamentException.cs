﻿namespace FootballTournamentSystem.TournamentDomain.Exceptions
{
    public class InvalidTournamentException : BaseDomainException
    {
        public InvalidTournamentException()
        {

        }

        public InvalidTournamentException(string message) => this.Message = message;
    }
}
