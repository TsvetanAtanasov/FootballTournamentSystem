namespace FootballTournamentSystem.Domain.Exceptions
{
    using global::Common.Domain;

    public class InvalidMatchException : BaseDomainException
    {
        public InvalidMatchException()
        {

        }

        public InvalidMatchException(string message) => this.Message = message;
    }
}
