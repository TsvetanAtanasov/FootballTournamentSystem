namespace FootballTournamentSystem.Domain.Exceptions
{
    public class InvalidPlayerDetailsException : BaseDomainException
    {
        public InvalidPlayerDetailsException()
        {

        }

        public InvalidPlayerDetailsException(string message) => this.Message = message;
    }
}
