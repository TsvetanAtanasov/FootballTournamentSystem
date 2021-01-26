namespace FootballTournamentSystem.Domain.Exceptions
{
    public class InvalidMatchException : BaseDomainException
    {
        public InvalidMatchException()
        {

        }

        public InvalidMatchException(string message) => this.Message = message;
    }
}
