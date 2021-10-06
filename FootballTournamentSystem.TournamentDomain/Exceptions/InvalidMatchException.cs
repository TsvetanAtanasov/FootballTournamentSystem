namespace FootballTournamentSystem.Domain.Exceptions
{
    using Core.Domain;

    public class InvalidMatchException : BaseDomainException
    {
        public InvalidMatchException()
        {

        }

        public InvalidMatchException(string message) => this.Message = message;
    }
}
