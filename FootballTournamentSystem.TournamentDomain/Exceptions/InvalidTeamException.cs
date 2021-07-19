namespace FootballTournamentSystem.Domain.Exceptions
{
    using global::Common.Domain;

    public class InvalidTeamException : BaseDomainException
    {
        public InvalidTeamException()
        {

        }

        public InvalidTeamException(string message) => this.Message = message;
    }
}
