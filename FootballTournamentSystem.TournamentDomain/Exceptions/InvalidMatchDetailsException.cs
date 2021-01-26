namespace FootballTournamentSystem.Domain.Exceptions
{
    public class InvalidMatchDetailsException : BaseDomainException
    {
        public InvalidMatchDetailsException()
        {

        }

        public InvalidMatchDetailsException(string message) => this.Message = message;
    }
}
